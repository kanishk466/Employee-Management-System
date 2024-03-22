using Employee_Management_System.Models;

namespace Employee_Management_System.Services
{
    public interface IUserService
    {
        List<User> GetUser();

        User Get(string id);
        User Create(User user);
        void Update(string id, User user);

        void Remove(string id);
    }
}
