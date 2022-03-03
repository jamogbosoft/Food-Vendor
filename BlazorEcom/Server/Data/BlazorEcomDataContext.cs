
namespace BlazorEcom.Server.Data
{
    public class BlazorEcomDataContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {           
            modelBuilder.Entity<Food>(entity => { entity.Property(e => e.ImageUrl).IsRequired(); });

            #region BlogSeed
            modelBuilder.Entity<Food>().HasData(
                new Food
                {
                    FoodId = 1,
                    Name = "Nigerian-inspired Vegan Egusi (Melon) Seed Stew with Tofu",
                    Description = "Nigerian-inspired, protein-rich vegan egusi stew. Enjoy this with rice, yams, plantains, sweet or regular potatoes.",
                    ImageUrl = "https://i0.wp.com/somiigbene.com/wp-content/uploads/2019/12/Nigerian-inspired-vegan-egusi-ii.jpeg?resize=1152%2C1536&ssl=1",
                    
                    Instruction = @"Preheat the oven to 200C. Line a baking tray with baking paper then evenly distribute tofu on the tray and bake for 25 minutes, turning halfway through cooking until all sides are golden then set aside and keep warm.
                        Put the tomatoes, red onion, garlic cloves, bell pepper, ginger and chilli in a food processor and blitz to form a smooth liquid. Tip the mixture into a medium saucepan and cook on a medium heat for 25 minutes until the sauce reduces to a very thick paste.
                        Heat the olive oil in another saucepan over medium heat. Once hot, add the ground egusi and fry, stirring frequently for 4 minutes. Stir in the tomato paste, fry for an additional two minutes then add around 200ml of water. Add the vegetable stock cube and adjust seasoning as needed with salt pepper. Allow to cook on medium heat for 3 minutes then add kale and tofu. Cook for 4-5 minutes or until the kale is tender then serve over rice.",
                    Price = 350.0f
                },

            new Food
            {
                FoodId = 2,
                Name = "Groundnut and Spinach Stew with Cornmeal",
                Description = "A tasty groundnut soup with spinach, baked salmon and cornmeal",
                ImageUrl = "https://i0.wp.com/somiigbene.com/wp-content/uploads/2021/01/GROUNDNUT-SPINACH-AND-CORNMEAL.png?w=1000&ssl=1",
                
                Instruction = @"For the peanut soup
                        Heat 300ml of water in a medium saucepan, add shallots, chilli, vegetable stock cube and ground peanuts.
                        Cook on medium heat for 15 minutes. Stir in spinach and Crayfish then season with a pinch of salt if needed.
                        Cook for 3 minutes (5-6 minutes if usuing pumpkin leaves) then take the pan off the heat and set aside.
                        For the cornmeal
                        Tip the cornmeal into a large bowl then add around 250ml of water to form a loose paste. Tip into a large, non-stick pan then place the pan on a very low heat.
                        Keep stirring with a wooden cooking spoon over low heat for around 20 minutes, adding small amounts of water to cook the semolina and thicken it.
                        Once the cornmeal is cooked and thickens such that it sticks to a wooden spoon, take the pan off the heat and allow it cool. Divide the semolina into three equal portions then mould into a round ball.
                        For the salmon
                        Season with salt and black pepper or fish seasoning and dried herbs. Place a baking tray lined with parchment paper and bake for 15 minutes in the oven, turning it halfway through cooking.
                        Serve the cornmeal with the spinach and peanut soup and baked salmon. Garnish with chilli flakes if you wish. Enjoy!",
                Price = 550.0f
            },

            new Food
            {
                FoodId = 3,
                Name = "10-Minute Tortellini Soup",
                Description = "Effortless tortellini soup with mixed vegetables and tofu",
                ImageUrl = "https://i0.wp.com/somiigbene.com/wp-content/uploads/2020/11/10-minute-Tortellini-Soup.jpg?fit=1920%2C2400&ssl=1",
                
                Instruction = @"Add approximately 300ml of boiling water to a medium saucepan. Add garlic, vegetable seasoning and mixed vegetables to the pan then cook for 6 minutes.
                    Add tofu and tortellini. Cook for 3 minutes or until the tortellini is tender and floats to the top. Stir in fresh parsley then take the pan off the heat.
                    To serve, transfer to a bowl, sprinkle black pepper and extra fresh parsley. You can add parmesan and a drizzle of olive oil if you wish.",
                Price = 450.0f
            });
            #endregion

