using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
     class AccessModifier
    {
        private string name = "sudharshan raju";

        private string place = "konduru";

        public string Name
        {
            get { return name; }

            set { name = value; }
        }
        public string Place
        {
              get { return place; }
            set { place = value; }
        }
    }
}
