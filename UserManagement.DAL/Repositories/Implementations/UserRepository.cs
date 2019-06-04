using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using UserManagement.Data.Repositories.Interfaces;
using UserManagement.Domain;

namespace UserManagement.Data.Repositories.Implementations
{
    public class UserRepository : IUserRepository
    {
        private readonly UserManager<User> _userManager;

        public UserRepository(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public async Task<bool> DeleteUser(string id)
        {
            var userToDelete = await _userManager.Users.FirstOrDefaultAsync(user => user.Id == id);
            var response = await _userManager.DeleteAsync(userToDelete);
            return response.Succeeded;
        }
    }
}