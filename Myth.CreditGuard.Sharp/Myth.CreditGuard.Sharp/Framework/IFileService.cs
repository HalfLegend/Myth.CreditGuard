using System.IO;

namespace Myth.CreditGuard.Sharp.Framework
{
    public interface IFileService
	{
		void WriteAllText(string filename, string text);
        void WriteStream(string fileName, Stream stream);
        bool Exists(string fileName);
		string ReadAllText(string filename);
        string PersonalPath { get; }
	}
}
