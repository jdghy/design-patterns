using System.Text;

namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The file path where the compressed file will be stored
            string compressedFilePath = "compressedFile.gz";

            // Original data to be written to the file
            string originalData = "This is some sample data to be compressed and written to a file.";
            byte[] dataToWrite = Encoding.UTF8.GetBytes(originalData);

            //Intialize the file operation with compression decorator
            IFileOperation fileOperation = new CompressionDecorator(new FileOperation());

            //Compress and write data to the file
            fileOperation.WriteFile(compressedFilePath, dataToWrite);
            Console.WriteLine("Data written to file with compression" + compressedFilePath);
            //Read and decompress data from the file
            byte[] readData = fileOperation.ReadFile(compressedFilePath);

            //Convert the byte array back to string
            string decompressedData = Encoding.UTF8.GetString(readData);
            Console.WriteLine("Decompressed Data: " + decompressedData);
        }
    }
}
