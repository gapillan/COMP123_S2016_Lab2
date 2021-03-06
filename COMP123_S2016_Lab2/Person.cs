﻿using System;
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
        // PRIVATE INSTANCE VARAIABLES ++++++++++++++++++++++++++++++++++++
        private string _name;
        private int _age;

        // PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This is a public property for our private _name field 
         * </summary>
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
                //Console.WriteLine("_name value set");
                this._name = value; 
            }
        }

        /** 
         * <summary>
         * This is a public property for our private _age field
         * </summary>
         * @property {int} Age
         */
        public int Age 
        {
            get 
            {
                return this._age;
            }

            set 
            {
                this._age = value; 
            }
        } 

        // CONSTRUCTORS +++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This is the default empty constructor for the Person class 
         * </summary>
         * @contructor Person
         */
        public Person() 
        {
            this._initialize();
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
            this.Name = name;
            this.Age = 0;
        }

        /**
         *<summary> 
         *This is a constructor that takes age as a parameter and passes
         *it to the _age private instance variable 
         *</summary> 
         *@constructor Person 
         *@param {int} age
         */
        public Person(int age) 
        {
            this.Name = "unknown name";
            this.Age = age;
        }
        /**
         * <summary>
         * This is a constructor that takes both name and age as paramters. 
         * It assigns the local name value to the Name property.
         * It assigns the local age value to the Age property.
         * </summary>
         * 
         * @constructor Person 
         * @param {string} name 
         * @param {int} age 
         */
        public Person(string name, int age) 
        {
            this.Name = name;
            this.Age = age;
        }
        
        // PRIVATE METHODS ++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This method initializes the public properties Name and Agge 
         * </summary>
         * 
         * @private 
         * @method _initialize 
         * @returns {void}
         */
        private void _initialize()
        {
            this.Name = "unknown name!";
            this.Age = 0;
        }




        // PUBLIC METHODS +++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This method outputs the _name value with " says Hello!" to the console.
         * </summary>
         * @method SaysHello() 
         * @returns {void}
         */
        public void SaysHello() 
        {
            Console.WriteLine(this.Name + " says Hello!" );
        }

        /**
         * <summary>
         * This method outputs the _name and _age values in the following
         * format: _name + " is " + this.Age " years old".
         * </summary>
         * 
         * @method ShowAge 
         * @returns {void}
         */
        public void ShowAge() 
        {
            Console.WriteLine(this.Name + " is " + this.Age);
        }
    }
}
