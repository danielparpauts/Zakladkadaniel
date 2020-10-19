using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Zakladkadaniel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Juuli : ContentPage
    {
        public Juuli()
        {
            InitializeComponent();
            Grid grd = new Grid
            {
                RowDefinitions =
                {
                    new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
                    new RowDefinition{Height=new GridLength(2,GridUnitType.Star)},
                    new RowDefinition{Height=new GridLength(3,GridUnitType.Star)}

                },
                ColumnDefinitions =
                {
                    new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)}
                }



            };
            Label nimetus = new Label { Text = "Июльская фотография", FontSize = 30 };
            Image img = new Image { Source = "iui.jpg" };
            Label kirjeldus = new Label { Text = "В современную эпоху до 20 июля по григорианскому календарю солнце находится в созвездии Близнецов, с 20 июля — в созвездии Рака!!! \nВ большинстве языков Европы название июля соответствует латинской традиции!!!" };
            var tap = new TapGestureRecognizer();
            tap.Tapped += async (s, e) =>
            {
                img = (Image)s;
                await DisplayAlert("Информация", "1 Июля, Всемирный день Бакинцев", "Закрыть");
            };
            img.GestureRecognizers.Add(tap);
            grd.Children.Add(nimetus, 0, 0);
            grd.Children.Add(img, 0, 1);
            grd.Children.Add(kirjeldus, 0, 2);
            Content = grd;
        }
    }
}