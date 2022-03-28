namespace BlazorEcom.Server.Services.FoodService
{
    public interface IFoodService
    {
        Task<ServiceResponse<List<Food>>> GetFoodsAsync();
        Task<ServiceResponse<List<Food>>> GetFoodAsync(int id);
    }
}
