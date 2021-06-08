<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFromAll.aspx.cs" Inherits="WebServicesAJAX.WebFromAll" %>

<head runat="server">
<title></title>
    >
    <!--<link rel="shortcut icon" href="data:image/x-icon;," type="image/x-icon"/>-->

    <script src="Script/jquery-1.11.2.js"></script>
    <script src="Script/jquery.dataTables.min.js"></script>
    <link href="Script/jquery.dataTables.min.css" rel="stylesheet" />
    <script src="Script/jquery-ui.min.js"></script>
    <link href="Script/jquery-ui.min.css" rel="stylesheet" />
    
    <script type="text/javascript">
        
        $(document).ready(function () {

            // Autocomplete textbox using jquery in asp net with a handler
           /* $('#txtName').autocomplete({
                source: 'StudentHandler.ashx'
              });*/


               // Autocomplete textbox using jquery in asp net with a webservice
              $('#txtName').autocomplete({
                  source: function (request, response)
                  {
                      $.ajax({

                          url: 'StudentsService.asmx/GetStudentNames',
                          method: 'post',
                          contentType: 'application/json;charset=utf-8',
                          data: JSON.stringify({ term: request.term }),
                          dataType: 'json',
                          success: function (data) {
                              response(data.d);
                          },
                          error: function (err) {
                              alert(err);
                          }

                      });

                  }
              });
            //JQuery Accordion in asp net

            $.ajax({

                url: 'StudentsService.asmx/GetCountries',
                method: 'post',
                contentType: 'application/json;charset=utf-8',
                success: function (data) {

                    var htmString = '';
                    $(data.d).each(function (index, country) {
                        htmString += '<h3>' + country.Name + '</h3><div>' + country.CountryDescription + '</div>';
                    })
                    $('#accordion').html(htmString).accordion({
                        collapsible: true,
                        active: 0
                    });
                }
            });

            // JQuery Accordion using asp net repeter control
            $('#accordion1').accordion({
                        collapsible: true,
                        active: 0
            });

             // JQuery Accordion using asp net ListView control
            $('#accordion2').accordion({
                        collapsible: true,
                        active: 0
                    });
            //Jquery tabs part 1
            $('#tabs').tabs({
                        collapsible: true,
                        active: 1,
                        event:'mouseover'
            });

            // jquery datepicker
            $('#txtDate').datepicker({
                appendText: 'MM/DD/YY',
                showOn: 'both',
                buttonText: 'Calender',
                dateFormat: 'dd/mm/yy',
                numberOfMonths: 2,
                changeMonth: true,
                changeYear: true,
                minDate:new Date(2005,1,1),
                maxDate:new Date(2015,11,31)
                

            });

            // Slider range
            var outputSpan = $('#spanOutput');
            var sliderElement = $('#slider');
            $('#slider').slider({
                range: true,
                min: 18,
                max: 100,
                values:[20,30],
                slide: function (e, ui) {
                    outputSpan.html(ui.values[0] + ' - ' + ui.values[1] + ' Years');
                    $('#txtMinAge').val(ui.values[0]);
                     $('#txtMaxAge').val(ui.values[1]);

                }        
            });

           outputSpan.html(sliderElement.slider('values', 0) + ' - ' + sliderElement.slider('values', 1) + ' Years');
            $('#txtMinAge').val(sliderElement.slider('values', 0));
            $('#txtMaxAge').val(sliderElement.slider('values', 1));

            //Tooltip From dataabse using webservice
            $('.displayTooltip').tooltip({
                content: function () {
                    var returnValue = '';
                    $.ajax({
                        url: 'TooltipService.asmx/GetHelpTextByKey',
                        method: 'post',
                        data: { key: $(this).attr('id') },
                        dataType: 'json',
                        async: false,
                        success: function (data) {
                            returnValue = data.Text;
                        }
                    });
                    return returnValue;
                }
            });
            /*
            $('.displayTooltip').tooltip({
                content: getTooltip
            });
            function getTooltip()
            {
                var returnValue = '';
                $.ajax({
                    url: 'TooltipService.asmx/GetHelpTextByKey',
                    method: 'post',
                    data: { key: $(this).attr('id') },
                    dataType: 'json',
                    async: false,
                    success: function (data) {
                        returnValue = data.Text;
                    }
                });
                return returnValue;
            }
            */
            // File uploead with progressBar
            $('#btnUpload').click(function () {
                var files = $('#FileUpload1')[0].files;
                if (files.length > 0)
                {
                    var formData = new FormData();
                    for (var i = 0; i < files.length; i++)
                    {
                        formData.append(files[i].Name, files[i]);
                    }
                    var progessBarDiv = $('#progressBar');
                    var progressBarLabel = $('#progressBarLabel');
                    $.ajax({

                        url: 'UploadHandler.ashx',
                        method: 'post',
                        data: formData,
                        contentType: false,
                        processData: false,
                        success: function () {
                            progressBarLabel.text('Complete -:)');
                            progessBarDiv.fadeOut(2000);
                        },
                        error: function (err) {
                            alert(err.statusText);
                        }
                    });
                    progressBarLabel.text('Uploading...');
                    progessBarDiv.progressbar({
                        value: false
                    }).fadeIn(500);
                }

            });

            // Dynmic Menu from the DB
            $.ajax({
                url: 'MenuHandler.ashx',
                method: 'get',
                dataType: 'json',
                success: function (data) {
                    buildMenu($('#menu'), data);
                    $('#menu').menu();
                }

            });

            function buildMenu(parent, items) {
                $.each(items, function () {
                    var li = $('<li>' + this.MenuText + '</li>');
                    if (this.Active)
                    {
                        li.addClass('ui-state-anabled');
                    }
                    li.appendTo(parent);

                    if (this.List && this.List.length > 0)
                    {
                        var ul = $('<ul></ul>');
                        ul.appendTo(li);
                        buildMenu(ul, this.List);
                    }
                });
            }

            // Menu widget
            $('#menu1').menu();

            // Select Menu
            $('#selectMenu').selectmenu({
                icons: {button:'ui-icon-circle-arrow-s'}
            });

            // Dialog Menu
            var dialogDiv = $('#dialog');
            $('#btnAddEmployee').click(function () {
                dialogDiv.dialog('open');

            });
            dialogDiv.dialog({
                autoOpen: false,
                modal: true,
                buttons: {
                    'Create':saveEmployee,
                    'Cancel': function () {
                        dialogDiv.dialog('close');
                        clearImputField();
                    }

                }


            });
            function getAllEmployees() {
                $.ajax({
                    url: 'EmployeeService.asmx/GetEmployees',
                    method: 'post',
                    dataType: 'json',
                    success: function (data) {
    
                        var employeeTableIns = $('#tbEmployees').DataTable({
                            data: data,
                            columns: [
                                { 'data': 'Id' },
                                { 'data': 'Name' },
                                {
                                    'data': 'Gender',
                                    'searchable': true,
                                    'sortable': true
                                },
                                {
                                    'data': 'Salary',
                                    'render': function (salary) {
                                        return salary + "$"; 
                                    }
                                }

                            ]


                        });
                        $('#tbEmployees thead th').each(function () {
                            var title = $('#tbEmployees tfoot th').eq($(this).index()).text();
                            $(this).html('<input type="text" placeholder="Search ' + title + '"/>');
                        });   

                        employeeTableIns.columns().every(function () {
                            var datatableColumn = this;
                            var searchtextBox =$(this.header()).find('input');
                            searchtextBox.on('keyup change', function () {
                                datatableColumn.search(this.value).draw();
                            });
                            searchtextBox.on('click', function (e) {
                                e.stopPropagation();
                            });
                        });
                    },
                    error: function (err) {
                        alert(err);
                    }
                });

            }
            getAllEmployees();
       // Create a new employee
            function saveEmployee() {            
                    var emp = {};
                    emp.Name = $('#dtxtName').val();
                    emp.Gender = $('#dtxtGender').val();
                    emp.Salary = $('#dtxtSalary').val();
                    $.ajax({
                        url: 'EmployeeService.asmx/AddEmployees',
                        method: 'post',
                        contentType: 'application/json;charset=utf-8',
                        data: '{emp:' + JSON.stringify(emp) + '}',
                        success: function (data) {
                            getAllEmployees();
                            dialogDiv.dialog('close');
                            clearImputField();
                        },
                        error: function (err) {
                            alert(err);
                        }
                    });
            }

            function clearImputField() {
                $('#dialog input[type="text"] ').val(''); 
            }

            // Draggable element
            $('.divClass').draggable().resizable({
                aspectRatio:true
            });
            $('.divClass').mousedown(function () {
                var maxZindex = 0;
                $(this).siblings('.divClass').each(function () {
                    var currentZindex = Number($(this).css('z-index'));
                    maxZindex = currentZindex > maxZindex ? currentZindex : maxZindex;
                });
                $(this).css('z-index', maxZindex + 1);
            });

            //Droppable widget
            $('#source li').draggable({            
                helper: 'clone',
                revert:'invalid'
            });

            $('#divCountries').droppable({
                accept: 'li[data-value="country"]',
                activeClass:'highlight',
                //over: function (even, ui) {
                //    $(this).addClass('highlight');
                //},
                //out: function (even, ui) {
                //    $(this).removeClass('highlight');
                //},
                drop: function (even, ui) {
                    $('#countries').append(ui.draggable);
                }
            });
            $('#divCities').droppable({
                accept: 'li[data-value="city"]',
                activeClass:'highlight',
                //over: function (even, ui) {
                //    $(this).addClass('highlight');
                //},
                //out: function (even, ui) {
                //    $(this).removeClass('highlight');
                //},
                 drop: function (even, ui) {
                     $('#cities').append(ui.draggable);
                 }
            });
            // Autocomplete with flag and text
            function updateTexBox(evn, ui) {
                $(this).val(ui.item.Id + '-' +
                    ui.item.Name);
                    return false;
            }
            $('#txtNameC').autocomplete({
                minLength: 1,
                focus: updateTexBox,
                select:updateTexBox,
                source: function (request, response) {

                    $.ajax({
                        url: 'EmployeeService.asmx/GetCountry',
                        method: 'post',
                        data: { term: request.term },
                        dataType: 'json',
                        success: function (data) {
                            response(data);
                        }
                    });
                }
            }).autocomplete('instance')._renderItem = function (ul, item) {
                return $('<li>')
                    .append('<img class="imgClass" src=' + item.FlagPath + 'alt=' + item.Name + '/>')
                    .append('<a>' + item.Id + '.' + item.Name + '</a>')
                    .appendTo(ul);
            }
        });
    </script>
    <style>
        .imgClass{
            width :16px;
            height:16px;
            padding-right:3px;
        }
        .dpdivClass{
            border :3px solid black;
            font-size:25px;
            background-color:lightgray;
            width:200px;
            padding:5px;
            display:inline-table;
        }
        li{
            font-size:20px;
        }
        .divClass {

            font-family :Arial;
            height:200px;
            width:200px;
            color:white;
            display:table-cell;
            vertical-align:middle;
            text-align:center;
            z-index:0;
        }

         #dialog, .highlight{
            background-color :green;
            color:white;
            border:3px solid grey;

        }

    </style>

