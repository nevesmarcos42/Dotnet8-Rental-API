using RentalAPI.Domain.Common;
using RentalAPI.Domain.Enums;

namespace RentalAPI.Domain.Entities;

public class Rental : BaseEntity
{
    public Guid CustomerId { get; set; }
    public Customer Customer { get; set; } = null!;

    public Guid VehicleId { get; set; }
    public Vehicle Vehicle { get; set; } = null!;

    public DateTime StartDate { get; set; }
    public DateTime ExpectedEndDate { get; set; }
    public DateTime? ActualEndDate { get; set; }

    public decimal TotalAmount { get; set; }
    public decimal DailyRate { get; set; }
    public RentalStatus Status { get; set; }

    public int InitialMileage { get; set; }
    public int? FinalMileage { get; set; }
    public string? Notes { get; set; }

    // Relacionamento com devolução
    public RentalReturn? RentalReturn { get; set; }
}
