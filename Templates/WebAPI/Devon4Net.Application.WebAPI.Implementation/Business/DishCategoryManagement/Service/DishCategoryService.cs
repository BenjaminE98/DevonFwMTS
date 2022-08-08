using System.Linq.Expressions;
using Devon4Net.Domain.UnitOfWork.Service;
using Devon4Net.Domain.UnitOfWork.UnitOfWork;
using Devon4Net.Infrastructure.Log;
using Devon4Net.Application.WebAPI.Implementation.Business.DishCategoryManagement.Converters;
using Devon4Net.Application.WebAPI.Implementation.Business.DishCategoryManagement.Dto;
using Devon4Net.Application.WebAPI.Implementation.Domain.Database;
using Devon4Net.Application.WebAPI.Implementation.Domain.Entities;
using Devon4Net.Application.WebAPI.Implementation.Domain.RepositoryInterfaces;

namespace Devon4Net.Application.WebAPI.Implementation.Business.DishCategoryManagement.Service
{
    /// <summary>
    /// Service implementation
    /// </summary>
    public class DishCategoryService : Service<DishCategoryContext>, IDishCategoryService
    {
        private readonly IDishCategoryRepository _dishCategoryRepository;

        
        public DishCategoryService(IUnitOfWork<DishCategoryContext> uoW) : base(uoW)
        {
            _dishCategoryRepository = uoW.Repository<IDishCategoryRepository>();
        }

        public async Task<IEnumerable<DishCategoryDto>> GetDishCategory(Expression<Func<DishCategory, bool>> predicate = null)
        {
            Devon4NetLogger.Debug("GetDish from DishService");
            var result = await _dishCategoryRepository.GetDishCategory(predicate).ConfigureAwait(false);
            return result.Select(DishCategoryConverter.ModelToDto);
        }
        public Task<DishCategory> GetDishCategoryById(long id)
        {
            Devon4NetLogger.Debug($"GetDishCategoryById method from service DishCategoryservice with value : {id}");
            return _dishCategoryRepository.GetDishCategoryById(id);
        }
    }
}