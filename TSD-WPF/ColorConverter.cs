using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace TSD_WPF
{
    class MyColorConverter : IValueConverter
    {
        public MyColorConverter()
        {
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var greenValue = (Double)value;
            return new SolidColorBrush(Color.FromRgb(0x0, System.Convert.ToByte(greenValue), 0x0));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
