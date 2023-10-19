using NavegationDemo.Utilities;

namespace NavegationDemo.MVVM.Pages;

public partial class StartPage : ContentPage
{
	public StartPage()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        NavUtilities.Examine(Navigation);
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new Page2());
        NavUtilities.DeletePage(Navigation, "StartPage");
    }
}