<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm7.aspx.cs" Inherits="Quetzal_Express.WebForm7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 145px;
            height: 144px;
        }
        .auto-style3 {
            height: 67px;
        }
        .auto-style4 {
            width: 174px;
            height: 144px;
        }
        .auto-style5 {
            width: 181px;
        }
        .auto-style6 {
            font-size: large;
            font-weight: bold;
        }
    </style>
</head>
<body style="background-image: url( imagenes/fondo.jpg )">
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2" style="background-color: #E69242; border-style: outset" rowspan="2">
                    <img alt="" class="auto-style4" src="imagenes/Quetzal.jpg" /></td>
                <td class="auto-style3" style="background-color: #E69242; border-style: outset; text-align: center; font-size: xx-large; font-weight: 700;">QUETZAL EXPRESS</td>
            </tr>
            <tr>
                <td style="background-color: #E69242; border-style: outset; text-align: center; font-size: large; font-weight: 700;">Servicio al cliente</td>
            </tr>
        </table>
    
    </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style5">
                    <br />
                    <br />
                    <br />
                </td>
                <td>
                    <br />
                    <br />
                    <asp:RadioButton ID="RadioButton1" runat="server" CssClass="auto-style6" GroupName="ServicioCliente" Text="Entrega y Facturacion" />
                    <br />
                    <br />
                    <br />
                    <asp:RadioButton ID="RadioButton2" runat="server" CssClass="auto-style6" GroupName="ServicioCliente" Text="Devolucion" />
                    <br />
                    <br />
                    <br />
                    <asp:RadioButton ID="RadioButton3" runat="server" CssClass="auto-style6" GroupName="ServicioCliente" Text="Busqueda Cliente" />
                    <br />
                    <br />
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/imagenes/arrow-right-5-32.png" OnClick="ImageButton1_Click" />
                    <br />
                    <br />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
