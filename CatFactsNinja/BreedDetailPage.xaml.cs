using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CatFactsNinja
{
    public partial class BreedDetailPage : ContentPage
    {
        public BreedDetailPage()
        {
            InitializeComponent();
        }

        async void OnNavigateButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}