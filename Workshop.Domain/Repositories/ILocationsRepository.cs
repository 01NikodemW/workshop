using Workshop.Domain.Entities;

namespace Workshop.Domain.Repositories;

public interface ILocationsRepository
{
    Task<IEnumerable<Location>> GetAllLocations();
}