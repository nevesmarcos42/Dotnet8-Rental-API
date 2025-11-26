using RentalAPI.Domain.Entities;

namespace RentalAPI.Domain.Interfaces;

public interface ICustomerRepository : IRepository<Customer>
{
    Task<Customer?> GetByEmailAsync(string email);

    Task<Customer?> GetByDriversLicenseAsync(string driversLicense);
}
