
using System;

namespace PatronObservador
{
    class Program
    {
        static void Main(string[] args)
        {
            Sujeto sujeto = new Sujeto();

            // Creamos al observador
            Observador a = new Observador("A", sujeto);
            Observador b = new Observador("B" ,sujeto);
            Observador c = new Observador("C", sujeto);

            //Trabajamos
            for (int n = 0; n < 5; n++)
                sujeto.Trabajo();// Se llama al metodo Trabajo
            
            //Alguin se sale de la lista
            Console.WriteLine("-----Descubrir----");
            
            // Se va ah desuscribir el sujeto b y ya nose va a imprimir por pantalla
            sujeto.Desuscribir(b);
            

            for (int n = 0; n < 5; n++)
              sujeto.Trabajo();


        }
    }
}
