using System.Threading.Tasks;

namespace UserManagement.Data.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<bool> DeleteUser(string id);
    }
}
