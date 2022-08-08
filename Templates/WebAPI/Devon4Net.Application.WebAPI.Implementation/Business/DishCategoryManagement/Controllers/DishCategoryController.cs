using System.ComponentModel.DataAnnotations;
using Devon4Net.Application.WebAPI.Implementation.Business.DishCategoryManagement.Service;
using Devon4Net.Infrastructure.Log;
using Devon4Net.Application.WebAPI.Implementation.Business.DishCategoryManagement.Dto;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Devon4Net.Application.WebAPI.Implementation.Business.DishCategoryManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [EnableCors("CorsPolicy")]
    public class DishCategoryController : ControllerBase
    {
        private readonly IDishCategoryService _DishCategoryService;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="DishCategoryService"></param>
        public DishCategoryController(IDishCategoryService DishCategoryService)
        {
            _DishCategoryService = DishCategoryService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(DishCategoryDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetDishCategory()
        {
            Devon4NetLogger.Debug("Executing GetDishCategory from controller DishCategoryController");
            return Ok(await _DishCategoryService.GetDishCategory().ConfigureAwait(false));
        }
/*        public async Task<ActionResult> GetDishById(long id)
        {
            Devon4NetLogger.Debug("Executing GetDishByID from controller DishController");
            return Ok(await _DishService.GetDishById(id).ConfigureAwait(false));
        }*/
    }
}
