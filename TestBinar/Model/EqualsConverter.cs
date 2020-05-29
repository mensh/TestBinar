using System;
using System.Windows.Data;
using System.Windows.Markup;

namespace TestBinar.Model
{
    public class EqualsConverter : MarkupExtension, IMultiValueConverter
    {
        public EqualsConverter() { }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }


        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (values.Length != 2) return false;
            return ReferenceEquals(values[0], values[1]);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}