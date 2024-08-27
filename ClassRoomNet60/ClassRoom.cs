using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class ClassRoom
    {
        private string _className;

        public DateTime _semesterStart;

        public DateTime SemesterStart
        {
            get { return _semesterStart; }
            set { _semesterStart = value; }
        }
        public string Classname
        {
            get { return _className; }
            set { _className = value; }
        }

        public List<Student> Studentlist;

        public ClassRoom(DateTime semesterStart, string classname)
        {
            SemesterStart = semesterStart;
            Classname = classname;
        }
    }
}
