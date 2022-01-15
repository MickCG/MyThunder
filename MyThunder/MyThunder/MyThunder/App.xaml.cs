using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyThunder
{
    using MyThunder.Services;
    using MyThunder.Views;

    using ThunderboltIoc;

    public partial class App : Application
    {
        static App()
        {
            ThunderboltActivator.Attach<SharedServiceRegistration>();
        }
        public App()
        {
            InitializeComponent();

            MainPage = new MainView();
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
