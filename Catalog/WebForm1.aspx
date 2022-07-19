<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Catalog.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Insert" OnClick="Button1_Click" />
                    </td>
                </tr>
                <tr>
                    <td>Marca</td>
                    <td>
                        <asp:TextBox ID="Marca" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Nume</td>
                    <td>
                        <asp:TextBox ID="nume" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Prenume</td>
                    <td>
                        <asp:TextBox ID="prenume" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Nota1</td>
                    <td>
                        <asp:TextBox ID="nota1" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Nota2</td>
                    <td>
                        <asp:TextBox ID="nota2" runat="server"></asp:TextBox></td>
                </tr>
                <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            </table>
        </div>
    </form>
</body>
</html>
