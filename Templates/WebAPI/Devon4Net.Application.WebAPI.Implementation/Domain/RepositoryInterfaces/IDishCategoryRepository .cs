using System.Linq.Expressions;
using Devon4Net.Domain.UnitOfWork.Repository;
using Devon4Net.Application.WebAPI.Implementation.Domain.Entities;

namespace Devon4Net.Application.WebAPI.Implementation.Domain.RepositoryInterfaces
{
    public interface IDishCategoryRepository : IRepository<DishCategory> {
        Task<IList<DishCategory>> GetDishCategory(Expression<Func<DishCategory, bool>> predicate = null);
        Task<DishCategory> GetDishCategoryById(long id);
    }

}