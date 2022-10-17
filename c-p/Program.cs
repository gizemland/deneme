using System;

namespace c_p
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("adınız?");
            string name= Console.ReadLine();
            Console.WriteLine("soyadınız?");
            string surname=Console.ReadLine();
            Console.WriteLine("merhaba"+" "+name+" "+surname);
            
        }
    }
}
