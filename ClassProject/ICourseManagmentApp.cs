using System;
using System.Collections.Generic;
using System.Text;

namespace ClassProject
{
    interface ICourseManagmentApp
    {
        public  List <Group> Groups { get; }
        void CreatGroup();
        void ShowGroupLIst();
        void EditGroup();
        void ShowGroupStudentList();
        void ShowAllStudentList();
        void CreateStudent();
        void DeletedStudent();




    }
}
