using System.ComponentModel.DataAnnotations;

namespace SimpleBlog.ViewModels
{
  public class AuthLogin
    {
        //Data going to be sent from view to controller
        [Required]
        public string Username { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
    }
}