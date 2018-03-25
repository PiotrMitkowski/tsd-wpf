﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace TSD_WPF
{
    class BookFormatConverter : IValueConverter
    {
        public BookFormatConverter()
        {
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var parsedValue = (HomeLibrary.BookFormat)value;
            if(parsedValue == HomeLibrary.BookFormat.PaperBack)
            {
                return new SolidColorBrush(Color.FromRgb(0xEA, 0xEA, 0xEA));
            }
            return new SolidColorBrush(Colors.White);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
