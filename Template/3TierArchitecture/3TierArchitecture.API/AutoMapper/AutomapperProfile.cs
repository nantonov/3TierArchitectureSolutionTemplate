using $safeprojectname$.ViewModels.Base;
using $ext_safeprojectname$.BLL.Models.Base;
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
