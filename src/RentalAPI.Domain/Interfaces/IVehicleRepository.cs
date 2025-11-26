using RentalAPI.Domain.Entities;

namespace RentalAPI.Domain.Interfaces;

public interface IVehicleRepository : IRepository<Vehicle>
{
    Task<IEnumerable<Vehicle>> GetAvailableVehiclesAsync();

    Task<Vehicle?> GetByLicensePlateAsync(string licensePlate);
}
