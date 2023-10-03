namespace MauiApp3;

public partial class FruitDetailed : ContentPage
{
	public FruitDetailed(string fruitName,string fruitImage,string fruitDescription)
	{
		InitializeComponent();
		showName.Text = fruitName;
		showImage.Source = fruitImage;
			showDescription.Text = fruitDescription;
	}
}