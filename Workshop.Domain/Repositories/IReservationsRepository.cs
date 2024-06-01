using Workshop.Domain.Entities;

namespace Workshop.Domain.Repositories;

public interface IReservationsRepository
{
    Task<Guid> CreateReservation(Reservation reservation);
}