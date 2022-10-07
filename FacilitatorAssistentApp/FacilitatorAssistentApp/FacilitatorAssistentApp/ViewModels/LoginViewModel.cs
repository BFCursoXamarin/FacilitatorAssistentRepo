using System;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using Xamarin.Forms;

namespace FacilitatorAssistentApp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {

        #region Attributes

        private string user;
        private string password;

        #endregion

        #region Properties

        public string userText {
            get { return this.user;  }
            set { SetValue(ref this.user, value); }
        }

        public string pwdText
        {
            get { return this.password; }
            set { SetValue(ref this.password, value); }
        }

        #endregion

        #region Commands


        public ICommand LoginCommad
        {
            get { return new RelayCommand(Login); }
            set { }
        }

        public ICommand goRegisterPageCommand => new Command(() => { Application.Current.MainPage.Navigation.PopAsync(); });

        #endregion

        #region Methods

        private void Login()
        {
            
            if (validateStringField(userText) == "guadalupe" && validateStringField(pwdText) == "4503")
            {
                Application.Current.MainPage.DisplayAlert("Correct","Bindig succesfuly, you are loged.", "Ok");
            }
            else {
                Application.Current.MainPage.DisplayAlert("Fail","Binding Correct, but you can't login", "Ok");
            }
        }


        private string validateStringField(string data) {
            return string.IsNullOrEmpty(data) ? "" : data.ToString();
        }
        
        #endregion

        #region Constructors

        #endregion
    }
}

