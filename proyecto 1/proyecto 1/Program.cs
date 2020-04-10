using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int edad = 0;
            bool permiso = false;
            string valor = "";
            

            Console.WriteLine(" dame la edad");
            valor = Console.ReadLine();
            edad = Convert.ToInt32(valor);

            Console.WriteLine("tiene permiso de los padres(true/false): ");
            valor = Console.ReadLine();
            permiso = Convert.ToBoolean(valor);

            if(edad >18|| (edad > 15 && permiso == true))
                Console.WriteLine("es posible condu");

            else
                Console.WriteLine("no puede ");


        }
    }
}
