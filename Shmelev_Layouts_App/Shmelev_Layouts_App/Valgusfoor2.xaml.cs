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
        public Valgusfoor2()
        {
            //InitializeComponent();
            Label red = new Label()
            {
                Text = "Red", BackgroundColor = Color.Red, FontSize = 18, Margin = (20,20,20,20)

            };
            Label yellow = new Label()
            {
                Text = "Yellow",
                BackgroundColor = Color.Yellow,
                FontSize = 18

            };
            Label green = new Label()
            {
                Text = "Green",
                BackgroundColor = Color.Green,
                FontSize = 18

            };
            StackLayout stackLayout = new StackLayout()
            {
                Children = { red, yellow, green }
            };
            stackLayout.Orientation = StackOrientation.Horizontal;
            this.Content = stackLayout;
        }
    }
}