using MobileOrderApp.BackendSources.Helpers;
using MobileOrderApp.BackendSources.Models;
using Newtonsoft.Json;

namespace MobileOrderApp.Views;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void ProductsButtonClick(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
        // await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
    }

    private async void OrdersButtonClick(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"//{nameof(OrderPage)}");
    }

    private async void LoginButtonClick(object sender, EventArgs e)
    {
        //await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
    }

    private async void OnSaveClicked(object sender, EventArgs e)
    {
        var loginResult = await RestHelper.LoginMethod(new Login() { username = usernameEntry.Text, password = passwordEntry.Text });


        if (loginResult != null)
        {
            try
            {
                var deseriliazeJson = JsonConvert.DeserializeObject<LoginResponse>(loginResult.ToString());

                if (deseriliazeJson != null)
                {
                    await SecureStorage.SetAsync("AccessToken", deseriliazeJson.token);
                    string accessToken = await SecureStorage.GetAsync("AccessToken");
                    richTextBox.Text = accessToken;
                }
            }
            catch (Exception)
            {

            }
        }
        else
        {

        }

    }
    private void OnShowPasswordClicked(object sender, EventArgs e)
    {
        passwordEntry.IsPassword = !passwordEntry.IsPassword;
    }
    private async void ReturnMainMenu(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
}