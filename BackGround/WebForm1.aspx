<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="BackGround.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body id="Body" runat="server"> 
<form id="form1" runat="server"> 

    <div>
        
       <button id="button1" runat="server" onserverclick="doIt" >Red</button>
         <button id="button2" runat="server" onserverclick="doIt2" >yellow</button>
             <button id="button3" runat="server" onserverclick="doIt3" >Green</button>
                 <button id="button4" runat="server" onserverclick="doIt4" >Blue</button>
        </div>
</form> 
</body>
</html>
