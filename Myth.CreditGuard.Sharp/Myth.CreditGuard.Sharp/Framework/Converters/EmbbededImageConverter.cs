using System;
using System.Globalization;
using MvvmCross.Platform.Converters;
using Xamarin.Forms;
using System.Reflection;

namespace Myth.CreditGuard.Sharp.Framework.Converters
{
    public class EmbbededImageConverter : ValueConverterBase<string, ImageSource>
    {
        static Assembly _assembly = typeof(EmbbededImageConverter).GetTypeInfo().Assembly;
        protected override ImageSource Convert(string value, Type targetType, object parameter, CultureInfo culture)
        {
            string[] resourceNames = _assembly.GetManifestResourceNames();
            foreach(string resourceName in resourceNames)
            {
                System.Diagnostics.Debug.WriteLine("found resource: " + resourceName);
            }
            return ImageSource.FromResource(value, _assembly);
        }
    }
}
