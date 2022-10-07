using System;
using System.Collections.Generic;
using System.Windows.Input;
using FacilitatorAssistentApp.ViewModels;
using Xamarin.Forms;

namespace FacilitatorAssistentApp.Views.AccessViews
{
    public partial class LoginPage : ContentPage
    {

        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel();
        }

    }
}

