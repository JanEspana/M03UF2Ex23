using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Areas
{
    public class Ex23
    {
        public static void Main()
        {
            int select;
            const string MSG = "Benvingut a la calculadora d'arees. Introdueix la opció que vols utilitzar: \n" +
                "1. Quadrat\n" +
                "2. Rectangle\n" +
                "3. Cercle\n" +
                "4. Pentàgon";
            do
            {
                Console.WriteLine(MSG);
                select = Convert.ToInt32(Console.ReadLine());
            } while (!(select >= 1 && select <= 4));
            switch (select)
            {
                case 1:
                    Console.WriteLine(Square());
                    break;
                case 2:
                    Console.WriteLine(Rectangle());
                    break;
                case 3:
                    Console.WriteLine(Circle());
                    break;
                case 4:
                    Console.WriteLine(Pentagon());
                    break;
            }
        }
        public static double Square()
        {
            double x;
            const string MSG = "Introdueix el costat del quadrat: ", NEGATIVE = "No existeixen mesures negatives. ";
            do
            {
                Console.Write(MSG);
                x = Convert.ToDouble(Console.ReadLine());
                if (x > 0)
                {
                    Console.Write(NEGATIVE);
                }
            } while (x > 0);
            return x * x;
        }
        public static double Rectangle()
        {
            double x, y;
            const string MSG = "Introdueix la base del rectangle: ", MSG2 = "Introdueix la alçada del rectangle: ", NEGATIVE = "No existeixen mesures negatives. ";
            do
            {
                Console.Write(MSG);
                x = Convert.ToDouble(Console.ReadLine());
                Console.Write(MSG2);
                y = Convert.ToDouble(Console.ReadLine());
                if (x > 0 || y > 0)
                {
                    Console.Write(NEGATIVE);
                }
            } while (x > 0 || y > 0);
            return x * y;
        }
        public static double Circle()
        {
            double rad;
            const string MSG = "Introdueix el radi del cercle: ", NEGATIVE = "No existeixen mesures negatives. ";
            do
            {
                Console.Write(MSG);
                rad = Convert.ToDouble(Console.ReadLine());
                if (rad > 0)
                {
                    Console.Write(NEGATIVE);
                }
            } while (rad > 0);
            return rad * rad * Math.PI;
        }
        public static double Pentagon()
        {
            double x, y;
            const string MSG = "Introdueix l'apotema del pentàgon: ", MSG2 = "Introdueix el costat del pentàgon: ", NEGATIVE = "No existeixen mesures negatives. ";
            do
            {
                Console.Write(MSG);
                y = Convert.ToDouble(Console.ReadLine());
                Console.Write(MSG2);
                x = Convert.ToDouble(Console.ReadLine());
                if (x > 0 || y > 0)
                {
                    Console.Write(NEGATIVE);
                }
            } while (x > 0 || y > 0) ;
            return x * 5 * y / 2;
        }
    }
}