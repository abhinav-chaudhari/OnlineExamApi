using OnlineExamAPi.Models;
using OnlineExamAPi.Services;
using OnlineExamAPi.Data;

namespace OnlineExamAPi.Services
{
    public class UserService : IUserService
    {
        private readonly AppDbContext _context;
        public UserService(AppDbContext context)
        {
            _context = context;
        }
        public string AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return "User added Successfully !";
        }
    }
}

