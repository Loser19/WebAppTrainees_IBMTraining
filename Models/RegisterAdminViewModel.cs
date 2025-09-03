﻿using System.ComponentModel.DataAnnotations;

namespace WebAppTrainees.Models
{
    public class RegisterAdminViewModel
    {
        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required, DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;

        [Required, DataType(DataType.Password), Compare("Password")]
        public string ConfirmPassword { get; set; } = string.Empty;

        [Required]
        public string SpecialPassKey { get; set; } = string.Empty;
    }
}
