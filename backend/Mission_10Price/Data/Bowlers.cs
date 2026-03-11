using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission_10Price.Models;

// Class for the bowler object, tells the database what the bowler object is
public class Bowlers
{
    [Key]
    public int BowlerId { get; set; }
    [Required]
    public string BowlerLastName { get; set; }
    [Required]
    public string BowlerFirstName { get; set; }
    public char? BowlerMiddleInit { get; set; }
    [Required]
    public string BowlerAddress { get; set; }
    [Required]
    public string BowlerCity { get; set; }
    [Required]
    public string BowlerState { get; set; }
    [Required]
    public string BowlerZip { get; set; }
    [Required]
    public string BowlerPhoneNumber { get; set; }
    [Required]
    public int TeamId { get; set; }
    [ForeignKey("TeamId")]
    public Teams Teams { get; set; }
}
