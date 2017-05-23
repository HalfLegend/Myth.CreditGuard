using System;
using System.Globalization;
using Xamarin.Forms;

namespace Myth.CreditGuard.Sharp.Framework.Converters
{
    public abstract class ValueConverterBase<TIn, TOut> : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Convert((TIn)value, targetType, parameter, culture);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ConvertBack((TOut)value, targetType, parameter, culture);
        }

        protected virtual TOut Convert(TIn inValue, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
        protected virtual TIn ConvertBack(TOut value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}

	}
}
