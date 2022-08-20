using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_005
{
    internal class DocumentB : Printer
    {
        public DocumentB() 
            => Console.ForegroundColor = ConsoleColor.Red;
    }
}
