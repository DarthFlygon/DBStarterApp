<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DBDisplay.aspx.cs" Inherits="DBStarterApp.DBDisplay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <form runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </div>
        <div>
            <p>Find record by entering an id in the text input below<br /></p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Find" OnClick="Button1_Click" />
        </div>
    </form>
    
    <div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><br />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label><br />
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label><br />
    </div>
    <div>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/DBInsert.aspx">Insert</asp:HyperLink>&nbsp&nbsp
        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/DBUpdate.aspx">Update</asp:HyperLink>&nbsp&nbsp
        <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/DBDelete.aspx">Delete</asp:HyperLink>&nbsp&nbsp
    </div>
    
</body>
</html>
