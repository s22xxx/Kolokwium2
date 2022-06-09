using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KOl2_02.Entities.Configuration
{
    public class Musician_TrackConfiguration : IEntityTypeConfiguration<Musician_Track>
    {
        public void Configure(EntityTypeBuilder<Musician_Track> builder)
        {

            builder.ToTable("Musician_Track");
            builder.HasKey(e => new {e.IdMusician,e.IdTrack});

            builder.HasOne(e=>e.MusicianNavigator)
                .WithMany(e=>e.Musician_Tracks)
                .HasForeignKey(e=>e.IdMusician)
                .OnDelete(DeleteBehavior.NoAction)
                .HasConstraintName("MusicianMusician_Track");

            builder.HasOne(e => e.TrackNavigator)
               .WithMany(e => e.Musician_Tracks)
               .HasForeignKey(e => e.IdTrack)
               .OnDelete(DeleteBehavior.NoAction)
               .HasConstraintName("MusicianMusician_Track");


        }
    }
}
