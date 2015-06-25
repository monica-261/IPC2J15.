<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DespEmp.aspx.cs" Inherits="Quetzal_Express.DespEmp" %>

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
            height: 144px;
        }
        .auto-style4 {
            height: 100px;
        }
        .auto-style5 {
            width: 183px;
        }
    </style>
</head>
<body  style="background-image: url( imagenes/fondo.jpg )">
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2" rowspan="2" style="background-color: #E69242; border-style: outset">
                    <img alt="" class="auto-style3" src="imagenes/Quetzal.jpg" /></td>
                <td class="auto-style4" style="background-color: #E69242; border-style: outset; text-align: center; font-weight: 700; font-size: xx-large;">QUETZAL EXPRESS</td>
            </tr>
            <tr>
                <td style="background-color: #E69242; border-style: outset; text-align: center; font-size: large; font-weight: 700;">Despedir empleado</td>
            </tr>
        </table>
    
    </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td style="font-weight: 700; font-size: large">Código de empleado&nbsp;
                    <asp:TextBox ID="TextBox1" runat="server" Width="50px"></asp:TextBox>
                    <asp:ImageButton ID="ImageButton1" runat="server" Height="24px" ImageUrl="~/imagenes/search-32.png" Width="26px" OnClick="ImageButton1_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td style="font-size: large; font-weight: 700">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Nombre&nbsp; &nbsp;<asp:Label ID="Label1" runat="server"></asp:Label>
                    <asp:Label ID="Label2" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td style="font-size: large; font-weight: 700">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Puesto&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox3" runat="server" Enabled="False"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td style="font-size: large; font-weight: 700">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="Button1" runat="server" BackColor="#1DC8F4" BorderColor="#1DC8F4" Text="Borrar de la base de datos" OnClick="Button1_Click" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
