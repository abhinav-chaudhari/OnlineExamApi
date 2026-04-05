using OnlineExamAPi.Models;

namespace OnlineExamAPi.Services
{
    public interface IAuthService
    {
        string Register(User user);
        string Login(string email, string password);
    }
}
