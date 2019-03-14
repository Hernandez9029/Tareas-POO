using System;

namespace Dados
{
    class Dados
    {
        private int valor, v1, v2, v3;
        private string color;
        public Dados()
        {
            Console.WriteLine("Tirar los dados --- Presiona Enter");
            Console.ReadKey(13);
        }

        public Dados(string color)
        {
            this.color = color;
        }

        public Dados(int valor)

        {
            Random valores = new Random(1,6);
            this.valor = valores;
        }
        public Dados()
        {
            valor = 1;
        }
        public void imprime()
        {
            Console.WriteLine("El mayor es: {0} {1}", color, valor);
        }
        public static Dados operator <(Dados X, Dados Y)
        {
            return new Dados(X.valor < Y.valor);
        }
                public static Dados operator >(Dados X, Dados Y)
        {
            return new Dados(X.valor > Y.valor);
        }
                public static Dados operator ==(Dados X, Dados Y)
        {
            return new Dados(X.valor == Y.valor);
        }
    }
    class Program
    {
        static void Main()
        {
            Dados dado1 = new Dados("Verde", valor);
            Dados dado2 = new Dados("Amarillo", valor); 
            Dados dado3 = new Dados("Rojo", valor);

            if (dado1 == dado2 && dado1 == dado3)
            {
                Console.WriteLine("No hay dado mayor, todas sus caras dieron el mismo número");
            }

            else if (dado1 > dado2 && dado1 > dado3)
            {
                dado1.imprime();
            }

            else if (dado2 > dado3)
            {
                dado2.imprime();
            }

            else
            {
                dado3.imprime();
            }
            
        }
    }
}
