using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFPrinter.Services;
using XFPrinter.Views;

namespace XFPrinter
{
    public partial class App : Application
    {
        public static string BtAddress { get; set; } = "";
        public static string BtName { get; set; } = "";

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
