using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KOl2_02.Entities.Configuration
{
    public class AlbumConfiguration
    {

		public void Configure(EntityTypeBuilder<Album> builder)
		{
			builder.HasKey(e => e.IdFireTruck).HasName("IdAlbum");
			builder.Property(e => e.IdAlbum)
				.UseIdentityColumn();
			builder.Property(e => e.IdAlbum)
				.IsRequired();

			builder.Property(e => e.AlbumName)
				.HasMaxLength(30)
				.IsRequired();

			builder.HasForeignKey(e => e.IdMusicLabel);

		}
	}
}
