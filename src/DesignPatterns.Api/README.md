# DesignPatterns.Api

An ASP.NET Core API designed for studying design patterns with a focus on evolutionary, maintainable architecture.

## Implemented Patterns

### 1. Abstract Factory

Creates families of related objects without specifying their concrete classes.

**Endpoints:**
- `GET /api/patterns/abstract-factory/styles` - Get available furniture styles
- `GET /api/patterns/abstract-factory/furniture-set?style=Modern` - Get furniture set for specific style

**Use Case:** Furniture store simulator - Modern, Victorian, ArtDeco styles with compatible products.

### 2. Factory Method

Provides an interface for creating objects in a superclass while allowing subclasses to alter the type.

**Endpoints:**
- `GET /api/patterns/factory-method/transport-types` - Get available transport types
- `GET /api/patterns/factory-method/plan-delivery?cargo=Electronics&destination=Berlin&transportType=Road` - Plan a delivery
- `GET /api/patterns/factory-method/compare-routes?cargo=Furniture&destination=Shanghai` - Compare all delivery routes

**Use Case:** Logistics system - Road, Sea, Air, and Rail transport options.

## Architectural Philosophy

The solution is designed to grow with new patterns by separating concerns:

- **Domain/**: Abstractions and business contracts per pattern
- **Infrastructure/**: Concrete implementations, factories, and resolvers
- **Application/**: Use cases and orchestration services
- **Controllers/**: HTTP API layer
- **Extensions/**: Dependency injection composition

Each pattern is **self-contained** and doesn't require changes to existing patterns.

## Next Patterns (Planned)

- **Builder** - Complex object construction
- **Singleton** - Single instance management
- **Decorator** - Dynamic behavior composition
- **Strategy** - Algorithm selection at runtime
- **Observer** - Event notification system
- **Command** - Encapsulate requests as objects

## Building and Running

```bash
dotnet build
dotnet run --project src/DesignPatterns.Api
```

The API will be available at `http://localhost:5000` with Swagger documentation at `/swagger`.

