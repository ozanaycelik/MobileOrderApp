using MobileOrderApp.BackendSources.Models;

namespace MobileOrderApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            GlobalProperties.onStartControlValue = true;

            MainPage = new AppShell();
        }

        //protected override void OnStart()
        //{
        //    base.OnStart();

            
        //}
    }
}
