using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class Student
    {
        //Instansfelter
        private string _name;
        private int _birthmonth;
        private int _birthday;

        //Properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Birthmonth
        {
            get { return _birthmonth; }
            set { _birthmonth = value; }
        }

        public int Birthday
        {
            get { return _birthday; }
            set { _birthday = value; }
        }
        //Constructor
        public Student(string name, int birthmonth, int birthday)
        {
            _name = name;
            _birthmonth = birthmonth;
            _birthday = birthday;
        }

    }
}
