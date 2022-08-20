using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_005
{
    internal class DocumentC : Printer
    {
        public DocumentC() 
            => Console.ForegroundColor = ConsoleColor.Blue;
    }
}
