using System;
using System.Reflection;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Myth.CreditGuard.Sharp.Framework
{
    [ContentProperty("Source")]
    public class ImageResourceExtension : IMarkupExtension<FileImageSource>
    {
        public string Source { get; set; }

        public FileImageSource ProvideValue(IServiceProvider serviceProvider)
        {
            string embeddedResourceName = "Myth.CreditGuard.Sharp.Resources." + Source;

            string fileResource = "FileImage/" + Source;
            IFileService fileService = DependencyService.Get<IFileService>();
            if (!fileService.Exists(fileResource))
            {
                Assembly assembly = typeof(ImageResourceExtension).GetTypeInfo().Assembly;
                Stream stream = assembly.GetManifestResourceStream(embeddedResourceName);
                fileService.WriteStream(fileResource, stream);
            }
            else
            {
#if DEBUG
				Assembly assembly = typeof(ImageResourceExtension).GetTypeInfo().Assembly;
				Stream stream = assembly.GetManifestResourceStream(embeddedResourceName);
				fileService.WriteStream(fileResource, stream);
#endif
            }
            string documentsPath = fileService.PersonalPath;
            return (FileImageSource)ImageSource.FromFile(Path.Combine(documentsPath, fileResource));
        }

        object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider)
        {
            return ProvideValue(serviceProvider);
        }
    }

}
