using Microsoft.EntityFrameworkCore;
using MovieDB.Models;

namespace MovieDB.Data
{
    public class ApplicationDBContext : DbContext

    #region Notes

    //ApplicationDbContext is inheriting from DbContext, which is a built-in class provided by Entity Framework
    //The ApplicationDBContext is a class that represents a connection to a database, and it's responsible for tracking changes to data and updating the database accordingly.

    #endregion Notes

    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        { }

        #region Notes

        //The constructor for ApplicationDBContext takes an object called DbContextOptions<ApplicationDBContext> as a parameter. This object contains configuration information about how to connect to the database, like the database provider to use, the database connection string, and other settings.

        //By calling the base(options) method in the constructor, you're passing the DbContextOptions object to the base constructor of the DbContext class, which is what ApplicationDBContext inherits from. This sets up the DbContext with the specified options, so that it knows how to connect to the database when you perform database operations.

        #endregion Notes

        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieGenre> MovieGenres { get; set; }

        #region Notes

        //Defined three DbSet properties in the ApplicationDBContext class, which correspond to the Movie, Genre, and MovieGenre tables in the database.
        //DbSet is a class provided by Entity Framework that represents a table in a database.

        #endregion Notes

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<MovieGenre>()
            //    .HasKey(mg => new { mg.MovieId, mg.GenreId }); //this would have been for setting up a composite key, but we're using a MovieGenreId primary key instead

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<MovieGenre>()
                .HasKey(mg => mg.MovieGenreId);

            modelBuilder.Entity<MovieGenre>()
                .HasOne(mg => mg.Movie)
                .WithMany(m => m.MovieGenres)
                .HasForeignKey(mg => mg.MovieId);

            modelBuilder.Entity<MovieGenre>()
                .HasOne(mg => mg.Genre)
                .WithMany(g => g.MovieGenres)
                .HasForeignKey(mg => mg.GenreId);

            #region Notes

            //1. base.OnModelCreating(modelBuilder);
            //Calls the base class implementation of the OnModelCreating method, which is responsible for setting up the default behavior for entity configuration in Entity Framework.

            //2. modelBuilder.Entity<MovieGenre>().HasKey(mg => mg.MovieGenreId);
            //This specifies that the MovieGenreId property of the MovieGenre class should be used as the primary key in the database.
            //The HasKey method takes a lambda expression (the =>) that specifies the primary key property or properties. In this case, it's just a single property, MovieGenreId.

            //3. modelBuilder.Entity<MovieGenre>().HasOne(mg => mg.Movie).WithMany(m => m.MovieGenres).HasForeignKey(mg => mg.MovieId);
            //This specifies that a MovieGenre can be associated with a single Movie and that a Movie can have multiple MovieGenres. The foreign key property in the MovieGenre table is MovieId.

            //4. modelBuilder.Entity<MovieGenre>().HasOne(mg => mg.Genre).WithMany(g => g.MovieGenres).HasForeignKey(mg => mg.GenreId);
            //This specifies that a MovieGenre can be associated with a single Genre and that a Genre can have multiple MovieGenres. The foreign key property in the MovieGenre table is GenreId.

            #endregion Notes
        }
    }
}