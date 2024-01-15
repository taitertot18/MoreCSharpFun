using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreCSharpFun
{
    internal class PrintStuff
    {
        private string language;

        /*Contructor - we can have more than one constructor!*/

        public PrintStuff()
        {
            language = "EN";
        }
        public PrintStuff(string temp)
        {
            language = temp;
        }

        /*the method signature (parameters) need to be different but the
         * names can be the same*/
        public void PrintName(string n)
        {
            if (language == "EN")
            {
                System.Console.WriteLine("Hello, " + n + "!");
            }

            if (language == "PT")
            {
                System.Console.WriteLine("Oi, " + n + "!");
            }

        }
    }
}
