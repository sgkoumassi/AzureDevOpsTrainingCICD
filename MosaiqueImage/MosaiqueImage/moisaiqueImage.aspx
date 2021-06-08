
<!DOCTYPE html>
<html>
<head>
    <link rel="shortcut icon" href="#" />
    <style>
        .imageStyle
        {
            height :100px;
            width :100px;
            border : 3px solid grey;
        }
    </style>

 <script src="script/jquery-1.11.2.js"></script>


<script type="text/javascript">

    $(document).ready(function () {


        // Thumbnail Images animation function
        $('#divContainer').on(
            {
            mouseover: function () {
                $(this).css({
                    'cursor': 'pointer',
                    'border-color': 'red'
                });
            },
            mouseout: function () {
                $(this).css({
                    'cursor': 'default',
                    'border-color':'grey'
                });
            },
            click: function () {
                var imageURL = $(this).attr('src');
                var effect = $('#selectImgEffect').val();
                var duration = $('#selectimgDuration').val() * 100;
                var mainImg = $('#mainimage');
                if (effect == 'Fade') {
                    mainImg.fadeOut(duration, function () {
                        $(this).attr('src', imageURL);
                    }).fadeIn(duration);
                }
                 else {
                    mainImg.slideUp(duration, function () {
                        $(this).attr('src', imageURL);
                    }).slideDown(duration);
                }
            }
            }, 'img');
            
          
        var mainImgElement = $('#mainimage');
        var height = parseInt(mainImgElement.attr('height'));
        var width = parseInt(mainImgElement.attr('width'));

        $('#bntEnlarge').click(function () {
            console.log('Enlarge');
            height += 100;
            width += 100;
            mainImgElement.animate({
                'height': height,
                'width': width
            });
        });

        $('#bntShrink').click(function () {
            console.log(' Shrink');
            height -= 100;
            width -= 100;
            mainImgElement.animate({
                'height': height,
                'width': width
            });
        });
        
      

        var imagesURLs = new Array();
        var intervaId;
        var bntStart = $('#bnttartslideshow');
        var bntStop = $('#bntstopslideshow');
    

        $('#divContainer img').each(function () {
            imagesURLs.push($(this).attr('src'));

            console.log(imagesURLs.length);
        });

        function setImage()
        {
            var mainImgElements = $('#mainimage');
            var currentImageURL = mainImgElements.attr('src');
            var currentImageIndex = $.inArray(currentImageURL, imagesURLs);
            if (currentImageIndex == (imagesURLs.length - 1))
            {
                currentImageIndex = -1;
            }

            mainImgElements.attr('src', imagesURLs[currentImageIndex + 1]);
        }

        bntStart.on('click', function () {
            console.log('starr slide');

            //debugger;
            intervaId = setInterval(setImage, 500);
            $(this).attr('disabled', 'disabled');
            bntStop.removeAttr('disabled');
        });

        bntStop.click(function () {
            clearInterval(intervaId);
             $(this).attr('disabled', 'disabled');
            bntStart.removeAttr('disabled');
        }).attr('disabled', 'disabled');
    

    $('#bntAnimate').click(function () {
        $('#animateDiv').animate({
            'font-size': 50
        }, 2000);
        });

         // Progess Bar Function

        $('#pAnimation').on('click', function () {
            curentPercentage = $('#ddPercentage').val();
            animateProgessionBar(curentPercentage);
        });
       
        function animateProgessionBar(curentPercentage) {
            $('#inerDiv').animate(
                {
                'width': (500 * curentPercentage) / 100
                },
                {
                    duration: 2000,
                    step: function (now, tween) {
                      
                        $('#inerDiv').text(Math.ceil((now/500) * 100) + "%");
                 }
                });
        }
        //  Hide and show password function
        $('#cbShowPassword').click(function () {
            var currentPasswordField = $('#txtPassword');
            var currentPassword = currentPasswordField.val();
            currentPasswordField.remove();
            if ($(this).is(':checked')) {
                $(this).before('<input type="text" id="txtPassword" value="' + currentPassword + '"/>');
            }
            else
            {
                 $(this).before('<input type="password" id="txtPassword" value="' + currentPassword + '"/>');
            }
           
        });

        // Ajax load htm page
        /*var textBoxes = $('input[type="text"]');
        textBoxes.focus(function () {
            var helpDiv = $(this).attr('id') + 'HelpDiv';
            $('#' + helpDiv).load('Help.html #' + helpDiv);
        });
        textBoxes.blur(function () {
            var helpDiv = $(this).attr('id') + 'HelpDiv';
            $('#' + helpDiv).html('');
        });*/

       // Ajax load aspx page

       /* var textBoxes = $('input[type="text"]');
        textBoxes.focus(function () {
            var helpDiv = $(this).attr('id');
            $('#' + helpDiv + 'HelpDiv').load('GetHelpText.aspx', { HelpTextKey: helpDiv }, function (response, status, xhr) {
                if (status == 'error') {
                var statusMessage = 'status :' + xhr.status + '<br/>';
                statusMessage += 'status Text :' + xhr.statusText + '<br/>';
                statusMessage += 'response :' + response;
                    $('#divStatus').html(statusMessage);
                    }
            });
        });
        textBoxes.blur(function () {
            var helpDiv = $(this).attr('id') + 'HelpDiv';
            $('#' + helpDiv).html('');
        });*/

        // Ajax get function :
        /* -------The different between Load fnction and Get fonction--------------- 
         Load function can be used to load only HTML data from the server,
         where Get function can be used to load any data (xml,json,script or html)
         
         ------------------------------------------------------------------------------*/

        var textBoxes = $('input[type="text"]');
        textBoxes.focus(function () {
            var helpDiv = $(this).attr('id');
            // With the ajax function we have more flexibility and control :
            $.ajax({
                url: 'GetHelpText.aspx',
                data: { HelpTextKey: helpDiv },
                method: 'post',
                dataType: 'xml',
                success: function (response) {
                    var jqueryXlm = $(response);
                    var textElement = jqueryXlm.fin('Text');
                    var keyElement = jqueryXlm.fin('Key');
                    $('#' + helpDiv + 'HelpDiv').html(keyElement.text() + ':' + textElement.text());
                }
            });
           });
            // the same with the post request
            /*
            $.get('GetHelpText.aspx', { HelpTextKey: helpDiv }, function (response) {    
                //$('#' + helpDiv + 'HelpDiv').html(response.Key + ':' + response.Text);
                var jqueryXlm = $(response);
                var textElement = jqueryXlm.fin('Text');
                var keyElement = jqueryXlm.fin('Key');
                $('#' + helpDiv + 'HelpDiv').html(keyElement.text() + ':' + textElement.text());
            },'xml');
        });*/
        textBoxes.blur(function () {
            var helpDiv = $(this).attr('id') + 'HelpDiv';
            $('#' + helpDiv).html('');
        });


 });
