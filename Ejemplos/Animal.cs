// ejemplos de clases y objetos en C#
using System;

namespace Democlases.Ejemplos;
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Speak()
        {
            Console.WriteLine($"{Name} says hello!");
        }
    }

