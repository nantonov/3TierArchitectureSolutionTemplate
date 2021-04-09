using $safeprojectname$.ViewModels.Base;
using _3TierArchitecture.BLL.Models.Base;
using AutoMapper;

namespace $safeprojectname$.AutoMapper
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<HasIdBaseViewModel, HasIdBase>().ReverseMap();
        }
    }
}
