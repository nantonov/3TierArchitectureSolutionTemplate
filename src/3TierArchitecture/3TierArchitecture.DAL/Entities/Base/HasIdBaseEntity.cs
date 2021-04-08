using _3TierArchitecture.DAL.Interfaces.Entities.Base;

namespace _3TierArchitecture.DAL.Entities.Base
{
    public class HasIdBaseEntity : IHasIdBaseEntity
    {
        public int Id { get; set; }
    }
}
