using BLL.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace BLL.ServiceInterfaces
{
    public interface IAuthorizationService
    {
        Task<IdentityResult> Register(RegisterModel registerModel);
        Task<IdentityResult> RegisterAdmin(RegisterModel registerModel);
        Task<LoginResultModel> Login(LoginModel loginModel);
    }
}
