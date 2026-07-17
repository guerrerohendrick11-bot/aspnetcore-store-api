🛒 ASP.NET Core Store API

REST API for a simple store, built with ASP.NET Core following a layered architecture (Controllers, Services, Interfaces, DTOs) and Entity Framework Core for data access.

✨ Features

Layered architecture: clear separation between controllers, business logic, and data access
Authentication and authorization with JWT
Persistence with Entity Framework Core and SQL Server
DTOs to decouple domain models from API responses
RESTful endpoints for product/store management

🛠️ Technologies

C# / ASP.NET Core
Entity Framework Core
SQL Server
JWT (JSON Web Tokens)

📁 Project Structure

├── Controllers/ # API Endpoints
├── Services/ # Business Logic
├── Interfaces/ # Service Contracts
├── DTOs/ # Data Transfer Objects
├── Models/ # Domain Entities
└── Data/ # DbContext EF Core Setup

🚀 How to Run the Project

Clone the repository

bash git clone https://github.com/guerrerohendrick11-bot/aspnetcore-store-api.git

Configure the connection string in appsettings.json
Apply migrations

bash dotnet ef database update

Run the project

bash dotnet run

🔐 Authentication

The API uses JWT to secure endpoints. To consume protected resources:

Authorize at /api/auth/login
Copy the received token
Send it in the header: Authorization: Bearer {token}

📌 Main Endpoints

Method Path Description POST /api/auth/login Login GET /api/products List products POST /api/products Create product PUT /api/products/{id} Update product DELETE /api/products/{id} Delete product

Adjust this table according to the actual endpoints of your project.

📄 License

This project is free to use for learning purposes.
