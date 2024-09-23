using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDU_System
{
    public class Student : Person
    {
        public static void StudentsMenu(){
            System.Console.WriteLine("1 - To Add Student press 1");
            System.Console.WriteLine("2 - To Delete Student press 2");
            System.Console.WriteLine("3 - To Adjust Student press 3");
            System.Console.WriteLine("4 - To Edit Student's Enrolled courses press 4");
            System.Console.WriteLine("5 - To Display All Students press 5");
            System.Console.WriteLine("6 - To Go Back To MainMenu 6");
            System.Console.WriteLine("Choice >> ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                AddStudent(students);
                break;
                case 2:
                DeleteStudent();
                break;
                case 3:
                AdjustStudent();
                break;
                case 4:
                EditStudentCourses(students);
                break;
                case 5:
                DisplayStudents();
                StudentsMenu();
                break;
                case 6:
                Program.DisplayMainMenu();
                break;
                default:
                StudentsMenu();
                break;
            }
        }
        static List <Student> students = new List<Student>();
        List <string> studentCourses = new List<string>();
        private string StudentEmail;
        private int grade;
        public Student(string Name, int id, string userName, string Password) : base(Name,id,Password,userName)
        {
        }
        public static void AddStudent(List <Student> s){
            System.Console.Write("Name : ");
            string name = Console.ReadLine();
            System.Console.Write("Password : ");
            string Password = Console.ReadLine();
            System.Console.Write("UserName : ");
            string userNAME = Console.ReadLine();
            System.Console.Write("ID : ");
            int ID = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Grade : ");
            int Grade = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Email : ");
            string Email = Console.ReadLine();
            Student S = new Student(name, ID, Password,userNAME);
            S.Email = Email;
            S.Grade = Grade;
            s.Add(S);
            System.Console.WriteLine("Professor Added Successfully!");
            StudentsMenu();
        }
        public static void DisplayStudents()
        {
            foreach (Student STD in students)
            {
                Professor.PrintLine();
                System.Console.WriteLine($"Student Name : {STD.Name}   Student ID : {STD.id}   Student UserName : {STD.userName}  Student Email : {STD.Email} Student Password : {STD.Password}");                
                System.Console.WriteLine("Current Courses Are : ");
                DisplayCourses(STD);
                Professor.PrintLine();
            }
        }
        public static void DeleteStudent(){
            string DesiredName;
            int DesiredID;
            System.Console.Write("Enter Name : ");
            DesiredName = Console.ReadLine();
            System.Console.Write("Enter ID : ");
            DesiredID = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Name == DesiredName && students[i].id == DesiredID)
                {
                    students.Remove(students[i]);
                    System.Console.WriteLine("Deleted!");
                }
            }
            StudentsMenu();
        }
        public static void AdjustStudent(){  
            bool found = false;
            System.Console.Write("Enter Professor UserName : ");
            string DesiredUserName = Console.ReadLine();
            System.Console.Write("Enter Professor Name : ");
            string DesiredName = Console.ReadLine();
            System.Console.Write("Enter Professor ID : ");
            int DesiredID = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Name == DesiredName && students[i].id == DesiredID && students[i].userName == DesiredUserName)
                {
                    found = true;
                }
                if (found)
                {
                    System.Console.WriteLine("What You like to Adjust");
                    System.Console.WriteLine("1 For Name");
                    System.Console.WriteLine("2 For UserName");
                    System.Console.WriteLine("3 For Password");
                    System.Console.WriteLine("4 For ID");
                    System.Console.WriteLine("5 For Salary");
                    System.Console.WriteLine("6 For Email");
                    System.Console.WriteLine();
                    System.Console.Write("Choice >> ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            System.Console.Write("Enter new Name : ");
                            string newName = Console.ReadLine();
                            students[i].Name = newName;
                            StudentsMenu();
                            break;

                        case 2:
                            System.Console.Write("Enter new UserName : ");
                            string newUserName = Console.ReadLine();
                            students[i].userName = newUserName;
                            StudentsMenu();
                            break;

                        case 3:
                            System.Console.Write("Enter new Password : ");
                            string newPassword = Console.ReadLine();
                            students[i].Password = newPassword;
                            StudentsMenu();
                            break;

                        case 4:
                            System.Console.Write("Enter new ID : ");
                            int newID = Convert.ToInt32(Console.ReadLine());
                            students[i].id = newID;
                            StudentsMenu();
                            break;

                        case 5:
                            System.Console.Write("Enter new Grade : ");
                            int newGrade = Convert.ToInt32(Console.ReadLine());
                            students[i].Grade = newGrade;
                            StudentsMenu();
                            break;
                        case 6:
                            System.Console.Write("Enter new Grade : ");
                            string newEmail = Console.ReadLine();
                            students[i].Email = newEmail;
                            StudentsMenu();
                            break;    
                        default:
                            StudentsMenu();
                            break;
                    }
                }
                else
                {
                    System.Console.WriteLine("Not Found!");
                }
            }
        }
        public static void EditStudentCourses(List <Student> s){
            
            System.Console.Write("Enter Assistant Name : ");
            string DesiredName = Console.ReadLine();
            System.Console.Write("Enter Assistant ID : ");
            int DesiredID = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < students.Count; i++)
            {
                if (s[i].Name == DesiredName && s[i].id == DesiredID)
                {
                System.Console.Write("Current Courses Are : ");
                DisplayCourses(s[i]);
                System.Console.WriteLine("To delete Course 1");
                System.Console.WriteLine("To Add Course 2");
                System.Console.WriteLine("To Go Back 3");
                System.Console.Write("Choice >> ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        string CourseName = Console.ReadLine();
                        s[i].studentCourses.Remove(CourseName);
                        StudentsMenu();
                        break;
                    case 2:
                        CourseName = Console.ReadLine();
                        s[i].studentCourses.Add(CourseName);
                        StudentsMenu();
                        break;
                    default:
                        StudentsMenu();
                        break;
                }
              }else{
                System.Console.WriteLine("Incorrect!");
                Program.DisplayMainMenu();
              }
            }
        }
        public static void DisplayCourses(Student s){
            foreach (string Course in s.studentCourses)
            {
                System.Console.WriteLine($"Student {s.Name} is Enrolled in {Course}");
            }
        }
        public string Email
        {
            set { StudentEmail = value; }
            get { return StudentEmail; }
        }
        public int Grade{
            set{ grade = value; }
            get { return grade; }
        } 
    }
}