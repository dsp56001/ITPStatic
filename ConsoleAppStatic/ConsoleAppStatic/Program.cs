using System;

namespace ConsoleAppStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            Console.WriteLine(d.Bark());
            Console.WriteLine(d.BarkCount);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(d.Bark());
            }
            Console.WriteLine(d.BarkCount);

            Dog milo = new Dog() { Name = "milo", BarkSound="arf!!!" };
            Console.WriteLine(milo.BarkCount);
            Console.WriteLine(milo.Bark());
            Console.WriteLine(milo.BarkCount);

            Console.WriteLine("Total:" + Dog.TotalBarks); 

            Console.ReadKey();
        }
    }
}
