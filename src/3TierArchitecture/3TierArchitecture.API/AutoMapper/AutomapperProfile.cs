using _3TierArchitecture.API.ViewModels.Base;
using _3TierArchitecture.BLL.Models.Base;
using AutoMapper;

namespace _3TierArchitecture.API.AutoMapper
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<HasIdBaseViewModel, HasIdBase>().ReverseMap();
        }
    }
}