</script>
</head>
<body style="font-family:Arial">
  
     <input type="password" id ="txtPassword" />
    <input type="checkbox" id ="cbShowPassword" /> Show Password
      <br />  <br />
    Select the percentage :
    <select id ="ddPercentage">
        <option value="10">10</option>
         <option value="20">20</option>
         <option value="30">30</option>
         <option value="40">40</option>
         <option value="50">50</option>
         <option value="60">60</option>
         <option value="70">70</option>
         <option value="80">80</option>
         <option value="90">90</option>
        <option value="100">100</option>
    </select>
    <input type="button" id="pAnimation" value=" Stat Percentage Animation" />
    <br /><br />
    <div id="outerDiv" style="background-color:cornsilk; height:20px;width:500px;padding:5px">
     <div id="inerDiv" style="background-color:crimson; height:19px;width:0px; color:white; text-align:center"></div></div>
    <br /><br />

    <table>
        <tr>
            <td>First Name</td>
             <td><input type="text" id="firstName"/> </td>
             <td><div id="firstNameHelpDiv"></div></td>
        </tr>
         <tr>
            <td>Last Name</td>
             <td><input type="text" id="lastName"/> </td>
             <td><div id="lastNameHelpDiv"></div></td>
        </tr>
         <tr>
            <td>Email</td>
             <td><input type="text" id="email"/> </td>
             <td><div id="emailHelpDiv"></div></td>
        </tr>
         <tr>
            <td>Income</td>
             <td><input type="text" id="income"/> </td>
             <td><div id="incomeHelpDiv"></div></td>
        </tr>
    </table>
    <div id="divStatus"></div>

    <!---
    
    Select Effect : <select id="selectImgEffect">
         <option value="Fade">Fade</option>
         <option value="Slide">Slide</option>
                    </select>
        Time in seconds : <select id="selectimgDuration">
        <option value="0.5">0.5</option>
         <option value="1">1</option>
         <option value="1.5">1.5</option>
         <option value="2">2</option>
         <option value="2.5">2.5</option>
         <option value="3">3</option>
         <option value="3.5">3.5</option>
         <option value="4">4</option>
         <option value="4.5">4.5</option>
    </select>
    <input type="button" id="bntAnimate" value="Animate" />
    <input type="button" id="bntEnlarge" value="Enlarge" />
    <input type="button" id="bntShrink" value="Shrink" />
    <input type="button" id="bnttartslideshow" value=" Start SlideShow" />
    <input type="button" id="bntstopslideshow" value=" Stop SlideShow" />
    <br /><br />

     <img id="mainimage" height="700" width="980" style="border: 3px solid grey"
      src="images/i1.jpg" />
    <br />
     <div id="divContainer">
        <img src="images/i1.jpg"  class ="imageStyle"/>
        <img src="images/i2.jpg"  class ="imageStyle"/>
        <img src="images/i3.jpg"  class ="imageStyle"/>
        <img src="images/i4.jpg"  class ="imageStyle"/>
        <img src="images/i5.jpg"  class ="imageStyle"/>
        <img src="images/i6.jpg"  class ="imageStyle"/>
        <img src="images/i7.jpg"  class ="imageStyle"/>
        <img src="images/i8.jpg"  class ="imageStyle"/>
        <img src="images/i9.jpg"  class ="imageStyle"/>
    </div> --->

</body>
</html>
