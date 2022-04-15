using AutoMapper;
using BLL.Exceptions;
using BLL.Models;
using BLL.ServiceInterfaces;
using DAL.Authorization.RepositoryInterfaces;
using DAL.Entity;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AuthorizationService : IAuthorizationService
    {
        readonly IAuthorizationRepository authorizationRepository;
        readonly IMapper mapper;
        public AuthorizationService(IAuthorizationRepository authorizationRepository, IMapper mapper)
        {
            this.authorizationRepository = authorizationRepository;
            this.mapper = mapper;
        }

        public async Task<IdentityResult> Register(RegisterModel registerModel)
        {
            return await authorizationRepository.Register(mapper.Map<ApplicationUser>(registerModel));
        }

        public async Task<IdentityResult> RegisterAdmin(RegisterModel registerModel)
        {
            return await authorizationRepository.RegisterAdmin(mapper.Map<ApplicationUser>(registerModel));
        }

        public async Task<LoginResultModel> Login(LoginModel loginModel)
        {
            var loginResult =  await authorizationRepository.Login(mapper.Map<ApplicationUser>(loginModel));
            return mapper.Map<LoginResultModel>(loginResult);
        }
    }
}
