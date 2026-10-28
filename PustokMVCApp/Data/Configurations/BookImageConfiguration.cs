using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PustokMVCApp.Models;

namespace PustokMVCApp.Data.Configirations
{
    public class BookImageConfigiration : IEntityTypeConfiguration<BookImage>
    {
        public void Configure(EntityTypeBuilder<BookImage> builder)
        {
            builder.Property(bi => bi.ImageUrl).IsRequired().HasMaxLength(200);
           
        }
    }
}