using DesignPatterns.Api.Application;
using DesignPatterns.Api.Domain.AbstractFactory.Furniture;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Api.Controllers;

[ApiController]
[Route("api/patterns")]
public sealed class PatternsController(AbstractFactoryShowcaseService showcaseService) : ControllerBase
{
    [HttpGet("abstract-factory/styles")]
    public ActionResult<IReadOnlyCollection<string>> GetSupportedStyles()
        => Ok(showcaseService.GetSupportedStyles());

    [HttpGet("abstract-factory/furniture-set")]
    public ActionResult<FurnitureSet> BuildFurnitureSet([FromQuery] string? style)
    {
        try
        {
            return Ok(showcaseService.CreateConfiguredSet(style));
        }
        catch (KeyNotFoundException ex)
        {
            return BadRequest(new { error = ex.Message });
        }
    }
}
