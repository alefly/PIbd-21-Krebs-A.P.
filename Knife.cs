using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Knife
    {
        public void Clean(Potato p)
        {
            if (p.Have_skin)
            {
                p.Have_skin = false;
            }
        }
        public void Cut(Potato p)
        {
            if (p.Have_wholeness)
            {
                p.Have_wholeness = false;
            }
        }
    }
}
