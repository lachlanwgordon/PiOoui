using System;
using Xamarin.Forms;

namespace PiOoui.Views
{
    public class HomePage : ContentPage
    {
        public HomePage ()
        {
            Content = new StackLayout
            {
                Children =
                {
                    new Button {Text = "Hello"}
                }
            };
        }
    }
}