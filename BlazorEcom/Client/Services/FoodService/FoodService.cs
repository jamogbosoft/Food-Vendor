namespace BlazorEcom.Client.Services.FoodService
{
    public class FoodService : IFoodService
    {
        private readonly HttpClient _http;

        public FoodService(HttpClient http)
        {
            _http = http;
        }
        public List<Food> Foods { get; set; } = new List<Food>();

        public async Task<ServiceResponse<Food>> GetFood(int foodId)
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<Food>>($"api/food/{foodId}");
            return result;
        }

        public async Task GetFoods()
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<List<Food>>>("api/food");
            if (result != null && result.Data != null)
            {
                Foods = result.Data;
            }
        }
    }
}
