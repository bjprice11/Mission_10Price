using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission_10Price.Data;
using Mission_10Price.Models;

namespace Mission_10Price.Controllers;

[Route("api/[controller]")]
[ApiController]
public class Bowling:ControllerBase
{
    private BowlingDbContext _bowlingContext;

    public Bowling(BowlingDbContext temp)
    {
        _bowlingContext = temp;
    }

    [HttpGet(Name = "GetBowling")]
    public IEnumerable<Data.Bowlers> Get()
    {
        var bowlerList = _bowlingContext.Bowlers
            .Include(b => b.Teams)
            .Where(b => b.Teams.TeamName == "Marlins"|| b.Teams.TeamName == "Sharks")
            .ToArray();
        return bowlerList;
    }
}