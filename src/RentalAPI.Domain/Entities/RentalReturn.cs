using RentalAPI.Domain.Common;
using RentalAPI.Domain.Enums;

namespace RentalAPI.Domain.Entities;

public class RentalReturn : BaseEntity
{
    public Guid RentalId { get; set; }
    public Rental Rental { get; set; } = null!;

    public DateTime ReturnDate { get; set; }
    public VehicleCondition Condition { get; set; }

    public decimal LateFee { get; set; }
    public decimal DamageFee { get; set; }
    public string? Notes { get; set; }

    public bool InspectionApproved { get; set; }
    public string InspectedBy { get; set; } = string.Empty;
}
