using System.Collections.Generic;
using System.Threading.Tasks;
using _3TierArchitecture.BLL.Interfaces.Models.Base;

namespace _3TierArchitecture.BLL.Interfaces.Services.Base
{
    public interface IServiceBase<TModel>
        where TModel : IHasIdBase
    {
        Task<IReadOnlyList<TModel>> GetAll();

        Task<TModel> GetById(int id);

        Task<TModel> Create(TModel model);

        Task<TModel> Update(TModel model);

        Task Delete(TModel model);

        Task DeleteById(int id);
    }
}
