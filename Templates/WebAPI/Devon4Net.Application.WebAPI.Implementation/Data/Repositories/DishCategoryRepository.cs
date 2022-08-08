using System.Linq.Expressions;
using Devon4Net.Domain.UnitOfWork.Repository;
using Devon4Net.Infrastructure.Log;
using Devon4Net.Application.WebAPI.Implementation.Business.TodoManagement.Validators;
using Devon4Net.Application.WebAPI.Implementation.Domain.Database;
using Devon4Net.Application.WebAPI.Implementation.Domain.Entities;
using Devon4Net.Application.WebAPI.Implementation.Domain.RepositoryInterfaces;

namespace Devon4Net.Application.WebAPI.Implementation.Data.Repositories
{
    public class DishCategoryRepository : Repository<DishCategory>, IDishCategoryRepository
    {
        public DishCategoryRepository(DishCategoryContext context) : base(context)
        {
        }

        public Task<IList<DishCategory>> GetDishCategory(Expression<Func<DishCategory, bool>> predicate = null)
        {
            return Get(predicate);
        }
        public Task<DishCategory> GetDishCategoryById(long id)
        {
            Devon4NetLogger.Debug($"GetDishCategoryByID method from repository DishCategoryservice with value : {id}");
            return GetFirstOrDefault(t => t.Id == id);
        }

    }
}