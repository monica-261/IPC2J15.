<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModificarClien.aspx.cs" Inherits="Quetzal_Express.ModificarClien" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 151px;
        }
        .auto-style3 {
            width: 151px;
            height: 148px;
        }
        .auto-style4 {
            height: 90px;
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
                <td class="auto-style4" style="border-style: outset; background-color: #E69242; text-align: center; font-weight: 700; font-size: xx-large;">Modificar Usuario</td>
            </tr>
            <tr>
                <td class="auto-style6" style="border-style: outset; background-color: #E69242; text-align: center; font-size: large; font-weight: 700;">Ingrese datos a modificar</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td style="font-size: large; font-weight: 700">Nombre<br />
                    <asp:TextBox ID="TextBox1" runat="server" Width="360px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td style="font-size: large; font-weight: 700">Apellido<br />
                    <asp:TextBox ID="TextBox2" runat="server" Width="360px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td style="font-size: large; font-weight: 700">Contraseña<br />
                    <asp:TextBox ID="TextBox3" runat="server" Width="250px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td style="font-size: large; font-weight: 700">Confirmar Contraseña<br />
                    <asp:TextBox ID="TextBox4" runat="server" Width="250px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td style="font-size: large; font-weight: 700">Teléfono<br />
                    <asp:TextBox ID="TextBox5" runat="server" Width="250px"></asp:TextBox>
&nbsp;<asp:Label ID="Label1" runat="server" style="font-style: italic"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td style="font-size: large; font-weight: 700">Dirección<br />
                    <asp:TextBox ID="TextBox6" runat="server" Width="250px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td style="font-size: large; font-weight: 700">
                    <asp:Button ID="Button1" runat="server" BackColor="#24ADD9" BorderColor="#24ADD9" Text="Modificar" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
