using _3TierArchitecture.BLL.Models.Base;
using _3TierArchitecture.DAL.Entities.Base;
using AutoMapper;

namespace _3TierArchitecture.BLL.AutoMapper
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<HasIdBase, HasIdBaseEntity>().ReverseMap();
        }
    }
}
