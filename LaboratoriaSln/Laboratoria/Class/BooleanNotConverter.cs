﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Laboratoria.Class
{
    public class BooleanNotConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Проверка на передаваемый тип Boolean
            if (value is bool valBool)
                return !valBool;
            // Проверка на передаваемый тип String
            if (value is string valStr && bool.TryParse(valStr, out valBool))
                return !valBool;

            throw new ArgumentException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Проверка на передаваемый тип Boolean
            if (value is bool valBool)
                return !valBool;
            // Проверка на передаваемый тип String
            if (value is string valStr && bool.TryParse(valStr, out valBool))
                return !valBool;
            throw new ArgumentException();
        }
    }
}
