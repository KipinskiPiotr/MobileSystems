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
    public partial class BmiCalculator : ContentPage
    {
        public BmiCalculator()
        {
            InitializeComponent();
        }

        private void CalculateBmi(object sender, EventArgs e)
        {
            if (weightEntry.Text == null || weightEntry.Text.Length == 0 || heightEntry.Text == null || heightEntry.Text.Length == 0)
            {
                _ = DisplayAlert("Musisz podac pomiary!", "Podaj wage i wzrost", "Ok");
                return;
            }

            double weight = double.Parse(weightEntry.Text);
            double height = double.Parse(heightEntry.Text) / 100;
            double bmi = weight / height / height;
            UpdateImage(bmi);
        }

        private void UpdateImage(double bmi)
        {
            if (bmi < 18.5)
            {
                bmiImage.Source = ImageSource.FromFile("underweight.png");
            }
            else if (bmi < 25)
            {
                bmiImage.Source = ImageSource.FromFile("healthy.png");

            }
            else if (bmi < 30)
            {
                bmiImage.Source = ImageSource.FromFile("overweight.png");
            }
            else
            {
                bmiImage.Source = ImageSource.FromFile("obesity.png");
            }
        }
    }
}