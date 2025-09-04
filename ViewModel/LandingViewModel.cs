using PropertApp.Model;
using PropertyApp.View;
using PropertApp.View;
using PropertyApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;



namespace PropertyApp.ViewModel
{
    public class LandingViewModel : BaseViewModel
    {
        public List<string> Sections => new List<string> { "Trending", "Popular", "Buy", "Rent" };

        public List<Property> Properties => PropertyRepo.AllProperties;

        public Property SelectedProperty { get; set; }

        public ICommand PropertySelected => new Command(obj =>
        {
            if (SelectedProperty != null)
            {
                Application.Current.MainPage.Navigation.PushAsync(page: new DetailsPage(SelectedProperty));
            }
            SelectedProperty = null;
        });
    }
}
