﻿using E_commerce.Models;

namespace E_commerce.DTOs
{

    public class UserDTO
    {
        public int UserId { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        [PasswordComplexity]
        public string? Password { get; set; } = string.Empty;
        public bool isAdmin { get; set; } = false;
        public string? Token { get; set; }
    }



    public class LoginDTO
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
    public class LoginResponseDTO
    {
        public UserDTO User { get; set; }
        public string Token { get; set; }
    }
    public class UpdateUserDTO
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public bool IsAdmin { get; set; }
    }



}
