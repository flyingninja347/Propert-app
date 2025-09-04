using Microsoft.UI.Xaml;

namespace PropertyApp.WinUI
{
   
    public partial class App : MauiWinUIApplication
    {
       
        public App()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
    }

}
