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
![Employee Directory Index](docs/screenshots/directory_index.png)

### Create Employee Page
![Create Employee Screen](docs/screenshots/create_employee.png)

### Edit Employee Page
![Edit Employee Screen](docs/screenshots/edit_employee.png)

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
