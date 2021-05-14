using System;
using PiOoui.ViewModels;
using Xamarin.Forms;


namespace PiOoui.Views
{
    public partial class XamlPage : ContentPage
    {
        public XamlPage()
        {
            BindingContext = new XamlPageViewModel();
            InitializeComponent();
        }
    }
}