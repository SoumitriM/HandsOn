using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class Program
    {
        public  async static void PrintName()
        {
            Console.WriteLine("First method calls the second method..");
            string str = await GetName();
            Console.WriteLine(str);


        }
        public async static Task<string> GetName()
        {
            Thread.Sleep(3000);
             return("My name is Soumitri..");
        }

        static void Main(string[] args)
        {
            PrintName();
            
        }
    }
}
