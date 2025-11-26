namespace RentalAPI.Domain.Interfaces;

public interface IUnitOfWork : IDisposable
{
    IVehicleRepository Vehicles { get; }

    ICustomerRepository Customers { get; }

    IRentalRepository Rentals { get; }

    IRentalReturnRepository RentalReturns { get; }

    IUserRepository Users { get; }

    Task<int> SaveChangesAsync();
}
