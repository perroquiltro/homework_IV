<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default4.aspx.cs" Inherits="Default4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 437px;
        }
        .auto-style2 {
            width: 167px;
        }
        .auto-style3 {
            width: 213px;
        }
        .auto-style4 {
            width: 209px;
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
                <td class="auto-style3">
                    <asp:TextBox ID="txt_edad" runat="server" Width="119px"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:RadioButton ID="radiobutton_year" runat="server" Text="Años" GroupName="tipo" />
                    <asp:RadioButton ID="radiobutton_month" runat="server" Text="Meses" GroupName="tipo" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lbl_nombre" Text="" runat="server" />
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txt_nombre" runat="server" />
                </td>
                <td class="auto-style4">
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lbl_peso" Text="" runat="server" />
                </td>
                <td class="auto-style3">
                    
                    <asp:TextBox ID="txt_peso" runat="server"></asp:TextBox>
                    
                </td>
                <td class="auto-style4">
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td class="auto-style3">
                    <asp:Button ID="btn_calcular" runat="server" Text="Calcular" OnClick="btn_calcular_Click" />
                </td>
            </tr>
        </table>
    </div>
        <asp:Label ID="lbl_mensaje2" Text="" runat="server" />
    </form>
</body>
</html>
