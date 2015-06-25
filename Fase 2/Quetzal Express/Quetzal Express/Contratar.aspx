<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contratar.aspx.cs" Inherits="Quetzal_Express.Contratacion" %>

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
        }
        .auto-style3 {
            width: 175px;
            height: 145px;
        }
        .auto-style4 {
            height: 100px;
        }
        .auto-style5 {
            width: 185px;
        }
        .auto-style6 {
            font-size: large;
            font-weight: bold;
        }
        .auto-style7 {
            width: 185px;
            height: 24px;
        }
        .auto-style8 {
            font-size: large;
            font-weight: bold;
            height: 24px;
            text-align: right;
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
                <td class="auto-style4" style="background-color: #E69242; border-style: outset; text-align: center; font-size: xx-large; font-weight: 700;">QUETZAL EXPRESS</td>
            </tr>
            <tr>
                <td style="background-color: #E69242; border-style: outset; text-align: center; font-size: large; font-weight: 700;">Contrataciones</td>
            </tr>
        </table>
    
    </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style6">
                    <br />
                    Nombre<br />
                    <asp:TextBox ID="TextBox1" runat="server" Width="360px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style6">Apellido<br />
                    <asp:TextBox ID="TextBox2" runat="server" Width="360px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style6">Usuario<br />
                    <asp:TextBox ID="TextBox3" runat="server" Width="250px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style6">Contraseña<br />
                    <asp:TextBox ID="TextBox4" runat="server" Width="250px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style6">Confirmar Contraseña<br />
                    <asp:TextBox ID="TextBox5" runat="server" Width="250px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label1" runat="server" style="font-style: italic"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style6">Sueldo<br />
                    <asp:TextBox ID="TextBox6" runat="server" Width="155px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style6">Sucursal<br />
                    <asp:TextBox ID="TextBox7" runat="server" Width="154px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style6">Puesto<br />
                    <asp:TextBox ID="TextBox8" runat="server" Width="155px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style6">Departamento<br />
                    <asp:TextBox ID="TextBox9" runat="server" Width="155px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style6">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="Button1" runat="server" BackColor="#209FCC" BorderColor="#209FCC" OnClick="Button1_Click" Text="Registrar" />
                </td>
            </tr>
            <tr>
                <td class="auto-style7"></td>
                <td class="auto-style8">
                    <asp:ImageButton ID="ImageButton1" runat="server" Height="20px" ImageUrl="~/imagenes/upload-2-32.png" Width="32px" OnClick="ImageButton1_Click" />
                    <asp:FileUpload ID="FileUpload1" runat="server" BackColor="#1DAAD7" />
&nbsp;&nbsp; </td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
