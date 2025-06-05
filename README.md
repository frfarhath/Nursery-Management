
# User Management App

## 📘 Description
This is a simple User Management application built with ASP.NET Core MVC. It allows managing users with roles such as Admin, Principal, Teacher, Assistant Teacher, and User.

## ✨ Features
- Add, edit, view, and delete users
- Dropdown role selection
- Server-side form validation
- UI success notifications with auto-dismiss

## ✅ Prerequisites
- [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)
- Microsoft SQL Server 2022 Developer Edition
- Visual Studio Code (or Visual Studio)

## 🚀 Setup and Installation

1. **Clone the repository**:
   ```bash
   git clone https://github.com/frfarhath/Nursery-Management.git


2. **Update database connection string** in `appsettings.json` to match your SQL Server setup:

   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=localhost\\MSSQLSERVER01;Database=master;Trusted_Connection=True;TrustServerCertificate=True;"
   }


3. **Run the database SQL script** to create and seed the `Users` table:

   * Open SQL Server Management Studio or use `sqlcmd`
   * Run the script located at:

     ```
     sql/master.sql


4. **Run the application**:

   ```bash
   dotnet build
   dotnet run


5. Open your browser and navigate to:

   ```
   https://localhost:5001/


## 🗂️ Project Structure


UserManagementApp/
├── Controllers/
├── Models/
├── Views/
├── sql/
│   └── master.sql        <-- 📄 SQL script to create and seed Users table
├── wwwroot/
├── appsettings.json
└── README.md


## 📝 Notes

* The `master.sql` file creates the `Users` table and inserts sample data.
* Success messages appear on the UI and disappear automatically after 3 second or can be manually dismissed.

