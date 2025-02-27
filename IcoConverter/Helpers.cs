﻿using System;
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

        public static string DetermineType(string path)
        {

            if (path.ToLower().Contains(".jpg"))
            {
                return "JPG";
            }
            if (path.ToLower().Contains(".png"))
            {
                return "PNG";
            }
            return "Other";
        }


    }



}
