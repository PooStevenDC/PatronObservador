using System;
using System.Collections.Generic;
using System.Text;

namespace PatronObservador
{
    //Esta clase va a determinar los sujetos con el que se esta trabajando
    class Sujeto
    {
        //creamos lista para almacenar a los observadores 
        private List<IObservador> obsrvadores = new List<IObservador>();
        private string mensaje;
        // Ramdon ace que se generen numeros aleatorios  
        private Random rnd = new Random();
        private int n;

        //Esta es una propiedad
        public int N { get => n; set => n = value; }
	
        // Metodo que agregan a los observadores suscritos
        public void Suscribir (IObservador suscrito)
        {
            obsrvadores.Add(suscrito);
        }

        //Este metodo desuscribe a los observadores que se hayan suscrito
        public void Desuscribir(IObservador suscrito)
        {
            obsrvadores.Remove(suscrito);
        }
        //Aqui se notifican a los que estan suscritos sobre toda actualizacion que se haga
        private void Notificar()
        {
            foreach (IObservador o in obsrvadores)
            {
                o.Update(mensaje);
                
            }
        }
        
        // Este metodo va a generar el cambio que se va hacer 
        // En este caso se le va a dar un nuevo valor a los diferentes observadores 
        //en lo cual se le va asignara un numero aleatorio que va de 1 a 20
        public void Trabajo()
        {
            n = rnd.Next(20);
            if (n%2==0)
            {
                Console.ForegroundColor = ConsoleColor.Blue;//Aquii me va a mostrar por pantalla de color azul "Nuevo estado valido"
                Console.WriteLine("Nuevo estado valido");
                mensaje = string.Format("el nuevo valor es {0}", n);//Aqui se va a mostar en nuevo valor que se va a generar
                                                                    //con el Ramdon
                Notificar();//LLamamos al metodo notificar para que guarde cambios
            }
        }

         
    }
}
