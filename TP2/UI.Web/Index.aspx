<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="UI.Web.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="HojaDeEstilo1.css" rel="stylesheet" type="text/css"/>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form runat="server">
         <table style="width:100%;">
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>
    
            <asp:Label ID="lblBienvenido" runat="server" Text="Bienvenido al Sistema!"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
            <asp:Label ID="lblUsuario" runat="server" Text="Usuario"></asp:Label>
                    </td>
                    <td>
            <asp:TextBox ID="txtUsuario" runat="server" placeholder="Usuario"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
            <asp:Label ID="lblClave" runat="server" Text="Clave"></asp:Label>
                    </td>
                    <td>
            <asp:TextBox ID="txtClave" type="password" runat="server" placeholder="Clave"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>
            <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" onClick="btnIngresar_Click"/>
                    </td>
                </tr>
                <tr>
                    <td>
    
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </form>
</body>
</html>
