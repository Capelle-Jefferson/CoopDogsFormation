using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoopDogsFormation.Models
{
    public class InputGenerateModel
    {
        public InputGenerateModel(string name, string property, string type)
        {
            Name = name;
            Property = property;
            Type = type;
        }
        public string Name { get; set; }
        public string Property { get; set; }
        public string Type { get; set; }
    }
}
