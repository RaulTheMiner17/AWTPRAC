<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmpRegistration.aspx.cs" Inherits="dbDemo.EmpRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Name:
            <asp:TextBox ID="tbname" runat="server"></asp:TextBox>
        </div>
        <p>
            Department:
            <asp:TextBox ID="tbdep" runat="server"></asp:TextBox>
        </p>
        <p>
            City:
            <asp:TextBox ID="tbcity" runat="server"></asp:TextBox>
        </p>
        <p>
            Salary:
            <asp:TextBox ID="tbsal" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Register" />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:RegConnectionString %>" ProviderName="<%$ ConnectionStrings:RegConnectionString.ProviderName %>" SelectCommand="SELECT [name], [department], [city], [salary] FROM [Employee]"></asp:SqlDataSource>
    </form>
</body>
</html>
