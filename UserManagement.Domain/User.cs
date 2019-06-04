using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace UserManagement.Domain
{
    public class User : IdentityUser
    {
        [Column] public string FullName { get; set; }
    }
}
