namespace Facade.Application.Services.UserRegister;

public class UserRegisterService : IUserRegisterService
{
    public void Execute()
    {
        Register();
    }

    private void Register()
    {
        Console.WriteLine("User registered.");
    }
}
 