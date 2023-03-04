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
            Button RGB_btn = new Button
            {
                Text = "RGB leht",
                TextColor = Color.Wheat,
                BackgroundColor = Color.White
            };
            Button StepperSlider_btn = new Button
            {
                Text = "StepperSlider leht",
                TextColor = Color.Wheat,
                BackgroundColor = Color.White
            };
            Button DateTime_btn = new Button
            {
                Text = "DateTime leht",
                TextColor = Color.Wheat,
                BackgroundColor = Color.White
            };
            Button Valgusfoor_btn = new Button
            {
                Text = "Ava Valgusfoor leht",
                TextColor = Color.Wheat,
                BackgroundColor = Color.White
            };
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
                Children = { Entry_btn, Timer_btn, BoxView_btn, Valgusfoor_btn, DateTime_btn, StepperSlider_btn, RGB_btn },
                BackgroundColor = Color.YellowGreen
            };
            Content = st;
            RGB_btn.Clicked += RGB_btn_Clicked;
            StepperSlider_btn.Clicked += StepperSlider_btn_Clicked;
            DateTime_btn.Clicked += DateTime_btn_Clicked;
            Entry_btn.Clicked += Entry_btn_Clicked;
            Timer_btn.Clicked += Timer_btn_Clicked;
            BoxView_btn.Clicked += BoxView_btn_Clicked;
            Valgusfoor_btn.Clicked += Valgusfoor_btn_Clicked;
        }

        private async void RGB_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RGB());
        }

        private async void StepperSlider_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StepperSlider_Page());
        }

        private async void DateTime_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DateTime_Page());
        }

        private async void Valgusfoor_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Valgusfoor_Page());
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