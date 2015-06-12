<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="Quetzal_Express.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 63px;
        }
        .auto-style5 {
            width: 175px;
            height: 144px;
        }
        .auto-style6 {
            width: 63px;
            height: 148px;
        }
        .auto-style7 {
            height: 148px;
        }
        .auto-style8 {
            width: 63px;
            height: 131px;
        }
        .auto-style9 {
            height: 131px;
            text-align: center;
            font-weight: 700;
            font-size: large;
        }
    </style>
</head>
<body style="background-image: url( imagenes/fondo.jpg )">
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style6">
                    <img alt="" class="auto-style5" src="imagenes/Quetzal.jpg" style="border-style: outset" /></td>
                <td class="auto-style7" style="background-color: #E69242; border-style: outset; text-align: center; font-size: xx-large; font-weight: 700;">BIENVENIDO</td>
            </tr>
            <tr>
                <td class="auto-style8"></td>
                <td class="auto-style9">Usuario<br />
                    <asp:TextBox ID="TextBox1" runat="server" Width="143px"></asp:TextBox>
                    <br />
                    Contraseña<br />
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" Width="143px"></asp:TextBox>
                    <br />
                    <asp:Button ID="Button1" runat="server" BackColor="#1CA3D0" BorderColor="#1CA3D0" Text="Ingresar" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>¿Sin cuenta de usuario?<br />
                    <asp:Button ID="Button2" runat="server" BackColor="#20C1ED" BorderColor="#20C1ED" OnClick="Button2_Click" Text="Crear una" />
                </td>
            </tr>
        </table>
    
    </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
