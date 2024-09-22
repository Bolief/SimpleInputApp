using System.ComponentModel.DataAnnotations;

namespace SimpleInputApp.Models
{
    public class UserInputModel
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Email not valid")]
        public string Email { get; set; }
    }
}

