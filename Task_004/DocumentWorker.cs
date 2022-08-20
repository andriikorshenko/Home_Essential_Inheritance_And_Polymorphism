using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_004
{
    internal class DocumentWorker
    {
        public virtual void OpenDocument()
            => Console.WriteLine("Документ открыт");
        public virtual void EditDocument()
            => Console.WriteLine("Редактирование документа доступно в версии PRO");
        public virtual void SaveDocument()
            => Console.WriteLine("Сохранение документа доступно в версии PRO");
    }
}
