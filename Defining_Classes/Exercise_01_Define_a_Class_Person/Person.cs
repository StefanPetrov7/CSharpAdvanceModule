﻿using System;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
        private string name;

        private int age;

        public Person()
        {
            Name = "No name";
            Age = 1;
        }

        public Person(int age) : this()
        {
            this.Age = age;
        }

        public Person(int age, string name) : this(age)
        {
            this.Name = name;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.Age}";
        }
    }
}
