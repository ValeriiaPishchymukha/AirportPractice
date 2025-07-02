using Airport.BLL.DTOs.Validation;
using Airport.BLL.Services;
using Airport.BLL.Services.Interfaces;
using Airport.DAL.EF;
using Airport.DAL.EF.Helpers;
using Airport.DAL.EF.Interfaces;
using Airport.DAL.EF.Repositories;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authentication.OAuth;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace WebApplicationAirport
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddAuthorization();
            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        // вказує, чи валідуватиметься видавець при валідації токена
                        ValidateIssuer = true,
                        // Рядок, що представляє видавця
                        ValidIssuer = AuthOptions.ISSUER,
                        // Чи валідуватиметься споживач токена
                        ValidateAudience = true,
                        // Установка споживача токена
                        ValidAudience = AuthOptions.AUDIENCE,
                        // чи валідуватиметься час існування
                        ValidateLifetime = true,
                        // встановлення ключа безпеки
                        IssuerSigningKey = AuthOptions.GetSymmetricSecurityKey(),
                        // валідація ключа безпеки
                        ValidateIssuerSigningKey = true,
                        };
               });



            builder.Services.AddDbContext<AirportDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<AirportDbContext>()
                .AddDefaultTokenProviders();

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

            builder.Services.AddFluentValidationAutoValidation();
            builder.Services.AddFluentValidationClientsideAdapters();

            builder.Services.AddValidatorsFromAssemblyContaining<AircraftReqDTO_Validator>();
            builder.Services.AddValidatorsFromAssemblyContaining<AircraftTypeReqDTO_Validator>();
            builder.Services.AddValidatorsFromAssemblyContaining<AirportEntityReqDTO_Validator>();
            builder.Services.AddValidatorsFromAssemblyContaining<FlightDestinationReqDTO_Validator>();
            builder.Services.AddValidatorsFromAssemblyContaining<PassengerReqDTO_Validator>();
            builder.Services.AddValidatorsFromAssemblyContaining<PilotReqDTO_Validator>();

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

            app.UseAuthentication();
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
