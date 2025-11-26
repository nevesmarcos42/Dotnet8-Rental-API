using RentalAPI.Domain.Common;

namespace RentalAPI.Domain.Entities;

public class Customer : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string DriversLicense { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public DateTime DateOfBirth { get; set; }
    public bool IsActive { get; set; }
    
    // Relacionamentos
    public ICollection<Rental> Rentals { get; set; } = new List<Rental>();
}
