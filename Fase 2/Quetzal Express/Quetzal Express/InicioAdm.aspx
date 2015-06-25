<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InicioAdm.aspx.cs" Inherits="Quetzal_Express.InicioAdm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 144px;
            height: 144px;
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
            width: 183px;
        }
    </style>
</head>
<body style="background-image: url( imagenes/fondo.jpg )">
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2" rowspan="2" style="background-color: #E69242; border-style: outset">
                    <img alt="" class="auto-style3" src="imagenes/Quetzal.jpg" /></td>
                <td class="auto-style5" style="background-color: #E69242; border-style: outset; text-align: center; font-weight: 700; font-size: xx-large;">BIENVENIDO</td>
            </tr>
            <tr>
                <td class="auto-style4" style="background-color: #E69242; border-style: outset">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Label ID="Label1" runat="server" style="font-style: italic; font-weight: 700; font-size: large"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td>
                    <br />
                    <br />
                    <asp:RadioButton ID="RadioButton1" runat="server" style="font-weight: 700; font-size: large" Text="Carga Masiva" OnCheckedChanged="RadioButton1_CheckedChanged" />
                    <br />
                    <br />
                    <br />
                    <asp:RadioButton ID="RadioButton2" runat="server" style="font-weight: 700; font-size: large" Text="Gestión de Cobros" />
                    <br />
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/imagenes/arrow-right-5-32.png" OnClick="ImageButton2_Click" />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
