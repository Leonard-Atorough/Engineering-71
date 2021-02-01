using System;
using System.Collections.Generic;
using System.Text;

namespace SafariPark
{
    public class Person : IMovable
    {
        private string _firstName;
        private string _lastName;
        private int _age;

        public int Age { 
            get { return _age; }

            set
            { if (value >= 0) { _age = value; } }

        }
        public int Health { get; set; }

        //profull - full version of the above auto implemented property
        //private int myVar;

        //public int MyProperty
        //{
        //    get { return myVar; }
        //    set { myVar = value; }
        //}

        public Person(){ }

        public Person(string fName, string lName)
        {
            _firstName = fName;
            _lastName = lName;
        }

        public string GetFullName()
        {
            return ($"{_firstName} {_lastName}");
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Name:{GetFullName()}, Age:{Age}"; 
        }

        public string Move()
        {
            return "Walking Along";
        }

        public string Move(int times)
        {
            return $"Walking along {times} times";
        }
    }

}
