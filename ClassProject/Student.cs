using System;
using System.Collections.Generic;
using System.Text;

namespace ClassProject
{
    class Student
    {
        private uint _ID;
        public uint ID { get { return _ID; } }
        public string FullName;
        public string GroupNo;
        public bool Type;
        public static uint StudentsCount;

        public Student()
        {
            StudentsCount = 1;
        }

        public Student(string fullname, string groupno)
        {
            FullName = fullname;
            GroupNo = groupno;
            Type = false;
            _ID = StudentsCount;
            StudentsCount++;


        }
    }

}
