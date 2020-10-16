using System.Collections.Generic;
using FamilyApp.Models;

namespace FamilyApp.Data
{
    public interface IUserService
    {
        User ValidateUser(string userName, string password);
        void AddUser(User user);
        IList<User> GetUsers();
        IList<User> GetBasicUsers();
        void RemoveUser(User user);
    }
}