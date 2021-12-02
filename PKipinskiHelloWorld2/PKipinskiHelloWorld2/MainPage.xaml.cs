using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PKipinskiHelloWorld2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void ShowMessage(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 1", "What's your name?", initialValue:entry.Text);
            Console.WriteLine(result);
        }

        private void runHowManyFingers(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HowManyFingers());
        }

        private void runDices(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Dices());
        }

        private void runBmiCalculator(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BmiCalculator());
        }

        private void runFlowerList(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FlowerList());
        }

        private void runFlowerList2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FlowerList2());
        }
    }
}
