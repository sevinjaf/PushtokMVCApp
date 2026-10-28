using Microsoft.EntityFrameworkCore;
using PustokMVCApp.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PustokMVCApp.Data.Configiration
{
    public class AuthorConfigiration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.Property(a => a.FullName).IsRequired().HasMaxLength(50);
        }
    }
}