            modelBuilder.Entity<Ingredient>(
            entity =>
            {
                entity.HasOne(d => d.Food)
                    .WithMany(p => p.Ingredients)
                    .HasForeignKey("FoodId");
            });

            #region PostSeed
            modelBuilder.Entity<Ingredient>().HasData(

                  new Ingredient
                  {                      
                      FoodId = 1,
                      IngredientId = 1,
                      Name = "400 g tin plum tomatoes"

                  },
                  new Ingredient
                  {
                      FoodId = 1,
                      IngredientId = 2,                      
                      Name = "1 large red onion, peeled and quartered"
                  },
                  new Ingredient
                  {
                      FoodId = 1,
                      IngredientId = 3,
                      Name = "3 medium garlic cloves"
                  },
                   new Ingredient
                   {
                       FoodId = 1,
                       IngredientId = 4,                       
                       Name = "1 large red chilli"
                   },
                   new Ingredient
                   {
                       FoodId = 1,
                       IngredientId = 5,
                       Name = "1 large red bell pepper"
                   },
                   new Ingredient
                   {
                       FoodId = 1,
                       IngredientId = 6,
                       Name = "1 pack tofu, drained and cubed"
                   },
                   new Ingredient
                   {
                       FoodId = 1,
                       IngredientId = 7,
                       Name = "4 tablespoon ground egusi (melon seeds)"
                   },
                   new Ingredient
                   {
                       FoodId = 1,
                       IngredientId = 8,
                       Name = "2 tablespoon olive oil"
                   },
                   new Ingredient
                   {
                       FoodId = 1,
                       IngredientId = 9,
                       Name = "½ inch ginger"
                   },
                   new Ingredient
                   {
                       FoodId = 1,
                       IngredientId = 10,
                       Name = "2 vegetable stock cubes"
                   },

                  new Ingredient
                  {
                      FoodId = 2,
                      IngredientId = 11,                      
                      Name = "50g ground peanuts"
                  },
                  new Ingredient
                  {
                      FoodId = 2,
                      IngredientId = 12,
                      Name = "675g spinach (or pumpkin leaves)"
                  },
                  new Ingredient
                  {
                      FoodId = 2,
                      IngredientId = 13,
                      Name = "1 fresh chilli (chopped)"
                  },
                   new Ingredient
                   {
                       FoodId = 2,
                       IngredientId = 14,
                       Name = "180g coarse Semolina"
                   },
                   new Ingredient
                   {
                       FoodId = 2,
                       IngredientId = 15,
                       Name = "2 medium shallots, finely chopped"
                   },
                   new Ingredient
                   {
                       FoodId = 2,
                       IngredientId = 16,
                       Name = "3 medium salmon fillets"
                   },
                   new Ingredient
                   {
                       FoodId = 2,
                       IngredientId = 17,
                       Name = "1 tablespoon ground Crayfish"
                   },
                   new Ingredient
                   {
                       FoodId = 2,
                       IngredientId = 18,
                       Name = "1 vegetable stock cube"
                   },

                  new Ingredient
                  {
                      FoodId = 3,
                      IngredientId = 19,
                      Name = "100g spinach and ricotta tortellini"
                  },
                  new Ingredient
                  {
                      FoodId = 3,
                      IngredientId = 20,
                      Name = "1 tablespoon vegetable seasoning or 1 stock cube"
                  },
                  new Ingredient
                  {
                      FoodId = 3,
                      IngredientId = 21,
                      Name = "150g frozen mixed vegetables"
                  },
                   new Ingredient
                   {
                       FoodId = 3,
                       IngredientId = 22,
                       Name = "1 small garlic clove, finely chopped"
                   },
                   new Ingredient
                   {
                       FoodId = 3,
                       IngredientId = 23,
                       Name = "Large handful fresh parsley, roughly chopped"
                   },
                   new Ingredient
                   {
                       FoodId = 3,
                       IngredientId = 24,
                       Name = "Black pepper, to taste"
                   },
                   new Ingredient
                   {
                       FoodId = 3,
                       IngredientId = 25,
                       Name = "100g firm tofu, cut into small cubes"
                   }
               );
            #endregion

            

