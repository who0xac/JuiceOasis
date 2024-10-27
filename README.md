# Juice Oasis Management System

Juice Oasis Management System is a web application developed with ASP.NET Web Forms (.NET Framework) and MySQL. The system is designed to help administrators efficiently manage juice inventory, categorize items, and track sales, with full CRUD functionality and a streamlined user interface.

## Table of Contents
- [Features](#features)
- [Technologies Used](#technologies-used)
- [Installation](#installation)


---

## Features

1. **User Authentication**  
   - Admin login and registration to access the system securely.
   - Only authenticated admins can view the dashboard and perform operations.

2. **Dashboard**  
   - Displays an overview of juice inventory and allows admins to view, add, edit, or delete juice records.
   - Shows the availability status of each juice, including options to categorize as Fruit, Vegetable, or Mixed.

3. **Juice Management (CRUD Operations)**  
   - **Create**: Add new juices with details like name, description, ingredients, category, availability, and price.
   - **Read**: View a comprehensive list of juices in a card format with all relevant information.
   - **Update**: Modify juice details, such as availability, price, and category.
   - **Delete**: Remove juices that are no longer available.

4. **Category Management**  
   - Add, edit, and delete categories (e.g., Fruit, Vegetable, Mixed) for better inventory organization.

5. **Sales and Stock Tracking**  
   - Filter juices by category and check availability.
   - Track trends in juice availability and identify popular categories.

## Technologies Used
- **Framework**: ASP.NET Web Forms (.NET Framework)
- **Database**: MySQL
- **Languages**: C#, HTML, CSS, JavaScript
- **Other Tools**: ADO.NET for database connectivity

## Installation

1. **Clone the Repository**
   ```bash
   git clone https://github.com/your-username/juice-oasis-management-system.git
   cd juice-oasis-management-system
