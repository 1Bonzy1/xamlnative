using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace CircularProgress
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Xamarin.Forms.Device.StartTimer(TimeSpan.FromSeconds(.02), OnTimer);
        }

        private bool OnTimer()
        {
            var progress = (progressControl.Progress + .01) ;
            if (progress > 1) progress = 0;
            progressControl.Progress = progress;
            return true;
        }
    }
}
