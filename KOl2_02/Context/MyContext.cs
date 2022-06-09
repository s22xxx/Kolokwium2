using KOl2_02.Entities;
using KOl2_02.Entities.Configuration;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace KOl2_02.Context
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options)
        {
        }

        protected MyContext()
        {
        }

        public DbSet<Musician> Musicians { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<MusicLabel> MusicLabel { get; set; }

        public  DbSet<Musician_Track> Musician_Tracks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Track>().HasData(new Musician
            {
                IdMuscian = 1,
                FirstName = "1",
                LastName = "1",
                NickName = "1"
                
            },
            new Musician
            {
                IdMuscian = 2,
                FirstName = "2",
                LastName = "2",
                NickName = "2"
            }, new Musician
            {
                IdMuscian = 3,
                FirstName = "3",
                LastName = "3",
                NickName = "3"
            });

            modelBuilder.Entity<Musician>().HasData(new Track
            {
                IdTrack = 1,
                TrackName = "1",
                Duration = 1,
                IdMusciAlbum = 1

            }, new Track
            {
                IdTrack = 2,
                TrackName = "2",
                Duration = 2,
                IdMusciAlbum = 2


            }, new Track
            {
                IdTrack = 3,
                TrackName = "3",
                Duration = 3,
                IdMusciAlbum = 3
            },
            new Track
            {
                IdTrack = 4,
                TrackName = "4",
                Duration = 4,
                IdMusciAlbum = 4
            }); ;

            modelBuilder.Entity<Musician_Track>().HasData(new Musician_Track
            {
                IdMusician = 1,
                IdTrack = 1
            },
            new Musician_Track
            {
                IdMusician = 2,
                IdTrack = 2
            });


            modelBuilder.Entity<Album>().HasData(new Album
            {
                IdAlbum = 1,
                AlbumName = "1"
            },
            new Album
            {
                IdAlbum = 2,
                AlbumName = "2"
            });



        modelBuilder.Entity<MusicLabel>().HasData(new MusicLabel
            {
                IdMusicLabel= 1,
                Name = "1"
            },
            new MusicLabel
            {
                IdMusicLabel = 2,
                Name = "2"
            });




            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Musician_TrackConfiguration).GetTypeInfo().Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AlbumConfiguration).GetTypeInfo().Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TrackConfiguration).GetTypeInfo().Assembly);

        }

        

}
}
