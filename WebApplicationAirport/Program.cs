using Airport.BLL.DTOs.Validation;
using Airport.BLL.Services;
using Airport.BLL.Services.Interfaces;
using Airport.BLL.Services.Interfaces.JWTAuthentication.WebApi.Services;
using Airport.DAL.EF;
using Airport.DAL.EF.Entities.HelpModels.Identity;
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
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using WebApplicationAirport.Middleware;

namespace WebApplicationAirport
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddAuthorization();
            builder.Services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidIssuer = AuthOptions.Issuer,
                    ValidateAudience = true,
                    ValidAudience = AuthOptions.Audience,
                    ValidateLifetime = true,
                    IssuerSigningKey = AuthOptions.GetSymmetricSecurityKey(),
                    ValidateIssuerSigningKey = true,
                };
            });


            builder.Services.AddDbContext<AirportDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
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

            builder.Services.AddScoped<IUserService, UserService>();



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
            //builder.Services.AddSwaggerGen();


            //experiment ----------------------------------------------------------------
            builder.Services.AddSwaggerGen(c =>
            {
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = "JWT Authorization header using the Bearer scheme. Example: \"Bearer {token}\"",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer"
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement{
                {
                    new OpenApiSecurityScheme{
                        Reference = new OpenApiReference{
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                        }
                    },
                    new string[]{}
                }});
            });
            //end of it ----------------------------------------------------------------


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseMiddleware<ExceptionMiddleware>();

            app.UseStatusCodePages(async context =>
            {
                var response = context.HttpContext.Response;
                response.ContentType = "application/json";

                string message = context.HttpContext.Request.Path;

                switch (response.StatusCode)
                {
                    case 401:
                        await response.WriteAsync(JsonConvert.SerializeObject(new
                        {
                            StatusCode = 401,
                            Message = "Неавторизований доступ",
                            Status = "ERROR"
                        }));
                        break;
                    case 403:
                        await response.WriteAsync(JsonConvert.SerializeObject(new
                        {
                            StatusCode = 403,
                            Message = "Доступ заборонено",
                            Status = "ERROR"
                        }));
                        break;
                    case 500:
                        await response.WriteAsync(JsonConvert.SerializeObject(new
                        {
                            StatusCode = 500,
                            Message = "Внутрішня помилка сервера",
                            Status = "ERROR"
                        }));
                        break;
                    default:
                        await response.WriteAsync(JsonConvert.SerializeObject(new
                        {
                            StatusCode = response.StatusCode,
                            Message = "Сталася помилка",
                            Status = "ERROR"
                        }));
                        break;
                }
            });


            app.UseHttpsRedirection();

            app.UseAuthentication();
            app.UseAuthorization();



            app.MapControllers();

            app.Run();
        }
    }
}
