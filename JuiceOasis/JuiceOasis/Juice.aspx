<%@ Page Title="Juices" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="Juice.aspx.cs" Inherits="JuiceOasis.Juice" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <head runat="server">
        <title>Juices</title>
        <style>
            .sidebar h3 {
                font-size: 1.5em;
                margin-bottom: 10px;
                color: #333;
            }

            .sidebar button, .sidebar input[type="button"], .sidebar input[type="submit"] {
                display: block;
                width: 100%;
                padding: 10px;
                margin-bottom: 10px;
                font-size: 1em;
                background-color: #4CAF50; /* Default button color */
                color: white;
                border: none;
                border-radius: 5px;
                cursor: pointer;
                transition: background-color 0.3s, transform 0.2s;
            }

            .sidebar button:hover, .sidebar input[type="button"]:hover, .sidebar input[type="submit"]:hover {
                background-color: #45a049; /* Hover color */
                transform: translateY(-2px); /* Slight lift effect */
            }

            .sidebar button.active, .sidebar input[type="button"].active, .sidebar input[type="submit"].active {
                background-color: #2196F3; /* Active button color */
            }
        </style>
    </head>

    <div class="juice-container">
        <div class="sidebar">
            <h3>Filter by Category</h3>
            <asp:Button ID="btnAll" runat="server" Text="All" OnClick="btnFilter_Click" CommandArgument="All" />
            <asp:Button ID="btnFruits" runat="server" Text="Fruits" OnClick="btnFilter_Click" CommandArgument="Fruit" />
            <asp:Button ID="btnVegetables" runat="server" Text="Vegetables" OnClick="btnFilter_Click" CommandArgument="Vegetable" />
            <asp:Button ID="btnMixed" runat="server" Text="Mixed" OnClick="btnFilter_Click" CommandArgument="Mixed" />
        </div>
        <div class="juice-cards" id="juiceCards" runat="server">
            <asp:Repeater ID="repeaterJuices" runat="server">
                <ItemTemplate>
                    <div class="juice-card">
                        <img src='<%# Eval("ImageUrl") %>' alt='<%# Eval("Name") %>' />
                        <h3><%# Eval("Name") %></h3>
                        <p><%# Eval("Description") %></p>
                        <p style="color: <%# Eval("Availability").ToString() == "Available" ? "green" : "red" %>;">
                            <%# Eval("Availability") %>
                        </p>
                        <p>Price: $<%# Eval("Price", "{0:F2}") %></p>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>
