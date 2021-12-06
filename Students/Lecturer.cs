using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    internal class Lecturer
    {
        public string name;
        public string nameStudent;
        public string idStudent;
        public int[] grades;
        public Lecturer(string name, string nameStudent,string idStudent, int[] grades)
        {
            this.name = name;
            this.nameStudent = nameStudent;
            this.idStudent=idStudent;
            this.grades = grades;
        }
    }
}
