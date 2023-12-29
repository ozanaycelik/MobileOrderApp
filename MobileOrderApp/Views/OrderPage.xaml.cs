namespace MobileOrderApp.Views;

public partial class OrderPage : ContentPage
{
	public OrderPage()
	{
		InitializeComponent();
	}

    private async void ProductsButtonClick(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }

    private async void OrdersButtonClick(object sender, EventArgs e)
    {
        //await Shell.Current.GoToAsync($"//{nameof(OrderPage)}");
    }

    private async void LoginButtonClick(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
    }
}