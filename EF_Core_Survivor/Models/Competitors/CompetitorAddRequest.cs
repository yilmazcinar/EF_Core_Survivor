﻿namespace EF_Core_Survivor.Models.Competitors;

public class CompetitorAddRequest
{

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int CategoryId { get; set; }
}
