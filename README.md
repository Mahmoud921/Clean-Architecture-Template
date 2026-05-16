# Clean Architecture Template (.NET)
![.NET](https://img.shields.io/badge/.NET-10.0-blue)
![Architecture](https://img.shields.io/badge/Architecture-Clean-green)
![CQRS](https://img.shields.io/badge/Pattern-CQRS-orange)
![License](https://img.shields.io/badge/License-MIT-purple)

A professional, production-ready template for .NET applications using **Clean Architecture** (Onion Architecture). Designed to help you start new projects quickly with clean, maintainable, and scalable code.


## 🎯 Why This Template?
This template provides a scalable and maintainable foundation for building modern .NET applications using Clean Architecture principles.

It helps developers:
- Separate concerns clearly
- Build highly testable systems
- Apply CQRS and SOLID principles
- Reduce boilerplate code
- Start production-ready projects quickly
---

## ✨ Features

- **Clean Architecture** with clear layer separation
- CQRS pattern with **MediatR**
- Domain-Driven Design principles
- Repository Pattern with EF Core
- Generic Repository
- FluentValidation for request validation
- Result Pattern
- Global API Response Wrapper
- Custom Exception Handling Middleware
- AutoMapper for object mapping
- Global exception handling
- Centralized logging
- Highly testable and extensible
- Ready for future microservices or multi-tenant architecture
- JWT Authentication
- Scalable Folder Structure
- Production-Ready API Setup
- Extensible & Highly Testable

---

## 📁 Project Structure

```bash
Architecture/
├── Architecture.sln
├── Architecture.API/                          # Presentation Layer
│   ├── Controllers/
│   ├── Middleware/
│   ├── Filters/
│   ├── Program.cs
│   └── appsettings.json
│
├── Architecture.Application/                  # Application Layer
│   ├── Common/
        ├── Response/
        ├── Results/
│   ├── DTOs/
    ├── Exceptions/
│   ├── Features/                              # Commands, Queries & Handlers
│   ├── Behaviors/                             # MediatR Pipeline Behaviors
│   ├── Mappings/                              # AutoMapper Profiles
│   └── Services/
│
├── Architecture.Domain/                       # Domain Layer (Core)
│   ├── Entities/
│   ├── ValueObjects/
│   ├── Enums/
│   ├── Errors/
│   ├── Events/
│   ├── Interfaces/
        ├── Repository/
        ├── IUnitOfWorks.cs
│   └── Primitives/
        ├── BaseEntity.cs
        ├── AuditableEntity.cs
│
└── Architecture.Infrastructure/               # Infrastructure Layer
    ├── Persistence/
    │   ├── Migrations/
    │   ├── DataSeeder/
    │   ├── Repository/
    │   ├── AppDbContext.cs
    |   ├── UnitOfWorks

    ├── Logging/

```

---
## 📌 Dependency Rules

- Domain layer has no dependencies
- Application depends only on Domain
- Infrastructure depends on Application
- API depends on Application & Infrastructure
---

## 🔄 Request Flow

1. Request enters API Controller
2. Sent to MediatR
3. Validation Pipeline executes
4. Handler processes request
5. Repository accesses database
6. Response returned to client
---
### Standard API Response 
```json
{
  "success": true,
  "message": "Success",
  "data": {},
  "statusCode": 200
}
```

## 🚀 Getting Started

### 1. Clone the Repository

```bash
git clone https://github.com/Mahmoud921/Architecture-Template.git YourProjectName
cd YourProjectName
```

### 2. Restore and Build the Solution

```bash
dotnet restore
dotnet build
```
### 3. Update the Database (Apply Migrations)
```bash
# Make sure you are in the root of the project
cd Architecture.Infrastructure

# Apply migrations to create/update the database
dotnet ef database update --startup-project ../Architecture.API
```
### 4. Run the Application
```bash
cd ../Architecture.API
dotnet run
```
## Contributing
Contributions, issues, and feature requests are welcome.
Feel free to fork the repository and submit pull requests.

