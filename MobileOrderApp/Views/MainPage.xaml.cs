using MobileOrderApp.BackendSources.Models;
using MobileOrderApp.ViewModels;
using MobileOrderApp.Views;
using MvvmHelpers;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MobileOrderApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            if (!GlobalProperties.onStartControlValue)
            {
                Navigation.PushModalAsync(new LoadingPage(), false);

                InitializeComponent();

                //ShowLoadingPopup();

                var viewModel = new ProductViewModel();
                BindingContext = viewModel;

                ////HideLoadingPopup();
                Device.BeginInvokeOnMainThread(async () =>
                {
                    await Task.Delay(2000);
                    await Navigation.PopModalAsync(); // Loading sayfasını kapat
                });


            }
            else
            {
                InitializeComponent();

                var viewModel = new ProductViewModel();
                BindingContext = viewModel;

                GlobalProperties.onStartControlValue = false;
            }
           
        }



        private async void ShowLoadingPopup()
        {
            var loadingLayout = new StackLayout
            {
                BackgroundColor = Color.FromRgba(0, 0, 0, 0.5), // Yarı saydam siyah arka plan
                Padding = new Thickness(20),
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            var activityIndicator = new ActivityIndicator
            {
                IsRunning = true,
                Color = Color.FromRgb(255, 255, 255) // Beyaz renk
            };

            loadingLayout.Children.Add(activityIndicator);

            var loadingPopup = new ContentView
            {
                Content = loadingLayout,
                BackgroundColor = Color.FromRgba(173, 216, 230, 0.5),
                Padding = new Thickness(40),
                IsVisible = true
            };

            Content = loadingPopup;

            await Task.Delay(500); // Simülasyon amacıyla bir bekleme süresi ekleyebilirsiniz.

        }
        private void HideLoadingPopup()
        {
            // Loading ekranını gizle
            Content.IsVisible = false;
        }
        private void DecreaseQuantityClicked(object sender, EventArgs e)
        {
            if (sender is Button button && button.BindingContext is Product product)
            {
                product.Quantity--;
                if (product.Quantity < 0)
                {
                    product.Quantity = 0;
                }
            }
        }

        private void IncreaseQuantityClicked(object sender, EventArgs e)
        {
            if (sender is Button button && button.BindingContext is Product product)
            {
                product.Quantity++;
                if (product.Quantity > 99)
                {
                    product.Quantity = 99;
                }
            }
        }


        private async void ProductsButtonClick(object sender, EventArgs e)
        {
            //await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
        }

        private async void OrdersButtonClick(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(OrderPage)}");
        }

        private async void LoginButtonClick(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }
    }

}
