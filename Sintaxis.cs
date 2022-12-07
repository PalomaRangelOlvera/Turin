using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Turin
{
    public class Sintaxis : Lexico
    {
        public Sintaxis(string nombre) : base(nombre)
        {
            nextToken();
        }
        public Sintaxis()
        {
            nextToken();
        }

        public void match(string espera)
        {
            // Console.WriteLine(espera + " " + GETContenido());
            if (GETContenido() == espera)
            {
                nextToken();
            }
            else
            {
                throw new Error("Error de Sintaxis: Se espara un "+espera+" en la linea "+Linea,log);
            }
        }

        public void match(Tipos espera)
        {
            // Console.WriteLine(espera + " " + GETClasificacion());
            if (GETClasificacion() == espera)
            {
                nextToken();
            }
            else
            {
                throw new Error("Error de Sintaxis: Se espara un "+espera+" en la linea "+Linea,log);
            }
        }

    }
}