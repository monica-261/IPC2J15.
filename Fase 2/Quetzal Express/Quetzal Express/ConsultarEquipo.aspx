<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultarEquipo.aspx.cs" Inherits="Quetzal_Express.ConsultarEquipo" %>

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
            width: 175px;
            height: 144px;
        }
        .auto-style3 {
            width: 148px;
        }
        .auto-style4 {
            height: 71px;
        }
    </style>
</head>
<body  style="background-image: url('imagenes/fondo.jpg'); font-weight: 700; font-size: large;">
    <form id="form1" runat="server">
    <div>
    
        .<table class="auto-style1">
            <tr>
                <td class="auto-style3" rowspan="2" style="background-color: #E69242; border-style: outset">
                    <img alt="" class="auto-style2" src="imagenes/Quetzal.jpg" /></td>
                <td class="auto-style4" style="background-color: #E69242; border-style: outset; text-align: center; font-weight: 700; font-size: xx-large;">VER EMPLEADOS</td>
            </tr>
            <tr>
                <td style="background-color: #E69242; border-style: outset">&nbsp;</td>
            </tr>
        </table>
    
    </div>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Departamento&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Height="22px" Width="302px"></asp:TextBox>
&nbsp;<asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/imagenes/search-32.png" />
        </p>
    </form>
</body>
</html>
