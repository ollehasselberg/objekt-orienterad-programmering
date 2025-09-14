using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    //HÄR ÄR ETT EXEMPEL PÅ ARV-METODEN
    public class Animal

        //ATTRIBUT FÖR "ANIMAL"
    {
        public string Name;
        public int Age;
        //NU SKAPAR JAG METODER FÖR KLASSEN ANIMAL

        public void Print()
        {
            Console.WriteLine($"{Name} is an animal and is {Age} years old");
        }
            //Metoder som visar om djuret springer 
        public void Run()
        {
            Console.WriteLine("This animal runs");
        }
    }

    public class Owl : Animal
    {
        public int NumberOfLegs;

        public new void Print()
        {
            Console.WriteLine($"{Name} is an owl and is {Age} years old and has {NumberOfLegs} legs");
        }

        
            
    }


}    


