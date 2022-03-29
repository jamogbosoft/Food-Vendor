using BlazorEcom.Shared;

namespace BlazorEcom.Client.Services.FoodService
{
    public interface IFoodService
    {
        List<Food> Foods { get; set; }

        [HttpGet]
        Task GetFoods();

        [HttpGet("{foodId}")]
        Task<ServiceResponse<Food>> GetFood(int foodId);
    }
}
