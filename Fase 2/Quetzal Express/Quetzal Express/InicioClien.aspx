<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InicioClien.aspx.cs" Inherits="Quetzal_Express.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 176px;
        }
        .auto-style3 {
            width: 176px;
            height: 148px;
        }
        .auto-style4 {
            height: 100px;
        }
        .auto-style5 {
            width: 175px;
            height: 144px;
        }
        .auto-style6 {
            height: 33px;
        }
    </style>
</head>
<body style="background-image: url( imagenes/fondo.jpg )">
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style3" rowspan="2" style="border-style: outset">
                    <img alt="" class="auto-style5" src="imagenes/Quetzal.jpg" /></td>
                <td class="auto-style4" style="border-style: outset; background-color: #E69242; text-align: center; font-weight: 700; font-size: xx-large;">BIENVENIDO</td>
            </tr>
            <tr>
                <td class="auto-style6" style="border-style: outset; background-color: #E69242;">&nbsp; &nbsp;<asp:Button ID="Button1" runat="server" BackColor="#E69242" BorderColor="#E69242" OnClick="Button1_Click" Text="Modificar Usuario" Width="116px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
