using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input number");// prompts user input
            int number = Convert.ToInt32(Console.ReadLine());
            int secretnumber = 37;// intger secretnumber = 37 

            if (number > secretnumber) {// if number  greater than secretnumber 
                Console.WriteLine("Too high!");// if number is greater than secretnumber it prints out "Too High"
                    }
            if (number < secretnumber) // if number less than secretnumber 
            {
                Console.WriteLine("Too low!");// if number is less than secretnumber print out "Too Low!"
            }
            if (number == secretnumber) //if number equal to secretnumber  
            {
                Console.WriteLine("Correct!"); //if number is equal to secretnumber  then it prints out "Correct"
            }
        }
    }
}
