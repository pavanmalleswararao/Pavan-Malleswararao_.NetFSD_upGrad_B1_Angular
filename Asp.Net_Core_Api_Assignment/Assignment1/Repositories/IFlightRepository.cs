using Assignment1.Models;

namespace Assignment1.Repositories
{
    public interface IFlightRepository
    {
        List<Flight> GetAllFlights();
        Flight GetFlight(int id);
        void AddFlight(Flight flight);
        void EditFlight(Flight flight);
        void DeleteFlight(int id);
    }
}
