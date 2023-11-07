using AutoMapper;
using WasteMgmtService.Data.Dtos;
using WasteMgmtService.Models;

namespace WasteMgmtService.Profiles
{
    public class WastesProfile : Profile
    {
        public WastesProfile()
        {
            CreateMap<Waste, WasteReadDto>();
            CreateMap<WasteCreateDto, Waste>();
        }
    }
}
