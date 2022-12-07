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
                #include <stdio.h>;
                L.nextToken();
                if(L.GETContenido() == "include")
                {
                    L.nextToken();
                }
                else{
                    throw new error("Error, se esperaba un include");
                }

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