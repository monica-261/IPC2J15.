<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm8.aspx.cs" Inherits="Quetzal_Express.WebForm8" %>

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
        .auto-style4 {
            width: 175px;
            height: 144px;
        }
        .auto-style5 {
            height: 67px;
        }
        .auto-style6 {
            height: 22px;
            font-size: large;
        }
        .auto-style7 {
            width: 182px;
        }
    </style>
</head>
<body  style="background-image: url( imagenes/fondo.jpg )">
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2" rowspan="2" style="background-color: #E69242; border-style: outset">
                    <img alt="" class="auto-style4" src="imagenes/Quetzal.jpg" /></td>
                <td class="auto-style5" style="background-color: #E69242; border-style: outset; text-align: center; font-weight: 700; font-size: xx-large;">QUETZAL EXPRESS</td>
            </tr>
            <tr>
                <td class="auto-style6" style="background-color: #E69242; border-style: outset; text-align: center; font-weight: 700;">Entrega y facturación</td>
            </tr>
        </table>
    
    </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td style="font-size: large; font-weight: 700">
                    <br />
&nbsp;Código Cliente
                    <asp:TextBox ID="TextBox1" runat="server" Width="45px"></asp:TextBox>
                    <asp:ImageButton ID="ImageButton1" runat="server" Height="27px" ImageUrl="~/imagenes/search-32.png" OnClick="ImageButton1_Click" Width="31px" />
                    <br />
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Nombre Cliente
                    <asp:Label ID="Label1" runat="server" style="font-style: italic"></asp:Label>
                    <asp:Label ID="Label2" runat="server" style="font-style: italic"></asp:Label>
                    <br />
                    <br />
                    <br />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
