using System;
using System.IO;
using Myth.CreditGuard.Sharp.Framework;
using Myth.CreditGuard.Sharp.iOS.Framework;
using Xamarin.Forms;

[assembly: Dependency(typeof(FileService))]
namespace Myth.CreditGuard.Sharp.iOS.Framework
{
    public class FileService : IFileService
    {
        public string PersonalPath => Environment.GetFolderPath(Environment.SpecialFolder.Personal);

        public bool Exists(string fileName)
        {
			var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			var filePath = Path.Combine(documentsPath, fileName);
            return File.Exists(filePath);
        }

        public void WriteAllText(string filename, string text)
		{
			var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			var filePath = Path.Combine(documentsPath, filename);
            File.WriteAllText(filePath, text);
		}

		public void WriteStream(string fileName, Stream stream)
		{
			var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			var filePath = Path.Combine(documentsPath, fileName);
			byte[] buffer = new byte[10240];
			int sizeRead;
            FileInfo fileInfo = new FileInfo(fileName);
            string directoryPath = Path.GetDirectoryName(filePath);
            Directory.CreateDirectory(directoryPath);
			using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
			{
				do
				{
					sizeRead = stream.Read(buffer, 0, buffer.Length);
					fileStream.Write(buffer, 0, sizeRead);
				} while (sizeRead == buffer.Length);
			}
		}

		public string ReadAllText(string filename)
		{
			var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			var filePath = Path.Combine(documentsPath, filename);
			return File.ReadAllText(filePath);
		}


    }
}
