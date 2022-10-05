using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FacilitatorAssistentApp.Views.AccessViews
{
    public partial class StartPage : ContentPage
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void RegisterNav_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new RegisterPage());
        }
        private void LoginNav_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
        }
    }
}

