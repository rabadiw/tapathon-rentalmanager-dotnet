using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace RentalManager.Rental;

[ApiController]
[Route("[controller]")]
public class RentalController :  ControllerBase
{
    private readonly RentalDbContext _dbContext;

    public RentalController(RentalDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        if (_dbContext.RentalData is not { } data)
            return Problem(statusCode: 500, detail: "Unexpected null rental set");
        
        var results = await data.ToListAsync();
        return Ok(results);

    }
}