using System.ComponentModel.DataAnnotations;

namespace PustokMVCApp.Areas.ViewModels
{
    public class AuthorEditVm
    {
        [Required (ErrorMessage = "Full name is required")]
        [MaxLength(20, ErrorMessage = "Full name cannot exceed 20 characters")]
        public string FullName { get; set; } = null!;
    }
}