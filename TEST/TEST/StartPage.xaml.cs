using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TEST
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartPage : ContentPage
    {
        public StartPage()
        {
            //InitializeComponent();
            Button Entry_btn= new Button
            {
                Text = "Ava Entry leht",
                TextColor = Color.Wheat,
                BackgroundColor = Color.White
            };

            Button BoxView_btn = new Button
            {
                Text = "Ava Box leht",
                TextColor = Color.Wheat,
                BackgroundColor = Color.White
            };

            Button Timer_btn = new Button
            {
                Text = "Ava Timer leht",
                TextColor = Color.Wheat,
                BackgroundColor = Color.White
            };

            StackLayout st = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Children = { Entry_btn, Timer_btn, BoxView_btn },
                BackgroundColor = Color.YellowGreen
            };
            Content = st;
            Entry_btn.Clicked += Entry_btn_Clicked;
            Timer_btn.Clicked += Timer_btn_Clicked;
            BoxView_btn.Clicked += BoxView_btn_Clicked;
        }

        private async void BoxView_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BoxView_Page());
        }

        private async void Timer_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Timer_Page());
        }

        private async void Entry_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Entry_Page());
        }
    }
}