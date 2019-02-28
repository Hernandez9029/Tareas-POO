using System;

namespace Sobrecarga
{
    class Dados
    {
        private string color;
        private int valor;

        //Constructor
        public Dados(string color)
        {
            this.color = color;
        }

        public Dados (int valor)
        {
            Random aleatorio = new Random(1,6);
            this.valor = aleatorio;
        }

        public void imprime()
        {
            Console.WriteLine("El dado mayor y su número de cara es: {0} {1}", color, valor);
        }
        
        public Dados()
        {
            valor = 1;
        }

        public static Dados operator ==(Dados a, Dados b)
        {
            return new Dados(a.valor == b.valor);
        }
                public static Dados operator >(Dados a, Dados b)
        {
            return new Dados(a.valor > b.valor);
        }
                public static Dados operator <(Dados a, Dados b)
        {
            return new Dados(a.valor < b.valor);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Dados dado1 = new Dados("Azul", valor);
            Dados dado2 = new Dados("Negro", valor); 
            Dados dado3 = new Dados("Blanco", valor);

            if (dado1 == dado2 && dado1 == dado3)
            {
                Console.WriteLine("No hay dado mayor, todas sus caras dieron el mismo número");
            }

            else if (dado1 > dado2 && dado1 > dado3)
            {
                dado1.imprime();
            }

            else if (dado1 == dado2 && dado1 > dado3)
            {
                dado1.imprime();
            }

            else if (dado1 > dado2 && dado1 == dado3)
            {
                dado1.imprime();
            }

            else if (dado2 > dado1 && dado2 > dado3)
            {
                dado2.imprime();
            }

            else if (dado2 == dado1 && dado2 > dado3)
            {
                dado2.imprime();
            }

            else if (dado2 > dado1 && dado2 == dado3)
            {
                dado2.imprime();
            }

            else if (dado3 > dado1 && dado3 > dado2)
            {
                dado3.imprime();
            }

            else if (dado3 == dado1 && dado3 > dado2)
            {
                dado3.imprime();
            }

            else if (dado3 > dado1 && dado3 == dado2)
            {
                dado3.imprime();
            }
        }
    }
}
