using Hospital.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hospital.Infrustructure.Data.EntityConfigurations
{
    public class BedConfig : IEntityTypeConfiguration<Bed>
    {
        public void Configure(EntityTypeBuilder<Bed> builder)
        {
            builder.ToTable("Beds");
            builder.HasKey(b => b.Id);
            builder.Property(b => b.BedNumber).IsRequired().HasMaxLength(50);


            builder.HasOne(b => b.Room)
            .WithMany(r => r.Beds)
            .HasForeignKey(b => b.RoomId)
            .OnDelete(DeleteBehavior.Cascade);


          
        }
    }
}
