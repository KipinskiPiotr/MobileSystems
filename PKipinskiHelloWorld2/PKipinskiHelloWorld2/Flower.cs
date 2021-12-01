using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace PKipinskiHelloWorld2
{
    public class Flower : INotifyPropertyChanged
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public override string ToString()
        {
            return Name;
        }
        public void NotifyNameChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
        }
    }
}
