using System;
using System.Collections.Generic;

namespace Figuras
{
    class Vector2D
    {
        public int x, y;
        public Vector2D(int x, int y)
        {
            this.x=x; this.y=y;
        }
        public override string ToString()
        {
            return String.Format ("{0}, {1}", x, y);
        }
    }
    class Color
    {
        public string fill;
        public string border;

        public Color(string fill, string border)
        {
            this.fill = fill; this.border = border;
        }

        public override string ToString ()
        {
            return String.Format("{0}, {1}", fill, border);
        }
    }
    abstract class Figura
    {
        public Vector2D position;
        public Color fill, border;
        public Figura():this(new Vector2D(100,100))
        {
            
        }
        public Figura(Vector2D pos)
        {
            position = pos;
        }

        public Figura():this(new Color("white", "black"))
        {

        }
        public Figura(Color fill, Color border)
        {
            this.fill = fill; this.border = border;
        }

        public abstract void Dibuja();
    }
    
    class Circulo : Figura
    {
        private int radio;
        public Circulo(Vector2D pos, int radio):base(pos)
        {
            this.radio = radio;
        }
        public Circulo(Color fi, Color bor):base(fi, bor)
        {
            
        }
        public Circulo():base()
        {
            this.radio = 10;
            this.fill = "white";
            this.border = "black";
        }
        public override void Dibuja()
        {
            Console.WriteLine("Se dibuja un circulo en {0} de color {1}", position, fill);
        }
    }
    
    class Rectangulo : Figura
    {
        public Rectangulo(Vector2D pos):base(pos)
        {
            
        }
        public Rectangulo(Color fi, Color bor):base(fi, bor)
        {
            
        }
        public Rectangulo():base()
        {
            this.fill = "blue";
            this.border = "black";
        }
        public override void Dibuja()
        {
            Console.WriteLine("Se dibuja un rectangulo en {0} de color {1}", position, fill);
        }
    }

    class Cuadrado : Figura
    {
        public Cuadrado(Vector2D pos):base(pos)
        {

        }
        public Cuadrado(Color fi, Color bor):base(fi, bor)
        {
            
        }
        public Cuadrado():base()
        {
            this.fill = "red";
            this.border = "black";
        }
        public override void Dibuja()
        {
            Console.WriteLine("Se dibuja un cuadrado en {0} de color {1}", position, fill);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> figuras = new List<Figura>();
            figuras.Add(new Circulo());
            figuras.Add(new Rectangulo(new Vector2D(200,200) ));
            figuras.Add(new Cuadrado(new Vector2D(300,300) ));
            foreach(Figura f in figuras)
                f.Dibuja();
        }
    }
}
