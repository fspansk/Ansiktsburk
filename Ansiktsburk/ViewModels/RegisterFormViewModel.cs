using System.ComponentModel.DataAnnotations;

namespace Ansiktsburk.ViewModels
{
    public class RegisterFormViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password), Compare(nameof(Password), ErrorMessage = "Not matching passwords.")]
        public string ConfirmPassword { get; set; }
    }
}
