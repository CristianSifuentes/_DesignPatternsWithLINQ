using DesignPatterns.Api.Application;
using DesignPatterns.Api.Domain.AbstractFactory.Furniture;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Api.Controllers;

[ApiController]
[Route("api/patterns")]
public sealed class PatternsController(
    AbstractFactoryShowcaseService abstractFactoryService,
    FactoryMethodShowcaseService factoryMethodService) : ControllerBase
{
    #region Abstract Factory Endpoints

    [HttpGet("abstract-factory/styles")]
    public ActionResult<IReadOnlyCollection<string>> GetSupportedFurnitureStyles()
        => Ok(abstractFactoryService.GetSupportedStyles());

    [HttpGet("abstract-factory/furniture-set")]
    public ActionResult<FurnitureSet> BuildFurnitureSet([FromQuery] string? style)
    {
        try
        {
            return Ok(abstractFactoryService.CreateConfiguredSet(style));
        }
        catch (KeyNotFoundException ex)
        {
            return BadRequest(new { error = ex.Message });
        }
    }

    #endregion

    #region Factory Method Endpoints

    [HttpGet("factory-method/transport-types")]
    public ActionResult<IReadOnlyCollection<string>> GetAvailableTransportTypes()
        => Ok(factoryMethodService.GetAvailableTransportTypes());

    [HttpGet("factory-method/plan-delivery")]
    public ActionResult<object> PlanDelivery(
        [FromQuery] string cargo,
        [FromQuery] string destination,
        [FromQuery] string transportType)
    {
        try
        {
            var result = factoryMethodService.PlanDelivery(cargo, destination, transportType);
            return Ok(new { cargo, destination, transportType, result });
        }
        catch (KeyNotFoundException ex)
        {
            return BadRequest(new { error = ex.Message });
        }
    }

    [HttpGet("factory-method/compare-routes")]
    public ActionResult<object> CompareDeliveryRoutes(
        [FromQuery] string cargo,
        [FromQuery] string destination)
    {
        var routes = factoryMethodService.GetMultiRouteComparison(cargo, destination);
        return Ok(new { cargo, destination, availableRoutes = routes });
    }

    #endregion
}

