﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DBDelete.aspx.cs" Inherits="DBStarterApp.DBDelete" %>

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
            <p>Delete record by entering an id in the text input below<br /></p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Delete" OnClick="Button1_Click" /><br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/DBInsert.aspx">Insert</asp:HyperLink>&nbsp&nbsp
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/DBDisplay.aspx">Display</asp:HyperLink>&nbsp&nbsp
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/DBUpdate.aspx">Update</asp:HyperLink>&nbsp&nbsp
        </div>
    </form>
</body>
</html>
