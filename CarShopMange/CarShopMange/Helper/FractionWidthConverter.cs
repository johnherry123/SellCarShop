using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace CarShopMange.Helper
{
    public class FractionWidthConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double total && parameter is string p)
            {
                var parts = p.Split(';');
                var frac = double.Parse(parts[0], NumberStyles.Any, CultureInfo.InvariantCulture);
                var subtract = parts.Length > 1
                    ? double.Parse(parts[1], NumberStyles.Any, CultureInfo.InvariantCulture)
                    : 0d;

                var usable = Math.Max(0, total - subtract - 35);
                return Math.Max(50, usable * frac);          
            }
            return 100d;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
