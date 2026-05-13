# Clean Architecture Template (.NET)

A professional, production-ready template for .NET applications using **Clean Architecture** (Onion Architecture). Designed to help you start new projects quickly with clean, maintainable, and scalable code.

---

## ✨ Features

- **Clean Architecture** with clear layer separation
- CQRS pattern with **MediatR**
- Domain-Driven Design principles
- Repository Pattern with EF Core
- FluentValidation for request validation
- AutoMapper for object mapping
- Global exception handling
- Centralized logging
- Highly testable and extensible
- Ready for future microservices or multi-tenant architecture
- JWT Authentication

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
│   ├── DTOs/
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
│   └── Primitives/
│
└── Architecture.Infrastructure/               # Infrastructure Layer
    ├── Persistence/
    │   ├── Migrations/
    │   ├── DataSeeder/
    │   ├── Repository/
    │   └── AppDbContext.cs
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

