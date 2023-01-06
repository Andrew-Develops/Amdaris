using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Seeding
{
    public class Module3Seeding
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Room>().HasData(
            new Room
            {
                Id = 1,
                RoomNumber = 101,
                RoomTypeId = 1
            },
            new Room
            {
                Id = 2,
                RoomNumber = 102,
                RoomTypeId = 1
            },
            new Room
            {
                Id = 3,
                RoomNumber = 103,
                RoomTypeId = 2
            },
            new Room
            {
                Id = 4,
                RoomNumber = 104,
                RoomTypeId = 2
            },
            new Room
            {
                Id = 5,
                RoomNumber = 105,
                RoomTypeId = 3
            }
        );

            modelBuilder.Entity<RoomType>().HasData(
            new RoomType
            {
                Id = 1,
                Title = "Standard Room",
                Description = "A standard room with a queen-size bed and a private bathroom.",
                Price = 99.99m
            },
            new RoomType
            {
                Id = 2,
                Title = "Deluxe Room",
                Description = "A deluxe room with a king-size bed, a private bathroom, and a balcony.",
                Price = 149.99m
            },
            new RoomType
            {
                Id = 3,
                Title = "Suite",
                Description = "A suite with a king-size bed, a private bathroom, a living room, and a kitchenette.",
                Price = 199.99m
            }
        );

            modelBuilder.Entity<Guest>().HasData(
            new Guest
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe"
            },
            new Guest
            {
                Id = 2,
                FirstName = "Jane",
                LastName = "Doe"
            },
            new Guest
            {
                Id = 3,
                FirstName = "Bob",
                LastName = "Smith"
            },
            new Guest
            {
                Id = 4,
                FirstName = "Alice",
                LastName = "Smith"
            },
            new Guest
            {
                Id = 5,
                FirstName = "Tom",
                LastName = "Johnson"
            }
        );

            modelBuilder.Entity<Booking>().HasData(
            new Booking
            {
                Id = 1,
                RoomId = 1,
                GuestId = 1,
                StartDate = new DateTime(2022, 1, 1),
                EndDate = new DateTime(2022, 1, 3),
                CheckedIn = true,
                TotalCost = 299.97m
            },
            new Booking
            {
                Id = 2,
                RoomId = 2,
                GuestId = 2,
                StartDate = new DateTime(2022, 2, 1),
                EndDate = new DateTime(2022, 2, 3),
                CheckedIn = true,
                TotalCost = 299.97m
            },
            new Booking
            {
                Id = 3,
                RoomId = 3,
                GuestId = 3,
                StartDate = new DateTime(2022, 3, 1),
                EndDate = new DateTime(2022, 3, 3),
                CheckedIn = true,
                TotalCost = 449.95m
            },
            new Booking
            {
                Id = 4,
                RoomId = 4,
                GuestId = 4,
                StartDate = new DateTime(2022, 4, 1),
                EndDate = new DateTime(2022, 4, 3),
                CheckedIn = true,
                TotalCost = 449.95m
            },
            new Booking
            {
                Id = 5,
                RoomId = 5,
                GuestId = 5,
                StartDate = new DateTime(2022, 5, 1),
                EndDate = new DateTime(2022, 5, 3),
                CheckedIn = true,
                TotalCost = 599.93m
            }
        );
        }
    }
}