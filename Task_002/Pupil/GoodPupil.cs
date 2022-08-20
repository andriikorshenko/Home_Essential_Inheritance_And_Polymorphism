using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_002
{
    internal class GoodPupil : Pupil
    {
        public GoodPupil(string name) : base(name) { }

        public override void Read()
            => Console.WriteLine("Read: GOOD");

        public override void Write()
            => Console.WriteLine("Write: GOOD");

        public override void Relax()
            => Console.WriteLine("Relax: GOOD");

        public override void Study()
            => Console.WriteLine("Study: GOOD");
    }
}
