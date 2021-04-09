using System.Collections.Generic;
using System.Threading.Tasks;
using $safeprojectname$.Interfaces.Services.Base;
using $safeprojectname$.Models.Base;
using _3TierArchitecture.DAL.Entities.Base;
using _3TierArchitecture.DAL.Interfaces.Repositories.Base;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace $safeprojectname$.Services.Base
{
    public class BaseService<TModel, TEntity> : IServiceBase<TModel>
        where TModel : HasIdBase
        where TEntity : HasIdBaseEntity
    {
        protected readonly IGenericRepository<TEntity> GenericRepository;
        protected readonly IMapper Mapper;

        protected BaseService(IGenericRepository<TEntity> genericRepository, IMapper mapper)
        {
            GenericRepository = genericRepository;
            Mapper = mapper;
        }

        public async Task<IReadOnlyList<TModel>> GetAll()
        {
            return await Mapper.ProjectTo<TModel>(GenericRepository.Query).ToListAsync();
        }

        public async Task<TModel> GetById(int id)
        {
            var entity = await GenericRepository.Get(x => x.Id == id);
            return Mapper.Map<TModel>(entity);
        }

        public async Task<TModel> Create(TModel model)
        {
            var entity = Mapper.Map<TEntity>(model);
            return Mapper.Map<TModel>(await GenericRepository.Insert(entity));
        }

        public async Task<TModel> Update(TModel model)
        {
            var entity = Mapper.Map<TEntity>(model);
            return Mapper.Map<TModel>(await GenericRepository.Update(entity));
        }

        public Task Delete(TModel model)
        {
            var entity = Mapper.Map<TEntity>(model);
            return GenericRepository.Delete(entity);
        }

        public async Task DeleteById(int id)
        {
            var entity = await GenericRepository.Get(x => x.Id == id);
            await GenericRepository.Delete(entity);
        }
    }
}
