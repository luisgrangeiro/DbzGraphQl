using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbzGraphQl.Types
{
    public class BaseCharacter
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string[] Enemies { get; set; }
        public int Power { get; set; }
    }
}
