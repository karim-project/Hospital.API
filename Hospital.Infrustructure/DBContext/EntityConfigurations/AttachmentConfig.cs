using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Net.Mail;
using Attachment = Hospital.Data.Models.Attachment;

namespace Hospital.Infrustructure.Data.EntityConfigurations
{
    public class AttachmentConfig : IEntityTypeConfiguration<Attachment>
    {
        public void Configure(EntityTypeBuilder<Hospital.Data.Models.Attachment> builder)
        {
            builder.ToTable("Attachments");
            builder.HasKey(a => a.Id);
            builder.Property(a => a.FileName).IsRequired().HasMaxLength(200);
            builder.Property(a => a.BlobPath).IsRequired();


            builder.HasOne(a => a.Patient)
            .WithMany()
            .HasForeignKey(a => a.PatientId)
            .OnDelete(DeleteBehavior.SetNull);


            builder.HasOne(a => a.Visit)
            .WithMany(v => v.Attachments)
            .HasForeignKey(a => a.VisitId)
            .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
