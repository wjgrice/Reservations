using System.ComponentModel.DataAnnotations;

namespace Reservations.Models;
public enum RestaurantType
{
    FastFood,
    Casual,
    FineDining
}

public class Restaurant
{
    [Key]
    public int RestaurantId { get; set; }

    [Required, MaxLength(100)]
    public string RestaurantName { get; set; }

    [Required, MaxLength(200)]
    public string Location { get; set; }

    public RestaurantType Type { get; set; }

    // Assuming the restaurant has a fixed number of tables
    public int NumberOfTables { get; set; }
}