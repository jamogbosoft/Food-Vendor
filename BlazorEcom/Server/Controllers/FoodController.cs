using BlazorEcom.Server.Data;
using BlazorEcom.Server.Services.FoodService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace BlazorEcom.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodController : ControllerBase
    {
        private readonly IFoodService _foodService;

        public FoodController(IFoodService foodService)
        {
            _foodService = foodService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Food>>>> GetFoods()
        {
            var result = await _foodService.GetFoodsAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<List<Food>>>> GetFood(int id)
        {
            var result = await _foodService.GetFoodAsync(id);

            if (result == null)
            {
                return NotFound("This food is not available");
            }
            return Ok(result);     
        }
    }
}
