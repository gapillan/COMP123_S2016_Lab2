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
         * This is the default empty constructor for the Person class 
         * 
         * @contructor Person
         */
        public Person() 
        {

        }
    }
}
