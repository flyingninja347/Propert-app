using PropertyApp.ViewModel;

namespace PropertApp.View;

public partial class DetailsPage : ContentPage
{
	public DetailsPage(Model.Property SelectedProperty)
	{
		InitializeComponent();
		var viewModel = new DetailsviewModel(){ SelectedProperty = SelectedProperty};
		viewModel.PropertyImages = SelectedProperty.Images.Take(count: 2). ToList ();
		viewModel.MoreItems = SelectedProperty.Images.Count - 2;

		this.BindingContext = viewModel;

    }

}