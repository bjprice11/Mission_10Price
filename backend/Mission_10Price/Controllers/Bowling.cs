using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission_10Price.Models;

namespace Mission_10Price.Controllers;

// Controller for the Bowling API
[Route("api/[controller]")]
[ApiController]
public class Bowling:ControllerBase
{
    //Private context for the database
    private BowlingDbContext _bowlingContext;

    // How the user can access the database
    public Bowling(BowlingDbContext temp)
    {
        _bowlingContext = temp;
    }

    // Get the bowler list
    [HttpGet(Name = "GetBowling")]
    public IEnumerable<Models.Bowlers> Get()
    {
        // Get the bowler list from the database, include the team information
        var bowlerList = _bowlingContext.Bowlers
            .Include(b => b.Teams)
            .Where(b => b.Teams.TeamName == "Marlins"|| b.Teams.TeamName == "Sharks")
            .ToList();
        return bowlerList;
    }
}