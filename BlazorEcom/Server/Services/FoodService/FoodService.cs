using BlazorEcom.Server.Data;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEcom.Server.Services.FoodService
{
    public class FoodService : IFoodService
    {
        private readonly BlazorEcomDataContext _context;

        public FoodService(BlazorEcomDataContext context)
        {
            _context = context;
        }

        [HttpGet("{foodId}")]
        public async Task<ServiceResponse<Food>> GetFoodAsync(int foodId)
        {
            var response = new ServiceResponse<Food>();
            var food = await _context.Foods.FindAsync(foodId);
            if (food == null)
            {
                response.Success = false;
                response.Message = "Sorry, this food does not exist";
            }
            else
            {
                response.Data = food;
            }
            return response;

        }

        [HttpGet]
        public async Task<ServiceResponse<List<Food>>> GetFoodsAsync()
        {
            var response = new ServiceResponse<List<Food>>
            {

                Data = await _context.Foods.ToListAsync()
            };
            return response;
        }

        /*

        [HttpGet("{foodId}")]
        public async Task<ServiceResponse<Food>> GetFoodAsync(int foodId)
        {
            /*
            if (_context == null) { return new ServiceResponse<List<Food>>(); }
            {
                var query = (from f in _context.Foods
                             from i in _context.Ingredients
                                .Where(i => i.FoodId == f.FoodId)
                                .DefaultIfEmpty()
                             select new
                             {
                                 f.FoodId,
                                 f.Name,
                                 f.Description,
                                 f.Price,
                                 f.ImageUrl,
                                 f.Instruction,
                                 f.Ingredients,
                                 IngredientId = i.IngredientId,
                                 IngredientName = i.Name
                             });
                var food = await query.FirstOrDefaultAsync();
                //

            var food = await _context.Foods.Find(foodId);

            if (food == null) { return new ServiceResponse<List<Food>>(); }
            var response = new ServiceResponse<List<Food>>
            {
                Data = new() { food }
            };
            return response;
        }
        */
    }
}