using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KOl2_02.Entities.Configuration
{
    public class TrackConfiguration
    {

		public void Configure(EntityTypeBuilder<Track> builder)
		{
			builder.HasKey(e => e.IdTrack).HasName("IdTrack");
			builder.Property(e => e.IdTrack)
				.UseIdentityColumn();
			builder.Property(e => e.IdTrack)
				.IsRequired();

			builder.Property(e => e.TrackName)
				.HasMaxLength(20)
				.IsRequired();

			builder.Property(e => e.Duration)
				.IsRequired();

		}
	}
}
