using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzduotis6
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.OutputEncoding= Encoding.UTF8;
            // 6 užduoties 5 punktas : 

            int skaicius = 5;
            int daugiklis = 0;

            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");

            // 6 užduoties 6 punktas : 

            Console.WriteLine();
            Console.WriteLine("Paspauskite ENTER mygtuką");
            Console.ReadKey();

            skaicius = 29;
            int pirmasSkaitmuo = skaicius / 10;
            int antrasSkaitmuo = skaicius % 10;
            Console.WriteLine($"Duotas skaičius: {skaicius}");
            Console.Write($"{pirmasSkaitmuo} * {antrasSkaitmuo} = ");
            Console.WriteLine(pirmasSkaitmuo * antrasSkaitmuo);
        }
    }
}
