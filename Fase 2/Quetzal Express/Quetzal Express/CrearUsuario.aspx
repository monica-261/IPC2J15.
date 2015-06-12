<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrearUsuario.aspx.cs" Inherits="Quetzal_Express.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 175px;
            height: 144px;
        }
        .auto-style3 {
            width: 164px;
        }
        .auto-style4 {
            width: 164px;
            height: 148px;
        }
        .auto-style5 {
            height: 100px;
        }
    </style>
</head>
<body style="background-image: url( imagenes/fondo.jpg )">
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style4" rowspan="2">
                    <img alt="" class="auto-style2" src="imagenes/Quetzal.jpg" style="border-style: outset" /></td>
                <td class="auto-style5" style="background-color: #E69242; border-style: outset; font-size: xx-large; text-align: center; font-weight: 700;">REGISTRESE</td>
            </tr>
            <tr>
                <td style="background-color: #E69242; border-style: outset; font-size: xx-large; text-align: center; font-weight: 700;"></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td style="font-weight: 700; font-size: large">Nombre<br />
                    <asp:TextBox ID="TextBox1" runat="server" Width="360px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td style="font-weight: 700; font-size: large">Apellido<br />
                    <asp:TextBox ID="TextBox2" runat="server" Width="360px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td style="font-weight: 700; font-size: large">Usuario<br />
                    <asp:TextBox ID="TextBox3" runat="server" Width="250px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td style="font-weight: 700; font-size: large">Contraseña<br />
                    <asp:TextBox ID="TextBox4" runat="server" Width="250px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td style="font-weight: 700; font-size: large">Confirmar Contraseña<br />
                    <asp:TextBox ID="TextBox5" runat="server" Width="250px"></asp:TextBox>
&nbsp;
                    <asp:Label ID="Label1" runat="server" style="font-style: italic"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td style="font-weight: 700; font-size: large">DPI<br />
                    <asp:TextBox ID="TextBox6" runat="server" Width="250px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td style="font-weight: 700; font-size: large">NIT<br />
                    <asp:TextBox ID="TextBox7" runat="server" Width="250px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td style="font-weight: 700; font-size: large">Teléfono<br />
                    <asp:TextBox ID="TextBox8" runat="server" Width="250px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td style="font-weight: 700; font-size: large">Dirección<br />
                    <asp:TextBox ID="TextBox9" runat="server" Width="250px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td style="font-weight: 700; font-size: large">No. Tarjeta<br />
                    <asp:TextBox ID="TextBox10" runat="server" Width="250px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td style="font-weight: 700; font-size: large; text-align: right">
                    <asp:Button ID="Button1" runat="server" BackColor="#00A2D0" BorderColor="#00A2D0" Text="Registrarse" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
