<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DBUpdate.aspx.cs" Inherits="DBStarterApp.DBUpdate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </div>
         <div>
            <p>Update record by entering an id in the text input below<br /></p>
            ID:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
             <p>Values to Update</p>
            Name:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
            Email:<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
            <asp:Button ID="Button1" runat="server" Text="Update" OnClick="Button1_Click" /><br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/DBInsert.aspx">Insert</asp:HyperLink>&nbsp&nbsp
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/DBDisplay.aspx">Display</asp:HyperLink>&nbsp&nbsp
            <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/DBDelete.aspx">Delete</asp:HyperLink>&nbsp&nbsp
        </div>
    </form>
</body>
</html>
