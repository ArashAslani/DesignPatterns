using Facade.Application.Services.UserLogin;
using Facade.Application.Services.UserRegister;

namespace FacadeLayer;

public class FacadeService : IFacadeService
{
    private IUserLoginService _userLoginService;
    public IUserLoginService userLoginService {
        get 
        { 
            return _userLoginService ??= new UserLoginService();
        }
    }

    private IUserRegisterService _userRegisterService;
    public IUserRegisterService userRegisterService { 
        get 
        {
            return _userRegisterService ??= new UserRegisterService();
        } 
    }
}
