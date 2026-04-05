using Microsoft.AspNetCore.Mvc;

namespace OnlineExamAPi.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string PasswordHash { get; set; }

        public string Role { get; set; } // Admin / Student
    }
}
