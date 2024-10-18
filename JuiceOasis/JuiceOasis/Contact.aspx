<%@ Page Title="Contact Us" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="ContactUs.aspx.cs" Inherits="JuiceOasis.ContactUs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="contact-container">
        <div class="contact-image">
            <img src="Images/about-us.jpg" alt="Contact Us">
            <div class="overlay">
                <h2>Contact Us</h2>
                <p>Get in touch with us for any inquiries!</p>
            </div>
        </div>
        <div class="contact-form">
            <h3>We'd love to hear from you!</h3>
            <form>
                <label for="name">Name:</label>
                <input type="text" id="name" name="name" required>
                
                <label for="email">Email:</label>
                <input type="email" id="email" name="email" required>
                
                <label for="message">Message:</label>
                <textarea id="message" name="message" rows="4" required></textarea>
                
                <input type="submit" value="Send Message">
            </form>
        </div>
    </div>
</asp:Content>
