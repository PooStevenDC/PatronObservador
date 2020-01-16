using System;
using System.Collections.Generic;
using System.Text;

namespace PatronObservador
{
    //Esta clase ace que se actualice la informacion del usuario gracias a la herencia de la
    //Interfaz IObservadores que genera un metodo para actualizar cambios de notificaciones

    class Observador : IObservador
    {
        private string nombre;
        private Sujeto sujeto;

        //Aqui estamos creando un constructor 
        public Observador(string pNombre, Sujeto pSujeto)
        {
            nombre = pNombre;
            sujeto = pSujeto;
            sujeto.Suscribir(this);
            
        }

        //Este metodo hace que se guarden los nuevos cambios de los Obsrvadores
        public void Update(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Red;//Semostraran letras de color rojo
            Console.WriteLine("Pus,{0} - {1}", nombre, mensaje);//Aqui me mostrara el nombre de os  Observadores En este caso
                                                                //se mostarra como PusA PusB PusC y tambiem me va a retonar el nuevo valor
                                                                //que se  que puede ser del 1 al 20

        }

         
    }
} 
