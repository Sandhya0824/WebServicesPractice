<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="EmployeeWebApplication.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Employee Portal</h1>
    <form>
        <asp:Label ID="firstName" runat="server"> First Name : </asp:Label>
        <input type="text" id="textbox1" name="textbox1"><br><br>
        
        <asp:Label ID="lastName" runat="server">Last Name : </asp:Label>
        <input type="text" id="textbox2" name="textbox2"><br><br>
        
        <asp:Label ID="empID" runat="server">Employee ID : </asp:Label>
        <input type="number" id="textbox3" name="textbox3"><br><br>

        <asp:Button ID="Button5" runat="server" Text="Add Employee" OnClick="Button5_Click" />
        <asp:Button ID="Button1" runat="server" Text="Remove Employee" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Update First Name" OnClick="Button2_Click" />
        <asp:Button ID="Button3" runat="server" Text="Update last Name" OnClick="Button3_Click" />
        <asp:Button ID="Button4" runat="server" Text="Get Employee Name" OnClick="Button4_Click" />
    </form>
</body>
</html>
