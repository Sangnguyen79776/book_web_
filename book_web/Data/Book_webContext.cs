
using book_web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace book_web.Data
{
    public class Book_webContext : IdentityDbContext
    {
        public Book_webContext(DbContextOptions<Book_webContext> options)
            : base(options)
        {
        }
        public DbSet<Book> Book { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<ActivityLog> ActivityLogs { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<BookReview> BookReviews { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<BookClub> BookClubs { get; set; }
        public DbSet<FAQ> FAQs { get; set; }
        public DbSet<ContactInfo> ContactInformations { get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
       public DbSet<BookStatistics> BookStatistics {  get; set; }
        public DbSet<BookStatisticViewModel> BookStatisticViewModel { get; set; }
        public DbSet<ContactForm> ContactForm { get; set; }
        public DbSet<UserViewModel> UserViewModel { get; set; }
        public DbSet<BookViewModel> BookViewModel { get; set; }
        public DbSet<ArticleDetailsViewModel> ArticleDetailsViewModel { get; set; }
        public DbSet<Discount> Discount {  get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //Seed data for User & Role
            SeedUserRole(builder);

            //Seed data for table Genre
            SeedGenre(builder);

            //Seed data for table Book
            SeedBook(builder);
            SeedEvents(builder);
            SeedBookClub(builder);
            SeedFAQ(builder);
            SeedHistory(builder);
            SeedTeamMember(builder);
            SeedBookStatistic(builder);
            
        }
        private void SeedBookStatistic(ModelBuilder builder)
        {
            builder.Entity<BookStatistics>().HasData(
               new BookStatistics
               {
                   Id = 1,
                   BookId = 1,
                   Views= 540,
                   Sales = 1200,
                   Date = DateTime.Now
                   
               },
               new BookStatistics
               {
                   Id = 2,
                   BookId =3,
                   Views = 320,
                   Sales = 985,
                   Date = DateTime.Now
               }



                );
        }
        private void SeedTeamMember(ModelBuilder builder)
        {
            builder.Entity<TeamMember>().HasData(

                new TeamMember
                {
                    Id = 1,
                    Name = "John Doe",
                    Role = "Founder",
                    Bio = "John has always had a passion for literature and decided to create Bookstore XYZ to share that passion with the world.",
                    ImageUrl = "https://th.bing.com/th/id/OIP.61h_9hNpt0FeK2Sig6aQ6wAAAA?w=123&h=183&c=7&r=0&o=5&dpr=1.1&pid=1.7"
                },
                 new TeamMember
                 {
                     Id = 2,
                     Name = "Jane Smith",
                     Role = "Manager",
                     Bio = "Jane manages the daily operations of the bookstore and ensures that customers have the best experience possible.",
                     ImageUrl = "https://th.bing.com/th/id/OIP.xZNh-qFJhf2VICTsPuDf4wHaKj?w=152&h=217&c=7&r=0&o=5&dpr=1.1&pid=1.7"
                 }




                );
        }
        private void SeedHistory(ModelBuilder builder)
        {
            builder.Entity<History>().HasData(
                new History
                {
                    Id = 1,
                    Title = "Our Story",
                    Content = "Founded in 2020, Bookstore XYZ was created with the mission of providing a curated selection of books for avid readers." +
                    " Our bookstore values community, education, and the love of reading."
                }
                );
        }
        private void SeedFAQ(ModelBuilder builder)
        {
            builder.Entity<FAQ>().HasData(
               new FAQ
               {
                   Id = 1,
                   Question = "How do I order?",
                   Answer = "You can order through our website..."
               } ,
               new FAQ
               {
                   Id = 2,
                   Question= "What is your return policy?",
                   Answer = "We accept returns within 30 days..."
               } 
                
                );
        }
        private void SeedBookClub(ModelBuilder builder)
        {
            builder.Entity<BookClub>().HasData(
                new BookClub
                {
                    Id=1,
                    Name = "Sci-Fi Book Club",
                    Description = "A club for fans of science fiction books.",
                    JoinInstructions = "Sign up on our website or visit our store.",
                    MeetingDate = DateTime.Now.AddDays(7),
                    Location = "Bookstore, Downtown"
                },
                new BookClub
                {
                    Id = 2,
                    Name = "Mystery Book Club",
                    Description = "Join our mystery book club for thrilling discussions.",
                    JoinInstructions = "Register at the front desk.",
                    MeetingDate = DateTime.Now.AddDays(14),
                    Location = "Library, Main Street"
                }
                );
        }
        private void SeedEvents(ModelBuilder builder)
        {
            builder.Entity<Event>().HasData(
                new Event
                {
                    Id = 1,
                    Title = "Book Signing with Author XYZ",
                    Description = "Join us for a book signing with Author XYZ.",
                    Date = DateTime.Now.AddDays(10),
                    Location = "Bookstore, Downtown",
                    ImageUrl = "https://th.bing.com/th/id/OIP.bRWnWBnpkJYKbgtPYIIdawHaE5?w=261&h=180&c=7&r=0&o=5&dpr=1.1&pid=1.7"
                },
                new Event
                {
                    Id = 2,
                    Title = "Writing Workshop",
                    Description = "A workshop for aspiring writers.",
                    Date = DateTime.Now.AddDays(30),
                    Location = "Community Center",
                    ImageUrl = "https://th.bing.com/th/id/OIP.wT9mRKIUU-dlHXh0SmCuCwHaGN?w=940&h=788&rs=1&pid=ImgDetMain"
                }
                );
        }
        private void SeedUserRole(ModelBuilder builder)
        {
            //A) Setup IdentityUser
            //1. Create accounts
            var adminAccount = new IdentityUser
            {
                Id = "admin-account",
                UserName = "admin@gmail.com",
                Email = "admin@gmail.com",
                NormalizedUserName = "ADMIN@GMAIL.COM",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                EmailConfirmed = true
            };

            var readerAccount = new IdentityUser
            {
                Id = "reader-account",
                UserName = "reader@gmail.com",
                Email = "reader@gmail.com",
                NormalizedUserName = "READER@GMAIL.COM",
                NormalizedEmail = "READER@GMAIL.COM",
                EmailConfirmed = true
            };

            //2. Declare hasher for password encryption
            var hasher = new PasswordHasher<IdentityUser>();

            //3. Setup password for accounts
            adminAccount.PasswordHash = hasher.HashPassword(adminAccount, "123456");
            readerAccount.PasswordHash = hasher.HashPassword(readerAccount, "123456");

            //4. Add accounts to database
            builder.Entity<IdentityUser>().HasData(adminAccount, readerAccount);

            //B) Setup IdentityRole
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "admin-role",
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                 new IdentityRole
                 {
                     Id = "reader-role",
                     Name = "Reader",
                     NormalizedName = "READER"
                 });

            //C) Setup IdentityUserRole
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    UserId = "admin-account",
                    RoleId = "admin-role"
                },
                new IdentityUserRole<string>
                {
                    UserId = "reader-account",
                    RoleId = "reader-role"
                }
             );
        }

        private void SeedGenre(ModelBuilder builder)
        {
            builder.Entity<Genre>().HasData(
                new Genre
                {
                    GenreId = 1,
                    GenreName = "Programming"

                },
                new Genre
                {
                    GenreId = 2,
                    GenreName = "Self-help"
                },
                new Genre
                {
                    GenreId = 3,
                    GenreName = "Novel"
                }
             );
        }

        private void SeedBook(ModelBuilder builder)
        {
            builder.Entity<Book>().HasData(
                new Book
                {
                    BookId = 1,
                    BookTitle = "Clean Code",
                    BookPrice = 12.34,
                    BookCover = "https://images-na.ssl-images-amazon.com/images/I/51E2055ZGUL.jpg",
                    Author= "Robert C. Martin",
                    Rating=7.6,
                    SalesCount=50,
                    StockQuantity =250,
                    GenreId = 1,
                    DateAdded = DateTime.Now.AddMonths(-5),
                    IsLimitedEdition = false,
                    PublishedDate = DateTime.Now.AddYears(-7),   
                    LastUpdated = DateTime.Now,
                },
                new Book
                {
                    BookId = 2,
                    BookTitle = "The Mindfulness Journal",
                    BookPrice = 9.99,
                    BookCover = "https://m.media-amazon.com/images/I/91nJdrcNBtL._AC_UF1000,1000_QL80_.jpg",
                    Author = "Corinne Sweet",
                    Rating = 8.6,
                    SalesCount = 50,
                    StockQuantity = 175,
                    GenreId = 2,
                    DateAdded= DateTime.Now.AddMonths(-7),
                    IsLimitedEdition = false,
                    PublishedDate = DateTime.Now.AddYears(-5),
                    LastUpdated = DateTime.Now,


                },
                new Book
                {
                    BookId = 3,
                    BookTitle = "Harry Porter",
                    BookPrice = 6.78,

                    BookCover = "https://nhasachphuongnam.com/images/detailed/160/81YOuOGFCJL.jpg",
                    Author = "J.K.Rowling",
                    Rating = 9.6,
                    SalesCount = 750,
                    StockQuantity = 35,
                    GenreId = 3,
                    DateAdded=DateTime.Now.AddMonths(-8),
                    IsLimitedEdition = true,
                    PublishedDate = DateTime.Now.AddYears(-6),
                    LastUpdated = DateTime.Now,
                }
             );
        }
    }
}
