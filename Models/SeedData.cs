using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcLotion.Data;
using System;
using System.Linq;

namespace MvcLotion.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcLotionContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcLotionContext>>()))
            {
                // Look for any movies.
                if (context.Lotion.Any())
                {
                    return;   // DB has been seeded
                }

                context.Lotion.AddRange(
                    new Lotion
                    {
                        LotionName = "Vaseline Original Healing Jelly",
                        LotionType = "Cream",
                        Color = "Blue",
                        LaunchDate = DateTime.Parse("2020-2-12"),
                        Volume = 375,
                        Price = 4.47M,
                        Rating = 4.8M
                    },

                        new Lotion
                        {
                            LotionName = "Vaseline Original Petroleum Jelly",
                            LotionType = "Cream",
                            Color = "White",
                            LaunchDate = DateTime.Parse("2022-6-19"),
                            Volume = 215,
                            Price = 3.47M,
                            Rating = 4.8M
                        },
                             new Lotion
                             {
                                 LotionName = "Aveeno Baby Eczema Care",
                                 LotionType = "Moisturizing Cream",
                                 Color = "grey",
                                 LaunchDate = DateTime.Parse("2023-2-12"),
                                 Volume = 100,
                                 Price = 12.27M,
                                 Rating = 4.3M
                             },
                              new Lotion
                              {
                                  LotionName = "Eucerin Aquaphor Healing Multi-purpose Ointment for Dry, Cracked Skin",
                                  LotionType = "Ointment",
                                  Color = "White",
                                  LaunchDate = DateTime.Parse("2022-6-12"),
                                  Volume = 50,
                                  Price = 9.97M,
                                  Rating = 4.4M
                              },
                               new Lotion
                               {
                                   LotionName = "Neutrogena Hydro Boost Unscented Gel",
                                   LotionType = "Gel",
                                   Color = "Blue",
                                   LaunchDate = DateTime.Parse("2020-2-2"),
                                   Volume = 100,
                                   Price = 15.97M,
                                   Rating = 4.6M
                               },
                                new Lotion
                                {
                                    LotionName = "NIVEA Firming Body Lotion ",
                                    LotionType = "Lotion",
                                    Color = "White",
                                    LaunchDate = DateTime.Parse("2019-2-12"),
                                    Volume = 100,
                                    Price = 8.87M,
                                    Rating = 4.1M
                                },
                                 new Lotion
                                 {
                                     LotionName = "Vaseline Rosy Lip Therapy",
                                     LotionType = "Balm",
                                     Color = "Red",
                                     LaunchDate = DateTime.Parse("2023-7-12"),
                                     Volume = 50,
                                     Price = 8.47M,
                                     Rating = 4
                                 },
                                  new Lotion
                                  {
                                      LotionName = "Hempz Original Herbal Moisturizer",
                                      LotionType = "Moisturizer",
                                      Color = "White",
                                      LaunchDate = DateTime.Parse("2022-8-12"),
                                      Volume = 100,
                                      Price = 21.97M,
                                      Rating = 4.9M
                                  },
                                   new Lotion
                                   {
                                       LotionName = "Vaseline Intensive Care",
                                       LotionType = "Lotion",
                                       Color = "Gold",
                                       LaunchDate = DateTime.Parse("2019-8-12"),
                                       Volume = 600,
                                       Price = 7.27M,
                                       Rating = 4.5M
                                   },
                                    new Lotion
                                    {
                                        LotionName = "Lubriderm Unscented Body Lotion for Normal to Dry Skin, Fragrance Free,",
                                        LotionType = "Lotion",
                                        Color = "Grey",
                                        LaunchDate = DateTime.Parse("2022-9-22"),
                                        Volume = 480,
                                        Price = 9.97M,
                                        Rating = 3.9M
                                    }
                );
                context.SaveChanges();
            }
        }
    }
}