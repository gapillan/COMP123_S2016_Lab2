using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Lab2
{
    /**
     * This class defines a generic Person 
     * 
     *@class Person 
     *@field _name {string} 
     */
    public class Person
    {
        // PRIVATE INSTANCE VARAIABLES 
        private string _name; 

        // PUBLIC PROPERTIES 

        /**
         * <summary>
         * This is a property for our _name field 
         * 
         * @property {string} Name
         */
        public string Name 
        {
            get 
            {
                return this._name;
            }

            set 
            {
                this._name = value; 
            }
        }

        /**
         * <summary>
         * This is the default empty constructor for the Person class 
         * </summary>
         * @contructor Person
         */
        public Person() 
        {
            this._name = "unknown name!";
        }

        /**
         * <summary>
         * This is a constructor that takes name as a parameter and passes 
         * it to the _name private instance variable 
         * </summary>
         * @contructor Person
         * @param {string} name
         */
        public Person(string name)
        {
            this._name = name;
        }

        /**
         * <summary>
         * This method outputs the _name value with " says Hello!" to the console.
         * </summary>
         * @method _sayHello() 
         * @returns {void}
         */
        private void _sayHello() 
        {
            Console.WriteLine(this._name + " says Hello!" );
        }
    }
}
