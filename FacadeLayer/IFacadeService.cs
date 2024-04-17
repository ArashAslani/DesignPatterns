using Facade.Application.Services.UserLogin;
using Facade.Application.Services.UserRegister;

namespace FacadeLayer;

public interface IFacadeService
{
    public IUserLoginService userLoginService { get; } 
    public IUserRegisterService userRegisterService { get; }
}
