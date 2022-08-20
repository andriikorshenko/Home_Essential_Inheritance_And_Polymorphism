using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_002
{
    internal class BadPupil : Pupil
    {
        public BadPupil(string name) : base(name) { }

        public override void Read()
            => Console.WriteLine("Read: BAD");

        public override void Write()
            => Console.WriteLine("Write: BAD");

        public override void Relax()
            => Console.WriteLine("Relax: BAD");

        public override void Study()
            => Console.WriteLine("Study: BAD");
    }
}
