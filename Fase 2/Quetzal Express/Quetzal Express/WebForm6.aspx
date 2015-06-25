<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm6.aspx.cs" Inherits="Quetzal_Express.WebForm6" %>

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
            height: 66px;
        }
        .auto-style5 {
            width: 181px;
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
                <td class="auto-style4" style="background-color: #E69242; border-style: outset; text-align: center; font-weight: 700; font-size: xx-large;">QUETZAL EXPRESS</td>
            </tr>
            <tr>
                <td style="background-color: #E69242; border-style: outset; text-align: center; font-weight: 700; font-size: large;">Buscar Cliente</td>
            </tr>
        </table>
    
    </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td style="font-weight: 700; font-size: large">&nbsp;<br />
                    Cliente a buscar &nbsp;<asp:TextBox ID="TextBox1" runat="server" style="font-style: italic" Width="120px">Nombre</asp:TextBox>
&nbsp;<asp:TextBox ID="TextBox3" runat="server" style="font-style: italic" Width="120px">Apellido</asp:TextBox>
                    <asp:ImageButton ID="ImageButton1" runat="server" Height="21px" ImageUrl="~/imagenes/search-32.png" OnClick="ImageButton1_Click" Width="29px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td style="font-size: large; font-weight: 700">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Número Casilla &nbsp;<asp:TextBox ID="TextBox2" runat="server" Enabled="False" Width="50px"></asp:TextBox>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
