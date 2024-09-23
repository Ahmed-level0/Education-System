using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDU_System
{
    public class Courses
    {
        public static void CoursesMenu(){
            System.Console.WriteLine("1 - To Add Course press 1");
            System.Console.WriteLine("2 - To Delete Course press 2");
            System.Console.WriteLine("3 - To Display All Courses press 3");
            System.Console.WriteLine("5 - To Edit Course press 4");
            System.Console.WriteLine("5 - To Go Back 5");
            System.Console.Write("Choice >> ");
            int Choice = Convert.ToInt32(Console.ReadLine());
            switch (Choice)
            {
                case 1:
                AddCourse();
                CoursesMenu();
                break;

                case 2:
                RemoveCourse();
                CoursesMenu();
                break;

                case 3:
                DisplayCourses();
                CoursesMenu();
                break;
                
                case 4:
                EditCourses();
                CoursesMenu();
                break;
                
                default:
                Program.DisplayMainMenu();
                break;
            }
        }
        private string courseName;
        private int courseID;
        private string courseCode;
        private int hoursRate;
        static List <Courses> courses = new List<Courses>();
        public String CourseCode{
            set { courseCode = value; }
            get{ return courseCode; }
        }
        public int CourseID{
            set { courseID = value; }
            get{ return courseID; }
        }
        public String CourseName{
            set { courseName = value; }
            get{ return courseName; }
        }
        public int HoursRate{
            set { hoursRate = value; }
            get { return hoursRate;  }
        }
        public static void AddCourse(){
            Courses course = new Courses();
            System.Console.Write("Enter Course Name: ");
            string CourseName = Console.ReadLine();
            System.Console.Write("Enter Course ID: ");
            int CourseID = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Enter Course Code: ");
            string CourseCode = Console.ReadLine();
            System.Console.Write("Enter Course Hours Rate: ");
            int CourseHoursRate = Convert.ToInt32(Console.ReadLine());
            course.CourseName = CourseName;
            course.CourseID = CourseID;
            course.CourseCode = CourseCode;
            course.HoursRate = CourseHoursRate;
            courses.Add(course);
        }
        public static void RemoveCourse(){
            System.Console.Write("Please Enter Course Code: ");
            string DesiredCourseCode = Console.ReadLine();
            for (int i = 0; i < courses.Count; i++)
            {
                if (courses[i].courseCode == DesiredCourseCode)
                {
                    courses.Remove(courses[i]);
                    System.Console.WriteLine("Deleted!");                    
                }
            }
        }    
        public static void DisplayCourses(){
            System.Console.WriteLine("Courses Are");
            foreach (Courses course in courses)
            {
                Professor.PrintLine();
                System.Console.WriteLine($" Course Name: {course.CourseName} Course ID: {course.CourseID} Course Code: {course.CourseCode} Course Hours Rate: {course.HoursRate}");
                Professor.PrintLine();
            }
        }    
        public static void EditCourses(){
            System.Console.Write("Please Enter Desired Course Code: ");
            string DesiredCourseCode = Console.ReadLine();
            bool found = false;
            for (int i = 0; i < courses.Count; i++)
            {
            if (DesiredCourseCode == courses[i].CourseCode)
            {
                found = true;
            }
            if (found)
            {
                System.Console.WriteLine("To Edit Course Name 1");
                System.Console.WriteLine("To Edit Course Code 2");
                System.Console.WriteLine("To Edit Course ID 3");
                System.Console.WriteLine("To Edit Course Hours Rate 4");
                System.Console.Write("Choice >> ");
                int Choice = Convert.ToInt32(Console.ReadLine());
                switch (Choice)
                {   
                    case 1:
                    System.Console.Write("Please Enter New Course Name: ");
                    string NewCourseName = Console.ReadLine();
                    courses[i].CourseName = NewCourseName;
                    break;
                    case 2:
                    System.Console.Write("Please Enter New Course Code: ");
                    string NewCourseCode = Console.ReadLine();
                    courses[i].CourseCode = NewCourseCode;
                    break;
                    case 3:
                    System.Console.Write("Please Enter New Course ID: ");
                    int NewCourseID = Convert.ToInt32(Console.ReadLine());
                    courses[i].CourseID = NewCourseID;
                    break;
                    case 4:
                    System.Console.Write("Please Enter New Course Hours Rate: ");
                    int NewCourseHoursRate = Convert.ToInt32(Console.ReadLine());
                    courses[i].HoursRate = NewCourseHoursRate;
                    break;

                    default:
                    CoursesMenu();
                    break;
                    }
                }else{
                    System.Console.WriteLine("Not Found");
                    CoursesMenu();
                } 
            }
        }
    }
}