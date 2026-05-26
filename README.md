# Design Patterns With LINQ - Playground

Base repository to build a design patterns lab in .NET with a practical, hands-on approach.

## Current status

✅ Initial `ASP.NET Core Web API` project prepared.
✅ First implemented pattern: **Abstract Factory** (family of furniture by style).
✅ Scalable structure to add more patterns without breaking client code.

## Structure

- `DesignPatternsWithLinq.sln`
- `src/DesignPatterns.Api`
  - `Controllers`
  - `Application`
  - `Domain`
  - `Infrastructure`
  - `Extensions`

## How to run (local)

```bash
dotnet restore
dotnet build
dotnet run --project src/DesignPatterns.Api
```

## Initial endpoints

- `GET /api/patterns/abstract-factory/styles`
- `GET /api/patterns/abstract-factory/furniture-set?style=Modern`

