using System;
using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace MovieAPI_IonHH.Context;

public static class ModelBuilderExtensions
{
	public static void Seed(this ModelBuilder modelBuilder)
	{
        modelBuilder.Entity<Movies>().HasData(
            new Movies { MovieId = 1, Title = "Strange World", Overview = "", IsDeleted = false, Runtime = 102, Year = "2022" },
            new Movies { MovieId = 2, Title = "Black Adam", Overview = "", IsDeleted = false, Runtime = 103, Year = "2022" },
            new Movies { MovieId = 3, Title = "R.I.P.D. 2: Rise of the Damned", Overview = "", IsDeleted = false, Runtime = 104, Year = "2022" },
            new Movies { MovieId = 4, Title = "Black Panther: Wakanda Forever", Overview = "", IsDeleted = false, Runtime = 105, Year = "2022" },
            new Movies { MovieId = 5, Title = "Disenchanted", Overview = "", IsDeleted = false, Runtime = 102, Year = "2022" },
            new Movies { MovieId = 6, Title = "Smile", Overview = "", IsDeleted = false, Runtime = 102, Year = "2022" },
            new Movies { MovieId = 7, Title = "Terrifier 2", Overview = "", IsDeleted = false, Runtime = 102, Year = "2022" },
            new Movies { MovieId = 8, Title = "Sniper: The White Raven", Overview = "", IsDeleted = false, Runtime = 102, Year = "2022" },
            new Movies { MovieId = 9, Title = "Paradise City", Overview = "", IsDeleted = false, Runtime = 102, Year = "2022" },
            new Movies { MovieId = 10, Title = "Hex", Overview = "", IsDeleted = false, Runtime = 102, Year = "2022" },
            new Movies { MovieId = 11, Title = "Medieval", Overview = "", IsDeleted = false, Runtime = 102, Year = "2022" },
            new Movies { MovieId = 12, Title = "Jeepers Creepers: Reborn", Overview = "", IsDeleted = false, Runtime = 102, Year = "2022" },
            new Movies { MovieId = 13, Title = "The Lair", Overview = "", IsDeleted = false, Runtime = 102, Year = "2022" },
            new Movies { MovieId = 14, Title = "Tad the Lost Explorer and the Emerald Tablet", Overview = "", IsDeleted = false, Runtime = 102, Year = "2022" },
            new Movies { MovieId = 15, Title = "Emily the Criminal", Overview = "", IsDeleted = false, Runtime = 102, Year = "2022" },
            new Movies { MovieId = 16, Title = "Lost Bullet 2", Overview = "", IsDeleted = false, Runtime = 102, Year = "2022" },
            new Movies { MovieId = 17, Title = "Enola Holmes 2", Overview = "", IsDeleted = false, Runtime = 102, Year = "2022" },
            new Movies { MovieId = 18, Title = "The Menu", Overview = "", IsDeleted = false, Runtime = 102, Year = "2022" },
            new Movies { MovieId = 19, Title = "On the Line", Overview = "", IsDeleted = false, Runtime = 102, Year = "2022" },
            new Movies { MovieId = 20, Title = "MexZombies", Overview = "", IsDeleted = false, Runtime = 102, Year = "2022" },
            new Movies { MovieId = 21, Title = "Margaux", Overview = "", IsDeleted = false, Runtime = 102, Year = "2022" },
            new Movies { MovieId = 22, Title = "All Quiet on the Western Front", Overview = "", IsDeleted = false, Runtime = 102, Year = "2022" },
            new Movies { MovieId = 23, Title = "Beast", Overview = "", IsDeleted = false, Runtime = 102, Year = "2022" },
            new Movies { MovieId = 24, Title = "Corrective Measures", Overview = "", IsDeleted = false, Runtime = 102, Year = "2022" },
            new Movies { MovieId = 25, Title = "Avatar: The Way of Water\n", Overview = "", IsDeleted = false, Runtime = 102, Year = "2022" },
            new Movies { MovieId = 26, Title = "Overdose", Overview = "", IsDeleted = false, Runtime = 102, Year = "2022" },
            new Movies { MovieId = 27, Title = "The Soccer Football Movie", Overview = "", IsDeleted = false, Runtime = 102, Year = "2022" },
            new Movies { MovieId = 28, Title = "The Friendship Game", Overview = "", IsDeleted = false, Runtime = 102, Year = "2022" },
            new Movies { MovieId = 29, Title = "Cuando Sea Joven", Overview = "", IsDeleted = false, Runtime = 102, Year = "2022" },
            new Movies { MovieId = 30, Title = "Tom and Jerry Snowman's Land", Overview = "", IsDeleted = false, Runtime = 102, Year = "2022" },
            new Movies { MovieId = 31, Title = "Blade of the 47 Ronin", Overview = "", IsDeleted = false, Runtime = 102, Year = "2022" },
            new Movies { MovieId = 32, Title = "Avatar", Overview = "", IsDeleted = false, Runtime = 102, Year = "2022" },
            new Movies { MovieId = 33, Title = "Thor: Love and Thunder", Overview = "", IsDeleted = false, Runtime = 102, Year = "2022" },
            new Movies { MovieId = 34, Title = "Spider-Man: No Way Home", Overview = "", IsDeleted = false, Runtime = 102, Year = "2022" },
            new Movies { MovieId = 35, Title = "The School for Good and Evil", Overview = "", IsDeleted = false, Runtime = 102, Year = "2022" },
            new Movies { MovieId = 36, Title = "Jurassic World Dominion", Overview = "", IsDeleted = false, Runtime = 103, Year = "2021" },
            new Movies { MovieId = 37, Title = "Watcher", Overview = "", IsDeleted = false, Runtime = 102, Year = "2021" },
            new Movies { MovieId = 38, Title = "Top Gun: Maverick", Overview = "", IsDeleted = false, Runtime = 103, Year = "2021" },
            new Movies { MovieId = 39, Title = "Bullet Train", Overview = "", IsDeleted = false, Runtime = 102, Year = "2021" },
            new Movies { MovieId = 40, Title = "The Red Book Ritual", Overview = "", IsDeleted = false, Runtime = 103, Year = "2021" },
            new Movies { MovieId = 41, Title = "The Invitation", Overview = "", IsDeleted = false, Runtime = 102, Year = "2021" },
            new Movies { MovieId = 42, Title = "To Kill the Beast", Overview = "", IsDeleted = false, Runtime = 102, Year = "2020" },
            new Movies { MovieId = 43, Title = "Fullmetal Alchemist: The Final Alchemy", Overview = "", IsDeleted = false, Runtime = 102, Year = "2022" },
            new Movies { MovieId = 44, Title = "Minions: The Rise of Gru", Overview = "", IsDeleted = false, Runtime = 102, Year = "2020" },
            new Movies { MovieId = 45, Title = "Sonic the Hedgehog 2", Overview = "", IsDeleted = false, Runtime = 102, Year = "2020" }
        );

        modelBuilder.Entity<Reviews>().HasData(
            new Reviews { MovieId = 1, ReviewId = 1, Date=DateTime.Now, Description= "Lorem Ipsum is simply dummy text of the printing", IsDeleted = false, Rating=2.5,User ="Testing@mail.com"  },
            new Reviews { MovieId = 1, ReviewId = 2, Date = DateTime.Now, Description = "Lorem Ipsum is simply dummy text of the printing", IsDeleted = false, Rating = 2.5, User = "Testing@mail.com" },
            new Reviews { MovieId = 2, ReviewId = 3, Date = DateTime.Now, Description = "Lorem Ipsum is simply dummy text of the printing", IsDeleted = false, Rating = 2.5, User = "Testing@mail.com" },
            new Reviews { MovieId = 2, ReviewId = 4, Date = DateTime.Now, Description = "Lorem Ipsum is simply dummy text of the printing", IsDeleted = false, Rating = 2.5, User = "Testing@mail.com" },
            new Reviews { MovieId = 3, ReviewId = 5, Date = DateTime.Now, Description = "Lorem Ipsum is simply dummy text of the printing", IsDeleted = false, Rating = 2.5, User = "Testing@mail.com" },
            new Reviews { MovieId = 3, ReviewId = 6, Date = DateTime.Now, Description = "Lorem Ipsum is simply dummy text of the printing", IsDeleted = false, Rating = 2.5, User = "Testing@mail.com" },
            new Reviews { MovieId = 4, ReviewId = 7, Date = DateTime.Now, Description = "Lorem Ipsum is simply dummy text of the printing", IsDeleted = false, Rating = 2.5, User = "Testing@mail.com" },
            new Reviews { MovieId = 4, ReviewId = 8, Date = DateTime.Now, Description = "Lorem Ipsum is simply dummy text of the printing", IsDeleted = false, Rating = 2.5, User = "Testing@mail.com" },
            new Reviews { MovieId = 5, ReviewId = 9, Date = DateTime.Now, Description = "Lorem Ipsum is simply dummy text of the printing", IsDeleted = false, Rating = 2.5, User = "Testing@mail.com" },
            new Reviews { MovieId = 5, ReviewId = 10, Date = DateTime.Now, Description = "Lorem Ipsum is simply dummy text of the printing", IsDeleted = false, Rating = 2.5, User = "Testing@mail.com" }
        );
    }
}

