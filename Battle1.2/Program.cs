namespace Battle12
{
    class Program
    {
        static int Schaden;
        static int Rüstung;
        static int Angriffe;
        static int Beweglichkeit;
        static int Angriffsgeschwindigkeit;

        static int Damage;

        static void Main(string[] args)
        {
            WaffenAuswahl();

            RüstungsAuswahl();

            Angriffsgeschwindigkeit = Beweglichkeit + Angriffe;

            Console.WriteLine("Schaden = " + Schaden);
            Console.WriteLine("Angriffsgeschwindigkeit = " + Angriffsgeschwindigkeit);
            Console.WriteLine("Rüstungswert = " + Rüstung);

            Damage = Schaden * Angriffsgeschwindigkeit;

            Console.WriteLine(Damage);

            Kampf();


        }

        static void WaffenAuswahl()
        {

            Console.WriteLine("wähle eine Waffe");
            Console.WriteLine(" -dolch-      25 Schaden       Angriffsgeschwindigkeit x3");
            Console.WriteLine(" -schwert-    50 Schaden       Angriffsgeschwindigkeit x2");
            Console.WriteLine(" -hammer-    100 Schaden       Angriffsgeschwindigkeit x1");
            Console.WriteLine("Tippe deine Wahl ein: 1 = Dolch/ 2 = schwert/ 3 = Hammer");

            string WaffenWahlEingabe = Console.ReadLine();

            try
            {
                int WaffenWahl = int.Parse(WaffenWahlEingabe);

                switch (WaffenWahl)
                {
                    case 1:
                        Schaden = 25;
                        Angriffe = 3;
                        break;

                    case 2:
                        Schaden = 50;
                        Angriffe = 2;
                        break;

                    case 3:
                        Schaden = 100;
                        Angriffe = 1;
                        break;
                }

            }

            catch
            {
                Console.WriteLine("falsche Eingabe. Versuche es erneut");
                WaffenAuswahl();
            }

        }

        static void RüstungsAuswahl()
        {
            Console.WriteLine("wähle eine Rüstung");
            Console.WriteLine(" -Lederrüstung-          Rüstungswert = 3        Angriffsgeschwindigkeit = 3");
            Console.WriteLine(" -Beschlagenerüstung-    Rüstungswert = 6        Angriffsgeschwindigkeit = 2");
            Console.WriteLine(" -Stahlrüstung-          Rüstungswert = 9        Angriffsgeschwindigkeit = 1");
            Console.WriteLine("Tippe deine Wahl ein: 1 = Lederrüstung/ 2 = Beschlagenerüstung/ 3 = Stahlrüstung");

            string RüstungsWahlEingabe = Console.ReadLine();

            try
            {
                int WaffenWahl = int.Parse(RüstungsWahlEingabe);

                switch (WaffenWahl)
                {
                    case 1:
                        Rüstung = 25;
                        Beweglichkeit = 3;
                        break;

                    case 2:
                        Rüstung = 50;
                        Beweglichkeit = 2;
                        break;

                    case 3:
                        Rüstung = 100;
                        Beweglichkeit = 1;
                        break;
                }

            }

            catch
            {
                Console.WriteLine("falsche Eingabe. Versuche es erneut");
                RüstungsAuswahl();
            }
        }

        static void Kampf()
        {
            /*
            
            int Leben = 1000;

            Console.WriteLine("du kämpfst gegen einen Gegner mit 1000 Leben");

            while (Leben > 0)
            {
                Leben - Damage;

                Console.WriteLine("Du greifst an! Dein Gegner hat noch" + Leben + "Leben");
            }

            Console.WriteLine("Du gewinnst den Kampf");

            */
        }
    }
}