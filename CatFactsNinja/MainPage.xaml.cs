using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

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
            //List<Breeds.BreedDetail> breedDetails = null;


            Breeds breeds = await _breedsService.GetBreedsAsync(Constants.BreedsEndpoint);
            //BindingContext = breeds;

            //breedDetails = breeds;

            collectionView.ItemsSource = breeds.Data;


        }

        void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            BreedDetail selectedItem = e.SelectedItem as BreedDetail;
        }

        void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            BreedDetail tappedItem = e.Item as BreedDetail;
        }

        void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            BreedDetail selectedItem = e.CurrentSelection[0] as BreedDetail;
        }
    }
}
