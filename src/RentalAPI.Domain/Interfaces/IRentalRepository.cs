using RentalAPI.Domain.Entities;

namespace RentalAPI.Domain.Interfaces;

public interface IRentalRepository : IRepository<Rental>
{
    Task<IEnumerable<Rental>> GetActiveRentalsAsync();

    Task<IEnumerable<Rental>> GetByCustomerIdAsync(Guid customerId);

    Task<IEnumerable<Rental>> GetByVehicleIdAsync(Guid vehicleId);
}
