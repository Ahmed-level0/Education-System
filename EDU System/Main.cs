using System.Runtime.InteropServices;
using EDU_System;
namespace EDU_System{

public class Program{
        public static void  DisplayMainMenu()
        {
            System.Console.WriteLine("Welcome!");
            System.Console.WriteLine("1 - For Professors menu press 1");
            System.Console.WriteLine("2 - For Assistants menu press 2");
            System.Console.WriteLine("3 - For Students menu press 3");
            System.Console.WriteLine("4 - For Courses menu press 4");
            System.Console.Write("Choice >> ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice) {
                case 1:
                    Professor.ProfessorsMenu();
                    break;
                    
                case 2:
                    Assistant.AssistantsMenu();
                    break;
                    
                case 3:
                    Student.StudentsMenu();
                    break;
                    
                case 4:
                    Courses.CoursesMenu();
                    break;
                default:
                    break;
            }
        }  
        static void Main(string[] args) {
            DisplayMainMenu();
        }    
    }
}