<%@ Page Title="Home" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="JuiceOasis.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="slideshow-container">
        <div class="mySlides fade">
            <img src="Images/juice1.jpg" style="width:100%">
        </div>
        <div class="mySlides fade">
            <img src="Images/juice2.jpg" style="width:100%">
        </div>
        <div class="mySlides fade">
            <img src="Images/juice3.jpg" style="width:100%">
        </div>
        <div class="mySlides fade">
            <img src="Images/juice4.jpg" style="width:100%">
        </div>
        <div class="mySlides fade">
            <img src="Images/juice5.jpg" style="width:100%">
        </div>
    </div>

      <p class="description">
        Discover the vibrant world of juices made from the freshest fruits and vegetables. Our juices are packed with nutrients, delicious flavors, and are perfect for any occasion! Each bottle is a burst of health, crafted with care to ensure you get the best out of nature's bounty. 
        Experience the rich textures and colors that come from 100% natural ingredients, with no added sugars or preservatives. 
        Whether you’re looking for a refreshing drink on a hot day or a nutritious boost to start your morning, we have a juice for you. 
        From tangy citrus blends to sweet berry mixes, our diverse range caters to every palate. Embrace a healthier lifestyle with our delicious juices that nourish your body and delight your taste buds!
    </p>

    <h2 class="juice-heading">Sip into Bliss: Our Top 5 Juices!</h2>
    <div class="juice-cards">
        <div class="juice-card">
            <img src="Images/apple-juice.jpg" alt="Apple Juice">
            <h3>Apple Juice</h3>
            <p>Freshly squeezed apple juice for a crisp taste.</p>
        </div>
        <div class="juice-card">
            <img src="Images/carrot-juice.jpg" alt="Carrot Juice">
            <h3>Carrot Juice</h3>
            <p>Rich in vitamins and perfect for a health boost.</p>
        </div>
        <div class="juice-card">
            <img src="Images/berry-bliss.jpg" alt="Berry Bliss">
            <h3>Berry Bliss</h3>
            <p>A delicious blend of mixed berries for a refreshing drink.</p>
        </div>
        <div class="juice-card">
            <img src="Images/mango-juice.jpg" alt="Mango Juice">
            <h3>Mango Juice</h3>
            <p>Sweet and tropical mango juice to brighten your day.</p>
        </div>
        <div class="juice-card">
            <img src="Images/green-juice.jpg" alt="Green Juice">
            <h3>Green Juice</h3>
            <p>A nutritious blend of green vegetables for detox.</p>
        </div>
    </div>

    <!-- Move the script inside the content control -->
    <script>
        let slideIndex = 0;
        showSlides();

        function showSlides() {
            let slides = document.getElementsByClassName("mySlides");
            for (let i = 0; i < slides.length; i++) {
                slides[i].style.display = "none"; // Hide all slides
            }
            slideIndex++;
            if (slideIndex > slides.length) { slideIndex = 1 } // Reset to first slide
            slides[slideIndex - 1].style.display = "block"; // Show the current slide
            setTimeout(showSlides, 3000); // Change slide every 3 seconds
        }
    </script>
</asp:Content>
