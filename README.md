# 🏆 EF Core Survivor

EF Core Survivor is a .NET 8 Web API project that demonstrates the use of Entity Framework Core for managing competitors and categories in a database.

## ✨ Features

- 📋 List all competitors
- 🔍 List a competitor by ID
- 📂 List competitors by category
- ➕ Add a new competitor
- ✏️ Update an existing competitor
- 🗑️ Soft delete a competitor

## 🛠️ Technologies Used

- .NET 8
- Entity Framework Core
- ASP.NET Core Web API
- SQL Server

## 🚀 Getting Started

### 📋 Prerequisites

- .NET 8 SDK
- SQL Server

### 🛠️ Installation

1. Clone the repository:
    git clone https://github.com/your-username/ef-core-survivor.git
cd ef-core-survivor


2. Update the connection string in `appsettings.json` to match your SQL Server configuration:
    "ConnectionStrings": {
    "DefaultConnection": "server=YOUR_SERVER; database=SurvivorDb; Trusted_Connection = true; TrustServerCertificate = true"
}


3. Apply the database migrations:

    dotnet ef database update

   
4. Run the application:
    dotnet run

   
## 📚 API Endpoints

- `GET /api/competitors` - List all competitors
- `GET /api/competitors/{id}` - List a competitor by ID
- `GET /api/competitors/category/{categoryId}` - List competitors by category
- `POST /api/competitors` - Add a new competitor
- `PUT /api/competitors/{id}` - Update an existing competitor
- `DELETE /api/competitors/{id}` - Soft delete a competitor

## 📄 License

This project is licensed under the MIT License.
