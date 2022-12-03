using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SaiGonHiker.DataAccessor.Entities;
using System;

namespace SaiGonHiker.DataAccessor.Data.Seeds
{
    public static class TourDataInitializer
    {
        public static void SeedTourData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tour>().HasData(
                new Tour { 
                    Id = 1,
                    Name = "A1",
                    Address = "Tour1",
                    Region = "Northern",
                    Description = "Description Tour1",
                    Price = 500000,
                    DateOfDeparture = DateTime.Parse("2022-05-25"),
                    DateOfArrival = DateTime.Parse("2022-05-27"),
                    Image = "https://media.travelmag.vn/files/tuannam/2020/09/13/1_-hoat-dong-mao-hiem-thu-thach-thu-hut-khach-du-lich-1618.jpg",
                    IsDelete = false
                },
                new Tour { 
                    Id = 2,
                    Name = "A2",
                    Address = "Tour2",
                    Region = "Central",
                    Description = "Description Tour2",
                    Price = 1500000,
                    DateOfDeparture = DateTime.Parse("2022-06-15"),
                    DateOfArrival = DateTime.Parse("2022-06-19"),
                    Image = "https://media.travelmag.vn/files/tuannam/2020/09/13/1_-hoat-dong-mao-hiem-thu-thach-thu-hut-khach-du-lich-1618.jpg",
                    IsDelete = false
                },
                new Tour { 
                    Id = 3,
                    Name = "A3",
                    Address = "Tour3",
                    Region = "Southern",
                    Description = "Description Tour3",
                    Price = 1000000,
                    DateOfDeparture = DateTime.Parse("2022-05-25"),
                    DateOfArrival = DateTime.Parse("2022-05-27"),
                    Image = "https://media.travelmag.vn/files/tuannam/2020/09/13/1_-hoat-dong-mao-hiem-thu-thach-thu-hut-khach-du-lich-1618.jpg",
                    IsDelete = false
                },
                new Tour { 
                    Id = 4,
                    Name = "A4",
                    Address = "Tour4",
                    Region = "Northern",
                    Description = "Description Tour4",
                    Price = 500000,
                    DateOfDeparture = DateTime.Parse("2022-05-25"),
                    DateOfArrival = DateTime.Parse("2022-05-27"),
                    Image = "https://media.travelmag.vn/files/tuannam/2020/09/13/1_-hoat-dong-mao-hiem-thu-thach-thu-hut-khach-du-lich-1618.jpg",
                    IsDelete = false
                }, 
                new Tour { 
                    Id = 5,
                    Name = "A5",
                    Address = "Tour5",
                    Region = "Northern",
                    Description = "Description Tour5",
                    Price = 500000,
                    DateOfDeparture = DateTime.Parse("2022-05-25"),
                    DateOfArrival = DateTime.Parse("2022-05-27"),
                    Image = "https://media.travelmag.vn/files/tuannam/2020/09/13/1_-hoat-dong-mao-hiem-thu-thach-thu-hut-khach-du-lich-1618.jpg",
                    IsDelete = false
                },
                new Tour { 
                    Id = 6,
                    Name = "A6",
                    Address = "Tour6",
                    Region = "Southern",
                    Description = "Description Tour6",
                    Price = 500000,
                    DateOfDeparture = DateTime.Parse("2022-05-25"),
                    DateOfArrival = DateTime.Parse("2022-05-27"),
                    Image = "https://media.travelmag.vn/files/tuannam/2020/09/13/1_-hoat-dong-mao-hiem-thu-thach-thu-hut-khach-du-lich-1618.jpg",
                    IsDelete = false
                },
                new Tour { 
                    Id = 7,
                    Name = "A7",
                    Address = "Tour7",
                    Region = "Central",
                    Description = "Description Tour7",
                    Price = 500000,
                    DateOfDeparture = DateTime.Parse("2022-05-25"),
                    DateOfArrival = DateTime.Parse("2022-05-27"),
                    Image = "https://media.travelmag.vn/files/tuannam/2020/09/13/1_-hoat-dong-mao-hiem-thu-thach-thu-hut-khach-du-lich-1618.jpg",
                    IsDelete = false
                },
                new Tour { 
                    Id = 8,
                    Name = "A8",
                    Address = "Tour8",
                    Region = "Southern",
                    Description = "Description Tour8",
                    Price = 2500000,
                    DateOfDeparture = DateTime.Parse("2022-05-25"),
                    DateOfArrival = DateTime.Parse("2022-05-27"),
                    Image = "https://media.travelmag.vn/files/tuannam/2020/09/13/1_-hoat-dong-mao-hiem-thu-thach-thu-hut-khach-du-lich-1618.jpg",
                    IsDelete = false
                },
                new Tour { 
                    Id = 9,
                    Name = "A9",
                    Address = "Tour9",
                    Region = "Central",
                    Description = "Description Tour9",
                    Price = 3500000,
                    DateOfDeparture = DateTime.Parse("2022-05-25"),
                    DateOfArrival = DateTime.Parse("2022-05-27"),
                    Image = "https://media.travelmag.vn/files/tuannam/2020/09/13/1_-hoat-dong-mao-hiem-thu-thach-thu-hut-khach-du-lich-1618.jpg",
                    IsDelete = false
                },
                new Tour { 
                    Id = 10,
                    Name = "A10",
                    Address = "Tour10",
                    Region = "Southern",
                    Description = "Description Tour10",
                    Price = 1500000,
                    DateOfDeparture = DateTime.Parse("2022-05-25"),
                    DateOfArrival = DateTime.Parse("2022-05-27"),
                    Image = "https://media.travelmag.vn/files/tuannam/2020/09/13/1_-hoat-dong-mao-hiem-thu-thach-thu-hut-khach-du-lich-1618.jpg",
                    IsDelete = false
                },
                new Tour { 
                    Id = 11,
                    Name = "A11",
                    Address = "Tour11",
                    Region = "Central",
                    Description = "Description Tour11",
                    Price = 4500000,
                    DateOfDeparture = DateTime.Parse("2022-05-25"),
                    DateOfArrival = DateTime.Parse("2022-05-27"),
                    Image = "https://media.travelmag.vn/files/tuannam/2020/09/13/1_-hoat-dong-mao-hiem-thu-thach-thu-hut-khach-du-lich-1618.jpg",
                    IsDelete = false
                }
            );
        }
    }
}