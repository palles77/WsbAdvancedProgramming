using System;
using System.ComponentModel.DataAnnotations;

namespace AdvancedProgramming_Lesson1.Models;

/// <summary>
/// Represents a movie.
/// </summary>
public class Movie
{
    /// <summary>
    /// Gets or sets the identifier of the movie.
    /// </summary>
    [Display(Name = "Identyfikator")]
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the title of the movie.
    /// </summary>
    [Display(Name = "Tytuł")]
    public string Title { get; set; }

    /// <summary>
    /// Gets or sets the release date of the movie.
    /// </summary>
    [DataType(DataType.Date)]
    [Display(Name = "Data Wypuszczenia")]
    public DateTime ReleaseDate { get; set; }

    /// <summary>
    /// Gets or sets the genre of the movie.
    /// </summary>
    [Display(Name = "Rodzaj")]
    public string Genre { get; set; }

    /// <summary>
    /// Gets or sets the price of the movie.
    /// </summary>
    [Display(Name = "Cena")]
    public decimal Price { get; set; }
}