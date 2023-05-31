using System;
using System.ComponentModel.DataAnnotations;

namespace Reservations.Models;
public class Reservation
{
    [Key]
    public int ReservationId { get; set; }

    [Required]
    public int UserId { get; set; }

    [Required]
    public int RestaurantId { get; set; }

    [Required]
    public int TableNumber { get; set; }

    [Required]
    public DateTime TimeSlot { get; set; }

    public virtual User User { get; set; }
    public virtual Restaurant Restaurant { get; set; }
}