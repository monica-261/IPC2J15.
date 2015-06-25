<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CargaMasiva.aspx.cs" Inherits="Quetzal_Express.CargaMasiva" %>

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
            margin-bottom: 0px;
        }
        .auto-style3 {
            width: 171px;
        }
        .auto-style4 {
            height: 68px;
        }
        .auto-style5 {
            height: 23px;
        }
        .auto-style6 {
            width: 178px;
        }
    </style>
</head>
<body style="background-image: url( imagenes/fondo.jpg )">
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style3" rowspan="2">
                    <img alt="" class="auto-style2" src="imagenes/Quetzal.jpg" /></td>
                <td class="auto-style4" style="background-color: #E69242; border-style: outset; text-align: center; font-size: xx-large; font-weight: 700;">QUETZAL EXPRESS</td>
            </tr>
            <tr>
                <td class="auto-style5" style="background-color: #E69242; border-style: outset"></td>
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
                    <asp:RadioButton ID="RadioButton2" runat="server" GroupName="Carga" style="font-weight: 700; font-size: large" Text="Carga Productos" />
                    <br />
                    <br />
                    <br />
                    <asp:RadioButton ID="RadioButton1" runat="server" GroupName="Carga" style="font-weight: 700; font-size: large" Text="Carga Impuesto" />
                    <br />
                    <br />
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:ImageButton ID="ImageButton1" runat="server" Height="25px" ImageUrl="~/imagenes/upload-2-32.png" OnClick="ImageButton1_Click" Width="36px" />
&nbsp;<asp:FileUpload ID="FileUpload1" runat="server" BackColor="#1B8CB8" />
                    <br />
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
