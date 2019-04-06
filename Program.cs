using System;
using System.Collections.Generic;

 abstract class Musico

    {

      public string nombre;

      public Musico (string n)

      {

         this.nombre = n;

      }

      public abstract string Afina();

      public virtual string  Display()
      {
         return nombre;
      }

   }

class Bajista: Musico

  {

    public string instrumento;

    public Bajista (string n, string i ):base(n)
    {
       this.nombre = n;
       this.instrumento = i;
    }

    public override string Afina()
    {
       return string.Format("El Bajista afina");
    }
    public override string Display()
    {
       return nombre;
    }

 }

class Guitarrista : Musico

   {

      public string instrumento;

      public Guitarrista(string n, string intru ):base(n)
      {
         this.nombre = n;
         this.instrumento = intru;
      }
      public override string Afina()
      {
         return string.Format("El Guitarrista afina");
      }
      public override string Display()
      {
         return nombre;
      }
   }

 

class Program

 {

  public static void Main()

   {

  Bajista b = new Bajista("Flea", "bajín");

  Guitarrista g = new Guitarrista("Santana", "guitarrín");

  List<Musico> listamusicos = new List<Musico>();
  listamusicos.Add(b);
  listamusicos.Add(g);


 // (m as IAfina).Afina();

  foreach (Musico mus in listamusicos)
  {
     Console.WriteLine(mus.Display());
     Console.WriteLine(mus.Afina());
  }
 

 Console.ReadKey();

  

 }

}