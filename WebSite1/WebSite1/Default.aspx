<!DOCTYPE html>
<html>

<head>
	<title> </title>
	<meta charset="utf-8">
	<style>
		p,h2{
			border: 1px solid blue;
			background-color: #29B;
			padding: 20px;
			margin: 10px;
		}
	</style>
</head>
<body>
   <h1>MOUSE EVENT  PROPERTIES</h1> <br />
 <input type="button" value ="Afficher l'heure courante" onclick="horloge()"/>
 <input type="button" value ="Modifier la couleur de la page" onclick="couleur()"/>
<h2 id="h">  Horloge actualisté en direct  : il est : <span id= "temps"></span></h2>
<input type="button" value ="Single, Double or Rpght Click" 
    onmousedown ="logEvent(event)" onmouseup="logEvent(event)"
    onclick="logEvent(event)" onmouseover="logEvent(event)"
    onmouseout="logEvent(event)" ondblclick="logEvent(event)"
    oncontextmenu="logEvent(event)"/>
<input type="button" value ="Clear" onclick ="clearText()"/>

<br /><br />
<textarea id="txtArea" rows="3" cols="20"></textarea>

<input type="button" value ="Click Me" onmouseup="getMouseClickCode(event)"/><br /><br />

<input type="button" value ="popup Window" onclick="openpopup()"/>
<input type="button" value ="close Window" onclick="closepopoup()"/>


<script type="text/javascript">
        console.log("test debut");
    var body = document.body;
    var myWindow;
    function openpopup() {

        myWindow = window.open('https://csharp-video-tutorials.blogspot.com', 'My Window', 'height =100,width = 400, scrollbars =yes,resizable=yes');
    }

    function closepopoup() {
        myWindow.close();
    }

    function logEvent(event) {
        event = event || window.event;
        document.getElementById("txtArea").value += event.type + "\r\n";

    }

    function clearText() {
        document.getElementById("txtArea").value = "";
    }


    function getMouseClickCode(event) {
        var whichButton; 
        if (event.which) {
            document.getElementById("txtArea").value += "event.which = " + event.which + "\r\n";
            switch (event.which) {
                case 1:
                    whichButton = "Left Button Clicked";
                    break;
                case 2:
                    whichButton = "Middle Button Clicked";
                    break;
                case 3:
                    whichButton = "Right Button Clicked";
                    break;
                default:
                    whichButton = "Invalide Button Clicked";
                    break;            
            }
        }
        else {
            document.getElementById("txtArea").value += "event.button= " + event.button + "\r\n";
            switch (event.button) {
                case 1:
                    whichButton = "Left Button Clicked";
                    break;
                case 4:
                    whichButton = "Middle Button Clicked";
                    break;
                case 6:
                    whichButton = "Right Button Clicked";
                    break;
                default:
                    whichButton = "Invalide Button Clicked";
                    break;            
            }

        }
        alert(whichButton);
    }

     console.log("test ici");
  
    function horloge() {
        var d = new Date();
        document.getElementById('temps').innerHTML = d.toLocaleTimeString();
        console.log(d.toLocaleDateString());
        
    }

    function couleur() {
        
   	setTimeout((function () { body.style.backgroundColor = '#38A'}),200);
    setTimeout((function () { body.style.backgroundColor = '#4AB'}),400);
    setTimeout((function () { body.style.backgroundColor = '#59B'}),600);
    setTimeout((function () { body.style.backgroundColor = '#66B'}),800);
    setTimeout((function () { body.style.backgroundColor = '#63B'}),1000);
    setTimeout((function () { body.style.backgroundColor = '#83A'}),1200);
    setTimeout((function () { body.style.backgroundColor = '#A3A'}),1400);
    setTimeout((function () { body.style.backgroundColor = '#A59'}),1600);
    setTimeout((function () { body.style.backgroundColor = '#A77'}),1800);
    setTimeout((function () { body.style.backgroundColor = '#995'}),2000);

       
    }

  /*  document.oncontextmenu = preventContextMenu;

    function preventContextMenu(event){
        event = event || window.event;
        if (event.preventDefault) {
            event.preventDefault();
        }
        else {
            event.returnValue = false;
        }
    }*/

</script>
      </body>
 </html>