using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PKipinskiHelloWorld2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class FlowerList : ContentPage
    {
        public IList<Flower> Flowers { get; private set; }

        public FlowerList()
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

            //RefreshView refreshView = new RefreshView();
           // ICommand refreshCommand = new Command(() =>
            //{
                // IsRefreshing is true
                // Refresh data here
            //    refreshView.IsRefreshing = false;
            //});
            //refreshView.Command = refreshCommand;
            //refreshView.Content = flowersView;

            BindingContext = this;
        }
        async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Flower selectedItem = e.CurrentSelection[0] as Flower;
            string result = await DisplayPromptAsync("Zmień nazwę", "", initialValue: selectedItem.Name);
            selectedItem.Name = result;
            selectedItem.NotifyNameChanged();
        }
    }
}