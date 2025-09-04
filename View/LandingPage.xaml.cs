using System.Collections.ObjectModel;
using PropertyApp.View;
using PropertyApp.ViewModel;
using PropertApp.View;

namespace PropertyApp.View
{
    public partial class LandingPage : ContentPage
    {
     
        public LandingPage()
        {
            InitializeComponent();

            this.BindingContext = new LandingViewModel();
            (SectionList.Children[index: 0] as RadioButton).IsChecked = true;
        }

      
    }
}