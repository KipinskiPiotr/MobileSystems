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
    public partial class Dices : ContentPage
    {
        public Dices()
        {
            InitializeComponent();
        }
        private void PlayTheGame(object sender, EventArgs e)
        {
            if(numberEntry.Text == null || numberEntry.Text.Length == 0)
            {
                _ = DisplayAlert("Musisz podac liczbe!", "Podaj liczbe pomiedzy 2 a 12", "Ok");
                return;
            }
            int user_entry = int.Parse(numberEntry.Text);
            if (user_entry < 2 || user_entry > 12)
            {
                _ = DisplayAlert("Podales bledna liczbe!", "Podaj liczbe pomiedzy 2 a 12", "Ok");
                return;
            }

            Random rd = new Random();
            int rand_num1 = rd.Next(1, 7);
            int rand_num2 = rd.Next(1, 7);

            UpdateImage(dice1, rand_num1);
            UpdateImage(dice2, rand_num2);

            if (user_entry == rand_num1 + rand_num2)
            {
                resultLabel.Text = "Brawo, zgadles!";
                resultLabel.TextColor = Color.Green;
            }
            else
            {
                resultLabel.Text = "Niestety, nie udalo sie!";
                resultLabel.TextColor = Color.Red;
            }
        }

        private void UpdateImage(Image dice, int rand_num1)
        {
            switch (rand_num1)
            {
                case 1:
                    dice.Source = ImageSource.FromFile("dice1.png");
                    break;
                case 2:
                    dice.Source = ImageSource.FromFile("dice2.png");
                    break;
                case 3:
                    dice.Source = ImageSource.FromFile("dice3.png");
                    break;
                case 4:
                    dice.Source = ImageSource.FromFile("dice4.png");
                    break;
                case 5:
                    dice.Source = ImageSource.FromFile("dice5.png");
                    break;
                case 6:
                    dice.Source = ImageSource.FromFile("dice6.png");
                    break;
                default:
                    break;
            }
        }
    }
}