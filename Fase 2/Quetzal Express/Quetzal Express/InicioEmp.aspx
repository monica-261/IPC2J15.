<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InicioEmp.aspx.cs" Inherits="Quetzal_Express.InicioEmp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 128px;
        }
        .auto-style2 {
            width: 175px;
            height: 144px;
        }
        .auto-style4 {
            width: 151px;
            height: 148px;
        }
        .auto-style5 {
            height: 101px;
        }
        .auto-style6 {
            height: 32px;
            text-align: center;
        }
        .auto-style7 {
            width: 100%;
        }
        .auto-style8 {
            width: 180px;
        }
    </style>
</head>
<body style="background-image: url( imagenes/fondo.jpg )">
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style4" rowspan="2" style="background-color: #E69242; border-style: outset">
                    <img alt="" class="auto-style2" src="imagenes/Quetzal.jpg" /></td>
                <td class="auto-style5" style="background-color: #E69242; border-style: outset; text-align: center; font-size: xx-large; font-weight: 700;">BIENVENIDO&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6" style="background-color: #E69242; border-style: outset">&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Label ID="Label2" runat="server" style="font-weight: 700; font-style: italic; font-size: large"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label3" runat="server" style="font-weight: 700; font-size: large; font-style: italic"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label4" runat="server" style="font-weight: 700; font-size: large; font-style: italic"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
        <table class="auto-style7">
            <tr>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
                <td>
                    <br />
                    <br />
                    <asp:RadioButton ID="RadioButton1" runat="server" style="font-weight: 700; font-size: large" Text="Gestión de Paquetes" />
                    <br />
                    <br />
                    <br />
                    <asp:RadioButton ID="RadioButton2" runat="server" style="font-weight: 700; font-size: large" Text="Gestión de Bodega" />
                    <br />
                    <br />
                    <br />
                    <asp:RadioButton ID="RadioButton3" runat="server" style="font-weight: 700; font-size: large" Text="Gestión de Servicio al Cliente" />
                    <br />
                    <br />
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/imagenes/arrow-right-5-32.png" style="text-align: right" />
                    <br />
                </td>
            </tr>
        </table>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
