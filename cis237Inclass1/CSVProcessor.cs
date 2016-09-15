using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass1
{
    class CSVProcessor
    {
        //Setting the bath for the reader
        private string path = Path.Combine(Environment.CurrentDirectory + "../../../../datafiles/employees.csv");

        public bool ImportCSV(Employee[] employees)
        {
            //Declare a variable for the stream reader.
            StreamReader streamReader = null;
            //Start a try to verify the path to the file.
            //Throw an exception if incorrect.
            try
            {
                //Declare a string for each line we will read in.
                string line;
                //Instantiate the stream reader with the file path.
                streamReader = new StreamReader(this.path);
                //Setup a counter.
                int counter = 0;
                //While loop for processing the data in the file
                while ((line = streamReader.ReadLine()) != null)
                {
                    this.processLine(line, employees, counter);
                    counter++;
                }
                //All the reads are successful, return true.
                return true;
            }
            catch (Exception e)
            {
                //Output the exception and the stack trace.
                Console.WriteLine(e.ToString());
                Console.WriteLine();
                Console.WriteLine(e.StackTrace);
                //Return false, reading failed
                return false;
            }
            //Ensuring the stream reader gets closed regardless of try outcome.
            finally
            {
                //Check to make sure the stream was instantiated.
                if (streamReader != null)
                {
                    //Close the reader
                    streamReader.Close();
                }
            }
        }
        //Method for processing each line of text from the CSV file.
        private void processLine (string line, Employee[] employees, int index)
        {
            //Declare a string array and assigne the spline line to it.
            string[] parts = line.Split(',');
            //Assign the parts to local variables that mean something
            string firstName = parts[0];
            string lastName = parts[1];
            decimal salary = decimal.Parse(parts[2]);
            //Use the variables to create a new employee in the employees array at the index point that was passed in.
            employees[index] = new cis237Inclass1.Employee(firstName, lastName, salary);

        }
    }
}
