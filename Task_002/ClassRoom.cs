using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_002
{
    internal class ClassRoom
    {
        public Pupil p1;
        public Pupil p2;
        public Pupil p3;
        public Pupil p4;

        public ClassRoom(Pupil p1, Pupil p2, Pupil p3, Pupil p4) 
        { 
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;
        }

        public ClassRoom(Pupil p1, Pupil p2, Pupil p3) 
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
        }

        public ClassRoom(Pupil p1, Pupil p2) 
        {
            this.p1 = p1;
            this.p2 = p2;
        }
    }
}
