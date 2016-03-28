using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace XBindBasics
{
    class MainViewModel : INotifyPropertyChanged
    {
        public string FieldBindingText = "Here is a Field Binding";

        public MainViewModel()
        {
            this.PropertyBindingText = "This is a Property Binding";
        }

        string propertyBindingText;
        public string PropertyBindingText
        {
            get
            {
                return propertyBindingText;
            }
            set
            {
                propertyBindingText = value;
                NotifyPropertyChanged();
            }
        }

        public void ClickHandler()
        {
            PropertyBindingText = "Clicked!";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        } 

    }
}
