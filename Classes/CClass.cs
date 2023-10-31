using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class CClass
    {
        public string ClassName { get; set; }
        public int Year { get; set; }
        public List<Student> Students { get; set; }
        public List<Subject> Subjects { get; set; }
        public List<Teacher> Teachers { get; set; }

        public CClass()
        {
            Students = new List<Student>();
            Subjects = new List<Subject>();
            Teachers = new List<Teacher>();
        }
    }

}
