# 🏆 EF Core Survivor

EF Core Survivor is a .NET 8 Web API project that demonstrates the use of Entity Framework Core for managing competitors and categories in a database.

## ✨ Features

- 📋 List all competitors
- 🔍 List a competitor by ID
- 📂 List competitors by category
- ➕ Add a new competitor
- ✏️ Update an existing competitor
- 🗑️ Soft delete a competitor
- 📋 List all categories
- 🔍 List a category by ID
- ➕ Add a new category
- ✏️ Update an existing category
- 🗑️ Soft delete a category

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

    ```bash
    git clone https://github.com/your-username/ef-core-survivor.git
    cd ef-core-survivor
    ```

2. Update the connection string in `appsettings.json` to match your SQL Server configuration:

    ```json
    "ConnectionStrings": {
      "DefaultConnection": "server=YOUR_SERVER; database=SurvivorDb; Trusted_Connection = true; TrustServerCertificate = true"
    }
    ```

3. Apply the database migrations:

    ```bash
    dotnet ef database update
    ```

4. Run the application:

    ```bash
    dotnet run
    ```

## 📚 API Endpoints

### Competitors

- `GET /api/competitors` - List all competitors
- `GET /api/competitors/{id}` - List a competitor by ID
- `GET /api/competitors/category/{categoryId}` - List competitors by category
- `POST /api/competitors` - Add a new competitor
- `PUT /api/competitors/{id}` - Update an existing competitor
- `DELETE /api/competitors/{id}` - Soft delete a competitor

### Categories

- `GET /api/categories` - List all categories
- `GET /api/categories/{id}` - List a category by ID
- `POST /api/categories` - Add a new category
- `PUT /api/categories/{id}` - Update an existing category
- `DELETE /api/categories/{id}` - Soft delete a category

## 🤝 Contributing

Contributions are welcome! Please open an issue or submit a pull request.

## 📄 License

This project is licensed under the MIT License.