</head>
<body>
    
 <form id="form1" runat="server">
     <h2>Autocomplete with images and text</h2>
     Country Name : <input type="text" id="txtNameC"/>
        <h2>Droppable widget</h2>
     <div class="dpdivClass">
        Countries & Cities
      <ul id="source">
           <li data-value="country">USA</li>
           <li data-value="country">France</li>
           <li data-value="country">Niger</li>
           <li data-value="country">UK</li>
           <li data-value="city">New York</li>
           <li data-value="city">Chennai</li>
           <li data-value="city">London</li>
           <li data-value="city">Niamey</li>
           <li data-value="city">Paris</li>
      </ul>
      </div>
     <div class="dpdivClass" id="divCountries">
         Countries
         <ul id="countries"></ul>
     </div>

     <div class="dpdivClass" id="divCities">
         Cities
         <ul id="cities"></ul>
     </div>

<h2>Draggable element</h2>
        <div id="draggableElement">
        <div id="redDiv" class="divClass" style="background-color:red"> Red Div</div>
        <div id="greenDiv" class="divClass" style="background-color:green"> Green Div</div>
        <div id="blueDiv" class="divClass" style="background-color:blue"> Blue Div</div>
        <div id="brownDiv" class="divClass" style="background-color:brown"> Brown Div</div>
         </div>
