using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace W02_Assignment_ASP.NET_Core.Models;

public class MovieGenreViewModel
{
    public List<Movie>? Movies { get; set; }
    public SelectList? Genres { get; set; }
    public string? MovieGenre { get; set; }
    public string? SearchString { get; set; }
    public int? Year { get; set; }
}