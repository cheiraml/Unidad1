using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplicacionpc
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort operando1;
            ushort operando2;
            string operador;
            string o1;
            string o2;
            bool continua1;
            bool continua2;
            bool continua3;

            do
                {
                        try
                    {   continua1 = false;
                        Console.Write("Ingrese el primer valor:");
                        o1 = Console.ReadLine();
                        operando1 = ushort.Parse(o1);
                    
                    }
                    catch (FormatException e)
                    {
                        Console.Write("Debe ingresar obligatoriamente un número entero.");
                        continua1 = true;
                    }
                }while (continua1);
                //Console.ReadKey()
            do
            {
                try
                {
                    continua2 = false;
                    Console.Write("Ingrese el segundo valor:");
                    o2 = Console.ReadLine();
                    operando2 = ushort.Parse(o2);

                }
                catch (FormatException e)
                {
                    Console.Write("Debe ingresar obligatoriamente un número entero.");
                    continua2 = true;
                }
            } while (continua2);
            // Console.ReadKey();
            do
            {
                
                    continua3 = false;
                    Console.Write("Ingrese + o -, segun lo que prefiera:");
                    operador = Console.ReadLine();
                if(operador=="+" || operador == "-")// |bits ||booleano
                {
                    //Console.ReadKey();
                    //Aquí envío por el puerto serial el dato 
                    Console.WriteLine("Envío por el serial");
                    //Aquí espero a que me llegue la respuesta
                    Console.WriteLine("OK dato desde arduino");
                }
                else
                {
                    Console.Write("Operacion invalida");
                    continua3 = true;

                }

            } while (continua3);
            
            
        }
        
    }
}

