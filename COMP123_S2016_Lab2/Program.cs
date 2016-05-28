using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Lab2
{
    /**
     * This class is the "driver" class for our Program 
     * 
     * @class Program 
     */ 

    public class Program
    {
        /**
         * The main method of our driver class Program 
         * 
         * @method Main 
         * @param {string[]} args
         */
        public static void Main(string[] args)
        {
            // create a new instance of the Person class
            Person person = new Person("Pam");

            // set a value in the Name property of the Person class
            //person.Name = "Pam";

            // get the Name value and print to console
            Console.WriteLine(person.Name);
        }
    }
}
