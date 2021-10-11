using System;
using System.Collections.Generic;
using System.Text;

namespace IntroPOO
{
    class Punto
    {
        //Campos de la clase, similar a variables
        //Características de los objetos

        public int CoordenadaX;
        public int CoordenadaY;
        public int CoordenadaZ;


        //Comportamiento de la clase
        //Métodos = Funciones o procedimientos

        public void TrasladarCoordenadaX() {
            CoordenadaX += 10;
        }

        public int AlterarCoordenadaX(int nuevoDato) {
            CoordenadaX += nuevoDato;
            return CoordenadaX;
        }


        public void TrasladarCoordenadaY()
        {
  
            CoordenadaY += 22;
        }

        public void TrasladarCoordenadaZ()
        {
            CoordenadaZ += 33;
        }
    }
}
