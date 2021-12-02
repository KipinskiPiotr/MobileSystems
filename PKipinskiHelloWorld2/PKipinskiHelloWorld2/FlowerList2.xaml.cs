using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PKipinskiHelloWorld2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FlowerList2 : ContentPage
    {
        public IList<Flower> Flowers { get; private set; }

        public FlowerList2()
        {
            InitializeComponent();

            Flowers = new List<Flower>
            {
                new Flower
                {
                    Name = "Roza",
                    ImageUrl = "https://naszekrzewy.pl/img/products/61/1/3_max.jpg"
                },
                new Flower
                {
                    Name = "Frezja",
                    ImageUrl = "https://www.karmon-decor.pl/14227/frezja-na-piku-sun328-violet-blue.jpg"
                },
                new Flower
                {
                    Name = "Bratek",
                    ImageUrl = "https://www.sadowniczy.pl/data/gfx/pictures/medium/7/6/155367_1.jpg"
                },
                new Flower
                {
                    Name = "Stokrotka",
                    ImageUrl = "https://www.weranda.pl/data/articles/stokrotka_(8).jpg"
                },
                new Flower
                {
                    Name = "Roza",
                    ImageUrl = "https://naszekrzewy.pl/img/products/61/1/3_max.jpg"
                },
                new Flower
                {
                    Name = "Frezja",
                    ImageUrl = "https://www.karmon-decor.pl/14227/frezja-na-piku-sun328-violet-blue.jpg"
                },
                new Flower
                {
                    Name = "Bratek",
                    ImageUrl = "https://www.sadowniczy.pl/data/gfx/pictures/medium/7/6/155367_1.jpg"
                },
                new Flower
                {
                    Name = "Stokrotka",
                    ImageUrl = "https://www.weranda.pl/data/articles/stokrotka_(8).jpg"
                },
                new Flower
                {
                    Name = "Roza",
                    ImageUrl = "https://naszekrzewy.pl/img/products/61/1/3_max.jpg"
                },
                new Flower
                {
                    Name = "Frezja",
                    ImageUrl = "https://www.karmon-decor.pl/14227/frezja-na-piku-sun328-violet-blue.jpg"
                },
                new Flower
                {
                    Name = "Bratek",
                    ImageUrl = "https://www.sadowniczy.pl/data/gfx/pictures/medium/7/6/155367_1.jpg"
                },
                new Flower
                {
                    Name = "Stokrotka",
                    ImageUrl = "https://www.weranda.pl/data/articles/stokrotka_(8).jpg"
                }
            };

            BindingContext = this;
        }
        void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Flower selectedItem = e.CurrentSelection[0] as Flower;
            Navigation.PushAsync(new EditFlower(selectedItem));
        }
    }
}