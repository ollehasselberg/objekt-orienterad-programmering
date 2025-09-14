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

            Animal animal = new Animal();
            animal.Name = "Olof";
            animal.Age = 6;

            Owl owl = new Owl();
            owl.Name = "Bengt";
            owl.Age = 55;
            owl.NumberOfLegs = 2;

            animal.Print();
            owl.Print();

        }
    }
}

//Car har ärvt från Vehicles metoder.