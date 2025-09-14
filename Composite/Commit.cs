using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    // Leaf
    public class Commit : GitComponent
    {
        private readonly string _commitId;

        public Commit(string commitId)
        {
            _commitId = commitId;
        }

        public override void ShowDetail()
        {
            Console.WriteLine($"- Commit ID: {_commitId}");
        }
    }
}
