using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PustokMVCApp.Models;

namespace PustokMVCApp.Data.Configirations
{
    public class BookTagConfigiration : IEntityTypeConfiguration<BookTag>
    {
     

        public void Configure(EntityTypeBuilder<BookTag> builder)
        {
            builder.HasKey(bt => new { bt.BookId, bt.TagId });
        }
    }
}