namespace Facade.Application.Services.UserLogin;

public class UserLoginService : IUserLoginService
{
    public void Execute()
    {
        Validate();
        LoginUser();
    }

    private void Validate()
    {
        Console.WriteLine("Validate user info.");
    }
    private void LoginUser()
    {
        Console.WriteLine("Login user...");
    }
}
