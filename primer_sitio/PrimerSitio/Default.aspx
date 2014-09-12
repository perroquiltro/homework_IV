<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 130px;
        }
    </style>
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
                    <asp:Button ID="btn_calcular" runat="server" Text="Calcular" OnClick="btn_calcular_Click" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>

    </div>
        <asp:Label ID="lbl_pesoIdeal" runat="server"></asp:Label>
    </form>
</body>
</html>
