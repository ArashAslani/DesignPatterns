using Facade.Facade;

namespace Facade;

internal class Program
{
    //Client
    static void Main(string[] args)
    {
        FacadeService facadeService = new();
        facadeService.DoSomthing();
    }
}
