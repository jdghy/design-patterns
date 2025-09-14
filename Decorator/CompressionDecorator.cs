using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class CompressionDecorator : IFileOperation
    {
        private readonly IFileOperation _fileOperation;
        public CompressionDecorator(IFileOperation fileOperation)
        {
            _fileOperation = fileOperation;
        }
        public byte[] ReadFile(string path)
        {
            var compressedData = _fileOperation.ReadFile(path);
            return Decompress(compressedData);
        }
        public void WriteFile(string path, byte[] content)
        {
            var compressedData = Compress(content);
            _fileOperation.WriteFile(path, compressedData);
        }
        private byte[] Compress(byte[] data)
        {
            using (var memoryStream = new MemoryStream())
            {
                using (var gzipStream = new GZipStream(memoryStream, CompressionMode.Compress))
                {
                    gzipStream.Write(data, 0, data.Length);
                }
                return memoryStream.ToArray();
            }
        }
        private byte[] Decompress(byte[] data)
        {
            using (var memoryStream = new MemoryStream(data))
            using (var gzipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
            using (var resultStream = new MemoryStream())
            {
                gzipStream.CopyTo(resultStream);
                return resultStream.ToArray();
            }
        }
    }
}
