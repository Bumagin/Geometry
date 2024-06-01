using Geometry.Abstractions.Interfaces;
using Geometry.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Example.WebAPI.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class GeometryController : ControllerBase
{
    private readonly IFigureManager _figureManager;

    public GeometryController(IFigureManager figureManager)
    {
        _figureManager = figureManager;
    }
    
    [HttpPost]
    public IActionResult CalculateCircleArea(double radius)
    {
        var circle = new Circle(radius);
        var area = _figureManager.GetArea(circle);
        return Ok(area);
    }
    
    [HttpPost]
    public IActionResult CalculateTriangleArea(double leftSide, double rightSide, double downSide)
    {
        var triangle = new Triangle(leftSide, rightSide, downSide);
        var area = _figureManager.GetArea(triangle);
        return Ok(area);
    }
    
    [HttpPost]
    public IActionResult IsRectangularTriangle(double leftSide, double rightSide, double downSide)
    {
        var triangle = new Triangle(leftSide, rightSide, downSide);
        var isRectangular = _figureManager.IsRectangular(triangle);
        return Ok(isRectangular);
    }
}