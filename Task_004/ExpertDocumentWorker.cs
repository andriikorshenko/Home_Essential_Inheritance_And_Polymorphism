using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_004
{
    internal class ExpertDocumentWorker : DocumentWorker
    {
        public override void OpenDocument()
            => Console.WriteLine("Документ открыт");
        public override void EditDocument()
            => Console.WriteLine("Документ отредактирован");
        public override void SaveDocument()
            => Console.WriteLine("Документ сохранен в новом формате");
    }
}
