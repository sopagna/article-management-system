﻿using System;
using System.ComponentModel.DataAnnotations;

namespace ArticleManagementSystem.Models
{
    public class RegisterViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [Required, DataType(DataType.Password), Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
    }
}