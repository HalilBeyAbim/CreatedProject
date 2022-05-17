using System;

namespace ClassProject
{
    class Program
    {
        private static int selection;

        static void Main(string[] args)
        {
            CourseManagment courseManagment = new CourseManagment();
            while (true)
            {
                do
                {
                    Console.WriteLine("\nMenu");
                    Console.WriteLine("1: Created Group");
                    Console.WriteLine("2: Show Group list");
                    Console.WriteLine("3: Edit Group");
                    Console.WriteLine("4: Show Group Student LIst");
                    Console.WriteLine("5: Show All Student List");
                    Console.WriteLine("6: Create Student");
                    Console.WriteLine("7: Deleted Student");
                    Console.WriteLine("0: Exit");
                    Console.WriteLine("Select a number from 0 to 7 ");
                    int MenuIndex = int.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (MenuIndex)
                    {
                        case 1:
                            courseManagment.GroupInput();
                            break;
                        case 2:
                            courseManagment.ShowGroupList();
                            break;
                        //case 3:
                        //    courseManagment.EditGroup();
                        //    break;

                    }
                }
                while (selection != 0);
                {
                   
                }

            }
        }
    }
}
