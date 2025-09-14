using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{       
            //Här kommer ett exempel på en abstrakt klass. Jag kommer göra en basklass som är Colour 
    public abstract class Colour
    {
        //Jag vill ge min klass en abstrakt metod, som visar vilken färg
        public abstract void Paint();
    }

        //Här gör jag en subklass till färgen, jag kör på Röd i detta exempel.
    public class Red : Colour
    {

        //Här implementerar jag den abstrakta metoden
        public override void Paint()
        {
            Console.WriteLine("🟥 This is a red square");
        }
    }
}
