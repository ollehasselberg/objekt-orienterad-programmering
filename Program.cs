using System.Drawing;
using System.Reflection.Metadata;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle1 = new Vehicle();
            vehicle1.Move();

                //Jag skapar en ny bil och kallar på metoderna från mina klasser.
            
            Car car1 = new Car();
            car1.Move();

            Car car2 = new Car();
            car2.Stop();

            //Nu vill jag anropa Animal-klassen för att demonstrera att den ärver metoder från Animal-klassen.

            Animal animal = new Animal();
            animal.Name = "Olof";
            animal.Age = 6;

            Owl owl = new Owl();
            owl.Name = "Bengt";
            owl.Age = 55;
            owl.NumberOfLegs = 2;

            animal.Print();
            owl.Print();

                //Här är ett exempel på encapsulation-metoden.
                //Jag skapar en "counter" som t.ex räknar besökare som går igenom en dörr. Idén är att 
                //för varje gång jag anropar den så ökar värdet med +1.

            Counter counter = new Counter();
            counter.increase();     //+1 count
            counter.increase();     //+1 count

            Console.WriteLine($"Current count is {counter.getCount()}");

                //Jag har gjort en abstrakt klass och vill nu anropa den, om allt fungerar som det ska kommer den visa en röd ruta i termnialen

            Colour colour = new Red();
            colour.Paint();


        }
    }
}

//Car har ärvt från Vehicles metoder.