using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Front_End
{
    class Plane
    {
        protected string name;
        public string Name{ set { name = value; } get { return name; } }

        protected string code;
        public string Code { set { code = value; } get { return code; } }

        protected int capacity;
        public int Capacity { set { capacity = value; } get { return capacity; } }
        
    }
}
