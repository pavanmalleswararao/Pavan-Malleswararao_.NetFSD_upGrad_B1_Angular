using Assignment1.Models;

namespace Assignment1.Repositories
{
    public class FlightRepository : IFlightRepository
    {
        private List<Flight> flights=new List<Flight>()
        {
            new Flight()
            {
                Id=11,
                FlightCode="AI101",
                seat=150,
                FlightType="Domestic",
                Company="Air India"
            }
        };
        public void AddFlight(Flight flight)
        {
            flights.Add(flight);
        }

        public void DeleteFlight(int id)
        {
            var flight=flights.FirstOrDefault(f => f.Id==id);
            if (flight != null)
            {
                flights.Remove(flight);
            }
        }

        public void EditFlight(Flight flight)
        {
            var exist=flights.FirstOrDefault(x=>x.Id==flight.Id);
            if(exist != null)
            {
                exist.FlightCode=flight.FlightCode;
                exist.seat=flight.seat;
                exist.FlightType=flight.FlightType;
                exist.Company=flight.Company;
            }
        }

        public List<Flight> GetAllFlights()
        {
            return flights;
        }

        public Flight GetFlight(int id)
        {
            return flights.FirstOrDefault(x => x.Id == id);
        }
    }
}
