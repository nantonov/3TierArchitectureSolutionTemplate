using $safeprojectname$.Interfaces.Entities.Base;

namespace $safeprojectname$.Entities.Base
{
    public class HasIdBaseEntity : IHasIdBaseEntity
    {
        public int Id { get; set; }
    }
}
