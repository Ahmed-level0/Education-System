using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDU_System
{
    public class Assistant : Person
    {
        public Assistant(string Name, int id, string userName, string Password) : base(Name, id,Password,userName)
        {
        }
        public static void AddAssistant(List<Assistant> ass)
        {
            System.Console.Write("Name : ");
            string name = "Null";
            name = Console.ReadLine();
            System.Console.Write("Password : ");
            string Password = "Null";
            Password = Console.ReadLine();
            System.Console.Write("UserName : ");
            string userNAME = "";
            userNAME = Console.ReadLine();
            System.Console.Write("ID : ");
            int ID = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Salary : ");
            double Salary = Convert.ToDouble(Console.ReadLine());
            System.Console.Write("Email : ");
            string Email = "";
            Email = Console.ReadLine();
            Assistant a = new Assistant(name, ID, Password,userNAME );
            a.Email = Email;
            a.Salary = Salary;
            ass.Add(a);
            System.Console.WriteLine("Assistant Added Successfully!");
            AssistantsMenu();
        }
        public static void DisplayAssistants()
        {
            foreach (Assistant ASS in assistants)
            {
                Professor.PrintLine();
                System.Console.WriteLine($"Assistant Name : {ASS.Name}   Assistant ID : {ASS.id}   Assistant UserName : {ASS.userName}  Assistant Email : {ASS.Email} Assistant Password : {ASS.Password}");
                Professor.PrintLine();
            }
        }    
        public static void DeleteAssistant(){
            string DesiredName;
            int DesiredID;
            System.Console.Write("Enter Name : ");
            DesiredName = Console.ReadLine();
            System.Console.Write("Enter ID : ");
            DesiredID = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < assistants.Count; i++)
            {
                if (assistants[i].Name == DesiredName && assistants[i].id == DesiredID)
                {
                    assistants.Remove(assistants[i]);
                    System.Console.WriteLine("Deleted!");
                }
            }
            AssistantsMenu();
        }
        public static void AdjustAssistant(){
            
            bool found = false;
            System.Console.Write("Enter Professor UserName : ");
            string DesiredUserName = Console.ReadLine();
            System.Console.Write("Enter Professor Name : ");
            string DesiredName = Console.ReadLine();
            System.Console.Write("Enter Professor ID : ");
            int DesiredID = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < assistants.Count; i++)
            {
                if (assistants[i].Name == DesiredName && assistants[i].id == DesiredID && assistants[i].userName == DesiredUserName)
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
                            assistants[i].Name = newName;
                            AssistantsMenu();
                            break;

                        case 2:
                            System.Console.Write("Enter new UserName : ");
                            string newUserName = Console.ReadLine();
                            assistants[i].userName = newUserName;
                            AssistantsMenu();
                            break;

                        case 3:
                            System.Console.Write("Enter new Password : ");
                            string newPassword = Console.ReadLine();
                            assistants[i].Password = newPassword;
                            AssistantsMenu();
                            break;

                        case 4:
                            System.Console.Write("Enter new ID : ");
                            int newID = Convert.ToInt32(Console.ReadLine());
                            assistants[i].id = newID;
                            AssistantsMenu();
                            break;

                        case 5:
                            System.Console.Write("Enter new Salary : ");
                            double newSalary = Convert.ToDouble(Console.ReadLine());
                            assistants[i].Salary = newSalary;
                            AssistantsMenu();
                            break;
                        default:
                            AssistantsMenu();
                            break;
                    }
                }
                else
                {
                    System.Console.WriteLine("Not Found!");
                }
            }
        }
        public static void EditAssistantCourses(List <Assistant> a){
            System.Console.Write("Enter Assistant Name : ");
            string DesiredName = Console.ReadLine();
            System.Console.Write("Enter Assistant ID : ");
            int DesiredID = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < assistants.Count; i++)
            {
                if (a[i].Name == DesiredName && a[i].id == DesiredID)
                {
                    System.Console.Write("Current Courses Are : ");
                    DisplayCourses(a[i]);
                
                System.Console.WriteLine("To delete Course 1");
                System.Console.WriteLine("To Add Course 2");
                System.Console.WriteLine("To Go Back 3");
                System.Console.Write("Choice >> ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        string CourseName = Console.ReadLine();
                        a[i].assistantCourses.Remove(CourseName);
                        AssistantsMenu();
                        break;
                    case 2:
                        CourseName = Console.ReadLine();
                        a[i].assistantCourses.Add(CourseName);
                        AssistantsMenu();
                        break;
                    default:
                        AssistantsMenu();
                        break;
                }
              }else{
                System.Console.WriteLine("Incorrect!");
                Program.DisplayMainMenu();
              }
            }
        }
        public static List<Assistant> assistants = new List<Assistant>();
        public List<string>  assistantCourses = new List<string>();
        public static void AssistantsMenu(){
            System.Console.WriteLine("1 - To Add Assistant press 1");
            System.Console.WriteLine("2 - To Delete Assistant press 2");
            System.Console.WriteLine("3 - To Adjust Assistant press 3");
            System.Console.WriteLine("4 - To Edit an Assistant's courses press 4");
            System.Console.WriteLine("5 - To Display All Assistant press 5");
            System.Console.WriteLine("6 - TO EXIT PRESS 6");
            System.Console.WriteLine("7 - To Go Back To MainMenu 7");
            System.Console.Write("Choice >> ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                AddAssistant(assistants);
                AssistantsMenu();
                break;
                
                case 2:
                DeleteAssistant();
                break;

                case 3:
                AdjustAssistant();
                break;
                case 4:
                EditAssistantCourses(assistants);
                break;
                case 5:
                DisplayAssistants();
                AssistantsMenu();
                break;
                case 6:
                AssistantsMenu();
                break;
                case 7:
                Program.DisplayMainMenu();
                break;
                default:
                AssistantsMenu();
                break;
            }
        }
        private string assistantEmail = "Null";
        private double assistantSalary;
        public double Salary
        {
            set { assistantSalary = value; }
            get { return assistantSalary; }
        }
        public string Email
        {
            set { assistantEmail = value; }
            get { return assistantEmail; }
        }
        public static void DisplayCourses(Assistant a){
            foreach (string Course in a.assistantCourses)
            {
                System.Console.WriteLine($"Assistant {a.Name} is Helping On Teaching {Course}");
            }
        }
    }
}