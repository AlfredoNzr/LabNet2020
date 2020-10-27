<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebAppUI.aspx.cs" Inherits="ExceptionPractice.Interfaces.WebAppUI.WebAppUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="ListBoxExercises" runat="server" OnClick="ShowOptions();">
                <asp:ListItem Selected="True" Value="1">Ejercicio 1</asp:ListItem>
                <asp:ListItem Value="2">Ejercicio 2</asp:ListItem>
                <asp:ListItem Value="3">Ejercicio 3</asp:ListItem>
                <asp:ListItem Value="4">Ejercicio 4</asp:ListItem>
            </asp:ListBox>
            <asp:Button ID="ButtonExecute" runat="server" OnClick="ButtonExecute_Click" style="height: 26px" Text="Ejecutar" />
            <asp:ListBox ID="ListBoxOptions" runat="server">
                <asp:ListItem Selected="True" Value="1">Opcion 1</asp:ListItem>
                <asp:ListItem Value="2">Opcion 2</asp:ListItem>
                <asp:ListItem Value="3">Opcion 3</asp:ListItem>
            </asp:ListBox>
            <br />
            <asp:Label ID="LabelResult" runat="server" Text="Resultado"></asp:Label>
            <br />
            <asp:Label ID="LabelStatus" runat="server" Text="Estado"></asp:Label>
        </div>
    </form>
    <script>
        document.getElementById("ListBoxOptions").hidden = true;
        function ShowOptions() {
            if (document.getElementById("ListBoxExercises").value == 2) {
                document.getElementById("ListBoxOptions").hidden = false;
            } else {
                document.getElementById("ListBoxOptions").hidden = true;
            }
        }
    </script>
</body>
</html>
