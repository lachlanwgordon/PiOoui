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
            //UI.Host = "10.1.1.155";//This line needed if running on pi and serving to other computers
            Forms.Init();
            var page = new XamlPage();
            var element = page.GetOouiElement();
            UI.Publish("/", element);

            Console.ReadLine();

        }
    }
}
