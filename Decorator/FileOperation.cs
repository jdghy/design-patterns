using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class FileOperation:IFileOperation
    {
        public  byte[] ReadFile(string path)
        {
            return File.ReadAllBytes(path);
        }
        public void WriteFile(string path, byte[] content)
        {
            File.WriteAllBytes(path, content);
        }

    }
}
