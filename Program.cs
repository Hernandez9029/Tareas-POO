using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_8
{
    class FraccionDiv
    {
        //numerador
        private int numdiv;
        //denominador
        private int dendiv;

        //Constructor
        public FraccionDiv(int numdiv, int dendiv)
        {
            this.numdiv = numdiv; this.dendiv = dendiv;
        }

        public FraccionDiv()
        {
            numdiv = 1;
            dendiv = 1;
        }

        //Haciendo las operaciones para multiplicación de fracciones
        public static FraccionDiv operator /(FraccionDiv a, FraccionDiv b)
        {
            FraccionDiv result = new FraccionDiv(a.numdiv * b.dendiv, a.dendiv * b.numdiv);
            return result;
        }

        //Imprime
        public void imprime()
        {
            Console.WriteLine("{0}/{1}", numdiv, dendiv);
        }

        //Regresa valor decimal
        public decimal a_decimal()
        {
            return numdiv / dendiv;
        }
    }

    class FraccionMul
    {
        //numerador
        private int numul;
        //denominador
        private int denmul;

        //Constructor
        public FraccionMul(int numul, int denmul)
        {
            this.numul = numul; this.denmul = denmul;
        }

        public FraccionMul()
        {
            numul = 1;
            denmul = 1;
        }

        //Haciendo las operaciones para multiplicación de fracciones
        public static FraccionMul operator *(FraccionMul a, FraccionMul b)
        {
            FraccionMul result = new FraccionMul(a.numul * b.numul, a.denmul * b.denmul);
            return result;
        }

        //Imprime
        public void imprime()
        {
            Console.WriteLine("{0}/{1}", numul, denmul);
        }

        //Regresa valor decimal
        public decimal a_decimal()
        {
            return numul / denmul;
        }
    }

    class FraccionResta
    {
        //numerador
        private int numres;
        //denominador
        private int denres;

        //Constructor
        public FraccionResta(int numres, int denres)
        {
            this.numres = numres; this.denres = denres;
        }

        public FraccionResta()
        {
            numres = 1;
            denres = 1;
        }

        //Haciendo las operaciones de la división negativa
        public static FraccionResta operator -(FraccionResta a, FraccionResta b)
        {
            FraccionResta result = new FraccionResta(a.numres * b.denres - a.denres * b.numres, a.denres * b.denres);
            return result;
        }
        
        //Imprime
        public void imprime()
        {
            Console.WriteLine("{0}/{1}", numres, denres);
        }

        //Regresar valor decimal
        public decimal a_decimal()
        {
            return numres / denres;
        }
    }

    class Fraccion
    {
        //numerador
        private int num;
        //denominador
        private int den;

        //Constructor
        public Fraccion(int num, int den)
        {
            this.num = num; this.den = den;
        }
        
        public Fraccion()
        {
            num = 1;
            den = 1;
        }

        //Haciendo las operaciones de la división
        public static Fraccion operator +(Fraccion x, Fraccion y)
        {
            Fraccion result = new Fraccion(x.num * y.den + x.den * y.num, x.den * y.den);
            return result;
        }
        
        //Imprime
        public void imprime()
        {
            Console.WriteLine("{0}/{1}", num, den);
        }

        //Regresa valor decimal
        public decimal a_decimal()
        {
            return num / den;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Suma de fracciones");

            //Creando objetos de la clase Fraccion
            Fraccion a = new Fraccion(1,2);
            Fraccion b = new Fraccion();
            Fraccion c = a + b;

            //Imprimiendo objetos
            a.imprime();
            b.imprime();
            c.imprime();

            Console.WriteLine("Resta de fracciones");

            //Creando objetos de la clase FraccionResta
            FraccionResta a2 = new FraccionResta(3, 4);
            FraccionResta b2 = new FraccionResta();
            FraccionResta c2 = a2 - b2;

            //Imprimiendo objetos
            a2.imprime();
            b2.imprime();
            c2.imprime();

            Console.WriteLine("Multiplicación de fracciones");

            //Creando objetos de la clase FraccionMul
            FraccionMul a3 = new FraccionMul(4, 5);
            FraccionMul b3 = new FraccionMul(3, 7);
            FraccionMul c3 = a3 * b3;

            //Imprimiendo objetos
            a3.imprime();
            b3.imprime();
            c3.imprime();

            Console.WriteLine("División de fracciones");

            //Creando objetos de la clase FraccionDiv
            FraccionDiv a4 = new FraccionDiv(2, 6);
            FraccionDiv b4 = new FraccionDiv(4, 9);
            FraccionDiv c4 = a4 / b4;

            //Imprimiendo objetos
            a4.imprime();
            b4.imprime();
            c4.imprime();

            Console.ReadKey();
        }
    }
}
