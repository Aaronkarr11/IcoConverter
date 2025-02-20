using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcoConverter
{
    public class IcoConverterViewModel
    {
        public IcoConverterViewModel()
        {
            IcoSize = Helpers.BuildSizes();
        }

        public List<string> IcoSize { get; set; }

        public string? Message { get; set; }

    }
}
