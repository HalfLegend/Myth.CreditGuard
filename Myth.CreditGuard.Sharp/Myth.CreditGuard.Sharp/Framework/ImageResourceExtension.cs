using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Myth.CreditGuard.Sharp.Framework
{
    [ContentProperty("Source")]
    public class ImageResourceExtension : IMarkupExtension
    {
        public string Source { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Source == null)
            {
                return null;
            }

            ImageSource imageSource = null;

            var transformer = new ImageUrlTransformer();
            string url = transformer.TransformForCurrentPlatform(Source);

            if (Device.OS == TargetPlatform.Android)
            {
                imageSource = ImageSource.FromFile(url);
            }
            else if (Device.OS == TargetPlatform.iOS)
            {
                imageSource = ImageSource.FromFile(url);
            }
            else if (Device.OS == TargetPlatform.WinPhone)
            {

            }

            if (imageSource == null)
            {
                imageSource = ImageSource.FromFile(url);
            }

            return imageSource;
        }
    }

}
