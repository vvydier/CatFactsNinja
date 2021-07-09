using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace CatFactsNinja
{
    public partial class MainPage : ContentPage
    {
        BreedsService _breedsService;

        public MainPage()
        {
            InitializeComponent();
            _breedsService = new BreedsService();
        }

        async void OnButtonClicked1(object sender, EventArgs e)
        {
            Breeds breeds = await _breedsService.GetBreedsAsync(Constants.BreedsEndpoint);
            //BindingContext = breeds;
            collectionView.ItemsSource = breeds.Data;
        }


        async void OnButtonClicked2(object sender, EventArgs e)
        {

            var metrics = new Metrics {
                Name = DeviceInfo.Name,
                Model = DeviceInfo.Model,
                Manufacturer = DeviceInfo.Manufacturer,
                Version = DeviceInfo.VersionString
            };

            //collectionView.ItemsSource = breeds.Data;
            var _metricsPage = new MetricsPage();
            _metricsPage.BindingContext = metrics;
            await Navigation.PushModalAsync(_metricsPage);


        }

        async Task OnListViewItemSelectedAsync(object sender, SelectedItemChangedEventArgs e)
        {
            BreedDetail selectedItem = e.SelectedItem as BreedDetail;
            var _breedDetailPage = new BreedDetailPage();
            _breedDetailPage.BindingContext = selectedItem;
            await Navigation.PushModalAsync(_breedDetailPage);
        }

        async Task OnListViewItemTappedAsync(object sender, ItemTappedEventArgs e)
        {
            BreedDetail tappedItem = e.Item as BreedDetail;
            var _breedDetailPage = new BreedDetailPage();
            _breedDetailPage.BindingContext = tappedItem;
            await Navigation.PushModalAsync(_breedDetailPage);
        }


        async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //BreedDetail selectedItem = e.CurrentSelection[0] as BreedDetail;
            var _breedDetailPage = new BreedDetailPage();
            _breedDetailPage.BindingContext = e.CurrentSelection[0];
            await Navigation.PushModalAsync(_breedDetailPage);

        }
    }
}
