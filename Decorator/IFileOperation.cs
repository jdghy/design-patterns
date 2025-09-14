using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public interface IFileOperation
    {
        byte[] ReadFile(string path);
        void WriteFile(string path, byte[] content);
    }
}
