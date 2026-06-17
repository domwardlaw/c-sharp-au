# C# Australia - Enterprise Software Development

A complete ASP.NET Core 10 + React.js web application for C# Australia, a leading enterprise software development and consulting company.

## Project Structure

```
├── src/
│   ├── CSharpAu.Api/           # ASP.NET Core 10 Web API
│   │   ├── Controllers/        # API endpoints
│   │   ├── Models/            # Data models
│   │   ├── Services/          # Business logic
│   │   ├── Data/              # Database context
│   │   └── Validators/        # FluentValidation
│   └── CSharpAu.Web/          # React.js frontend
│       ├── src/
│       │   ├── pages/         # React pages
│       │   ├── components/    # React components
│       │   └── services/      # API client
│       └── public/            # Static assets
├── tests/
│   └── CSharpAu.Tests/        # Unit tests
├── docker-compose.yml         # Docker Compose configuration
└── Dockerfile                 # API Docker image
```

## Features

### Backend (ASP.NET Core 10)
- RESTful API with full CRUD operations
- Entity Framework Core with SQL Server
- MailKit email integration
- FluentValidation for input validation
- Swagger/OpenAPI documentation
- Structured logging
- Dependency injection

### Frontend (React.js)
- Modern React with Vite
- Tailwind CSS for responsive design
- Component-based architecture
- API client service
- Contact form with validation

### Database
- SQL Server 2022
- Entity Framework Core migrations
- Seed data for clients, services, and employees

### Infrastructure
- Docker & Docker Compose
- Multi-container orchestration
- SQL Server + ASP.NET Core API + React frontend

## Getting Started

### Prerequisites
- Docker and Docker Compose
- .NET 10 SDK (for local development)
- Node.js 18+ (for React development)

### Quick Start with Docker

```bash
docker-compose up -d
```

API: http://localhost:5000
Frontend: http://localhost:5173

### Local Development

**Backend:**
```bash
cd src/CSharpAu.Api
dotnet restore
dotnet ef database update
dotnet run
```

**Frontend:**
```bash
cd src/CSharpAu.Web
npm install
npm run dev
```

## API Endpoints

- `GET /api/health` - Health check
- `POST /api/contacts` - Create contact
- `GET /api/contacts` - Get all contacts
- `GET /api/services` - Get all services
- `GET /api/clients` - Get all clients
- `GET /api/employees` - Get all employees

## License
Copyright © 2024 C# Australia. All rights reserved.