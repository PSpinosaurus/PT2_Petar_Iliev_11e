using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "First name must be between 1 and 20 symbols.")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Last name must be between 1 and 20 symbols.")]
        public string LastName { get; set; }

        [Range(18,81, ErrorMessage ="Age must be between 18 and 81 years.")]
        public int Age { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Username must be between 1 and 20 symbols.")]
        public string UserName { get; set; }

        [Required]
        [MaxLength(70, ErrorMessage = "Password must be between 1 and 70 symbols.")]
        public string Password { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Email must be between 1 and 20 symbols.")]
        public string Email { get; set; }

        public HashSet<User> Friends { get; set; } = new HashSet<User> { };

        public HashSet<Interest> Interests { get; set; } = new HashSet<Interest> { };

        public User()
        {
            
        }

        public User(string firstName, string lastName, int age, string userName, string password, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            UserName = userName;
            Password = password;
            Email = email;
        }
    }
}
