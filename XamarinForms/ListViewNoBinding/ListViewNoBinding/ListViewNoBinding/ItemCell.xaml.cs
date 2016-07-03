using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ListViewNoBinding
{
    public partial class ItemCell : ViewCell
    {
        public ItemCell()
        {
            InitializeComponent();
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            var itm = BindingContext as ItemViewModel;
            if (itm != null)
            {
                idLabel.Text = itm.Id.ToString();
                textLabel.Text = itm.Text.ToString();
            }
            else
            {
                idLabel.Text = textLabel.Text = "";
            }
        }
    }
}
