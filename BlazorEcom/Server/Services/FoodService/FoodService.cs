using BlazorEcom.Server.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorEcom.Server.Services.FoodService
{
    public class FoodService : IFoodService
    {
        private readonly BlazorEcomDataContext _context;

        public FoodService(BlazorEcomDataContext context)
        {
            _context = context;
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

        [HttpGet("{id}")]
        public async Task<ServiceResponse<List<Food>>> GetFoodAsync(int id)
        {
            var foods = await _context.Foods.ToListAsync();
            var result = foods.FirstOrDefault(f => f.FoodId == id);
            List<Food> food1 = new() { result };
            //food1.Add(result);
            //var dataList = new ServiceResponse<List<Food>>> { result};
            var response = new ServiceResponse<List<Food>>
            {
                // Data = new List<Food>() { result }
                Data = food1
            };
            return response;
        }
    }
}