            ///////////////////////
            ///
            /*
            modelBuilder.Entity<Ingredient>(
            entity =>
            {
                entity.HasOne(d => d.Food)
                    .WithMany(p => p.Ingredients)
                    .HasForeignKey("FoodId");
            });

            modelBuilder.Entity<Food>().HasData(
           new Food
            {
                FoodId = 1,
                Name = "Nigerian-inspired Vegan Egusi (Melon) Seed Stew with Tofu",
                Description = "Nigerian-inspired, protein-rich vegan egusi stew. Enjoy this with rice, yams, plantains, sweet or regular potatoes.",
                ImageUrl = "https://i0.wp.com/somiigbene.com/wp-content/uploads/2019/12/Nigerian-inspired-vegan-egusi-ii.jpeg?resize=1152%2C1536&ssl=1",
                Ingredients = new  List<Ingredient>
                {
                   new Ingredient
                   {
                       IngredientId=1,
                       FoodId = 1,
                       Name="400 g tin plum tomatoes"
                   },
                   new Ingredient
                   {
                       IngredientId=2,
                       FoodId = 1,
                       Name="1 large red onion, peeled and quartered"
                   },
                   new Ingredient
                   {
                       IngredientId=3,
                       FoodId = 1,
                       Name="3 medium garlic cloves"
                   },
                    new Ingredient
                   {
                       IngredientId=4,
                       FoodId = 1,
                       Name="1 large red chilli"
                   },
                    new Ingredient
                   {
                       IngredientId=5,
                       FoodId = 1,
                       Name="1 large red bell pepper"
                   },
                    new Ingredient
                   {
                       IngredientId=6,
                       FoodId = 1,
                       Name="1 pack tofu, drained and cubed"
                   },
                    new Ingredient
                   {
                       IngredientId=7,
                       FoodId = 1,
                       Name="4 tablespoon ground egusi (melon seeds)"
                   },
                    new Ingredient
                   {
                       IngredientId=8,
                       FoodId = 1,
                       Name="2 tablespoon olive oil"
                   },
                    new Ingredient
                   {
                       IngredientId=9,
                       FoodId = 1,
                       Name="½ inch ginger"
                   },
                    new Ingredient
                   {
                       IngredientId=10,
                       FoodId = 1,
                       Name="2 vegetable stock cubes"
                   }
                },
                Instruction = @"Preheat the oven to 200C. Line a baking tray with baking paper then evenly distribute tofu on the tray and bake for 25 minutes, turning halfway through cooking until all sides are golden then set aside and keep warm.
                        Put the tomatoes, red onion, garlic cloves, bell pepper, ginger and chilli in a food processor and blitz to form a smooth liquid. Tip the mixture into a medium saucepan and cook on a medium heat for 25 minutes until the sauce reduces to a very thick paste.
                        Heat the olive oil in another saucepan over medium heat. Once hot, add the ground egusi and fry, stirring frequently for 4 minutes. Stir in the tomato paste, fry for an additional two minutes then add around 200ml of water. Add the vegetable stock cube and adjust seasoning as needed with salt pepper. Allow to cook on medium heat for 3 minutes then add kale and tofu. Cook for 4-5 minutes or until the kale is tender then serve over rice.",
                Price = 350.0f
            },

            new Food
            {
                FoodId = 2,
                Name = "Groundnut and Spinach Stew with Cornmeal",
                Description = "A tasty groundnut soup with spinach, baked salmon and cornmeal",
                ImageUrl = "https://i0.wp.com/somiigbene.com/wp-content/uploads/2021/01/GROUNDNUT-SPINACH-AND-CORNMEAL.png?w=1000&ssl=1",
                Ingredients = new List<Ingredient>
                {
                   new Ingredient
                   {
                       IngredientId=11,
                       FoodId = 2,
                       Name="50g ground peanuts"
                   },
                   new Ingredient
                   {
                       IngredientId=12,
                       FoodId = 2,
                       Name="675g spinach (or pumpkin leaves)"
                   },
                   new Ingredient
                   {
                       IngredientId=13,
                       FoodId = 2,
                       Name="1 fresh chilli (chopped)"
                   },
                    new Ingredient
                   {
                       IngredientId=14,
                       FoodId = 2,
                       Name="180g coarse Semolina"
                   },
                    new Ingredient
                   {
                       IngredientId=15,
                       FoodId = 2,
                       Name="2 medium shallots, finely chopped"
                   },
                    new Ingredient
                   {
                       IngredientId=16,
                       FoodId = 2,
                       Name="3 medium salmon fillets"
                   },
                    new Ingredient
                   {
                       IngredientId=17,
                       FoodId = 2,
                       Name="1 tablespoon ground Crayfish"
                   },
                    new Ingredient
                   {
                       IngredientId=18,
                       FoodId = 2,
                       Name="1 vegetable stock cube"
                   }
                },
                Instruction = @"For the peanut soup
                        Heat 300ml of water in a medium saucepan, add shallots, chilli, vegetable stock cube and ground peanuts.
                        Cook on medium heat for 15 minutes. Stir in spinach and Crayfish then season with a pinch of salt if needed.
                        Cook for 3 minutes (5-6 minutes if usuing pumpkin leaves) then take the pan off the heat and set aside.
                        For the cornmeal
                        Tip the cornmeal into a large bowl then add around 250ml of water to form a loose paste. Tip into a large, non-stick pan then place the pan on a very low heat.
                        Keep stirring with a wooden cooking spoon over low heat for around 20 minutes, adding small amounts of water to cook the semolina and thicken it.
                        Once the cornmeal is cooked and thickens such that it sticks to a wooden spoon, take the pan off the heat and allow it cool. Divide the semolina into three equal portions then mould into a round ball.
                        For the salmon
                        Season with salt and black pepper or fish seasoning and dried herbs. Place a baking tray lined with parchment paper and bake for 15 minutes in the oven, turning it halfway through cooking.
                        Serve the cornmeal with the spinach and peanut soup and baked salmon. Garnish with chilli flakes if you wish. Enjoy!",
                Price = 550.0f
            },

            new Food
            {
                FoodId = 3,
                Name = "10-Minute Tortellini Soup",
                Description = "Effortless tortellini soup with mixed vegetables and tofu",
                ImageUrl = "https://i0.wp.com/somiigbene.com/wp-content/uploads/2020/11/10-minute-Tortellini-Soup.jpg?fit=1920%2C2400&ssl=1",
                Ingredients = new List<Ingredient>
                {
                   new Ingredient
                   {
                       IngredientId=19,
                       FoodId = 3,
                       Name="100g spinach and ricotta tortellini"
                   },
                   new Ingredient
                   {
                       IngredientId=20,
                       FoodId = 3,
                       Name="1 tablespoon vegetable seasoning or 1 stock cube"
                   },
                   new Ingredient
                   {
                       IngredientId=21,
                       FoodId = 3,
                       Name="150g frozen mixed vegetables"
                   },
                    new Ingredient
                   {
                       IngredientId=22,
                       FoodId = 3,
                       Name="1 small garlic clove, finely chopped"
                   },
                    new Ingredient
                   {
                       IngredientId=23,
                       FoodId = 3,
                       Name="Large handful fresh parsley, roughly chopped"
                   },
                    new Ingredient
                   {
                       IngredientId=24,
                       FoodId = 3,
                       Name="Black pepper, to taste"
                   },
                    new Ingredient
                   {
                       IngredientId=25,
                       FoodId = 3,
                       Name="100g firm tofu, cut into small cubes"
                   }
                },
                Instruction = @"Add approximately 300ml of boiling water to a medium saucepan. Add garlic, vegetable seasoning and mixed vegetables to the pan then cook for 6 minutes.
                    Add tofu and tortellini. Cook for 3 minutes or until the tortellini is tender and floats to the top. Stir in fresh parsley then take the pan off the heat.
                    To serve, transfer to a bowl, sprinkle black pepper and extra fresh parsley. You can add parmesan and a drizzle of olive oil if you wish.",
                Price = 450.0f
            });
            */

            /////////////////////

        }
        public BlazorEcomDataContext(DbContextOptions<BlazorEcomDataContext> options)
            : base(options)
        {
        }

        public DbSet<Food> Foods { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
    }

}