<h2>Dialog Menu from DB</h2>
<div id="dialog">
    <table border="1" style="border-collapse:collapse">
        <tr>
            <td>Name</td>
            <td> <input id="dtxtName" type="text" /></td>
        </tr>
        <tr>
            <td>Gender</td>
            <td> <input id="dtxtGender" type="text" /></td>
        </tr>
        <tr>
            <td>Salary</td>
            <td> <input id="dtxtSalary" type="text" /></td>
        </tr>
    </table>
</div>
 <br /><br />
 <div>
     <h3>Retrieve of employees from DB</h3>
     <div style="border:2px solid black; padding:3px; width:1200px">
    <table id="tbEmployees">
        <thead>
            <tr>
                <th>ID</th>
                <th>Name</th>
                <th>Gender</th>
                <th>Salary</th>
            </tr>
        </thead>
        <tfoot>
             <tr>
                <th>ID</th>
                <th>Name</th>
                <th>Gender</th>
                <th>Salary</th>
            </tr>

        </tfoot>
        <tbody></tbody>
    </table>
         </div>
 </div>
  <br /><br />
 <div>
        <input id="btnAddEmployee" value="Add New Employee" type="button"/>
 </div>
        <br /><br />
        <h2> Select Menu</h2>
        <select id="selectMenu">
            <optgroup label="USA">
                <option value="1">New York</option>
                <option value="2">California</option>
            </optgroup>
             <optgroup label="France">
                <option value="3">Toulouse</option>
                <option value="4">Paris</option>
            </optgroup>
             <optgroup label="Niger">
                <option value="5">Niamey</option>
                <option value="6">Tahoua</option>
            </optgroup>
        </select>
         <br /><br />
        <h2>Dynmic Menu from the DB</h2>
        <br /><br />
        <div style="width:150px">
            <ul id="menu"></ul>
        </div>

        <br /><br />
        <h2>  File uploead with progressBar  </h2> 
    Select Files :<asp:FileUpload AllowMultiple="true" ID="FileUpload1" runat="server"/>
        <br /><br />
        <input type="button" id="btnUpload" value="Upload Files" />
        <br /><br />
        <div style="width:300px">
            <div id="progressBar" style="position:relative; display:none">
                <span id="progressBarLabel" style="position:absolute; left:35%;top:20%"> Uploading...</span>
            </div>
        </div>
         <br /><br />
        <h2>  Autocomplete Textbox </h2>
        <div>
            Student Name :
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            Date of Birth :
            <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
            <br /><br />

            Age : <span id="spanOutput"></span>
            <br /><br />
            <div id="slider"></div>
            <br />
            <label for="txtMinAge">Minimum Age</label>
            <input type ="text" id="txtMinAge"/>
            <br /> <br />
            <label for="txtMaxAge">Maximum Age</label>
            <input type ="text" id="txtMaxAge"/>

        </div>
    </form>

    <h2>Tooltip From dataabse using webservice</h2>
    <form>
        <table>
        <tr>
            <td>First Name</td>
             <td><input id="firstName" class="displayTooltip" title="" type="text"/> </td>
        </tr>
         <tr>
            <td>Last Name</td>
             <td><input id="lastName" class="displayTooltip" title="" type="text" /> </td>
        </tr>
         <tr>
            <td>Email</td>
             <td><input id="email" class="displayTooltip" title=""  type="text" /> </td>
        </tr>
         <tr>
            <td>Income</td>
             <td><input id="income" class="displayTooltip" title=""  type="text" /> </td>        
        </tr>
    </table>


    </form>

