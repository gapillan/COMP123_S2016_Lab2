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
            Person dan = new Person();
            dan.Name = "Daniela";
            dan.Age = 20;
            dan.SaysHello();
            dan.ShowAge();

            Console.WriteLine();

            Person pam = new Person("Pamela");
            pam.Age = 21;
            pam.SaysHello();
            pam.ShowAge();

            Console.WriteLine();

            Person jon = new Person(22);
            jon.Name = "Jonathan";
            jon.SaysHello();
            jon.ShowAge();

            Console.WriteLine();

            Person apes = new Person("April", 23);
            apes.SaysHello();
            apes.ShowAge(); 
        }
    }
}
