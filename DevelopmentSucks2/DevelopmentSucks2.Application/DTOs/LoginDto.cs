using System.ComponentModel.DataAnnotations;

namespace DevelopmentSucks2.Application.DTOs;

public class LoginDto
{
    [Required(ErrorMessage = "Username is required")]
    public string Username { get; set; } = string.Empty;

    [Required(ErrorMessage = "Password is required")]
    [MaxLength(6, ErrorMessage = "Max length is 6")]
    public string Password { get; set; } = string.Empty;
}
