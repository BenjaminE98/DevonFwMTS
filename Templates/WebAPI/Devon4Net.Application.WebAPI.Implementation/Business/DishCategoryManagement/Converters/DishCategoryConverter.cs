using Devon4Net.Application.WebAPI.Implementation.Business.DishCategoryManagement.Dto;
using Devon4Net.Application.WebAPI.Implementation.Domain.Entities;

namespace Devon4Net.Application.WebAPI.Implementation.Business.DishCategoryManagement.Converters
{
    /// <summary>
    /// DishConverter
    /// </summary>
    public static class DishCategoryConverter
    {
        /// <summary>
        /// ModelToDto transformation
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static DishCategoryDto ModelToDto(DishCategory item)
        {
            if (item == null) return new DishCategoryDto();

            return new DishCategoryDto
            {
                DishCategoryId = item.Id,
                DishId = item.IdDish,
                CategoryId =  item.IdCategory,
            };
        }

    }
}