<h2> JQuery Accordion in asp net </h2>
    <form>
        <div id="accordion" style="width:600px">       
        </div>

        <h2> JQuery Accordion using asp net repeter control with </h2>
        <div id="accordion1" style="width:600px">   
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <h3>
                        <%# Eval("Name") %>
                    </h3>
                    <div>
                        <%# Eval("CountryDescription") %>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
        <br/>
       
        <h2> JQuery Accordion using asp net LisView control </h2>
        <div id="accordion2" style="width:600px">   
            <asp:ListView ID="ListView1" runat="server">
                <ItemTemplate>
                    <h3>
                        <%# Eval("Name") %>S
                    </h3>
                    <div>
                        <%# Eval("CountryDescription") %>
                    </div>
                </ItemTemplate>
            </asp:ListView>
            </div>
    </form>

    <h3>Jquery tabs part 1</h3>
    <div id="tabs" style="width:500px">
        <ul>
            <asp:Repeater ID="Repeater2" runat="server">
                <ItemTemplate>
                    <li>
                        <a href="#c_<%#Eval("Id") %>">
                            <%#Eval("Name") %>
                        </a>
                    </li>
                </ItemTemplate>

            </asp:Repeater> 
        </ul>
        <asp:Repeater ID="Repeater3" runat="server">
            <ItemTemplate>
                <div id="c_<%#Eval("Id")%>">
                    <%#Eval("CountryDescription") %>
                </div>
            </ItemTemplate>
        </asp:Repeater>
      </div>
   
   
</body>
</html>
