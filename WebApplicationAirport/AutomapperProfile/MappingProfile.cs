using AutoMapper;
using Airport.DAL.EF.Entities;
using Airport.BLL.DTOs.Responses;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Aircraft, AircraftShortResponseDTO>();

        CreateMap<Aircraft, AircraftFullResponseDTO>()
            .ForMember(dest => dest.Pilots, opt => opt.MapFrom(src => src.PilotAircrafts.Select(pa => pa.Pilot).ToList()));

        CreateMap<AircraftType, AircraftTypeResponseDTO>();

        CreateMap<AirportEntity, AirportEntityResponseDTO>();

        CreateMap<FlightDestination, FlightDestinationShortResponseDTO>();

        CreateMap<FlightDestination, FlightDestinationFullResponseDTO>()
            .ForMember(dest => dest.AirportEntity, opt => opt.MapFrom(src => src.Airport))
            .ForMember(dest => dest.Aircraft, opt => opt.MapFrom(src => src.Aircraft))
            .ForMember(dest => dest.Passenger, opt => opt.MapFrom(src => src.Passenger));

        CreateMap<Passenger, PassengerResponseDTO>();

        CreateMap<Pilot, PilotShortResponseDTO>()
            .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.FirstName + " " + src.LastName));

        CreateMap<Pilot, PilotFullResponseDTO>()
            .ForMember(dest => dest.Aircrafts, opt => opt.MapFrom(src => src.PilotAircrafts.Select(pa => pa.Aircraft)));
    }
}