using $safeprojectname$.Models.Base;
using _3TierArchitecture.DAL.Entities.Base;
using AutoMapper;

namespace $safeprojectname$.AutoMapper
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<HasIdBase, HasIdBaseEntity>().ReverseMap();
        }
    }
}
