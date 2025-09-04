using PropertApp.Model;

namespace PropertApp.View
{
    internal class DetailsViewModel
    {
        public DetailsViewModel()
        {
        }

        public Property SelectedProperty { get; set; }
        public List<string> PropertyImages { get; internal set; }
        public int MoreItems { get; internal set; }
    }
}