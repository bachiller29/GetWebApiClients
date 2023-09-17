using System;
using System.Collections.Generic;

namespace Client.WebApi.Models;

public partial class Clients
{
    public int IdClient { get; set; }

    public string? NameClient { get; set; }

    public int? Ege { get; set; }

    public DateTime? BirthDate { get; set; }

    public string? Direction { get; set; }
}
