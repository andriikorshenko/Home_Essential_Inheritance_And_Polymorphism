using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_002
{
    internal class Pupil
    {
        private string name; 

        public virtual void Study() { }

        public virtual void Read() { }

        public virtual void Write() { }

        public virtual void Relax() { }

        public void Show()
        {
            Console.WriteLine($"{name}");
            Study();
            Read();
            Write();
            Relax();
            Console.WriteLine($"\n{new String('*', 3)}\n");
        }

        public Pupil(string name)
            => this.name = name;
        
    }
}
