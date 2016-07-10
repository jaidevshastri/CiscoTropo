using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tropo
{
    class Program
    {
        static void Main(string[] args)
        {
            TropoREST tropoRest = new TropoREST();
            var result = tropoRest.tropoRequest().Result;
        }
    }
}
