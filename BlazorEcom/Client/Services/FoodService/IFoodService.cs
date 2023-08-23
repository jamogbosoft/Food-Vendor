using BlazorEcom.Shared;

namespace BlazorEcom.Client.Services.FoodService
{
    public interface IFoodService
    {
        List<Food> Foods { get; set; }
        Task GetFoods();
        Task<ServiceResponse<Food>> GetFood(int foodId);
    }
}
