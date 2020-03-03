using System;

namespace FiguryLibrary
{
    public class Trojkat
    {
        // Dane
        private double a; //this.a;

        public double A
        {
            get { return a; }
            set 
            {
                if( value <= 0)
                {
                    throw new ArgumentOutOfRangeException("wartosc A musi byc dodatnia");
                }
                else if(isSpelnionyWarunekTkrojkata(value, b, c))
                {
                    a = value;
                }
                else //nie jest spełniony warunek trojkata
                {
                    throw new ArgumentOutOfRangeException("Nie spelniony warunek trojkata przy prubie zmiany A");
                }
                    
                    
            }
        }

        private double b; //this.b;

        public double B
        {
            get => B;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("wartosc B musi byc dodatnia");
                }
                else if (isSpelnionyWarunekTkrojkata(a, value, c))
                {
                    b = value;
                }
                else //nie jest spełniony warunek trojkata
                {
                    throw new ArgumentOutOfRangeException("Nie spelniony warunek trojkata przy prubie zmiany B");
                }

            }

        }
        

        private double c; //this.c;

    public double C
    {
        get => C;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("wartosc C musi byc dodatnia");
            }
            else if (isSpelnionyWarunekTkrojkata(a, b, value))
                {
                    c = value;
                }
                else //nie jest spełniony warunek trojkata
                {
                    throw new ArgumentOutOfRangeException("Nie spelniony warunek trojkata przy prubie zmiany C");
                }

            }

    }


        private bool isSpelnionyWarunekTkrojkata(double a, double b, double c)
        {
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        // konstuktory
        public Trojkat()  //Domyslny konstruktor
        {
            a = b = c = 1.0;
        }

       

        public Trojkat(double a, double b, double c)
        {
            if(a<= 0 || b <= 0 || c<= 0)
            {
                throw new ArgumentOutOfRangeException("boki musza byc dodatnie");
            }

            if (!isSpelnionyWarunekTkrojkata(a, b, c))
            {
                throw new ArgumentOutOfRangeException("Nie spełniony argument trujkata");
            }

            this.a = a;
            this.b = b;
            this.c = c;


        }

        //tekstowa reprezentacja obiektu (informujem jak wypisac ten obiekt )
        public override string ToString()
        {
            return $"Trojkat (a: {a}, b: {b}, c: {c}) ";
        }

        // Własciwosci i metody

        public double getObwod() //Metoda zwracajaca obwod trojkata
        {
            return a + b + c;
        }

        public double Obwod => a + b + c;  //propertys zwracajaca obwod tego trojkata

        public double getPole()
        {
            var p = 0.5 * getObwod();
            var s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return s;
        }

         public double Pole // propertis
         {
             get
             {
                 var p = 0.5 * Obwod;
                 var s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                 return s;
             }


         }

       /* public double Pole
        {
            get
            {
                var p = 0.5 * Obwod;
                var s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                return s;
            }
        }*/
    }
}
