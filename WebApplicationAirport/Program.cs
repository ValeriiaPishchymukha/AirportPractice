using Airport.BLL.DTOs.Services;
using Airport.BLL.DTOs.Services.Interfaces;
using Airport.DAL.EF;
using Airport.DAL.EF.Interfaces;
using Airport.DAL.EF.Repositories;
using Microsoft.EntityFrameworkCore;

namespace WebApplicationAirport
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<AirportDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            builder.Services.AddAutoMapper(typeof(MappingProfile).Assembly);


            builder.Services.AddScoped<IAircraftService, AircraftService>();
            builder.Services.AddScoped<IAircraftRepository, AircraftRepository>();

            builder.Services.AddScoped<IAircraftTypeService, AircraftTypeService>();
            builder.Services.AddScoped<IAircraftTypeRepository, AircraftTypeRepository>();


            builder.Services.AddScoped<IAirportEntityService, AirportEntityService>();
            builder.Services.AddScoped<IAirportEntityRepository, AirportEntityRepository>();


            builder.Services.AddScoped<IFlightDestinationService, FlightDestinationService>();
            builder.Services.AddScoped<IFlightDestinationRepository, FlightDestinationRepository>();

            builder.Services.AddScoped<IPassengerService, PassengerService>();
            builder.Services.AddScoped<IPassengerRepository, PassengerRepository>();

            builder.Services.AddScoped<IPilotService, PilotService>();
            builder.Services.AddScoped<IPilotRepository, PilotRepository>();


            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }


            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
