# Design Patterns With LINQ - Playground

A comprehensive exploration of Gang of Four design patterns implemented in .NET with practical, hands-on examples and a focus on real-world applications.

---

## Table of Contents

### Creational Patterns

1. **[Abstract Factory](#abstract-factory)** ✅ Implemented
   - Create families of related objects without specifying concrete classes
2. **[Factory Method](#factory-method)** ✅ Implemented
   - Define an interface for creating objects, letting subclasses decide the type
3. **Builder** ⏳ Planned
4. **Prototype** ⏳ Planned
5. **Singleton** ⏳ Planned

### Structural Patterns

- **Adapter** ⏳ Planned
- **Bridge** ⏳ Planned
- **Composite** ⏳ Planned
- **Decorator** ⏳ Planned
- **Facade** ⏳ Planned
- **Flyweight** ⏳ Planned
- **Proxy** ⏳ Planned

### Behavioral Patterns

- **Chain of Responsibility** ⏳ Planned
- **Command** ⏳ Planned
- **Iterator** ⏳ Planned
- **Mediator** ⏳ Planned
- **Memento** ⏳ Planned
- **Observer** ⏳ Planned
- **State** ⏳ Planned
- **Strategy** ⏳ Planned
- **Template Method** ⏳ Planned
- **Visitor** ⏳ Planned
- **Interpreter** ⏳ Planned

---

## Abstract Factory

### Overview

**Type:** Creational Pattern  
**Also Known As:** Kit  
**Difficulty Level:** ⭐⭐⭐ (Intermediate)

### Definition

Abstract Factory is a creational design pattern that allows you to produce **families of related objects without specifying their concrete classes**.

### What It Allows You to Do

✅ **Create families of compatible objects** - Ensures that related products (e.g., Chair + Sofa + CoffeeTable) work together seamlessly across different style variants (Modern, Victorian, ArtDeco).

✅ **Decouple client code from concrete implementations** - Clients work with abstract interfaces, not concrete classes, making the code flexible and maintainable.

✅ **Easily extend with new product variants** - Add new furniture styles or UI themes without modifying existing client code.

✅ **Guarantee consistency** - Products created by a single factory are guaranteed to be compatible with each other.

✅ **Encapsulate object creation logic** - Keep creation logic separate from usage, improving code organization and maintainability.

### Problems It Solves

❌ **Mixing incompatible styles** - Without Abstract Factory, you might accidentally create a Modern sofa with Victorian chairs, creating visual inconsistency.

❌ **Tight coupling to concrete classes** - Client code directly instantiating concrete products makes it hard to swap implementations or add new variants.

❌ **Scattered creation logic** - Product instantiation scattered throughout the codebase is difficult to maintain and extend.

❌ **Violating Open/Closed Principle** - Adding new product families often requires modifying existing client code.

### When to Use

Consider implementing Abstract Factory when:

- Your code needs to work with **multiple families of related products**
- You want to **avoid dependencies on concrete product classes**
- You need to **provide a library of products** that only reveals interfaces, not implementations
- You want to **ensure product family consistency** (all products from the same variant are compatible)
- You're building a system that should be **easily extended with new product families**
- You have methods in a class that are becoming **a factory method god object** with too many creation responsibilities

### Real-World Examples

- **UI Frameworks:** Different themes (Light/Dark) with compatible buttons, checkboxes, windows
- **Database Access:** Support multiple databases (SQL Server, PostgreSQL, MySQL) with compatible connection and query objects
- **Document Viewers:** Support different document formats (PDF, Word, Excel) with compatible renderers and exporters
- **Furniture Store Simulator:** Create furniture sets (chairs, sofas, tables) in different styles (Modern, Victorian, ArtDeco)

### Key Components

**1. Abstract Factory** (`IFurnitureFactory`)
   - Declares methods to create abstract products
   - Each method returns an abstract product type

**2. Concrete Factories** (`ModernFurnitureFactory`, `VictorianFurnitureFactory`, `ArtDecoFurnitureFactory`)
   - Implement methods to create specific product variants
   - Each factory produces a complete family of compatible products

**3. Abstract Products** (`IChair`, `ISofa`, `ICoffeeTable`)
   - Declare interfaces for products in the family
   - All variants must implement these interfaces

**4. Concrete Products**
   - Specific implementations of each product for each variant
   - Ensure compatibility within their variant family

**5. Client Code** (`FurnitureFactoryResolver`)
   - Works only with abstract types
   - Receives the factory and uses it to create products
   - Doesn't depend on concrete product classes

### Important Data to Consider

| Aspect | Consideration |
|--------|---------------|
| **Complexity** | Introduces many new interfaces and classes; suitable for complex systems with multiple product families |
| **Scalability** | Excellent for adding new variants; poor for adding new product types (requires interface changes) |
| **Coupling** | Reduces coupling between client and concrete products |
| **Testability** | Highly testable; easy to mock factories and products |
| **Performance** | Negligible overhead; one extra layer of indirection |
| **Learning Curve** | Moderate; requires understanding relationships between factories and products |
| **When NOT to use** | Single product family, simple applications, static product catalog |

### Pros and Cons

**Advantages:**
- ✅ Products from a factory are always compatible
- ✅ Loose coupling between client and concrete product classes
- ✅ Single Responsibility Principle - creation logic is centralized
- ✅ Open/Closed Principle - new variants can be added without modifying client code
- ✅ Reduces code duplication in client code

**Disadvantages:**
- ❌ Code complexity increases with many interfaces and classes
- ❌ Adding new product types requires changing the abstract factory interface
- ❌ May be overkill for simple systems with few product variants
- ❌ Additional layers of abstraction can make code harder to follow for beginners

### Pattern Relationships

- **Compared to Factory Method:** Abstract Factory is more complex but handles families of objects; Factory Method is simpler for single object creation
- **Combined with Builder:** Use when products are complex and require step-by-step construction
- **Combined with Prototype:** Can use Prototype instead of factory methods for instantiation
- **Alternative to Facade:** When you want to hide complex object creation from clients
- **Works well with Bridge:** For handling abstract hierarchies and concrete implementations separately

---

## Project Status

✅ Initial `ASP.NET Core Web API` project prepared  
✅ **Abstract Factory pattern fully implemented** (furniture family by style)  
✅ **Factory Method pattern fully implemented** (logistics/transport system)  
✅ Scalable, extensible structure for adding new patterns  
✅ Comprehensive routing and service resolution  
✅ Evolutionary architecture - new patterns don't break existing code  

---

## Architecture

```
src/DesignPatterns.Api/
├── Controllers/              # API endpoints for pattern demonstrations
├── Application/              # Services that showcase each pattern
├── Domain/                   # Core abstractions and product definitions
│   ├── AbstractFactory/      # Abstract Factory pattern
│   └── FactoryMethod/        # Factory Method pattern
├── Infrastructure/           # Concrete implementations and resolvers
│   ├── Factories/            # Factory implementations (Abstract Factory)
│   └── Creators/             # Creator implementations (Factory Method)
├── Extensions/               # Dependency injection setup
└── Contracts/                # Request/Response models
```

### Current Structure

```
src/DesignPatterns.Api/
├── Domain/
│   ├── AbstractFactory/Furniture/
│   │   ├── IChair.cs
│   │   ├── ISofa.cs
│   │   ├── ICoffeeTable.cs
│   │   ├── IFurnitureFactory.cs
│   │   └── FurnitureSet.cs
│   └── FactoryMethod/
│       ├── ITransport.cs
│       ├── Logistics.cs (base creator class)
│       ├── ConcreteTransports.cs (Truck, Ship, Airplane, Train)
│       └── ConcreteLogistics.cs (RoadLogistics, SeaLogistics, AirLogistics, RailLogistics)
├── Infrastructure/
│   ├── Factories/
│   │   ├── ModernFurnitureFactory.cs
│   │   ├── VictorianFurnitureFactory.cs
│   │   ├── ArtDecoFurnitureFactory.cs
│   │   └── FurnitureFactoryResolver.cs
│   └── Creators/
│       └── ILogisticsResolver.cs (LogisticsResolver implementation)
├── Application/
│   ├── AbstractFactoryShowcaseService.cs
│   └── FactoryMethodShowcaseService.cs
└── Controllers/
    └── PatternsController.cs
```

---

## How to Run (Local)

### Prerequisites
- .NET 8.0 SDK or later
- Windows/macOS/Linux with PowerShell or Bash

### Build and Run

```bash
# Restore dependencies
dotnet restore

# Build the solution
dotnet build

# Run the API
dotnet run --project src/DesignPatterns.Api
```

The API will be available at `http://localhost:5000` (or the port shown in console)

---

## API Endpoints

### Abstract Factory Pattern

**Get available furniture styles:**
```
GET /api/patterns/abstract-factory/styles
```

**Get furniture set for a specific style:**
```
GET /api/patterns/abstract-factory/furniture-set?style=Modern
```

**Query Parameters:**
- `style` (string): One of `Modern`, `Victorian`, `ArtDeco`

**Example Response:**
```json
{
  "style": "Modern",
  "chair": {
    "name": "Modern Chair",
    "material": "Leather",
    "legs": 4
  },
  "sofa": {
    "name": "Modern Sofa",
    "seats": 3
  },
  "coffeeTable": {
    "name": "Modern Coffee Table",
    "shape": "Rectangular"
  }
}
```

### Factory Method Pattern

**Get available transport types:**
```
GET /api/patterns/factory-method/transport-types
```

**Plan a delivery:**
```
GET /api/patterns/factory-method/plan-delivery?cargo=Electronics&destination=Berlin&transportType=Road
```

**Query Parameters:**
- `cargo` (string): Description of the cargo to deliver
- `destination` (string): Delivery destination
- `transportType` (string): One of `Road`, `Sea`, `Air`, or `Rail`

**Example Response:**
```json
{
  "cargo": "Electronics",
  "destination": "Berlin",
  "transportType": "Road",
  "result": "[RoadLogistics] Using Truck: Delivering 'Electronics' to Berlin by truck on highways. Road transport: ±5 days."
}
```

**Compare delivery routes:**
```
GET /api/patterns/factory-method/compare-routes?cargo=Furniture&destination=Shanghai
```

**Query Parameters:**
- `cargo` (string): Description of the cargo
- `destination` (string): Delivery destination

**Example Response:**
```json
{
  "cargo": "Furniture",
  "destination": "Shanghai",
  "availableRoutes": [
    "[RoadLogistics] Using Truck: Delivering 'Furniture' to Shanghai by truck on highways. Road transport: ±5 days.",
    "[SeaLogistics] Using Ship: Delivering 'Furniture' to Shanghai by ship across the seas. Sea transport: ±30 days.",
    "[AirLogistics] Using Airplane: Delivering 'Furniture' to Shanghai by airplane. Air transport: ±2 days (express).",
    "[RailLogistics] Using Train: Delivering 'Furniture' to Shanghai by train on rails. Rail transport: ±10 days (bulk friendly)."
  ]
}
```

---

## Factory Method

### Overview

**Type:** Creational Pattern  
**Also Known As:** Virtual Constructor  
**Difficulty Level:** ⭐⭐ (Beginner-Intermediate)

### Definition

Factory Method is a creational design pattern that provides an interface for creating objects in a superclass, while allowing subclasses to alter the type of objects that will be created.

### What It Allows You to Do

✅ **Decouple object creation from usage** - Client code doesn't know about concrete product classes; it works through abstract interfaces.

✅ **Enable easy extension with new product types** - Add new creators without modifying existing client code.

✅ **Centralize object creation logic** - All product instantiation happens in dedicated factory methods, making it easier to maintain.

✅ **Support runtime product selection** - Choose which product to create at runtime based on configuration or conditions.

✅ **Implement object pooling and reuse** - Factory methods can return cached or reused objects instead of always creating new ones.

### Problems It Solves

❌ **Tight coupling between client and product classes** - Direct instantiation scattered throughout code makes changes difficult.

❌ **Difficulty adding new product types** - Conditional logic (switch/if-else) becomes scattered and hard to maintain.

❌ **Violating Single Responsibility Principle** - Classes end up creating multiple types of objects alongside their main logic.

❌ **Hard to test** - Direct object instantiation makes unit testing difficult without mocking frameworks.

❌ **Framework/Library extensibility** - Libraries can't easily let users extend them with custom product types.

### When to Use

Consider implementing Factory Method when:

- Your code needs to **work with objects whose types aren't known until runtime**
- You want to **provide an extension point for users** of your library or framework
- You need to **centralize object creation** to manage initialization complexity
- You're **building a plugin system** or extensible architecture
- You want to **implement object pooling** or lazy instantiation
- You have **multiple related product types** that should be handled polymorphically

### Real-World Examples

- **UI Frameworks:** Creating buttons, dialogs, or controls for different OS platforms
- **Logistics Systems:** Creating different transport types (truck, ship, airplane, train)
- **Database Drivers:** Creating connections for different database engines (SQL Server, PostgreSQL, MySQL)
- **Document Processing:** Creating renderers for different document formats (PDF, Word, Excel)
- **Logging Frameworks:** Creating appropriate loggers based on configuration (file, console, cloud)
- **Game Development:** Creating different enemy types based on game level or difficulty

### Key Components

**1. Creator (Abstract)** (`Logistics`)
   - Declares the factory method
   - Contains business logic that depends on products
   - Works with products through abstract interface

**2. Concrete Creators** (`RoadLogistics`, `SeaLogistics`, `AirLogistics`, `RailLogistics`)
   - Override the factory method
   - Each produces a specific product type
   - Can add creator-specific logic

**3. Product (Abstract)** (`ITransport`)
   - Defines the interface all products must implement
   - Ensures type safety and consistency

**4. Concrete Products** (`Truck`, `Ship`, `Airplane`, `Train`)
   - Implement the product interface
   - Encapsulate their specific behavior

**5. Resolver** (`LogisticsResolver`)
   - Maps product types to creator implementations
   - Encapsulates the selection logic

### Important Data to Consider

| Aspect | Consideration |
|--------|---------------|
| **Complexity** | Simpler than Abstract Factory; easier to implement and understand |
| **Scalability** | Excellent for linear product variations; doesn't handle product families well |
| **Coupling** | Reduces client-product coupling; minimal framework overhead |
| **Testability** | Highly testable; easy to mock creators and products |
| **Performance** | Negligible overhead; single layer of indirection |
| **Learning Curve** | Low; most developers understand inheritance-based polymorphism |
| **Best For** | Single product lines with multiple variants or implementations |

### Pros and Cons

**Advantages:**
- ✅ Loose coupling between client and product classes
- ✅ Single Responsibility Principle - creation logic in one place
- ✅ Open/Closed Principle - new product types can be added easily
- ✅ Simpler than Abstract Factory for handling single product types
- ✅ Easier to implement object pooling and caching
- ✅ Good for building extensible frameworks

**Disadvantages:**
- ❌ Code complexity increases with many creator subclasses
- ❌ Each product type requires a new creator subclass
- ❌ Not suitable for families of related products (use Abstract Factory instead)
- ❌ Inheritance-based, so not as flexible as composition-based approaches

### Pattern Relationships

- **Compared to Abstract Factory:** Factory Method is simpler for single products; Abstract Factory handles product families
- **Compared to Singleton:** Factory Method can work with Singleton to ensure only one instance exists
- **With Template Method:** Factory Method is often a step in a Template Method algorithm
- **With Strategy:** Similar structure but different intent - Strategy for behavior, Factory Method for object creation
- **With Builder:** Combine when products are complex; use Builder for construction steps within factory

### Comparison with Abstract Factory

| Aspect | Factory Method | Abstract Factory |
|--------|---|---|
| **Products** | Single product line | Family of related products |
| **Variants** | Multiple implementations | Multiple related implementations |
| **Inheritance** | Based on inheritance | Based on composition |
| **Complexity** | Simple | More complex |
| **Use Case** | When you have one product type with multiple implementations | When you have families of related products |
| **Example** | Transport types (truck, ship, airplane) | Furniture styles (Modern, Victorian, ArtDeco) |

---

## Future Implementation Plan

### Next Patterns (Priority Order)

1. **Builder** - Handle complex object construction step-by-step
2. **Singleton** - Ensure single instances for shared resources
3. **Decorator** - Add behavior to objects dynamically
4. **Strategy** - Define interchangeable algorithms
5. **Observer** - Implement event notification systems

Each new pattern will:
- Follow the same structured approach as Abstract Factory and Factory Method
- Include comprehensive documentation
- Provide practical API endpoints
- Include conceptual and real-world examples
- Not require changes to existing client code (evolutionary approach)

---

## Contributing

When adding new patterns:

1. Create domain abstractions in `Domain/[PatternName]/`
2. Implement concrete classes in `Infrastructure/`
3. Create service/application layer in `Application/`
4. Add controller endpoints in `Controllers/`
5. Update this README with pattern documentation
6. Keep changes isolated - don't modify existing patterns

---

## License

See [LICENSE](LICENSE) file for details.

---

## Resources

- [Refactoring Guru - Design Patterns](https://refactoring.guru/design-patterns)
- [Microsoft - Design Patterns](https://docs.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/architectural-principles#design-patterns)
- [Gang of Four - Design Patterns Book](https://en.wikipedia.org/wiki/Design_Patterns)

---

**Last Updated:** 2026  
**Maintainer:** Design Patterns Lab Team

