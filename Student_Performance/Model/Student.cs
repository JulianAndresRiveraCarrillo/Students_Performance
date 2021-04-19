using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Performance.Model
{
    class Student
    {
        private string v1;
        private int v2;

        

        public Student(string vi, int vii)
        {
            v1 = vi;
            v2 = vii;
        }

        public string V1
        {
            get => v1;
            set => v1 = value;
        }

        public int V2
        {
            get => v2;
            set => v2 = value;
        }

       
    }
}
