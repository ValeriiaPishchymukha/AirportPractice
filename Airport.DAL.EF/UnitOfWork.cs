using Airport.DAL.EF.Interfaces;
using Airport.DAL.EF.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.DAL.EF
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AirportDbContext _context;

        public IAircraftRepository AircraftRepository { get; }
        public IAircraftTypeRepository AircraftTypeRepository { get; }
        public IAirportEntityRepository AirportEntityRepository { get; }
        public IFlightDestinationRepository FlightDestinationRepository { get; }
        public IPassengerRepository PassengerRepository { get; }
        public IPilotRepository PilotRepository { get; }


        public UnitOfWork(AirportDbContext context)
        {
            _context = context;
            AircraftRepository = new AircraftRepository(_context);
            AircraftTypeRepository = new AircraftTypeRepository(_context);
            AirportEntityRepository = new AirportEntityRepository(_context);
            FlightDestinationRepository = new FlightDestinationRepository(_context);
            PassengerRepository = new PassengerRepository(_context);
            PilotRepository = new PilotRepository(_context);
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

    }

}
