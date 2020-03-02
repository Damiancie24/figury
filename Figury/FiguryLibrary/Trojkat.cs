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
                else
                {
                    a = value;
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
                else
                {
                    b = value;
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
            else
            {
                c = value;
            }


        }

    }

    // konstuktory
    public Trojkat()  //Domyslny konstruktor
        {
            a = b = c = 1.0;
        }

        public Trojkat(double a, double b, double c)
        {
            if(a + b <+ c || a+c <+ b || b + c <= a)
            {
                throw new ArgumentOutOfRangeException("Nie spełniony warunek trojkata");
            }

            this.A = a;
            this.B = b;
            this.C = c;
        }

        //tekstowa reprezentacja obiektu
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

         public double Pole
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
