# StoreAPI
Simple ASP.NET Core Web API with CRUD operations for Products.
Tech: C#, .NET 8, EF Core, SQLite, DTOs, Swagger

Features:
Create, Read, Update, Delete Products
Request/Response DTOs
Database persistence with EF Core
API testing with Swagger

Getting Started:
git clone <repo-url>
dotnet restore
dotnet ef migrations add InitialCreate
dotnet ef database update
dotnet run

Open https://localhost:<port>/swagger to test endpoints
