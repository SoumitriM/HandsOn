using System;


namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var dBConn = DBConn.GetInstance();
            Console.WriteLine(dBConn.ToString());
            Console.ReadKey();
        }
    }
}
