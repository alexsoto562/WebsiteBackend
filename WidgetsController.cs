using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging; 
using AboutMeWebsite.Models;
using AboutMeWebsite;

[Route("api/[controller]")]
[ApiController]
public class WidgetsController : ControllerBase
{
    private readonly WidgetService _widgetService;
    private readonly ILogger<WidgetsController> _logger; 

    public WidgetsController(WidgetService widgetService, ILogger<WidgetsController> logger)
    {
        _widgetService = widgetService;
        _logger = logger; 
    }

    // POST api/widgets/insert
    [HttpPost("insert")]
    public IActionResult InsertWidget([FromBody] WidgetModel widget)
    {
        _widgetService.InsertWidget(widget.Name, widget.Manufacturer, widget.Description, widget.Cost);
        return Ok("Widget inserted successfully.");
    }

    // POST api/widgets/update
    [HttpPost("update")]
    public IActionResult UpdateWidget([FromBody] WidgetModel widget)
    {
        _widgetService.UpdateWidget(widget.Id, widget.Name, widget.Manufacturer, widget.Description, widget.Cost);
        return Ok("Widget updated successfully.");
    }

  
}
