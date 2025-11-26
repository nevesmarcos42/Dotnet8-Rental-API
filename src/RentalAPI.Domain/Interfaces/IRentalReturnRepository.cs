using RentalAPI.Domain.Entities;

namespace RentalAPI.Domain.Interfaces;

public interface IRentalReturnRepository : IRepository<RentalReturn>
{
    Task<RentalReturn?> GetByRentalIdAsync(Guid rentalId);
}
