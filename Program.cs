using System.Drawing;
using System.Reflection.Metadata;

namespace OOP
{

    internal class Program
    {
        static void Main(string[] args)
        {
               //OBJEKT & METODER FÖR KLASSERNA I "POLYMORPHISM"

            Vehicle vehicle1 = new Vehicle();
            vehicle1.Move();

            
            Car car1 = new Car();
            car1.Move();

            Car car2 = new Car();
            car2.Stop();

             //SKAPAR OBJEKT & SÄTTER ATTRIBUT FÖR KLASSERNA I "ARV"

            Animal animal = new Animal();
            animal.Name = "Olof";
            animal.Age = 6;

            Owl owl = new Owl();
            owl.Name = "Bengt";
            owl.Age = 55;
            owl.NumberOfLegs = 2;

            //METODER

            animal.Print();
            owl.Print();

                //OBJEKT & METODER FÖR KLASSERNA I "ENCAPSULATION"
                    //Jag skapar en "counter" som t.ex räknar besökare som går igenom en dörr. Idén är att 
                    //för varje gång jag anropar den så ökar värdet med +1.

            Counter counter = new Counter();
            counter.increase();     //+1 count
            counter.increase();     //+1 count

            Console.WriteLine($"Current count is {counter.getCount()}");

                //OBJEKT & METOD FÖR KLASSERNA I "ABSTRACTION"

            Colour colour = new Red();
            colour.Paint();


        }
    }
}
