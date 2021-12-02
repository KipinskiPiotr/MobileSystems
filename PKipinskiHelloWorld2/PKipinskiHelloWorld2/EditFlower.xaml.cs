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
    public partial class EditFlower : ContentPage
    {
        Flower flower;
        public EditFlower(Flower flower)
        {
            InitializeComponent();

            this.flower = flower;
            entry.Text = flower.Name;
        }

        private void buttonClicked(object sender, EventArgs e)
        {
            flower.Name = entry.Text;
            Navigation.PopAsync();
            flower.NotifyNameChanged();
        }
    }
}