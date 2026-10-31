using PustokMVCApp.Models.Common;

namespace PustokMVCApp.Models
{
    public class Tag : BaseEntity
    {
        public string Name { get; set; } = null!;
        public List<BookTag> BookTags { get; set; } = null!;
    }
}