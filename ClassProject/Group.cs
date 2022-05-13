using System;
using System.Collections.Generic;
using System.Text;

namespace ClassProject
{
    class Group
    {
        public string No;
        public Categories Category;
        public bool Isonline;
        byte _Limit;
        public byte Limit { get { return _Limit; } }
        public List<Student> Students;
        public static int count = 100;
        public Group( Categories category, bool isonline)
        {
            if (isonline )
            {
                _Limit = 15;
            }
            else
            {
                _Limit = 10;
            }
            Students = new List<Student>();


            switch (category)
            {
                case Categories.Programming:
                    No = $"P" + count;
                    break;
                case Categories.Design:
                    No = $"D" + count;
                    break;
                case Categories.SystemaAdministration:
                    No = $"SA" + count;
                    break;
                case Categories.Marketing:
                    No = $"M" + count;
                    break;
                default:
                    break;
            }
            Category = category;
            count++;
        }
    }


}
