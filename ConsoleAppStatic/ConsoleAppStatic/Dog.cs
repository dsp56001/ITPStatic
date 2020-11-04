using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppStatic
{
    class Dog
    {
        //Properties
        public string Name;
        public int Age;
        public int Weight;
        public int BarkCount;
        public string BarkSound;

        //This property belongs to the Dog class and not an instance of Dog
        public static int TotalBarks;
    
        //Constructor
        public Dog()
        {
            this.Name = "fido";
            this.Age = 3;
            this.Weight = 6;
            this.BarkSound = "woof";
        }

        public string Bark()
        {
            this.BarkCount++;
            Dog.TotalBarks++;
            return this.BarkSound;
        }
    }
}
