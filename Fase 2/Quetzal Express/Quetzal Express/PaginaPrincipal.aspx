<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaginaPrincipal.aspx.cs" Inherits="Quetzal_Express.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 181px;
            height: 71px;
        }
        .auto-style3 {
            width: 181px;
            height: 148px;
        }
        .auto-style4 {
            height: 148px;
        }
        .auto-style5 {
            width: 175px;
            height: 144px;
        }
        .auto-style6 {
            height: 71px;
            text-align: center;
        }
        .auto-style7 {
            height: 71px;
            width: 642px;
        }
        .auto-style8 {
            width: 181px;
            height: 31px;
            text-align: center;
        }
        .auto-style9 {
            height: 31px;
            width: 642px;
        }
        .auto-style10 {
            height: 31px;
            text-align: center;
        }
    </style>
</head>
<body style="background-image: url( imagenes/fondo.jpg )">
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">
                    <img alt="" class="auto-style5" src="imagenes/Quetzal.jpg" style="border-style: outset" /></td>
                <td class="auto-style4" colspan="2" style="border-style: outset; background-color: #E69242; text-align: center; font-weight: 700; font-size: xx-large;">QUETZAL EXPRESS</td>
            </tr>
            <tr>
                <td class="auto-style8">Bienvenido<br />
                    <asp:Button ID="Button1" runat="server" BackColor="#21A4D0" BorderColor="#21A4D0" OnClick="Button1_Click" Text="Ingresar" />
                </td>
                <td class="auto-style9"></td>
                <td class="auto-style10">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
            </tr>
            </table>
    
    </div>
    </form>
</body>
</html>
