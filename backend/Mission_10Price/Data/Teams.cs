using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mission_10Price.Models;

// Class for the team object, tells the database what the team object is
public class Teams
{
    [Key]
    // TeamId is the primary key for the team object
    public int TeamId { get; set; }

    public string TeamName { get; set; } = null!;

    public int? CaptainId { get; set; }
    
}
