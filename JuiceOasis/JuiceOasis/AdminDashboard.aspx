<%@ Page Title="Admin Dashboard" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeBehind="AdminDashboard.aspx.cs" Inherits="JuiceOasis.AdminDashboard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="admin-content">
        
        <asp:Repeater ID="repeaterJuices" runat="server">
            <ItemTemplate>
                <div class="juice-card">
                    <img src='<%# Eval("ImageUrl") %>' alt='<%# Eval("Name") %>' />
                    <h3><%# Eval("Name") %></h3>
                    <p><%# Eval("Description") %></p>
                    <p>Category: <%# Eval("Category") %></p>
                    <p>Price: $<%# Eval("Price", "{0:F2}") %></p>
                    <p style="color: <%# Eval("Availability").ToString() == "Available" ? "green" : "red" %>;">
                        <%# Eval("Availability") %>
                    </p>
                    <asp:Button ID="btnEdit" runat="server" Text="Edit" CommandArgument='<%# Eval("JuiceID") %>' OnClick="btnEdit_Click" CssClass="btn-edit" />
                    <asp:Button ID="btnDelete" runat="server" Text="Delete" CommandArgument='<%# Eval("JuiceID") %>' OnClick="btnDelete_Click" CssClass="btn-delete" />
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
