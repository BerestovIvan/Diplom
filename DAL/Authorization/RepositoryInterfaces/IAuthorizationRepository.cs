using DAL.Entity;
using DAL.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace DAL.Authorization.RepositoryInterfaces
{
    public interface IAuthorizationRepository
    {
        Task<IdentityResult> Register(ApplicationUser applicationUser);
        Task<IdentityResult> RegisterAdmin(ApplicationUser applicationUser);
        Task<LoginResult> Login(ApplicationUser applicationUser);
    }
}
