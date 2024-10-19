<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="JuiceOasis.AdminLogin" %>

<!DOCTYPE html>
<html lang="en">
<head runat="server">
    <meta charset="UTF-8">
    <title>Admin Login - Juice Oasis</title>
    <link href="Styles/adminStyles.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="admin-login-container">
            <img src="Images/juicelogo.png" alt="Juice Oasis Logo" class="logo" />
            <h2>Admin Login</h2>
            
            <asp:Label ID="lblErrorMessage" runat="server" CssClass="error-message" Visible="false"></asp:Label>
            
            <asp:TextBox ID="txtEmail" runat="server" CssClass="input-field" Placeholder="Email" TextMode="Email"></asp:TextBox>
            <asp:TextBox ID="txtPassword" runat="server" CssClass="input-field" Placeholder="Password" TextMode="Password"></asp:TextBox>
            
            <asp:Button ID="btnLogin" runat="server" CssClass="login-button" Text="Login" OnClick="btnLogin_Click" />
        </div>
    </form>
</body>
</html>
