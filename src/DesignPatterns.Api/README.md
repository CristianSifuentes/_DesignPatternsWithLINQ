# DesignPatterns.Api

An ASP.NET Core API prepared for studying design patterns in depth.

## First implemented pattern: Abstract Factory

- Available styles endpoint: `GET /api/patterns/abstract-factory/styles`
- Demo endpoint: `GET /api/patterns/abstract-factory/furniture-set?style=Modern`

### Architectural goal

The solution is designed to grow with new patterns by separating:

- `Domain/`: abstractions and business contracts per pattern.
- `Infrastructure/`: concrete implementations.
- `Application/`: use cases/orchestration.
- `Controllers/`: HTTP layer.
- `Extensions/`: composition and DI.

## Suggested next patterns

- Factory Method
- Builder
- Prototype
- Strategy
- Observer
- Command

