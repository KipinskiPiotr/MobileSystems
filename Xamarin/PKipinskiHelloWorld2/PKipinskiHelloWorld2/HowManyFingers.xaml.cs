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
    public partial class HowManyFingers : ContentPage
    {
        public HowManyFingers()
        {
            InitializeComponent();
        }

        private void PlayTheGame(object sender, EventArgs e)
        {
            if (numberEntry.Text == null || numberEntry.Text.Length == 0)
            {
                _ = DisplayAlert("Musisz podac liczbe!", "Podaj liczbe pomiedzy 1 a 10", "Ok");
                return;
            }
            int user_entry = int.Parse(numberEntry.Text);
            if(user_entry < 1 || user_entry > 10)
            {
                resultLabel.Text = "Nie przestrzegasz zasad!";
                resultLabel.TextColor = Color.Red;
                return;
            }

            Random rd = new Random();
            int rand_num = rd.Next(1, 11);

            if(user_entry == rand_num)
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
    }
}