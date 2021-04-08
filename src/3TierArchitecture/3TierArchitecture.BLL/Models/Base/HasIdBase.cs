using _3TierArchitecture.BLL.Interfaces.Models.Base;

namespace _3TierArchitecture.BLL.Models.Base
{
    public class HasIdBase : IHasIdBase
    {
        public int Id { get; set; }
    }
}
