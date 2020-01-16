using System;
using System.Collections.Generic;
using System.Text;

namespace PatronObservador
{
    //Interfaz para heradar a los Observadores un metodo que genera notificacion a los distintos observadores
    interface IObservador
    {
        //Metodo que genera una  notificacion de los usuarios que esten suscritos
        //Pasa como paarametro un mensaje
        
        void Update(string mensaje);
        
    }
}
