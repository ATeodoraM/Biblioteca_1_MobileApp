using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Biblioteca.Data;
using System.IO;
using Biblioteca.Pages;

namespace Biblioteca
{
    public partial class App : Application
    {

        static BookDatabase database;
        public static BookDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new
                   BookDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.
                   LocalApplicationData), "Biblioteca.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ListEntryPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
