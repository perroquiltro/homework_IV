<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lbl_mensaje" runat="server"></asp:Label>

        <br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lbl_edad" runat="server" Text=""></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txt_edad" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lbl_nombre" Text="" runat="server" />
                </td>
                <td>
                    <asp:TextBox ID="txt_nombre" runat="server" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lbl_peso" Text="" runat="server" />
                </td>
                <td>
                    
                    <asp:TextBox ID="txt_peso" runat="server"></asp:TextBox>
                    
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                    <asp:Button ID="btn_calcular" runat="server" Text="Calcular" OnClick="btn_calcular_Click" />
                </td>
            </tr>
        </table>
    </div>
        <asp:Label ID="lbl_mensaje2" Text="" runat="server" />
    </form>
</body>
</html>
