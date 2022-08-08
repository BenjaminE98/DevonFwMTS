using System.Linq.Expressions;
using Devon4Net.Application.WebAPI.Implementation.Business.DishCategoryManagement.Dto;
using Devon4Net.Application.WebAPI.Implementation.Domain.Entities;

namespace Devon4Net.Application.WebAPI.Implementation.Business.DishCategoryManagement.Service
{
    /// <summary>
    /// TodoService interface
    /// </summary>
    public interface IDishCategoryService
    {
        Task<IEnumerable<DishCategoryDto>> GetDishCategory(Expression<Func<DishCategory, bool>> predicate = null);
        Task<DishCategory> GetDishCategoryById(long id);
    }
}
