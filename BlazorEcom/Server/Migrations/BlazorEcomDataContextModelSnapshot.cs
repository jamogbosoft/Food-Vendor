﻿// <auto-generated />
using System;
using BlazorEcom.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorEcom.Server.Migrations
{
    [DbContext(typeof(BlazorEcomDataContext))]
    partial class BlazorEcomDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BlazorEcom.Shared.Food", b =>
                {
                    b.Property<int>("FoodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FoodId"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Instruction")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("FoodId");

                    b.ToTable("Foods");

                    b.HasData(
                        new
                        {
                            FoodId = 1,
                            Description = "Nigerian-inspired, protein-rich vegan egusi stew. Enjoy this with rice, yams, plantains, sweet or regular potatoes.",
                            ImageUrl = "https://i0.wp.com/somiigbene.com/wp-content/uploads/2019/12/Nigerian-inspired-vegan-egusi-ii.jpeg?resize=1152%2C1536&ssl=1",
                            Instruction = "Preheat the oven to 200C. Line a baking tray with baking paper then evenly distribute tofu on the tray and bake for 25 minutes, turning halfway through cooking until all sides are golden then set aside and keep warm.\r\n                        Put the tomatoes, red onion, garlic cloves, bell pepper, ginger and chilli in a food processor and blitz to form a smooth liquid. Tip the mixture into a medium saucepan and cook on a medium heat for 25 minutes until the sauce reduces to a very thick paste.\r\n                        Heat the olive oil in another saucepan over medium heat. Once hot, add the ground egusi and fry, stirring frequently for 4 minutes. Stir in the tomato paste, fry for an additional two minutes then add around 200ml of water. Add the vegetable stock cube and adjust seasoning as needed with salt pepper. Allow to cook on medium heat for 3 minutes then add kale and tofu. Cook for 4-5 minutes or until the kale is tender then serve over rice.",
                            Name = "Nigerian-inspired Vegan Egusi (Melon) Seed Stew with Tofu",
                            Price = 350.0
                        },
                        new
                        {
                            FoodId = 2,
                            Description = "A tasty groundnut soup with spinach, baked salmon and cornmeal",
                            ImageUrl = "https://i0.wp.com/somiigbene.com/wp-content/uploads/2021/01/GROUNDNUT-SPINACH-AND-CORNMEAL.png?w=1000&ssl=1",
                            Instruction = "For the peanut soup\r\n                        Heat 300ml of water in a medium saucepan, add shallots, chilli, vegetable stock cube and ground peanuts.\r\n                        Cook on medium heat for 15 minutes. Stir in spinach and Crayfish then season with a pinch of salt if needed.\r\n                        Cook for 3 minutes (5-6 minutes if usuing pumpkin leaves) then take the pan off the heat and set aside.\r\n                        For the cornmeal\r\n                        Tip the cornmeal into a large bowl then add around 250ml of water to form a loose paste. Tip into a large, non-stick pan then place the pan on a very low heat.\r\n                        Keep stirring with a wooden cooking spoon over low heat for around 20 minutes, adding small amounts of water to cook the semolina and thicken it.\r\n                        Once the cornmeal is cooked and thickens such that it sticks to a wooden spoon, take the pan off the heat and allow it cool. Divide the semolina into three equal portions then mould into a round ball.\r\n                        For the salmon\r\n                        Season with salt and black pepper or fish seasoning and dried herbs. Place a baking tray lined with parchment paper and bake for 15 minutes in the oven, turning it halfway through cooking.\r\n                        Serve the cornmeal with the spinach and peanut soup and baked salmon. Garnish with chilli flakes if you wish. Enjoy!",
                            Name = "Groundnut and Spinach Stew with Cornmeal",
                            Price = 550.0
                        },
                        new
                        {
                            FoodId = 3,
                            Description = "Effortless tortellini soup with mixed vegetables and tofu",
                            ImageUrl = "https://i0.wp.com/somiigbene.com/wp-content/uploads/2020/11/10-minute-Tortellini-Soup.jpg?fit=1920%2C2400&ssl=1",
                            Instruction = "Add approximately 300ml of boiling water to a medium saucepan. Add garlic, vegetable seasoning and mixed vegetables to the pan then cook for 6 minutes.\r\n                    Add tofu and tortellini. Cook for 3 minutes or until the tortellini is tender and floats to the top. Stir in fresh parsley then take the pan off the heat.\r\n                    To serve, transfer to a bowl, sprinkle black pepper and extra fresh parsley. You can add parmesan and a drizzle of olive oil if you wish.",
                            Name = "10-Minute Tortellini Soup",
                            Price = 450.0
                        });
                });

            modelBuilder.Entity("BlazorEcom.Shared.Ingredient", b =>
                {
                    b.Property<int>("IngredientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IngredientId"), 1L, 1);

                    b.Property<int?>("FoodId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IngredientId");

                    b.HasIndex("FoodId");

                    b.ToTable("Ingredients");

                    b.HasData(
                        new
                        {
                            IngredientId = 1,
                            FoodId = 1,
                            Name = "400 g tin plum tomatoes"
                        },
                        new
                        {
                            IngredientId = 2,
                            FoodId = 1,
                            Name = "1 large red onion, peeled and quartered"
                        },
                        new
                        {
                            IngredientId = 3,
                            FoodId = 1,
                            Name = "3 medium garlic cloves"
                        },
                        new
                        {
                            IngredientId = 4,
                            FoodId = 1,
                            Name = "1 large red chilli"
                        },
                        new
                        {
                            IngredientId = 5,
                            FoodId = 1,
                            Name = "1 large red bell pepper"
                        },
                        new
                        {
                            IngredientId = 6,
                            FoodId = 1,
                            Name = "1 pack tofu, drained and cubed"
                        },
                        new
                        {
                            IngredientId = 7,
                            FoodId = 1,
                            Name = "4 tablespoon ground egusi (melon seeds)"
                        },
                        new
                        {
                            IngredientId = 8,
                            FoodId = 1,
                            Name = "2 tablespoon olive oil"
                        },
                        new
                        {
                            IngredientId = 9,
                            FoodId = 1,
                            Name = "½ inch ginger"
                        },
                        new
                        {
                            IngredientId = 10,
                            FoodId = 1,
                            Name = "2 vegetable stock cubes"
                        },
                        new
                        {
                            IngredientId = 11,
                            FoodId = 2,
                            Name = "50g ground peanuts"
                        },
                        new
                        {
                            IngredientId = 12,
                            FoodId = 2,
                            Name = "675g spinach (or pumpkin leaves)"
                        },
                        new
                        {
                            IngredientId = 13,
                            FoodId = 2,
                            Name = "1 fresh chilli (chopped)"
                        },
                        new
                        {
                            IngredientId = 14,
                            FoodId = 2,
                            Name = "180g coarse Semolina"
                        },
                        new
                        {
                            IngredientId = 15,
                            FoodId = 2,
                            Name = "2 medium shallots, finely chopped"
                        },
                        new
                        {
                            IngredientId = 16,
                            FoodId = 2,
                            Name = "3 medium salmon fillets"
                        },
                        new
                        {
                            IngredientId = 17,
                            FoodId = 2,
                            Name = "1 tablespoon ground Crayfish"
                        },
                        new
                        {
                            IngredientId = 18,
                            FoodId = 2,
                            Name = "1 vegetable stock cube"
                        },
                        new
                        {
                            IngredientId = 19,
                            FoodId = 3,
                            Name = "100g spinach and ricotta tortellini"
                        },
                        new
                        {
                            IngredientId = 20,
                            FoodId = 3,
                            Name = "1 tablespoon vegetable seasoning or 1 stock cube"
                        },
                        new
                        {
                            IngredientId = 21,
                            FoodId = 3,
                            Name = "150g frozen mixed vegetables"
                        },
                        new
                        {
                            IngredientId = 22,
                            FoodId = 3,
                            Name = "1 small garlic clove, finely chopped"
                        },
                        new
                        {
                            IngredientId = 23,
                            FoodId = 3,
                            Name = "Large handful fresh parsley, roughly chopped"
                        },
                        new
                        {
                            IngredientId = 24,
                            FoodId = 3,
                            Name = "Black pepper, to taste"
                        },
                        new
                        {
                            IngredientId = 25,
                            FoodId = 3,
                            Name = "100g firm tofu, cut into small cubes"
                        });
                });

            modelBuilder.Entity("BlazorEcom.Shared.Ingredient", b =>
                {
                    b.HasOne("BlazorEcom.Shared.Food", "Food")
                        .WithMany("Ingredients")
                        .HasForeignKey("FoodId");

                    b.Navigation("Food");
                });

            modelBuilder.Entity("BlazorEcom.Shared.Food", b =>
                {
                    b.Navigation("Ingredients");
                });
#pragma warning restore 612, 618
        }
    }
}