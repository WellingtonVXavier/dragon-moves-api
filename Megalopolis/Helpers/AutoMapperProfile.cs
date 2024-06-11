using AutoMapper;
using Megalopolis.Model;
using Megalopolis.Model.Dto;

namespace Megalopolis.Helpers;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<FilmesDto, Filmes>();
        CreateMap<Filmes, FilmesDto>();
    }
}
