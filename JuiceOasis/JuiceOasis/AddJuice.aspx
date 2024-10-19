<%@ Page Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeBehind="AddJuice.aspx.cs" Inherits="JuiceOasis.AddJuice" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-container">
        <h2>Add New Juice</h2>
        <asp:TextBox ID="txtName" runat="server" CssClass="input-field" Placeholder="Name"></asp:TextBox>
        <asp:TextBox ID="txtDescription" runat="server" CssClass="input-field" Placeholder="Description" TextMode="MultiLine" Rows="4"></asp:TextBox>
        <asp:TextBox ID="txtImageUrl" runat="server" CssClass="input-field" Placeholder="Image URL"></asp:TextBox>
        <asp:TextBox ID="txtPrice" runat="server" CssClass="input-field" Placeholder="Price"></asp:TextBox>

        <!-- Category Dropdown -->
        <asp:DropDownList ID="ddlCategory" runat="server" CssClass="input-field">
            <asp:ListItem Value="Fruit">Fruit</asp:ListItem>
            <asp:ListItem Value="Vegetable">Vegetable</asp:ListItem>
            <asp:ListItem Value="Mixed">Mixed</asp:ListItem>
        </asp:DropDownList>

        <!-- Availability Dropdown -->
        <asp:DropDownList ID="ddlAvailability" runat="server" CssClass="input-field">
            <asp:ListItem Value="Available">Available</asp:ListItem>
            <asp:ListItem Value="Out of Stock">Out of Stock</asp:ListItem>
        </asp:DropDownList>

        <!-- Save Button -->
        <asp:Button ID="btnAddJuice" runat="server" Text="Save" CssClass="submit-button" OnClick="btnAddJuice_Click" />
    </div>
</asp:Content>
