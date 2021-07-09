using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CatFactsNinja
{
    public partial class MetricsPage : ContentPage
    {
        public MetricsPage()
        {
            InitializeComponent();
        }
        async void OnNavigateButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}
