using System;
using Ooui;
using Ooui.Forms;
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
            var page = new ContentPage
            {
                Content = new StackLayout
                {
                    Children = 
                    {
                        new Label{ Text = "Hello"}
                    }
                }
            };
            var element = page.GetOouiElement();
            UI.Publish("/", element);

            Console.ReadLine();

        }
    }
}
