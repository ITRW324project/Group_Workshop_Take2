using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop
{
    class Except
    {
        public bool BetweenTest(int i)
        {
            if (i > 5 && i < 20)
                return true;
            return false;
        }

    }
}
