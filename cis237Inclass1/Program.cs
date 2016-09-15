using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee myEmployee = new Employee("David", "Hatten", 697.36m);

            //Console.WriteLine(myEmployee.LastName + ", " + myEmployee.FirstName + ": " + myEmployee.WeeklySalary);
            //Console.WriteLine(myEmployee.Reporting());
            //Console.WriteLine(myEmployee);

            Employee[] employees = new Employee[5];
            CSVProcessor processor = new CSVProcessor();
            processor.ImportCSV(employees);


            //employees[0] = new Employee("James", "Kirk", 453.00m);
            //employees[1] = new Employee("Jean-Luc", "Picard", 607.00m);
            //employees[2] = new Employee("Benjamin", "Sisko", 556.00m);
            //employees[3] = new Employee("Kathryn", "Janeway", 290.00m);
            //employees[4] = new Employee("Johnathan", "Archer", 180.00m);
            //employees[5] = new Employee("Geordi", "LeForge", 190.00m);
            //employees[6] = new Employee("Wesly", "Crusher", 1.00m);
            //employees[7] = new Employee("Benjamin", "Sulu", 200.00m);
            //employees[8] = new Employee("Mister", "Spock", 250.00m);
            //employees[9] = new Employee("Beverly", "Crusher", 225.00m);

            //foreach (Employee employee in employees)
            //{
            //    if (employee != null)
            //    {
            //        Console.WriteLine(employee.Reporting());
            //    }
            //}

            UserInterface ui = new UserInterface();

            int choice = ui.GetUserInput();

            while (choice != 2)
            {
                if (choice == 1)
                {
                    string alloutput = "";

                    foreach (Employee employee in employees)
                    {
                        if (employee != null)
                        {
                            alloutput += employee.Reporting() + Environment.NewLine;
                        }
                    }

                    ui.PrintAllOutput(alloutput);
                }
                choice = ui.GetUserInput();
            }
            


        }
    }
}
