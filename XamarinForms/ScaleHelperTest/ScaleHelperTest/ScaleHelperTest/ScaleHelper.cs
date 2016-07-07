using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ScaleHelperTest
{
    public class ScaleHelper
    {
        public static readonly BindableProperty TabletFontSizeProperty = BindableProperty.CreateAttached("TabletFontSize", typeof(double), typeof(ScaleHelper), -1d, propertyChanged:OnTabletFontSizeChanged);

        private static void OnTabletFontSizeChanged(BindableObject b, object o, object n)
        {
            if (Device.Idiom == TargetIdiom.Tablet || Device.Idiom == TargetIdiom.Desktop)
            {
                var dn = (double)n;
                var btn = b as Button;
                if (btn != null)
                {
                    btn.FontSize = dn;
                    return;
                }
                var e = b as Entry;
                if (e != null)
                {
                    e.FontSize = dn;
                    return;
                }
                var lbl = b as Label;
                if (lbl != null)
                {
                    lbl.FontSize = dn;
                    return;
                }
            }

        }

        public static double GetTabletFontSize(BindableObject bo)
        {
            return (double)bo.GetValue(ScaleHelper.TabletFontSizeProperty);
        }

        public static void SetTabletFontSize(BindableObject bo, double value)
        {
            bo.SetValue(ScaleHelper.TabletFontSizeProperty, value);
        }


        public static readonly BindableProperty TabletStyleProperty = BindableProperty.CreateAttached("TabletStyle", typeof(Style), typeof(ScaleHelper), null, propertyChanged: OnTabletStyleChanged);

        private static void OnTabletStyleChanged(BindableObject b, object o, object n)
        {
            if (Device.Idiom == TargetIdiom.Tablet || Device.Idiom == TargetIdiom.Desktop)
            {
                var v = b as VisualElement;
                if (v != null)
                {
                    v.Style = n as Style;
                }
            }
        }

        public static Style GetTabletStyle(BindableObject bo)
        {
            return (Style)bo.GetValue(ScaleHelper.TabletStyleProperty);
        }

        public static void SetTabletStyle(BindableObject bo, Style value)
        {
            bo.SetValue(ScaleHelper.TabletStyleProperty, value);
        }
    }
}
