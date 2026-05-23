# Design Patterns With LINQ - Playground

Repositorio base para construir un laboratorio de patrones de diseño en .NET con enfoque práctico.

## Estado actual

✅ Proyecto `ASP.NET Core Web API` inicial preparado.
✅ Primer patrón implementado: **Abstract Factory** (familia de muebles por estilo).
✅ Estructura escalable para agregar más patrones sin romper código cliente.

## Estructura

- `DesignPatternsWithLinq.sln`
- `src/DesignPatterns.Api`
  - `Controllers`
  - `Application`
  - `Domain`
  - `Infrastructure`
  - `Extensions`

## Cómo correr (local)

```bash
dotnet restore
dotnet build
dotnet run --project src/DesignPatterns.Api
```

## Endpoints iniciales

- `GET /api/patterns/abstract-factory/styles`
- `GET /api/patterns/abstract-factory/furniture-set?style=Modern`

