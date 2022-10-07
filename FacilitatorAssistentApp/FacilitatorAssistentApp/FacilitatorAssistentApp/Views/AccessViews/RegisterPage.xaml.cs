using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FacilitatorAssistentApp.Views.AccessViews
{
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void ConfirmEvent_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
        }
        
        private void goBack_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}

