using System;
using System.IO;
using FacilitatorAssistentApp.Models.Data;
using FacilitatorAssistentApp.Views.AccessViews;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FacilitatorAssistentApp
{
    public partial class App : Application
    {

        private static DatabaseQuery database;

        public static DatabaseQuery SqliteDB
        {
            get{
                if (database == null) {
                    database = new DatabaseQuery(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "TestUsers.db3"));
                }
                return database;
            }
        }


        public App ()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new StartPage());
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}

