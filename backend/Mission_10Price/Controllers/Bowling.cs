using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission_10Price.Data;
using Mission_10Price.Models;

namespace Mission_10Price.Controllers;

[Microsoft.AspNetCore.Components.Route("api/[controller]")]
[ApiController]
public class Bowling:ControllerBase
{
    private BowlingDbContext _bowlingContext;

    public Bowling(BowlingDbContext temp)
    {
        _bowlingContext = temp;
    }

    [HttpGet(Name = "GetBowling")]
    public IEnumerable<Data.Bowler> Get()
    {
        var bowlerList = _bowlingContext.Bowlers
            .Include(b => b.Team)
            .Where(b => b.Team.TeamName == "Marlins"|| b.Team.TeamName == "Sharks")
            .ToList();
    }
}