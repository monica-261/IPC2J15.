<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InicioDir.aspx.cs" Inherits="Quetzal_Express.InicioDir" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 144px;
        }
        .auto-style2 {
            width: 164px;
        }
        .auto-style3 {
            width: 175px;
            height: 144px;
        }
        .auto-style4 {
            height: 25px;
        }
        .auto-style5 {
            height: 100px;
        }
        .auto-style6 {
            width: 100%;
        }
        .auto-style7 {
            width: 182px;
        }
        .auto-style8 {
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
                    <img alt="" class="auto-style3" src="imagenes/Quetzal.jpg" /></td>
                <td style="background-color: #E69242; border-style: outset; text-align: center; font-weight: 700; font-size: xx-large;" class="auto-style5">BIENVENIDO</td>
            </tr>
            <tr>
                <td style="background-color: #E69242; border-style: outset; text-align: center; font-weight: 700; font-size: large;" class="auto-style4">
                    <asp:Label ID="Label1" runat="server" style="font-size: large; font-style: italic"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
            </tr>
        </table>
    
    </div>
        <table class="auto-style6">
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td>
                    <br />
                    <asp:RadioButton ID="RadioButton1" runat="server" style="font-size: large; font-weight: 700" Text="Contratación" GroupName="opc" />
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
                    <br />
                    <asp:RadioButton ID="RadioButton2" runat="server" CssClass="auto-style8" Text="Consultar Equipo" GroupName="opc" />
                    <br />
                    <br />
                    <br />
                    <asp:RadioButton ID="RadioButton3" runat="server" CssClass="auto-style8" Text="Modificar Contratación" GroupName="opc" />
                    <br />
                    <br />
                    <br />
                    <asp:RadioButton ID="RadioButton4" runat="server" CssClass="auto-style8" Text="Despedir Empleado" GroupName="opc" />
                    <br />
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/imagenes/arrow-right-5-32.png" OnClick="ImageButton1_Click" />
                    <br />
                    <br />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
