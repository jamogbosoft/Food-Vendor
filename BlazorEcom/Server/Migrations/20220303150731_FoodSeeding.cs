using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEcom.Server.Migrations
{
    public partial class FoodSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "Description", "ImageUrl", "Instruction", "Name", "Price" },
                values: new object[] { 1, "Nigerian-inspired, protein-rich vegan egusi stew. Enjoy this with rice, yams, plantains, sweet or regular potatoes.", "https://i0.wp.com/somiigbene.com/wp-content/uploads/2019/12/Nigerian-inspired-vegan-egusi-ii.jpeg?resize=1152%2C1536&ssl=1", "Preheat the oven to 200C. Line a baking tray with baking paper then evenly distribute tofu on the tray and bake for 25 minutes, turning halfway through cooking until all sides are golden then set aside and keep warm.\r\n                        Put the tomatoes, red onion, garlic cloves, bell pepper, ginger and chilli in a food processor and blitz to form a smooth liquid. Tip the mixture into a medium saucepan and cook on a medium heat for 25 minutes until the sauce reduces to a very thick paste.\r\n                        Heat the olive oil in another saucepan over medium heat. Once hot, add the ground egusi and fry, stirring frequently for 4 minutes. Stir in the tomato paste, fry for an additional two minutes then add around 200ml of water. Add the vegetable stock cube and adjust seasoning as needed with salt pepper. Allow to cook on medium heat for 3 minutes then add kale and tofu. Cook for 4-5 minutes or until the kale is tender then serve over rice.", "Nigerian-inspired Vegan Egusi (Melon) Seed Stew with Tofu", 350.0 });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "Description", "ImageUrl", "Instruction", "Name", "Price" },
                values: new object[] { 2, "A tasty groundnut soup with spinach, baked salmon and cornmeal", "https://i0.wp.com/somiigbene.com/wp-content/uploads/2021/01/GROUNDNUT-SPINACH-AND-CORNMEAL.png?w=1000&ssl=1", "For the peanut soup\r\n                        Heat 300ml of water in a medium saucepan, add shallots, chilli, vegetable stock cube and ground peanuts.\r\n                        Cook on medium heat for 15 minutes. Stir in spinach and Crayfish then season with a pinch of salt if needed.\r\n                        Cook for 3 minutes (5-6 minutes if usuing pumpkin leaves) then take the pan off the heat and set aside.\r\n                        For the cornmeal\r\n                        Tip the cornmeal into a large bowl then add around 250ml of water to form a loose paste. Tip into a large, non-stick pan then place the pan on a very low heat.\r\n                        Keep stirring with a wooden cooking spoon over low heat for around 20 minutes, adding small amounts of water to cook the semolina and thicken it.\r\n                        Once the cornmeal is cooked and thickens such that it sticks to a wooden spoon, take the pan off the heat and allow it cool. Divide the semolina into three equal portions then mould into a round ball.\r\n                        For the salmon\r\n                        Season with salt and black pepper or fish seasoning and dried herbs. Place a baking tray lined with parchment paper and bake for 15 minutes in the oven, turning it halfway through cooking.\r\n                        Serve the cornmeal with the spinach and peanut soup and baked salmon. Garnish with chilli flakes if you wish. Enjoy!", "Groundnut and Spinach Stew with Cornmeal", 550.0 });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "Description", "ImageUrl", "Instruction", "Name", "Price" },
                values: new object[] { 3, "Effortless tortellini soup with mixed vegetables and tofu", "https://i0.wp.com/somiigbene.com/wp-content/uploads/2020/11/10-minute-Tortellini-Soup.jpg?fit=1920%2C2400&ssl=1", "Add approximately 300ml of boiling water to a medium saucepan. Add garlic, vegetable seasoning and mixed vegetables to the pan then cook for 6 minutes.\r\n                    Add tofu and tortellini. Cook for 3 minutes or until the tortellini is tender and floats to the top. Stir in fresh parsley then take the pan off the heat.\r\n                    To serve, transfer to a bowl, sprinkle black pepper and extra fresh parsley. You can add parmesan and a drizzle of olive oil if you wish.", "10-Minute Tortellini Soup", 450.0 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "IngredientId", "FoodId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "400 g tin plum tomatoes" },
                    { 2, 1, "1 large red onion, peeled and quartered" },
                    { 3, 1, "3 medium garlic cloves" },
                    { 4, 1, "1 large red chilli" },
                    { 5, 1, "1 large red bell pepper" },
                    { 6, 1, "1 pack tofu, drained and cubed" },
                    { 7, 1, "4 tablespoon ground egusi (melon seeds)" },
                    { 8, 1, "2 tablespoon olive oil" },
                    { 9, 1, "½ inch ginger" },
                    { 10, 1, "2 vegetable stock cubes" },
                    { 11, 2, "50g ground peanuts" },
                    { 12, 2, "675g spinach (or pumpkin leaves)" },
                    { 13, 2, "1 fresh chilli (chopped)" },
                    { 14, 2, "180g coarse Semolina" },
                    { 15, 2, "2 medium shallots, finely chopped" },
                    { 16, 2, "3 medium salmon fillets" },
                    { 17, 2, "1 tablespoon ground Crayfish" },
                    { 18, 2, "1 vegetable stock cube" },
                    { 19, 3, "100g spinach and ricotta tortellini" },
                    { 20, 3, "1 tablespoon vegetable seasoning or 1 stock cube" },
                    { 21, 3, "150g frozen mixed vegetables" },
                    { 22, 3, "1 small garlic clove, finely chopped" },
                    { 23, 3, "Large handful fresh parsley, roughly chopped" },
                    { 24, 3, "Black pepper, to taste" },
                    { 25, 3, "100g firm tofu, cut into small cubes" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 3);
        }
    }
}
