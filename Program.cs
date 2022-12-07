using System;

namespace Turin
{   
    class Program
    {
        static void Main(string[] args)
        {
        try
            {
                Lexico L = new Lexico();

                while (!L.FinArchivo())
                {
                    L.nextToken();
                }
            }
            catch (Error e)
            {
                Console.WriteLine( e.Message);
            }
        }
    }
}
