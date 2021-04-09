using $safeprojectname$.Interfaces.Models.Base;

namespace $safeprojectname$.Models.Base
{
    public class HasIdBase : IHasIdBase
    {
        public int Id { get; set; }
    }
}
