using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcoConverter
{
   public static class  Helpers
    {

        public static List<string> BuildSizes()
        {
            List<string> options = ["32", "64"];
            return options;
        }

    }
}
