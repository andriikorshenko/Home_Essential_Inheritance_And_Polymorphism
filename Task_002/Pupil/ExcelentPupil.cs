using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_002
{
    internal class ExcelentPupil : Pupil
    {
        public ExcelentPupil(string name) : base(name) { } 

        public override void Read()
            => Console.WriteLine("Read: EXCELENT");

        public override void Write()
            => Console.WriteLine("Write: EXCELENT");

        public override void Relax()
            => Console.WriteLine("Relax: EXCELENT");

        public override void Study()
            => Console.WriteLine("Study: EXCELENT");
    }
}
