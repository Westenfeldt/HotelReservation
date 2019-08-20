using System;

namespace HotelReservation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("Velkommen til Hotellet. ");
            Console.WriteLine("Vi tilbyder enkeltværlse, doubleværelse og familieværelser");
            Console.WriteLine("Angiv ønskes type. Enkeltværelse: E");
            Console.WriteLine("Angiv ønskes type. Doubleværelse: D");
            Console.WriteLine("Angiv ønskes type. Familieværlese: F");

            

            string tybeV = Console.ReadLine();

            // priser
            double enkelt = 60;
            double dobbelt = 110;
            double familie = 120;
            double total;
            double kurs = 756.89;
            double totalkurs;

            switch (tybeV.ToLower())
            {
                case "e":
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Du har valgt enkeltværelser, hvor mange ønskes der?");
                    string antalRe = Console.ReadLine();
                    double antalVe = float.Parse(antalRe);
                    Console.WriteLine("Hvor mange nætter ønsker du at overnatte?");
                    string antalNe = Console.ReadLine();
                    double antalnate = float.Parse(antalNe);

                    total = antalVe * enkelt * antalnate;

                    totalkurs = total * (kurs / 100);
                    Console.WriteLine("Din pris er {0} euro og ønskes der at betales i dkk er prisen {1:N2} kr.", totalkurs, total);

                    break;
                case "d":
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    Console.WriteLine("Du har valgt dobbelt, hvor mange ønskes der?");
                    string antalRd = Console.ReadLine();
                    double antalVd = float.Parse(antalRd);
                    Console.WriteLine("Hvor mange nætter ønsker du at overnatte?");
                    string antalNd = Console.ReadLine();
                    double antalnatd = float.Parse(antalNd);

                    total = antalVd * dobbelt * antalnatd;

                    totalkurs = total * (kurs / 100);
                    Console.WriteLine("Din pris er {0} euro og ønskes der at betales i dkk er prisen {1:N2} kr.", totalkurs, total);


                    Console.WriteLine("Prisen i Euro er {0}", totalkurs);
                    break;
                case "f":
                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine("Du har valgt familieværelse, hvor mange ønskes der?");
                    string antalRf = Console.ReadLine();
                    double antalVf = float.Parse(antalRf);
                    Console.WriteLine("Hvor mange nætter ønsker du at overnatte?");
                    string antalNf = Console.ReadLine();
                    double antalnatf = float.Parse(antalNf);

                    total = antalVf * familie * antalnatf;

                    totalkurs = total * (kurs / 100);
                    Console.WriteLine("Din pris er {0} euro og ønskes der at betales i dkk er prisen {1:N2} kr.", totalkurs, total);
                    break;
                default:
                    Console.WriteLine("FORKERT");
                    break;
            }
        }
    }
}
