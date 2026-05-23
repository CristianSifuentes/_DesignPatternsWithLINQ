# DesignPatterns.Api

API en ASP.NET Core preparada para estudiar patrones de diseño en profundidad.

## Primer patrón implementado: Abstract Factory

- Endpoint de estilos disponibles: `GET /api/patterns/abstract-factory/styles`
- Endpoint de demostración: `GET /api/patterns/abstract-factory/furniture-set?style=Modern`

### Objetivo de arquitectura

La solución está preparada para crecer con nuevos patrones separando:

- `Domain/`: abstracciones y contratos de negocio por patrón.
- `Infrastructure/`: implementaciones concretas.
- `Application/`: casos de uso/orquestación.
- `Controllers/`: capa HTTP.
- `Extensions/`: composición y DI.

## Próximos patrones sugeridos

- Factory Method
- Builder
- Prototype
- Strategy
- Observer
- Command

