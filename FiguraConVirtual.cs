using System;
using System.Collections.Generic;

namespace Figura2
{
    class Vector2D
    {
        public int x, y;
        public Vector2D(int x, int y)
        {
            this.x = x; this.y = y;
        }
        public override string ToString()
        {
            return String.Format("{0}, {1}", x, y);
        }
    }
    abstract class Figura
    {
        public Vector2D position;
        public string fill ,border;

          //Constructor por defecto 
        public Figura():this( new Vector2D(200, 500))
        {
        
        }
        //constructor de figura
        public Figura(Vector2D pos)
        {
            position= pos;
            fill= "azul";
            border= "verde";
        }

        public virtual void Dibuja()
        {
            Console.WriteLine("Se dibuja una forma en {0} de color {1}, con borde color {2}"
            , position, fill, border);
        }
    }

    class Circulo : Figura
    {
     private int radio;
     public Circulo(Vector2D pos, int radio):base(pos)
     {
         this.radio= radio;
     }
     public Circulo ():base()
     {
         this.radio= 10;
     }

     public override void Dibuja() 
     {
         Console.WriteLine("Se dibuja un circulo en {0} de color rojo, con borde color azul"
         , position);
     }
    }
 
    class Rectangulo : Figura
    {
     
     public Rectangulo(Vector2D pos):base(pos)
     {
         
     }
     public Rectangulo ():base()
     {
        
     }

     public override void Dibuja() 
     {
         Console.WriteLine("Se dibuja un rectangulo en {0} de color {1}, con borde color {2}"
         , position, fill, border);
     }
    }
    class Program
    {
        static void Main(string[] args)
        {

            List<Figura> figuras = new List<Figura>();
            figuras.Add(new Circulo());
            figuras.Add(new Rectangulo(new Vector2D(1500, 700) ));
            foreach(Figura f in figuras)
            f.Dibuja();
           
        }
    }
}
