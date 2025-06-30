using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.DAL.EF.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IAircraftRepository AircraftRepository { get; }
        IAircraftTypeRepository AircraftTypeRepository { get; }
        IAirportEntityRepository AirportEntityRepository { get; }
        IFlightDestinationRepository FlightDestinationRepository { get; }
        IPassengerRepository PassengerRepository { get; }
        IPilotRepository PilotRepository { get; }


        Task CommitAsync();
    }
}
