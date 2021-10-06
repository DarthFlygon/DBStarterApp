<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DBInsert.aspx.cs" Inherits="DBStarterApp.DBInsert" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Name<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
            Email<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
            Phone<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
            ID<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br />
       </div>
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" /><br />
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/DBDisplay.aspx">Display</asp:HyperLink>&nbsp&nbsp
        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/DBUpdate.aspx">Update</asp:HyperLink>&nbsp&nbsp
        <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/DBDelete.aspx">Delete</asp:HyperLink>&nbsp&nbsp
    </form>
</body>
</html>
