using System;

namespace InterfaceLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            var pb = new PitBull();
            var ch = new Chihuahua();
            var sh = new ShibaInu();

            var dogs = new IPrint[] { pb, ch, sh };

            foreach(var dog in dogs)
            {
                dog.Print();
            }

        }
    }
}
