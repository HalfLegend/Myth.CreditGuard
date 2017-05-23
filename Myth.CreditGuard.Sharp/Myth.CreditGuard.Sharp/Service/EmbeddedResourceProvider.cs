using System;
using System.Reflection;
using Xamarin.Forms;

namespace Myth.CreditGuard.Sharp.Service
{
    public static class EmbeddedResourceProvider
    {
		static Assembly _assembly = typeof(EmbeddedResourceProvider).GetTypeInfo().Assembly;
        public static ImageSource FindEmbeddedImage(string imagePath)
        {
			string[] resourceNames = _assembly.GetManifestResourceNames();
			foreach (string resourceName in resourceNames)
			{
				System.Diagnostics.Debug.WriteLine("found resource: " + resourceName);
			}
            //Device.On
            ImageSource imageSource = ImageSource.FromResource("Myth.CreditGuard.Sharp.Resources." + imagePath, _assembly);
            return imageSource;
        }
    }
}
