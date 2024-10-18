<%@ Page Title="Juices" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="Juice.aspx.cs" Inherits="JuiceOasis.Juice" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="juice-container">
        <div class="sidebar">
            <h3>Filter by Category</h3>
            <button onclick="filterJuices('All')">All</button>
            <button onclick="filterJuices('Fruits')">Fruits</button>
            <button onclick="filterJuices('Vegetables')">Vegetables</button>
            <button onclick="filterJuices('Mixed')">Mixed</button>
        </div>
        <div class="juice-cards" id="juiceCards">
            <!-- Juice cards will be populated here -->
        </div>
    </div>

    <script>
        // Ensure the juices array is populated with server-side data
        let juices = <%= Newtonsoft.Json.JsonConvert.SerializeObject(Juices) %>;

        function displayJuices(filter) {
            const juiceCardsContainer = document.getElementById('juiceCards');
            juiceCardsContainer.innerHTML = ''; // Clear previous content

            // Filter the juices based on the selected category
            const filteredJuices = filter === 'All' ? juices : juices.filter(juice => juice.Category === filter);

            // Create a card for each juice in the filtered array
            filteredJuices.forEach(juice => {
                const card = document.createElement('div');
                card.className = 'juice-card';
                card.innerHTML = `
                    <img src="${juice.ImageUrl}" alt="${juice.Name}">
                    <h3>${juice.Name}</h3>
                    <p>${juice.Description}</p>
                    <p style="color: ${juice.Availability === 'Available' ? 'green' : 'red'};">
                        ${juice.Availability}
                    </p>
                `;
                juiceCardsContainer.appendChild(card);
            });
        }

        function filterJuices(category) {
            displayJuices(category);
        }

        // Display all juices on page load
        window.onload = function () {
            displayJuices('All');
        };
    </script>
</asp:Content>
