# 🍹 Juice Oasis

Juice Oasis is a comprehensive web application developed with ASP.NET Web Forms (.NET Framework) and MySQL. The system provides administrators with powerful tools to efficiently manage juice inventory, categorize items, and track sales through a user-friendly interface with complete CRUD functionality.

## ✨ Features

### 🔐 User Authentication
- Secure admin login and registration system
- Role-based access control ensuring only authenticated administrators can access the dashboard
- Password encryption and security protocols for data protection

### 📊 Dashboard
- Comprehensive overview of juice inventory with real-time status updates
- Intuitive interface for quick access to management functions
- Visual indicators for juice availability and category distribution
- Summary statistics for inventory analysis

### 🥤 Juice Management (CRUD Operations)
- **Create**: Add new juices with detailed information including:
  - Name and description
  - Ingredient composition
  - Category classification
  - Availability status
  - Pricing information
  
- **Read**: Browse inventory through an aesthetically pleasing card layout featuring:
  - Visual representations of each juice
  - Complete product specifications
  - Category and availability indicators
  
- **Update**: Easily modify juice details with features for:
  - Adjusting pricing based on market conditions
  - Updating availability status
  - Reclassifying category assignments
  - Revising descriptions and ingredients
  
- **Delete**: Remove discontinued items with:
  - Confirmation dialogs to prevent accidental deletion
  - Optional archiving for maintaining historical data

### 🏷️ Category Management
- Flexible system for creating, editing, and removing juice categories
- Custom categorization options beyond the default Fruit, Vegetable, and Mixed types
- Category-specific attributes and reporting capabilities

### 📈 Sales and Stock Tracking
- Advanced filtering mechanisms for inventory analysis by category
- Real-time availability monitoring
- Trend analysis for identifying popular juice varieties
- Stock level alerts and notifications

## 🛠️ Technologies Used

- **Framework**: ASP.NET Web Forms (.NET Framework 4.7.2)
- **Database**: MySQL 8.0
- **Languages**:
  - C# for backend logic
  - HTML5 for structure
  - CSS3 for styling
  - JavaScript for client-side functionality
- **Database Connectivity**: ADO.NET
- **UI Components**: Bootstrap 4.6
- **Version Control**: Git

## 🚀 Getting Started

### Prerequisites
- Visual Studio 2019 or newer
- .NET Framework 4.7.2 or higher
- MySQL Server 8.0 or higher
- MySQL Connector/NET

### Installation

1. Clone the repository
   ```
   git clone https://github.com/GarudaR007X/juice-oasis.git
   ```

2. Open the solution file (`JuiceOasis.sln`) in Visual Studio

3. Restore NuGet packages
   ```
   Right-click on the solution in Solution Explorer > Restore NuGet Packages
   ```

4. Update the database connection string in `Web.config`
   ```xml
   <connectionStrings>
     <add name="JuiceOasisConnection" 
          connectionString="Server=localhost;Database=juiceoasis;Uid=root;Pwd=yourpassword;" 
          providerName="MySql.Data.MySqlClient" />
   </connectionStrings>
   ```

5. Execute the SQL scripts in the `Database` folder to set up your database schema

6. Build and run the application
   ```
   Press F5 or click the Start button in Visual Studio
   ```

## 📋 Usage

### Administrator Access
1. Navigate to the login page
2. Enter your administrator credentials
3. Access the dashboard to manage juice inventory
4. Use the navigation menu to access different management features

### Managing Juice Inventory
1. Add new juices using the "Add Juice" form
2. View all juices on the main dashboard
3. Edit juice details by clicking the "Edit" button on a juice card
4. Remove juices by clicking the "Delete" button (with confirmation)

### Category Management
1. Access the "Categories" section from the navigation menu
2. Add new categories as needed
3. Edit or delete existing categories


## 👨‍💻 Contributing
Contributions to improve Juice Oasis are welcome. To contribute:

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add some amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request


*Juice Oasis - Refreshing Inventory Management for Your Beverage Business*
