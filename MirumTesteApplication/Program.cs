using System;
using MirumTeste.UI;

namespace MirumTesteApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            MirumTeste.UI.Web.Controllers.HomeController homeController = new MirumTeste.UI.Web.Controllers.HomeController() ;
            int a = homeController.Teste();
            Console.WriteLine(a);
            Console.Read();
        }
    }
}
