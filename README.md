# Employee Management Mini System

A web-based Employee Management directory built using ASP.NET Core MVC, Entity Framework Core, and SQL Server.

## Description of Solution
This project implements a lightweight directory system to create, read, update, and delete (CRUD) employees and manage their departments.

### Key Features
* **Dynamic Search and Filtering**: Live, AJAX-based search updates the directory list dynamically as you type (debounced) or change the department dropdown, preventing full-page reloads.
* **Pagination**: Dynamic pagination works seamlessly with the AJAX search filters to navigate through the directory entries.
* **Department Integration**: Creation and Edit forms dynamically retrieve department options from the database context.
* **Modern UI Layout**: Designed using Bootstrap 5 with responsive grid layouts, status badges, and dynamic forms.

---

## Screenshots of the Application

*(Add screenshots of your application in this section)*

### Employee Directory (Index Page)
<img width="1888" height="903" alt="Screenshot 2026-06-13 182630" src="https://github.com/user-attachments/assets/7f42d605-b1ed-4f6d-952f-ea8d84917e25" />

### Search Employees by name or department
<img width="1912" height="396" alt="Screenshot 2026-06-13 182644" src="https://github.com/user-attachments/assets/0dfbe11f-b586-43cc-b128-314ee2bf8f48" />

### Create Employee Page
<img width="1918" height="739" alt="Screenshot 2026-06-13 182654" src="https://github.com/user-attachments/assets/48429170-1404-4b7b-9c48-c3e464a7721a" />

### Edit Employee Page
<img width="1917" height="758" alt="Screenshot 2026-06-13 182703" src="https://github.com/user-attachments/assets/5e05e0d8-bbed-474e-be34-59bf17c4e87c" />

### Delete Employee Page
<img width="1919" height="753" alt="Screenshot 2026-06-13 182719" src="https://github.com/user-attachments/assets/8e714daa-1d5e-46d5-98cd-aa504fbdff6b" />

---

## How to Run the Project

### Prerequisites
* .NET 8.0 SDK or later
* SQL Server or LocalDB instance installed locally

### Step-by-Step Instructions

1. **Clone or Download the Repository**
   Download the source files into a local folder.

2. **Navigate to the Project Directory**
   Open your terminal/command prompt and change directory to the project source folder:
   ```bash
   cd "src/Employee Management Mini System"
   ```

3. **Configure the Database Connection**
   Open the `appsettings.json` file and verify or modify the `DefaultConnection` connection string to point to your local SQL Server instance:
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Data Source=.;Initial Catalog=Employee_Management_System;Integrated Security=True;Encrypt=True;Trust Server Certificate=True;"
   }
   ```

4. **Apply Entity Framework Migrations**
   Update your database schema to the latest migration to automatically create the database and tables:
   ```bash
   dotnet ef database update
   ```
   *Note: If `dotnet-ef` tool is not installed, install it globally using: `dotnet tool install --global dotnet-ef`*

5. **Build and Run the Application**
   Compile and run the ASP.NET Core web server:
   ```bash
   dotnet run
   ```

6. **Access the Application**
   Open your browser and navigate to the local hosting URL (typically `http://localhost:5000` or the HTTPS equivalent printed in the console output).

---

## Important Running Notes

* **Local SQL Server Connection**: The connection string assumes Windows Integrated Security (`Integrated Security=True`) and that your default SQL Server instance is running. Ensure SQL Server services are started before launching the project.
* **Trust Server Certificate**: The default configuration includes `Trust Server Certificate=True`. If your SQL Server connection requires SSL verification, adjust the parameter accordingly in `appsettings.json`.
* **Static Assets**: The project utilizes Bootstrap Icons hosted via CDN and jQuery, which require an active internet connection for styling icons and executing AJAX queries on client-side search.
