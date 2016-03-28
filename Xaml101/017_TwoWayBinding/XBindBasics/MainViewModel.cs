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
        bool? checkBoxValue = false;
        string textBoxValue;

        public bool? CheckBoxValue
        {
            get
            {
                return checkBoxValue;
            }

            set
            {
                checkBoxValue = value;
                NotifyPropertyChanged();
            }
        }

        public string TextBoxValue
        {
            get
            {
                return textBoxValue;
            }

            set
            {
                textBoxValue = value;
                NotifyPropertyChanged();
            }
        }

        public MainViewModel()
        {
        }


        public async void ClickHandler(object sender, RoutedEventArgs e)
        {
            var dlg = new Windows.UI.Popups.MessageDialog(string.Format("CheckBox:{0}, TextBox:{1}", CheckBoxValue, TextBoxValue));
            await dlg.ShowAsync();
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
