using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    // 2. The Flyweight Factory
    public class TreeFactory
    {
        private static Dictionary<string, TreeType> _treeTypes = new();

        public static TreeType GetTreeType(string name, string color, string texture)
        {
            string key = $"{name}_{color}_{texture}";
            if (!_treeTypes.ContainsKey(key))
            {
                _treeTypes[key] = new TreeType(name, color, texture);
                Console.WriteLine($"-- Created NEW TreeType: {name}");
            }
            return _treeTypes[key];
        }
    }
}
