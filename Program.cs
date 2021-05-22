using System;
using Ooui;
using Ooui.Forms;
using PiOoui.Views;
using Xamarin.Forms;
using Label = Xamarin.Forms.Label;
namespace PiOoui
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Ooui");
            UI.Host = "10.1.1.155";//This line needed if running on pi and serving to other computers
            //UI.Host = "10.1.1.199";//This line needed if running on mac and serving to other computers
            Forms.Init();
            var page = new XamlPage();
            var page2 = new HomePage();
            var element = page.GetOouiElement();
            var element2 = page2.GetOouiElement();
            UI.Publish("/", element);
            UI.Publish("/test", element2);

            Console.ReadLine();

        }
    }
}
