using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Shmelev_Layouts_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Valgusfoor2 : ContentPage
    {
        Label yellow, red, green;
        Frame rframe, yframe, gframe;
        Button bt1, bt2;
        public Valgusfoor2()
        {
            //InitializeComponent();
            red = new Label()
            {
                Text = "  Red  ", 
                TextColor=Color.Red, 
                FontSize = 18
            };
            rframe = new Frame()
            {
                BackgroundColor = Color.Gray,
                Content = red,
                CornerRadius = 90,
                Padding = 50,
                HorizontalOptions=LayoutOptions.Center
            };
            yellow = new Label()
            {
                Text = "Yellow",
                TextColor=Color.Yellow,
                FontSize = 18

            };
            yframe = new Frame()
            {
                BackgroundColor = Color.Gray,
                Content = yellow,
                CornerRadius = 90,
                Padding = 50,
                HorizontalOptions = LayoutOptions.Center
            };
            green = new Label()
            {
                Text = "Green ",
                TextColor=Color.Green,
                FontSize = 18

            };
            gframe = new Frame()
            {
                BackgroundColor = Color.Gray,
                Content = green,
                CornerRadius = 90,
                Padding = 50,
                HorizontalOptions = LayoutOptions.Center
            };
            bt1 = new Button()
            {
                Text="On",
                HorizontalOptions=LayoutOptions.Start
            };
            bt2 = new Button()
            {
                Text = "off",
                HorizontalOptions = LayoutOptions.End
            };
            StackLayout stackLayout2 = new StackLayout()
            {
                Children = { bt1, bt2 }
            };
            StackLayout stackLayout = new StackLayout()
            {
                Children = { rframe, yframe, gframe, stackLayout2 }
            };
            stackLayout2.Orientation = StackOrientation.Horizontal;
            stackLayout2.Margin = new Thickness(90, 0, 0, 0);
           
            bt1.Clicked += Bt1_Clicked;
            bt2.Clicked += Bt2_Clicked;

            Content = stackLayout;

            var tap = new TapGestureRecognizer();
            tap.Tapped += Tap_Tapped;
            rframe.GestureRecognizers.Add(tap);
            yframe.GestureRecognizers.Add(tap);
            gframe.GestureRecognizers.Add(tap);

        }
        int clicked1 = 0;
        private void Tap_Tapped(object sender, EventArgs e)
        {
            Frame fr = sender as Frame;
            if (fr==rframe) 
            { 
                if (clicked1 == 0) { red.Text = "Светофор включи умник"; }
                else { red.Text = "Stop"; }
            }
            else if (fr == yframe)
            {
                if (clicked1 == 0) { yellow.Text = "Светофор включи умник"; }
                else { yellow.Text = "Get set"; }
            }
            else if (fr == gframe)
            {
                if (clicked1 == 0) { green.Text = "Светофор включи умник"; }
                else { green.Text = "Go"; }
            }
        }

        private void Bt2_Clicked(object sender, EventArgs e)
        {
            green.TextColor = Color.Green;
            yellow.TextColor = Color.Yellow;
            red.TextColor = Color.Red;
            red.Text = "  Red  ";
            yellow.Text = "Yellow";
            green.Text = "Green";
            rframe.BackgroundColor = Color.Gray;
            gframe.BackgroundColor = Color.Gray;
            yframe.BackgroundColor = Color.Gray;
            clicked1 = 0;
        }

        private void Bt1_Clicked(object sender, EventArgs e)
        {
            clicked1++;
            var rand = new Random();
            int num = rand.Next(1, 4);
            if (num == 1)
            {
                red.TextColor = Color.White;
                yellow.Text = "Yellow";
                green.Text = "Green";
                rframe.BackgroundColor = Color.Red;
                yframe.BackgroundColor = Color.Gray;
                gframe.BackgroundColor = Color.Gray;
            }
            else if (num == 2)
            {
                yellow.TextColor = Color.White;
                red.Text = "  Red  ";
                green.Text = "Green";
                rframe.BackgroundColor = Color.Gray;
                yframe.BackgroundColor = Color.Yellow;
                gframe.BackgroundColor = Color.Gray;
            }
            else if (num == 3)
            {
                green.TextColor = Color.White;
                red.Text = "  Red  ";
                yellow.Text = "Yellow";
                rframe.BackgroundColor = Color.Gray;
                yframe.BackgroundColor = Color.Gray;
                gframe.BackgroundColor = Color.Green;
            }
        }
    }
}