using System.Threading.Tasks;

namespace UserManagement.Data.Repositories.Interfaces
{
    public interface ILoginRepository
    {
        Task<string> Login(string username, string password);
    }
}
