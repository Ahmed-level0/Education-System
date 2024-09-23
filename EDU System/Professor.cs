using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace EDU_System
{
    public class Professor : Person
    {
        public static void PrintLine(){
            System.Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------");
        }
        public static void AddProfessor(List<Professor> pro)
        {
            System.Console.Write("Name : ");
            string name = Console.ReadLine();
            System.Console.Write("Password : ");
            string Password = Console.ReadLine();
            System.Console.Write("UserName : ");
            string userNAME = Console.ReadLine();
            System.Console.Write("ID : ");
            int ID = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Salary : ");
            double Salary = Convert.ToDouble(Console.ReadLine());
            System.Console.Write("Email : ");
            string Email = Console.ReadLine();
            Professor p = new Professor(name, userNAME, Password, ID);
            p.Email = Email;
            p.Salary = Salary;
            professors.Add(p);
            System.Console.WriteLine("Professor Added Successfully!");
            ProfessorsMenu();
        }
        public static void DeleteProfessor(List<Professor> p)
        {
            string DesiredName;
            int DesiredID;
            System.Console.Write("Enter Name : ");
            DesiredName = Console.ReadLine();
            System.Console.Write("Enter ID : ");
            DesiredID = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < professors.Count; i++)
            {
                if (professors[i].Name == DesiredName && professors[i].id == DesiredID)
                {
                    professors.Remove(professors[i]);
                    System.Console.WriteLine("Deleted!");
                }
            }
            ProfessorsMenu();
        }
        public static void AdjustProfessor(List<Professor> p)
        {
            bool found = false;
            System.Console.Write("Enter Professor UserName : ");
            string DesiredUserName = Console.ReadLine();
            System.Console.Write("Enter Professor Name : ");
            string DesiredName = Console.ReadLine();
            System.Console.Write("Enter Professor ID : ");
            int DesiredID = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < professors.Count; i++)
            {
                if (professors[i].Name == DesiredName && professors[i].id == DesiredID && professors[i].userName == DesiredUserName)
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
                    System.Console.WriteLine();
                    System.Console.Write("Choice >> ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            System.Console.Write("Enter new Name : ");
                            string newName = Console.ReadLine();
                            professors[i].Name = newName;
                            ProfessorsMenu();
                            break;

                        case 2:
                            System.Console.Write("Enter new UserName : ");
                            string newUserName = Console.ReadLine();
                            professors[i].userName = newUserName;
                            ProfessorsMenu();
                            break;

                        case 3:
                            System.Console.Write("Enter new Password : ");
                            string newPassword = Console.ReadLine();
                            professors[i].Password = newPassword;
                            ProfessorsMenu();
                            break;

                        case 4:
                            System.Console.Write("Enter new ID : ");
                            int newID = Convert.ToInt32(Console.ReadLine());
                            professors[i].id = newID;
                            ProfessorsMenu();
                            break;

                        case 5:
                            System.Console.Write("Enter new Salary : ");
                            double newSalary = Convert.ToDouble(Console.ReadLine());
                            professors[i].Salary = newSalary;
                            break;
                        default:
                            ProfessorsMenu();
                            break;
                    }
                }
                else
                {
                    System.Console.WriteLine("Not Found!");
                }
            }
        }
        public static void EditProfessorCourses(List<Professor> p)
        {
            System.Console.Write("Enter Professor Name : ");
            string DesiredName = Console.ReadLine();
            System.Console.Write("Enter Professor ID : ");
            int DesiredID = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < professors.Count; i++)
            {
                if (p[i].Name == DesiredName && p[i].id == DesiredID)
                {
                    System.Console.Write("Current Courses Are : ");
                    DisplayCourses(p[i]);
                }
                System.Console.WriteLine("To delete Course 1");
                System.Console.WriteLine("To Add Course 2");
                System.Console.Write("Choice >> ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        string CourseName = Console.ReadLine();
                        p[i].RemoveCourse(CourseName);
                        ProfessorsMenu();
                        break;
                    case 2:
                        CourseName = Console.ReadLine();
                        p[i].AddCourse(CourseName);
                        ProfessorsMenu();
                        break;
                    default:
                        ProfessorsMenu();
                        break;
                }
            }
        }
        public static void DisplayProfessors()
        {
            foreach (Professor PRO in professors)
            {
                PrintLine();
                System.Console.WriteLine($"Professor Name : {PRO.Name}   Professor ID : {PRO.id}   Professor UserName : {PRO.userName}  Professor Email : {PRO.Email} Professor Password : {PRO.Password}");
                PrintLine();
            }
        }
        public static void DisplayProfessorCourses(List<Professor> p)
        {
            System.Console.WriteLine("Enter Professor Name : ");
            string DesiredName = Console.ReadLine();
            System.Console.WriteLine("Enter Professor ID : ");
            int DesiredID = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <p.Count ; i++)
            {
                if (p[i].Name == DesiredName && p[i].id == DesiredID)
                {
                DisplayCourses(p[i]);
                }
          }
        }
        public static void DisplayCourses(Professor p){
            foreach (string Course in p.professorCourses)
            {
                System.Console.WriteLine($"Professor {p.Name} is Going On Teaching {Course}");
            }
        }
        public static List<Professor> professors = new List<Professor>();
        public static void ProfessorsMenu()
        {
            System.Console.WriteLine("1 - To Add professor press 1");
            System.Console.WriteLine("2 - To Delete professor press 2");
            System.Console.WriteLine("3 - To Adjust professor press 3");
            System.Console.WriteLine("4 - To Edit a professor's courses press 4");
            System.Console.WriteLine("5 - To Display All professors press 5");
            System.Console.WriteLine("6 - TO EXIT PRESS 6");
            System.Console.WriteLine("7 - TO Go Back To MainMenu 7");
            System.Console.Write("Choice >> ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    AddProfessor(professors);
                    break;

                case 2:
                    DeleteProfessor(professors);
                    break;
                case 3:
                    AdjustProfessor(professors);
                    break;

                case 4:
                    EditProfessorCourses(professors);
                    break;

                case 5:
                    DisplayProfessors();
                    ProfessorsMenu();
                    break;
                case 6:
                    ProfessorsMenu();
                    break;
                case 7: 
                    Program.DisplayMainMenu();
                    break;        
                default:
                    Program.DisplayMainMenu();
                    break;
            }
        }
        private string professorEmail = "Null";
        private double professorSalary;
        public List<string>  professorCourses = new List<string>();
        public Professor(string professorName, string professorUserName, string professorPassword, int professorID) : base(professorName, professorID, professorUserName, professorPassword) { }
        public double Salary
        {
            set { professorSalary = value; }
            get { return professorSalary; }
        }
        public string Email
        {
            set { professorEmail = value; }
            get { return professorEmail; }
        }
        public void AddCourse(string courseName)
        {
            professorCourses.Add(courseName);
        }
        public void RemoveCourse(string courseName){
            professorCourses.Remove(courseName);
        }    
    }
}