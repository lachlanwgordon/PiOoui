using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace PiOoui.ViewModels
{
    public class XamlPageViewModel
    {
        public ICommand ButtonCommand { get; set; } = new Command(ExecuteButtonCommand);

        private static void ExecuteButtonCommand(object obj)
        {
            Console.WriteLine("Testing");
        }
    }
}
