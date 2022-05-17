using System;
using System.Collections.Generic;
using System.Text;

namespace ClassProject
{
     class CourseManagment
    {
        public  List<Group> groups = new List<Group>();
        public Group GroupInput()
        {

            try
            {
                Categories category;
                Console.WriteLine("Select Group Type");
                Console.WriteLine("1: Programming");
                Console.WriteLine("2: Desing");
                Console.WriteLine("3: System Administration");
                Console.WriteLine("4: Marketing");
                int CategoryInput = int.Parse(Console.ReadLine());
                switch (CategoryInput)
                {
                    case 1:
                        category = Categories.Programming;
                        break;
                    case 2:
                        category = Categories.Design;
                        break;
                    case 3:
                        category = Categories.SystemAdministration;
                        break;
                    case 4:
                        category = Categories.Marketing;
                        break;
                    default: throw new Exception("We dont have this type category");
                }
                Console.WriteLine("This group online?");
                Console.WriteLine("1: Yes / 0: No");
                bool Isonline;
                string ison = Console.ReadLine();
                int isonInt = int.Parse(ison);

                if (isonInt == 1)
                {
                    Isonline = true;
                    Group group = new Group(category, Isonline);
                    groups.Add(group);
                    Console.WriteLine($"{category.ToString() + Group.count} Added Online Group");
                    Group.count--;

                }
                else
                {
                    Isonline = false;
                }


                if (!Isonline == true)
                {
                    Group group = new Group(category, Isonline);
                    groups.Add(group);
                    Console.WriteLine($"{category.ToString() + Group.count} Added Offline Group ");
                    Group.count--;


                }
                else
                {
                    return new Group(category, Isonline);

                }
                return new Group(category, Isonline);


            }
            catch (Exception)
            {
                Console.WriteLine("input error, please try again");

                return GroupInput();
            }

        }

        public void ShowGroupList()
        {
            foreach (Group group in groups)
            {
                Console.WriteLine(group.ToString());

            }

        }
        public void EditGroup()
        {
            if (true) 
            {

            }
        }
        public void FindGroup(string NewNumber)
        {
            foreach (Group group in groups)
            {
                if (group.No == NewNumber)
                {
                    Console.WriteLine(group);
                }

            }
        }
    }
}
