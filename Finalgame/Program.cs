using System;
using System.IO;
using System.Media;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalgame
{
    internal class Program
    {
        #region Static Variablen
        static int Raum = 0;
        static string Ort = @"C:\Game\Game.txt";
        static string Spielereingabe = "";
        static string Spielereingabel = "";
        static int i = 0;
        static int rleiche = 0;
        static int[] leiche = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        static int rkameraraum = 0;
        static int o = 0;
        static int leichegefunden = 0;
        static int code = 0;
        static int x = 0;
        #endregion



        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Sie sind ein erfahrener Privatdetektiv und wurden zu einer exklusiven Party eingeladen, bei der plötzlich der Gastgeber spurlos verschwindet. ");
            Console.WriteLine("Keine Spuren, keine Hinweise, nur ein Rätsel, das es zu lösen gilt. ");
            Console.WriteLine("Sie sind die einzige Hoffnung, um die Wahrheit aufzudecken und den Fall zu lösen. ");
            Console.WriteLine("Können Sie die Puzzleteile zusammensetzen und den Fall abschließen, bevor es zu spät ist? ");
            Console.WriteLine("Der Fall liegt in Ihren Händen. Viel Glück bei der Aufklärung!\n ");

            Console.WriteLine("Drücke Enter um fortzufahren. ");
            Console.ReadLine();
            Console.Clear();
            Rleiche();
            Menue();
        }

        #region Menü
        static void Menue()
        {
            do
            {
                i = 0;
                Console.Clear();
                Console.WriteLine("Willkommen bei Mystery Mansion!\n ");
                Console.WriteLine("1. Neues Spiel starten. ");
                Console.WriteLine("2. Gespeichertes Spiel laden. ");
                Console.WriteLine("3. Spiel beenden. ");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        i++;
                        Neuesspiel();
                        break;
                    case 2:
                        i++;
                        Spielladen();
                        break;
                    case 3:
                        i++;
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Error");
                        break;

                }
            }
            while (i == 0);

        }
        #endregion

        #region Spiel speichern
        static void Spielspeichern()
        {
            string speichern = Raum.ToString() + "," + rkameraraum.ToString() + "," + rleiche.ToString() + "," + x.ToString() + "," + leichegefunden.ToString();

            File.WriteAllText(Ort, speichern);
            Console.WriteLine("Spielstand gespeichert. ");
        }
        #endregion

        #region Spiel laden
        static void Spielladen()
        {
            string saveData = File.ReadAllText(Ort);
            string[] data = saveData.Split(',');
            Raum = int.Parse(data[0]);
            rkameraraum = int.Parse(data[1]);
            rleiche = int.Parse(data[2]);
            x = int.Parse(data[3]);
            leichegefunden = int.Parse(data[4]);
            Console.WriteLine("Möchtest du deinen Spielstand laden? (ja) (nein). ");

            Spielereingabel = Console.ReadLine().ToLower();

            switch (Spielereingabel.ToLower())
            {
                case "ja":

                    switch (Raum)
                    {
                        case 1:
                            Flur();
                            break;

                        case 2:
                            Bad();
                            break;

                        case 3:
                            Abstellkammer();
                            break;

                        case 4:
                            Kaminzimmer();
                            break;

                        case 5:
                            Bibliothek();
                            break;

                        case 6:
                            Schlafzimmer();
                            break;

                        case 7:
                            Esszimmer();
                            break;

                        case 8:
                            Kueche();
                            break;

                        case 9:
                            Keller();
                            break;

                        case 10:
                            Abkeller();
                            break;

                    }
                    switch (rleiche)
                    {
                        case 1:
                            leiche[0] = 1;
                            break;

                        case 2:
                            leiche[1] = 1;
                            break;

                        case 3:
                            leiche[2] = 1;
                            break;

                        case 4:
                            leiche[3] = 1;
                            break;

                        case 5:
                            leiche[4] = 1;
                            break;

                        case 6:
                            leiche[5] = 1;
                            break;

                        case 7:
                            leiche[6] = 1;
                            break;

                        case 8:
                            leiche[7] = 1;
                            break;

                        case 9:
                            leiche[8] = 1;
                            break;

                        case 10:
                            leiche[9] = 1;
                            break;
                    }
                    break;



                case "nein":
                    Menue();
                    break;

                default:
                    Spielladen();
                    break;

            }

        }
        #endregion

        #region Neues Spiel
        static void Neuesspiel()
        {
            Flur();

        }
        #endregion 

        #region Flur
        static void Flur()
        {
            Raum = 1;

            do
            {
                i = 0;
                Console.Clear();
                Console.WriteLine("Du stehst im Flur, was möchtest du tun?\n ");
                Console.WriteLine("1. Gehe in die Abstellkammer. ");
                Console.WriteLine("2. Gehe in das Badezimmer. ");
                Console.WriteLine("3. Gehe in das Kaminzimmer. ");
                Console.WriteLine("4. Gehe in den Keller");
                Console.WriteLine("5. Spreche mit John Doe.");
                Console.WriteLine("6. Spreche mit Elizabeth Rodriguez.");
                Console.WriteLine("7. Hinweise Ansehen. ");
                Console.WriteLine("8. Fall lösen. ");
                Console.WriteLine("9. Spiel speichern. ");
                Console.WriteLine("10. Spiel beenden. ");


                Spielereingabe = Console.ReadLine();

                switch (Spielereingabe)
                {
                    case "1":
                        i++;
                        Abstellkammer();
                        break;

                    case "2":
                        i++;
                        Bad();
                        break;

                    case "3":
                        i++;
                        Kaminzimmer();
                        break;

                    case "4":
                        i++;
                        Keller();
                        break;

                    case "5":
                        i++;
                        JohnDoeFlur();
                        break;

                    case "6":
                        i++;
                        ElizabethRodriguezFlur();
                        break;

                    case "9":
                        Spielspeichern();
                        break;

                    case "10":
                        i++;
                        Environment.Exit(0);
                        break;

                    case "7":
                        Hinweiseansehen();
                        break;

                    case "8":
                        Gewinnen();
                        break;

                    default:
                        Console.WriteLine("Error");
                        break;
                }
            }
            while (i == 0);


        }
        #endregion

        #region Bad
        static void Bad()
        {
            Raum = 2;

            do
            {
                Console.Clear();
                i = 0;
                Console.WriteLine("Du stehst im Bad, was möchtest du tun?\n ");
                Console.WriteLine("1. Spreche mit Karen Lee. ");
                Console.WriteLine("2. Gehe zurück in den Flur. ");
                Console.WriteLine("3. Hinweise Ansehen. ");
                Console.WriteLine("4. Fall lösen. ");
                Console.WriteLine("5. Spiel speichern. ");
                Console.WriteLine("6. Spiel beenden. ");


                Spielereingabe = Console.ReadLine();

                switch (Spielereingabe)
                {

                    case "1":
                        KarenLeeBad();
                        break;
                        
                    case "2":
                        i++;
                        Flur();
                        break;

                    case "4":
                        Gewinnen();
                        break;

                    case "5":
                        Spielspeichern();
                        break;

                    case "6":
                        i++;
                        Environment.Exit(0);
                        break;

                    case "3":
                        Hinweiseansehen();
                        break;

                    default:
                        Console.WriteLine("Error");
                        break;
                }
            }
            while (i == 0);

        }
        #endregion

        #region Abstellkammer
        static void Abstellkammer()
        {
            Raum = 3;

            do
            {
                Console.Clear();
                i = 0;
                Console.WriteLine("Du stehst in der Abstellkammer, was möchtest du tun?\n ");
                Console.WriteLine("1. Gehe zurück in den Flur. ");
                Console.WriteLine("2. Durchsuche die Schränke. ");
                Console.WriteLine("3. Hinweise Ansehen. ");
                Console.WriteLine("4. Fall lösen. ");
                Console.WriteLine("5. Spiel Speichern. ");
                Console.WriteLine("6. Spiel beenden. ");

                Spielereingabe = Console.ReadLine();

                switch (Spielereingabe)
                {


                    case "1":
                        i++;
                        Flur();
                        break;

                    case "2":

                        do
                        {

                            i = 0;
                            Console.WriteLine("Du stehst vor den Schränken.\n ");
                            Console.WriteLine("1. Durchsuche Schrank 1.");
                            Console.WriteLine("2. Durchsuche Schrank 2.");
                            Console.WriteLine("3. Durchsuche Schrank 3.");
                            Console.WriteLine("4. Höre auf zu durchsuchen. ");

                            Spielereingabe = Console.ReadLine();

                            switch (Spielereingabe)
                            {
                                case "1":
                                    if (leiche[0] == 1 && leichegefunden == 0)
                                    {
                                        Console.WriteLine("Du findest die Leiche des Gastgebers. ");
                                        leichegefunden = 1;
                                    }
                                    else if (leiche[0] == 1 && leichegefunden == 1)
                                    {
                                        Console.WriteLine("Du siehst die bereits gefundende Leiche des Gastgebers. ");
                                    }
                                    else if (leiche[0] == 0)
                                    {
                                        Console.WriteLine("Der Schrank ist voll mit Werkzeug. ");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Error");
                                    }
                                    break;

                                case "2":
                                    if (leiche[1] == 1 && leichegefunden == 0)
                                    {
                                        Console.WriteLine("Du findest die Leiche des Gastgebers. ");
                                        leichegefunden = 1;
                                    }
                                    else if (leiche[1] == 1 && leichegefunden == 1)
                                    {
                                        Console.WriteLine("Du siehst die bereits gefundende Leiche des Gastgebers. ");
                                    }
                                    else if (leiche[1] == 0)
                                    {
                                        Console.WriteLine("Der Schrank ist voll mit Werkzeug. ");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Error");
                                    }
                                    break;

                                case "3":
                                    if (leiche[2] == 1 && leichegefunden == 0)
                                    {
                                        Console.WriteLine("Du findest die Leiche des Gastgebers. ");
                                        leichegefunden = 1;
                                    }
                                    else if (leiche[2] == 1 && leichegefunden == 1)
                                    {
                                        Console.WriteLine("Du siehst die bereits gefundende Leiche des Gastgebers. ");
                                    }
                                    else if (leiche[2] == 0)
                                    {
                                        Console.WriteLine("Der Schrank ist voll mit Werkzeug. ");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Error");
                                    }
                                    break;

                                case "4":
                                    i++;
                                    break;
                            }

                        }
                        while (i == 0);
                        i = 0;
                        break;

                    case "4":
                        Gewinnen();
                        break;

                    case "5":
                        Spielspeichern();
                        break;

                    case "6":
                        i++;
                        Environment.Exit(0);
                        break;

                    case "3":
                        Hinweiseansehen();
                        break;

                    default:
                        Console.WriteLine("Error");
                        break;
                }
            }
            while (i == 0);

        }
        #endregion

        #region Kaminzimmer
        static void Kaminzimmer()
        {
            Raum = 4;

            do
            {
                Console.Clear();
                i = 0;
                Console.WriteLine("Du stehst jetzt im Kaminzimmer, was möchtest du tun?\n ");
                Console.WriteLine("1. Gehe nach rechts in die Bibliothek. ");
                Console.WriteLine("2. Gehe nach links in das Esszimmer. ");
                Console.WriteLine("3. Gehe zurück in den Flur. ");
                Console.WriteLine("4. Spreche mit Mr. Thompson. ");
                Console.WriteLine("5. Spreche mit Michael Brown. ");
                Console.WriteLine("6. Spreche mit Tony Sanchez. ");
                Console.WriteLine("7. Hinweise Ansehen. ");
                Console.WriteLine("8. Fall lösen. ");
                Console.WriteLine("9. Spiel speichern. ");
                Console.WriteLine("10. Spiel beenden. ");

                Spielereingabe = Console.ReadLine();

                switch (Spielereingabe)
                {
                    case "1":
                        i++;
                        Bibliothek();
                        break;

                    case "2":
                        i++;
                        Esszimmer();
                        break;

                    case "3":
                        i++;
                        Flur();
                        break;

                    case "4":
                        i++;
                        MrThompsonKaminzimmer();
                        break;

                    case "5":
                        i++;
                        MichaelBrownKaminzimmer();
                        break;

                    case "6":
                        i++;
                        TonySanchezKaminzimmer();
                        break;

                    case "7":
                        Hinweiseansehen();
                        break;

                    case "8":
                        Gewinnen();
                        break;

                    case "9":
                        Spielspeichern();
                        break;

                    case "10":
                        i++;
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Error");
                        break;
                }
            }
            while (i == 0);
        }
        #endregion

        #region Bibliothek
        static void Bibliothek()
        {
            Raum = 5;

            do
            {
                i = 0;
                Console.Clear();
                Console.WriteLine("Du stehst jetzt in der Bibliothek, was möchtest du tun?\n ");
                Console.WriteLine("1. Gehe in das Schlafzimmer. ");
                Console.WriteLine("2. Gehe zurück in das Kaminzimmer. ");
                Console.WriteLine("3. Schaue dir das große Regal mit den Büchern an. ");
                Console.WriteLine("4. Spreche mit Proffesor William Hayes. ");
                Console.WriteLine("5. Hinweise Ansehen. ");
                Console.WriteLine("6. Fall lösen. ");
                Console.WriteLine("7. Spiel speichern. ");
                Console.WriteLine("8. Spiel beenden. ");

                Spielereingabe = Console.ReadLine();

                switch (Spielereingabe)
                {
                    case "1":
                        i++;
                        Schlafzimmer();
                        break;

                    case "2":
                        i++;
                        Kaminzimmer();
                        break;

                    case "3":
                        Console.WriteLine("Dir fällt auf, dass eines der Bücher sehr stark gehandhabt wurde. ");
                        Console.WriteLine("Du kannst ebenfalls einige verstaubte Fingerabdrücke erkennen. ");
                        Console.WriteLine("Was möchtest du tun?\n ");
                        Console.WriteLine("1. Sehe dir das Buch näher an. ");
                        Console.WriteLine("2. Ignoriere es. ");

                        Spielereingabe = Console.ReadLine();

                        do
                        {
                            switch (Spielereingabe)
                            {
                                case "1":
                                    Console.WriteLine("Du findest ein Tastenfeld mit einer dreistelligen Code Eingabetafel. ");
                                    Console.WriteLine("Bitte geben Sie einen Code ein: ");
                                    Spielereingabe = Console.ReadLine();

                                    if (Convert.ToInt64(Spielereingabe) == 187)
                                    {
                                        Geheimraum();
                                        i++;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Der eingegebene Code ist Falsch! Was möchtest du tun?\n ");
                                        Console.WriteLine("1. Den Code noch einmal eingeben. ");
                                        Console.WriteLine("2. In der Bibliothek umsehen. ");
                                        Spielereingabe = Console.ReadLine();

                                        if (Convert.ToInt64(Spielereingabe) == 2)
                                        {
                                            Bibliothek();
                                        }
                                    }


                                    break;

                                case "2":
                                    i++;
                                    break;
                            }


                        } while (i == 0);

                        i = 0;

                        break;

                    case "4":
                        i++;
                        ProfessorWilliamHayesBibliothek();
                        break;

                    case "7":
                        Spielspeichern();
                        break;

                    case "6":
                        Gewinnen();
                        break;

                    case "8":
                        i++;
                        Environment.Exit(0);
                        break;

                    case "5":
                        Hinweiseansehen();
                        break;

                    default:
                        Console.WriteLine("Error");
                        break;

                }

            }
            while (i == 0);

        }
        #endregion

        #region Schlafzimmer
        static void Schlafzimmer()
        {
            Raum = 6;

            do
            {
                Console.Clear();
                i = 0;
                Console.WriteLine("Du stehst jetzt im Schlafzimmer, was möchtest du tun?\n ");
                Console.WriteLine("1. Gehe zurück in die Bibliothek. ");
                Console.WriteLine("2. Durchsuche den Kleiderschrank. ");
                Console.WriteLine("3. Durchsuche den Nachttisch. ");
                Console.WriteLine("4. Gucke dir das Bett genauer an. ");
                Console.WriteLine("5. Hinweise Ansehen. ");
                Console.WriteLine("6. Fall lösen. ");
                Console.WriteLine("7. Spiel speichern. ");
                Console.WriteLine("8. Spiel beenden. ");

                Spielereingabe = Console.ReadLine();

                switch (Spielereingabe)
                {
                    case "1":
                        i++;
                        Bibliothek();
                        break;

                    case "2":
                        if (leiche[4] == 1 && leichegefunden == 0)
                        {
                            Console.WriteLine("Du gräbst dich durch ein paar Klamotten und erkennst den Körper eines Menschen dahinter. ");
                            Console.WriteLine("Bei genauerem Hinsehen erkennst du, dass es sich dabei um die Leiche des Gastgebers handelt. ");
                            leichegefunden = 1;
                        }
                        else if (leiche[4] == 1 && leichegefunden == 1)
                        {
                            Console.WriteLine("Du siehst die Leiche des Gastgebers. ");
                        }
                        else if (leiche[4] == 0)
                        {
                            Console.WriteLine("Im Kleiderschrank sind nur Kleider. ");
                        }
                        else
                        {
                            Console.WriteLine("Error");
                        }
                        Console.ReadLine();
                        break;

                    case "3":
                        Console.WriteLine("Du findest einen Zettel auf dem 187 steht. ");
                        code = 1;
                        Console.WriteLine("Drücke Enter Taste um fortzuffahren");
                        Console.ReadLine();
                        break;

                    case "4":
                        if (leiche[5] == 1 && leichegefunden == 0)
                        {
                            Console.WriteLine("Du schaust unter das Bett und erkennst eine Leiche, es handelt sich dabei um den Gastgeber. ");
                            leichegefunden = 1;
                        }
                        else if (leiche[5] == 1 && leichegefunden == 1)
                        {
                            Console.WriteLine("Du siehst die bereits gefundende Leiche. ");
                        }
                        else if (leiche[5] == 0)
                        {
                            Console.WriteLine("Unter dem Bett ist nur gerümpel. ");
                        }
                        else
                        {
                            Console.WriteLine("Error");
                        }
                        Console.WriteLine("Drücke die Enter Taste um fortzufahren. ");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case "6":
                        Gewinnen();
                        break;

                    case "7":
                        Spielspeichern();
                        break;

                    case "8":
                        i++;
                        Environment.Exit(0);
                        break;

                    case "5":
                        Hinweiseansehen();
                        break;

                    default:
                        Console.WriteLine("Error");
                        break;
                }
            }
            while (i == 0);

        }
        #endregion

        #region Esszimmer
        static void Esszimmer()
        {
            Raum = 7;

            do
            {
                Console.Clear();
                i = 0;
                Console.WriteLine("Du stehst im Esszimmer, was möchtest du tun?\n ");
                Console.WriteLine("1. Gehe zurück in das Kaminzimmer. ");
                Console.WriteLine("2. Gehe in die Küche. ");
                Console.WriteLine("3. Spreche mit Amanda Parker.");
                Console.WriteLine("4. Spreche mit Julia Davis. ");
                Console.WriteLine("5. Hinweise Ansehen. ");
                Console.WriteLine("6. Fall lösen. ");
                Console.WriteLine("7. Spiel speichern. ");
                Console.WriteLine("8. Spiel beenden. ");

                Spielereingabe = Console.ReadLine();

                switch (Spielereingabe)
                {
                    case "1":
                        i++;
                        Kaminzimmer();
                        break;

                    case "2":
                        i++;
                        Kueche();
                        break;

                    case "3":
                        i++;
                        AmandaParkerEsszimmer();
                        break;

                    case "4":
                        i++;
                        JuliaDavisEsszimmer();
                        break;

                    case "7":
                        Spielspeichern();
                        break;

                    case "6":
                        Gewinnen();
                        break;

                    case "8":
                        i++;
                        Environment.Exit(0);
                        break;

                    case "5":
                        Hinweiseansehen();
                        break;

                    default:
                        Console.WriteLine("Error");
                        break;

                }
            }
            while (i == 0);

        }
        #endregion

        #region Küche
        static void Kueche()
        {
            Raum = 8;

            do
            {

                i = 0;
                Console.Clear();
                Console.WriteLine("Du stehst in der Küche, was möchtest du tun?\n ");
                Console.WriteLine("1. Gehe zurück in das Esszimmer.");
                Console.WriteLine("2. Spreche mit Mrs. Smith. ");
                Console.WriteLine("3. Hinweise Ansehen. ");
                Console.WriteLine("4. Fall Lösen");
                Console.WriteLine("5. Spiel speichern. ");
                Console.WriteLine("6. Spiel beenden. ");

                Spielereingabe = Console.ReadLine();

                switch (Spielereingabe)
                {
                    case "1":
                        i++;
                        Esszimmer();
                        break;

                    case "2":
                        i++;
                        MrsSmithKueche();

                        break;

                    case "5":
                        Spielspeichern();
                        break;

                    case "4":
                        Gewinnen();
                        break;

                    case "6":
                        i++;
                        Environment.Exit(0);
                        break;

                    case "3":
                        Hinweiseansehen();
                        break;

                    default:
                        Console.WriteLine("Error");
                        break;
                }
            }
            while (i == 0);
        }
        #endregion

        #region Keller
        static void Keller()
        {
            Raum = 9;
            i = 0;
            do
            {

                Console.Clear();
                Console.WriteLine("Du stehst jetzt im Keller, was möchtest du tun?\n ");
                Console.WriteLine("1. Gehe in den zweiten Kellerraum. ");
                Console.WriteLine("2: Gehe zurück nach oben in den Flur. ");
                Console.WriteLine("3. Schaue dir die Truhe neben der Treppe an. ");
                Console.WriteLine("4. Überprüfe den Schrank.");
                Console.WriteLine("5. Hinweise Ansehen. ");
                Console.WriteLine("6. Fall Lösen");
                Console.WriteLine("7. Spiel speichern. ");
                Console.WriteLine("8. Spiel beenden. ");

                Spielereingabe = Console.ReadLine();

                switch (Spielereingabe)
                {
                    case "1":
                        i++;
                        Abkeller();
                        break;

                    case "2":
                        i++;
                        Flur();
                        break;

                    case "3":
                        if (leiche[6] == 1 && leichegefunden == 0)
                        {

                            Console.WriteLine("Du findest eine Leiche, es handelt sich dabei um den verschwundenen Gastgeber. ");
                            leichegefunden = 1;
                        }
                        else if (leiche[6] == 1 && leichegefunden == 1)
                        {
                            Console.WriteLine("Du findest die bereits gefundene Leiche des Gastgebers. ");
                        }
                        else if (leiche[6] == 0)
                        {
                            Console.WriteLine("In der Truhe sind nur alte Bücher. ");
                        }
                        else
                        {
                            Console.WriteLine("Error");
                        }
                        Console.WriteLine("Drücke Enter Taste um fortzuffahren");
                        Console.ReadLine();
                        break;

                    case "4":
                        if (leiche[7] == 1 && leichegefunden == 0)
                        {

                            Console.WriteLine("Du findest eine Leiche, es handelt sich dabei um den verschwundenen Gastgeber. ");
                            leichegefunden = 1;
                        }
                        else if (leiche[7] == 1 && leichegefunden == 1)
                        {
                            Console.WriteLine("Du findest die bereits gefundene Leiche des Gastgebers. ");
                        }
                        else if (leiche[7] == 0)
                        {
                            Console.WriteLine("In dem Schrank sind nur alte Ordner und Dokumente. ");
                        }
                        else
                        {
                            Console.WriteLine("Error");
                        }
                        Console.WriteLine("Drücke Enter Taste um fortzuffahren");
                        Console.ReadLine();
                        break;

                    case "7":
                        Spielspeichern();
                        break;

                    case "6":
                        Gewinnen();
                        break;

                    case "8":
                        i++;
                        Environment.Exit(0);
                        break;

                    case "5":
                        Hinweiseansehen();
                        break;

                    default:
                        Console.WriteLine("Error");
                        break;
                }
            } while (i == 0);
        }
        #endregion

        #region AbKeller

        static void Abkeller()
        {
            i = 0;
            Raum = 9;
            do
            {
                Console.Clear();
                Console.WriteLine("Du stehst jetzt in dem hinteren Kellerabteil, was möchtest du tun?\n ");
                Console.WriteLine("1. Gehe zurück in den ersten Raum des Kellers. ");
                Console.WriteLine("2. Schaue dir den Kisten Stapel genauer an.");
                Console.WriteLine("3. Überprüfe die beiden Schränke. ");
                Console.WriteLine("4. Hinweise Ansehen. ");
                Console.WriteLine("5. Fall Lösen");
                Console.WriteLine("6. Spiel speichern. ");
                Console.WriteLine("7. Spiel beenden. ");

                Spielereingabe = Console.ReadLine();

                switch (Spielereingabe)
                {
                    case "1":
                        i++;
                        Keller();
                        break;

                    case "2":
                        if (leiche[8] == 1 && leichegefunden == 0)
                        {

                            Console.WriteLine("Du überprüfst den Kisten Stapel und findest hinter den Kisten eine Leiche. ");
                            Console.WriteLine("Bei der Leiche handelt es sich um den verschwundenen Gastgeber. ");
                            leichegefunden = 1;
                        }
                        else if (leiche[6] == 1 && leichegefunden == 1)
                        {
                            Console.WriteLine("Du hasst die Leiche hinter den Kisten bereits gefunden. ");
                        }
                        else if (leiche[6] == 0)
                        {
                            Console.WriteLine("Du erkennst einige Spinnennetze und Schrott, weiter nichts. ");
                        }
                        else
                        {
                            Console.WriteLine("Error");
                        }
                        Console.WriteLine("Drücke die Enter Taste um fortzufahren. ");
                        Console.ReadLine();
                        break;

                    case "3":
                        if (leiche[9] == 1 && leichegefunden == 0)
                        {

                            Console.WriteLine("Du findest eine Leiche zwischen den Schränken. Es handelt sich dabei um die Leiche des Gastgebers. ");
                            leichegefunden = 1;
                        }
                        else if (leiche[9] == 1 && leichegefunden == 1)
                        {
                            Console.WriteLine("Du siehst die bereits gefundende Leiche. ");
                        }
                        else if (leiche[9] == 0)
                        {
                            Console.WriteLine("Du findest nichts. ");
                        }
                        else
                        {
                            Console.WriteLine("Error");
                        }
                        Console.WriteLine("Drücke die Enter Taste um fortzufahren. ");
                        Console.ReadLine();
                        break;

                    case "6":
                        Spielspeichern();
                        break;

                    case "5":
                        Gewinnen();
                        break;

                    case "7":
                        i++;
                        Environment.Exit(0);
                        break;

                    case "4":
                        Hinweiseansehen();
                        break;


                    default:
                        Console.WriteLine("Error");
                        break;
                }


            } while (i == 0);
        }
        #endregion

        #region Geheimraum

        static void Geheimraum()
        {
            Console.Clear();
            i = 0;
            Raum = 10;

            Console.WriteLine("Du stehst in einem geheimen Raum. Er wird wohl als Safe Room in Notsituationen genutzt. ");

            if (leiche[3] == 1 && leichegefunden == 0)
            {
                Console.WriteLine("Auf dem Boden findest du die Leiche des verschwundenen Gastgebers. ");
            }
            if (leiche[3] == 1 && leichegefunden == 1)
            {
                Console.WriteLine("Du siehst die bereits gefundende Leiche. ");
            }
            else
            {
                Console.WriteLine("Im Raum befindet sich nichts Interessantes. ");
            }

            Console.WriteLine("Was möchtest du tun?\n ");
            Console.WriteLine("1. Gehe zurück in die Bibliothek. ");
            Console.WriteLine("2. Spiel speichern. ");
            Console.WriteLine("3. Spiel beenden. ");
            Console.WriteLine("4. Hinweise Ansehen. ");

            Spielereingabe = Console.ReadLine();

            switch (Spielereingabe)
            {
                case "1":
                    Bibliothek();
                    break;

                case "2":
                    Spielspeichern();
                    break;

                case "3":
                    Environment.Exit(0);
                    break;

                case "4":
                    Hinweiseansehen();
                    break;

                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
        #endregion

        #region Random Leiche 

        static void Rleiche()
        {

            Random random = new Random();
            rleiche = random.Next(1, 11);

            switch (rleiche)
            {
                case 1:
                    leiche[0] = 1; // 1 Fach in der Abstellkammer 
                    break;

                case 2:
                    leiche[1] = 1; // 2 Fach in der Abstellkammer 
                    break;

                case 3:
                    leiche[2] = 1; // 3 Fach in der Abstellkammer 
                    break;

                case 4:
                    leiche[3] = 1; // Geheimraum Leiche
                    break;

                case 5:
                    leiche[4] = 1; // Leiche im Kleider Schrank
                    break;

                case 6:
                    leiche[5] = 1; // leiche im Bett
                    break;

                case 7:
                    leiche[6] = 1; // leiche in der Truhe keller
                    break;

                case 8:
                    leiche[7] = 1; // leiche im Schrank Keller
                    break;

                case 9:
                    leiche[8] = 1; // LEiche hinter dem Kisten Stapel Abstellkammer keller
                    break;

                case 10:
                    leiche[9] = 1; // Leiche  in den Fächern im Keller
                    break;
            }
        }
        #endregion

        #region Sprechen mit Mrs. Smith
        static void MrsSmithKueche()
        {
            Console.WriteLine("Du näherst dich Mrs. Smith. ");
            Console.WriteLine("Möchtest du die Person untersuchen, mit ihr sprechen oder die Küche verlassen?\n ");
            Console.WriteLine("1. Untersuchen. ");
            Console.WriteLine("2. Sprechen. ");
            Console.WriteLine("3. Zurück in das Esszimmer. ");
            Spielereingabe = Console.ReadLine();

            switch (Spielereingabe)
            {
                case "1":
                    Console.WriteLine("Mrs. Smith ist eine ältere Dame und trägt immer eine alte, aber gepflegte Schürze und hat ein markantes Grübchen auf ihrer linken Wange.");
                    Console.ReadLine();
                    break;
                case "2":
                    Console.WriteLine("Mrs. Smith: „Hallo Detective, schön Sie zu sehen, wie kann ich Ihnen helfen?“\n ");
                    Console.WriteLine("Detective Shelby: „Guten Abend Mrs. Smith, ich habe ein Paar Fragen an Sie, wenn es Ihnen keine Umstände bereitet.“\n ");
                    Console.WriteLine("Mrs. Smith: „Selbstverständlich, was haben Sie denn für Fragen?“\n ");
                    Console.WriteLine("Detective Shelby: „Haben Sie irgendetwas Verdächtiges mitbekommen oder können Sie mir etwas über Mr. Morgan erzählen?“\n ");
                    Console.WriteLine("Mrs. Smith: „Ich habe tatsächlich etwas mitbekommen.“\n ");
                    Console.WriteLine("Mrs. Smith: „Ich hörte, wie sich Herr Morgan, mit der Frau Lee lautstark unterhalten hat.“\n ");
                    Console.WriteLine("Mrs. Smith: „Es hörte sich nach einer ordentlichen Auseinandersetzung an.“ ");
                    Console.WriteLine("Detective Shelby: „Vielen Dank Mrs. Smith, Sie haben mir sehr geholfen. Falls ich weitere Fragen haben sollte, melde ich mich bei Ihnen.“\n ");
                    Console.ReadLine();
                    break;
                case "3":
                    Esszimmer();
                    break;
                default:
                    Console.WriteLine("Error!");
                    break;
            }


        }
        #endregion

        #region Sprechen mit Karen Lee
        static void KarenLeeBad()
        {
            Console.WriteLine("Du näherst dich Karen Lee. ");
            Console.WriteLine("Möchtest du die Person untersuchen, mit ihr sprechen oder das Bad verlassen?\n ");
            Console.WriteLine("1. Untersuchen. ");
            Console.WriteLine("2. Sprechen. ");
            Console.WriteLine("3. Zurück in den Flur. ");
            Spielereingabe = Console.ReadLine();

            switch (Spielereingabe)
            {
                case "1":
                    Console.WriteLine("Sie hat eine randlose Brille auf der Nase und trägt einen auffälligen, roten Lippenstift. Außerdem kannst du Hautrötungen an Ihren Armen erkennen. ");
                    Console.ReadLine();
                    break;
                case "2":
                    Console.WriteLine("Karen Lee: „Guten Abend Detective Shelby, Sie haben mich erschreckt! Wie kann ich Ihnen helfen?“\n ");
                    Console.WriteLine("Detective Shelby: „Guten Abend Ms. Lee, entschuldigen Sie die Störung! Ich hätte ein paar Fragen. Haben Sie etwas Ungewöhnliches in den letzten Stunden bemerkt?“\n ");
                    Console.WriteLine("Du siehst wie sie sich das Gesicht abwischt und ein leicht rot gefärbtes Tuch in den Mülleimer wirft.\n ");
                    Console.WriteLine("Karen Lee: „Nein, ich habe nichts Ungewöhnliches bemerkt.“\n ");
                    Console.WriteLine("Detective Shelby: „Vielen Dank für Ihre Hilfe, Ms. Lee. Falls Sie sich noch an etwas erinnern sollten, lassen Sie es mich bitte wissen.“\n ");
                    Console.WriteLine("Karen Lee: „Natürlich, Detective. Ich hoffe, Sie finden heraus, was passiert ist.“\n ");
                    Console.ReadLine();
                    break;
                case "3":
                    Flur();
                    break;
                default:
                    Console.WriteLine("Error!");
                    break;
            }


        }
        #endregion

        #region Sprechen mit John Doe

        static void JohnDoeFlur()
        {
            Console.Clear();
            i = 0;
            do
            {
                Console.WriteLine("Du näherst dich John Doe. ");
                Console.WriteLine("Möchtest du die Person untersuchen, mit ihr sprechen oder dich weiter im Flur umsehen?\n ");
                Console.WriteLine("1. Untersuchen. ");
                Console.WriteLine("2. Sprechen. ");
                Console.WriteLine("3. Weiter umsehen. ");
                Spielereingabe = Console.ReadLine();

                switch (Spielereingabe)
                {
                    case "1":
                        Console.WriteLine("Trägt eine dunkle Sonnenbrille und hat eine auffällige Narbe über seiner linken Augenbraue.");
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("Detective Shelby: „Guten Abend John. Dürfte dir ein paar Fragen stellen?“\n ");
                        Console.WriteLine("John Doe: „Ach, du bist es Scott. Natürlich, nur nicht so zögerlich.“\n");
                        Console.WriteLine("Detective Shelby: „Hast du eventuell irgendetwas verdächtiges mitbekommen an diesem Abend?“\n");
                        Console.WriteLine("John Doe: „Hmm, jetzt wo ich so darüber nachdenke, ist mir tatsächlich etwas komisch vorgekommen.“\n");
                        Console.WriteLine("John Doe: „Ich stand hier im Flur und habe mir die Gemälde an den Wänden angeschaut, da sah ich wie Ms. Lee weinend ins Bad rannte.“\n");
                        Console.WriteLine("Detective Shelby: „Danke, das hilft mir sehr weiter. Falls ich noch Fragen an dich haben sollte, melde ich mich.“\n");
                        Console.ReadLine();
                        break;
                    case "3":
                        Flur();
                        break;
                    default:
                        Console.WriteLine("Error!");
                        break;
                }

            } while (i == 0);


        }

        #endregion

        #region Sprechen mit Elizabeth Rodriguez

        static void ElizabethRodriguezFlur()
        {
            Console.Clear();
            i = 0;
            do
            {
                Console.WriteLine("Du näherst dich Elizabeth Rodriguez. ");
                Console.WriteLine("Möchtest du die Person untersuchen, mit ihr sprechen oder dich weiter im Flur umsehen?\n ");
                Console.WriteLine("1. Untersuchen. ");
                Console.WriteLine("2. Sprechen. ");
                Console.WriteLine("3. Weiter umsehen. ");
                Spielereingabe = Console.ReadLine();

                switch (Spielereingabe)
                {
                    case "1":
                        Console.WriteLine("Hat graue Haare, trägt eine perlenbesetzte Kette und hat eine auffällige Lesebrille.");
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("Detective Shelby: „Guten Abend Frau Rodriguez. Dürfte ich Ihnen ein paar Fragen stellen?“\n ");
                        Console.WriteLine("Elizabeth Rodriguez: „Gut dass Sie da sind Detective, haben Sie schon etwas zu dem Verschwinden von Arthur herausgefunden?“\n");
                        Console.WriteLine("Detective Shelby: „Leider noch nicht, ich bin mit allen Mitteln dabei um sein Verschwinden so schnell wie möglich zu klären.“\n ");
                        Console.WriteLine("Elizabeth Rodriguez: „Sagen Sie mir bitte sobald Sie etwas wissen. Ich bin sehr besorgt!“\n ");
                        Console.WriteLine("Elizabeth Rodriguez: „Und bevor Sie fragen, ich habe leider nichts gesehen oder gehört. Zuletzt sah ich Arthur mit Ms. Lee in der Bibliothek.“\n ");
                        Console.WriteLine("Detective Shelby: „Keine Sorge, ich werde den Fall lösen. Vielen Dank für Ihre Offenheit. Bei weiteren Fragen, melde ich mich.“\n ");
                        Console.ReadLine();
                        break;
                    case "3":
                        Flur();
                        i++;
                        break;
                    default:
                        Console.WriteLine("Error!");
                        break;
                }

            } while (i == 0);

        }
        #endregion

        #region Sprechen mit Mr. Thompson

        static void MrThompsonKaminzimmer()
        {
            Console.Clear();
            i = 0;

            do
            {
                Console.WriteLine("Du näherst dich Mr. Thompson. ");
                Console.WriteLine("Möchtest du die Person untersuchen, mit ihr sprechen oder dich weiter im Raum umsehen?\n ");
                Console.WriteLine("1. Untersuchen. ");
                Console.WriteLine("2. Sprechen. ");
                Console.WriteLine("3. Weiter umsehen. ");
                Spielereingabe = Console.ReadLine();

                switch (Spielereingabe)
                {
                    case "1":
                        Console.WriteLine("Hat einen perfekt gestylten Bart und trägt teure Sonnenbrillen.");
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("Detective Shelby: „Guten Abend Herr Thompson. Dürfte ich Ihnen ein paar Fragen stellen?“\n ");
                        Console.WriteLine("Mr. Thompson: „Selbst redent, Herr Shelby. Spucken Sie es nur aus.“\n");
                        Console.WriteLine("Detective Shelby: „Haben Sie etwas Verdächtiges gesehen oder gehört?“\n");
                        Console.WriteLine("Mr. Thompson: „Ich habe Herr Morgan zuletzt mit Herrn Brown reden gesehen.“\n");
                        Console.WriteLine("Mr. Thompson: „Ansonnsten konnte ich nichts Auffälliges beobachten.“\n");
                        Console.WriteLine("Detective Shelby: „Vielen Dank, falls ich weitere Fragen habe, melde ich mich.“\n");
                        Console.ReadLine();
                        break;
                    case "3":
                        Kaminzimmer();
                        i++;
                        break;
                    default:
                        Console.WriteLine("Error!");
                        break;
                }
            } while (i == 0);


        }
        #endregion

        #region Sprechen mit Michael Brown

        static void MichaelBrownKaminzimmer()
        {
            i = 0;
            Console.Clear();
            do
            {
                Console.WriteLine("Du näherst dich Michael Brown. ");
                Console.WriteLine("Möchtest du die Person untersuchen, mit ihr sprechen oder dich weiter im Raum umsehen?\n ");
                Console.WriteLine("1. Untersuchen. ");
                Console.WriteLine("2. Sprechen. ");
                Console.WriteLine("3. Weiter umsehen. ");


                Spielereingabe = Console.ReadLine();

                switch (Spielereingabe)
                {
                    case "1":
                        Console.WriteLine("Trägt einen Ring mit einem Totenkopf an der rechten Hand.");
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("Detective Shelby: „Guten Abend Mr. Brown. Dürfte ich Ihnen ein paar Fragen stellen?“\n ");
                        Console.WriteLine("Michael Brown: „Natürlich Herr Detective. Ich helfe Ihnen gerne weiter.“\n");
                        Console.WriteLine("Detective Shelby: „Haben Sie etwas Verdächtiges gesehen oder gehört?“\n");
                        Console.WriteLine("Michael Brown: „Ich habe mich mit Herrn Morgan über mein neues Motorrad unterhalten.“\n");
                        Console.WriteLine("Michael Brown: „Anschließend habe ich Ihn in die Bibliothek verschwinden sehen.“\n");
                        Console.WriteLine("Detective Shelby: „Vielen Dank für die Hilfe Mr. Brown. Wenn ich weitere Fragen habe, melde ich mich.“\n");
                        Console.ReadLine();
                        break;
                    case "3":
                        Kaminzimmer();
                        i++;
                        break;
                    default:
                        Console.WriteLine("Error!");
                        break;
                }
            } while (i == 0);


        }

        #endregion

        #region Sprechen mit Tony Sanchez

        static void TonySanchezKaminzimmer()
        {
            i = 0;
            Console.Clear();
            do
            {
                Console.WriteLine("Du näherst dich TonySanchez. ");
                Console.WriteLine("Möchtest du die Person untersuchen, mit ihr sprechen oder dich weiter im Raum umsehen?\n ");
                Console.WriteLine("1. Untersuchen. ");
                Console.WriteLine("2. Sprechen. ");
                Console.WriteLine("3. Weiter umsehen. ");
                Spielereingabe = Console.ReadLine();

                switch (Spielereingabe)
                {
                    case "1":
                        Console.WriteLine("Ein junger Boxer mit einer beeindruckenden Statur und einer auffälligen Tätowierung auf seinem linken Arm.");
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("Detective Shelby: „Guten Abend Mr. Sanchez. Dürfte ich Ihnen ein paar Fragen stellen?“\n ");
                        Console.WriteLine("Michael Brown: „Wie kann ich Ihnen helfen?“\n");
                        Console.WriteLine("Detective Shelby: „Haben Sie etwas gesehen oder gehört, dass mir im Fall weiterhelfen könnte?“\n");
                        Console.WriteLine("Michael Brown: „Nein, ich habe nichts gesehen Detective. Aber wenn ich Ihnen anderweitig helfen kann melden Sie sich.“\n");
                        Console.WriteLine("Detective Shelby: „Trotzdem danke, ja das werde ich tun.“\n");
                        Console.ReadLine();
                        break;
                    case "3":
                        Kaminzimmer();
                        i++;
                        break;
                    default:
                        Console.WriteLine("Error!");
                        break;
                }

            } while (i == 0);

        }

        #endregion

        #region Sprechen mit Professor Hayes

        static void ProfessorWilliamHayesBibliothek()
        {
            i = 0;
            Console.Clear();
            do
            {
                Console.WriteLine("Du näherst dich Professor Hayes. ");
                Console.WriteLine("Möchtest du die Person untersuchen, mit ihr sprechen oder dich weiter im Raum umsehen?\n ");
                Console.WriteLine("1. Untersuchen. ");
                Console.WriteLine("2. Sprechen. ");
                Console.WriteLine("3. Weiter umsehen. ");
                Spielereingabe = Console.ReadLine();

                switch (Spielereingabe)
                {
                    case "1":
                        Console.WriteLine("Ein älterer Gelehrter, der sich auf antike Kulturen spezialisiert hat und oft mit einem Wanderstock und einer Brille zu sehen ist.");
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("Detective Shelby: „Guten Abend Professor. Dürfte ich Ihnen ein paar Fragen stellen?“\n ");
                        Console.WriteLine("Professor Hayes: „Sehr gerne, wie kann ich Ihnen helfen?“\n");
                        Console.WriteLine("Detective Shelby: „Wann haben Sie Mr. Morgan zuletzt gesehen?“\n");
                        Console.WriteLine("Professor Hayes: „Ich habe mich gegen 22:00uhr zuletzt mit Mr. Morgan unterhalten. Es ging dabei um die neusten Ausgrabungen in Kairo.“\n");
                        Console.WriteLine("Professor Hayes: „Dann hat Ms. Lee unser Gespräch unterbrochen und ist mit Herrn Morgan verschwunden.“\n");
                        Console.WriteLine("Detective Shelby: „Sie waren mir eine große Hilfe. Bei weiteren Fragen, melde ich mich.“\n");
                        Console.ReadLine();
                        break;
                    case "3":
                        Bibliothek();
                        i++;
                        break;
                    default:
                        Console.WriteLine("Error!");
                        break;
                }
            } while (i == 0);


        }
        #endregion

        #region Sprechen mit Amanda Parker

        static void AmandaParkerEsszimmer()
        {
            i = 0;
            Console.Clear();
            do
            {

                Console.WriteLine("Du näherst dich Amanda Parker. ");
                Console.WriteLine("Möchtest du die Person untersuchen, mit ihr sprechen oder dich weiter im Raum umsehen?\n ");
                Console.WriteLine("1. Untersuchen. ");
                Console.WriteLine("2. Sprechen. ");
                Console.WriteLine("3. Weiter umsehen. ");
                Spielereingabe = Console.ReadLine();

                switch (Spielereingabe)
                {
                    case "1":
                        Console.WriteLine("Sie hat eine auffällige Tätowierung auf ihrem rechten Arm und trägt eine rote Schürze.\nIhr Gesicht sagt es laut und deutlich, sie scheint vom Verschwinden des Gastgebers völlig kalt gelassen zu sein. ");
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("Amanda Parker: „Guten Abend Detective, wie kann ich Ihnen helfen?“\n ");
                        Console.WriteLine("Detective Shelby: „Guten Abend Ms. Parker, ich habe ein Paar Fragen an Sie, wenn es Ihnen keine Umstände bereitet.“\n ");
                        Console.WriteLine("Amanda Parker: „Selbstverständlich, was haben Sie denn für Fragen?“\n ");
                        Console.WriteLine("Detective Shelby: „Haben Sie irgendetwas Verdächtiges mitbekommen und können mir etwas zu dem Verschwinden von Mr. Morgan erzählen?“\n ");
                        Console.WriteLine("Amanda Parker: „Leider muss ich Sie enttäuschen, ich habe nichts mitbekommen.“\n ");
                        Console.WriteLine("Amanda Parker: „Ich habe Mr. Morgan lediglich ein paar Mal vorbeilaufen sehen.“\n ");
                        Console.WriteLine("Amanda Parker: „Ansonnsten unterhielt ich mich den gesamten Abend mit Julia.“ ");
                        Console.WriteLine("Detective Shelby: „Vielen Dank Ms. Parker, falls ich weitere Fragen haben sollte, melde ich mich bei Ihnen.“\n ");
                        Console.ReadLine();
                        break;
                    case "3":
                        Esszimmer();
                        i++;
                        break;
                    default:
                        Console.WriteLine("Error!");
                        break;
                }

            } while (i == 0);

        }
        #endregion

        #region Sprechen mit Julia Davis

        static void JuliaDavisEsszimmer()
        {
            i = 0;
            Console.Clear();
            do
            {

                Console.WriteLine("Du näherst dich Julia Davis. ");
                Console.WriteLine("Möchtest du die Person untersuchen, mit ihr sprechen oder dich weiter im Raum umsehen?\n ");
                Console.WriteLine("1. Untersuchen. ");
                Console.WriteLine("2. Sprechen. ");
                Console.WriteLine("3. Weiter umsehen. ");
                Spielereingabe = Console.ReadLine();

                switch (Spielereingabe)
                {
                    case "1":
                        Console.WriteLine("Vor dir steht eine erfolgreiche Geschäftsfrau mit einem strengen Auftreten und einer Vorliebe für hochwertige Designerkleidung.");
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("Julia Davis: „Guten Abend, was kann ich für Sie tun Mr. Shelby?“\n ");
                        Console.WriteLine("Detective Shelby: „Guten Abend Ms. Davis, ich habe ein Paar Fragen an Sie, wenn es Ihnen keine Umstände bereitet.“\n ");
                        Console.WriteLine("Julia Davis: „Mir bleibt ja wohl keine Wahl, wenn man die Umstände betrachtet. Wir wollen schließlich alle langsam mal nach Hause.“\n ");
                        Console.WriteLine("Detective Shelby: „Ich entschuldige mich für die Umstände und bin zuversichtlich den Fall bald zu lösen.“\n ");
                        Console.WriteLine("Detective Shelby: „Haben Sie irgendetwas Verdächtiges gehört oder gesehen?“\n ");
                        Console.WriteLine("Julia Davis: „Leider nicht nein. Ich wünschte es wäre so, dann könnte ich dieses geschmacklose Haus bald verlassen.“\n ");
                        Console.WriteLine("Julia Davis: „Ich habe mich seit Stunden mit Amanda unterhalten. Mehr kann ich Ihnen leider nicht sagen Mr. Shelby.“ ");
                        Console.WriteLine("Detective Shelby: „Vielen Dank Ms. Davis, falls ich weitere Fragen haben sollte, melde ich mich bei Ihnen.“\n ");
                        Console.ReadLine();
                        break;
                    case "3":
                        Esszimmer();
                        i++;
                        break;
                    default:
                        Console.WriteLine("Error!");
                        break;
                }

            } while (i == 0);


        }
        #endregion

        #region Hinweise ansehen

        static void Hinweiseansehen()
        {
            Console.Clear();

            do
            {
                if (leichegefunden == 1 && code == 1)
                {
                    Console.WriteLine("Du hast die Leiche des Gastgebers gefunden. In dem Gesicht der Leiche sind rote Spuren zu erkennen. ");
                    Console.WriteLine("Du hast einen Zettel gefunden auf dem 187 steht. ");
                }
                else if (leichegefunden == 1 && code == 0)
                {
                    Console.WriteLine("Du hast die Leiche des Gastgebers gefunden. In dem Gesicht der Leiche sind rote Spuren zu erkennen. ");
                }
                else if (leichegefunden == 0 && code == 1)
                {
                    Console.WriteLine("Du hast einen Zettel gefunden auf dem 187 steht. ");
                }
                else if (leichegefunden == 0 && code == 0)
                {
                    Console.WriteLine("Du hast noch keine Hinweise gefunden\n");
                }

                Console.WriteLine("Drücke die Enter Taste um fortzufahren. ");
                Console.ReadLine();
                

                switch (Raum)
                {
                    case 1:
                        i++;
                        Flur();
                        break;

                    case 2:
                        i++;
                        Bad();
                        break;

                    case 3:
                        i++;
                        Abstellkammer();
                        break;

                    case 4:
                        i++;
                        Kaminzimmer();
                        break;

                    case 5:
                        i++;
                        Bibliothek();
                        break;

                    case 6:
                        i++;
                        Schlafzimmer();
                        break;

                    case 7:
                        i++;
                        Esszimmer();
                        break;

                    case 8:
                        i++;
                        Kueche();
                        break;

                    case 9:
                        i++;
                        Keller();
                        break;

                    case 10:
                        i++;
                        Abkeller();
                        break;

                }

            } while (i == 0);

        }
        #endregion

        #region Gewinnen

        public static void Gewinnen()
        {
            if (leichegefunden == 1)
            {
                Console.WriteLine("Du hast die Leiche gefunden und kannst den Fall jetzt lösen. ");
                Console.WriteLine("Möchtest du versuchen den Fall lösen?: (ja) (nein)");

                Spielereingabe = Console.ReadLine();
                if (Spielereingabe.ToLower() == "ja")
                {
                    do
                    {   
                        Console.Clear();

                        Console.WriteLine("Also, wer glaubst du hat ihn getötet?\n ");
                        Console.WriteLine("Mrs. Smith");
                        Console.WriteLine("John Doe");
                        Console.WriteLine("Elizabeth Rodriguez");
                        Console.WriteLine("Mr. Thompson");
                        Console.WriteLine("Michael Brown");
                        Console.WriteLine("Tony Sanchez");
                        Console.WriteLine("Professor William Hayes");
                        Console.WriteLine("Amanda Parker");
                        Console.WriteLine("Julia Davis");
                        Console.WriteLine("Karen Lee\n");
                        Console.WriteLine("Pass auf, du hast nur 3 Versuche und dann macht sich der Killer aus dem Staub! ");
                        Console.WriteLine("Drücke 1 um weiter zu suchen");

                        Spielereingabe = Console.ReadLine();

                        if (Spielereingabe.ToLower() == "karen lee")
                        {
                            SoundPlayer gewinnerMusik = new SoundPlayer(@"C:\Users\lukeb\OneDrive\Desktop\Finalgame\gewonnen.wav");
                            gewinnerMusik.Play();
                            Console.WriteLine("Herzlichen Glückwunsch! Sie haben den Fall gelöst!\n");
                            Console.WriteLine("Bitte drücken Sie eine beliebige Taste zum Fortfahren.");
                            Console.ReadLine();
                            Console.Clear();

                            Console.WriteLine("Detective Shelby: „Guten Abend, ich entschuldige mich bei Ihnen, für das lange Warten!“\n");
                            Console.WriteLine("Detective Shelby: „Wie Ihnen sicherlich schon bekannt ist, ist der Gastgeber heute Abend verschwunden.“\n");
                            Console.WriteLine("Detective Shelby: „Ich habe den Fall gelöst!“\n");
                            Console.WriteLine("Karen Lee: „Könnten wir zur Sache kommen? Ich möchte endlich wissen, was los ist.“\n");
                            Console.WriteLine("Detective Shelby: „Nun, Ms. Lee, nur nicht so eilig, wir haben Beweise. Wie ich gehört habe, wurden Sie zuletzt mit Mr. Morgan gesehen?“\n");
                            Console.WriteLine("Karen Lee: „Was? Das ist lächerlich. Ja, ich habe ihn gesehen, aber warum macht mich das nun verdächtig?“\n");
                            Console.WriteLine("Detective Shelby: „Mir ist bekannt, dass sie sich vor wenigen Stunden mit Mr. Morgan wegen etwas gestritten haben, das ist Ihnen doch hoffentlich bewusst?“\n");
                            Console.WriteLine("Karen Lee: „Ja, ich war wütend auf ihn, aber das tut nichts zur Sache!“\n");
                            Console.WriteLine("Detective Shelby: „Und wenn es Beweise gäbe, die gegen Sie sprechen?“\n");
                            Console.WriteLine("Karen Lee: „Meine Güte! Wie können Sie nur so etwas denken! Niemals würde ich jemanden töten!! Welche Gründe hätte ich denn dazu?“\n");
                            Console.WriteLine("Detective Shelby: „Nun stellen Sie sich nicht so an. Ich habe an der Leiche einen roten Lippenstift gefunden, der Ihrem sehr ähnlich sieht.“\n");
                            Console.WriteLine("Detective Shelby: „Dieser Lippenstift wurde auch auf einem Glas gefunden, dass Sie benutzt haben.“\n");
                            Console.WriteLine("Karen Lee: „Und anhand eines Glases, sehen Sie mich nun als Mörder?“\n");
                            Console.WriteLine("Detective Shelby: „Miss Lee, Sie können nicht leugnen, dass Sie eifersüchtig auf John waren. Er hatte eine Affäre mit einer anderen Frau, und Sie waren wütend darüber.“\n");
                            Console.WriteLine("Karen Lee: „Ja, ich war verletzt, aber das gibt mir noch lange nicht das Recht, jemanden umzubringen. Ich habe nichts damit zu tun.“\n");
                            Console.WriteLine("Detective Shelby: „Wir haben Zeugenaussagen von Personen, die Sie und John an diesem Abend zusammen gesehen haben. Sie waren die letzte Person, die ihn lebendig gesehen hat.“\n");
                            Console.WriteLine("Karen Lee: „Was? Nein, das stimmt nicht. Ich habe ihn verlassen und er war noch am Leben. Ich schwöre es.“\n");
                            Console.WriteLine("Detective Shelby: „Ms. Lee, die Beweise sind eindeutig. Die Frage bleibt nur noch, wie Sie Mr. Morgan umgebracht haben.“\n");
                            Console.WriteLine("Detective Shelby: „Meine Vermutung liegt bei einer akuten Vergiftung durch Zyankali.\nZyankali ist ein starkes Gift, das schnell wirkt und bei einer Überdosis zu Atemlähmung und inneren Blutungen führen kann.\nEs gibt jedoch ein Gegenmittel namens Hydroxocobalamin, das bei einer Vergiftung mit Zyankali eingesetzt werden kann.\nEs ist wichtig zu beachten, dass die Zeit zwischen der Vergiftung und der Verabreichung des Gegenmittels entscheidend ist und daher eine schnelle Reaktion erforderlich ist.“\n");
                            Console.WriteLine("Detective Shelby: „Liegt deswegen die Ampulle des Gegenmittels im Mülleimer des Badezimmers Ms. Lee?“\n");
                            Console.WriteLine("Detective Shelby: „Das Labor wird mir dementsprechende Befunde über das Gegenmittel und ihre Fingerabdrücke der Ampulle bestätigen.“\n");
                            Console.WriteLine("Karen Lee: „Ja, ich hatte ein Motiv, aber das bedeutet nicht, dass ich es getan habe. Ich schwöre bei Gott, dass ich unschuldig bin.“\n");
                            Console.WriteLine("Detective Shelby: „Miss Lee, ich kann Ihnen helfen, wenn Sie die Wahrheit sagen.“\n");
                            Console.WriteLine("Karen Lee: „Ach verdammt! Er hat mich betrogen. Mit dieser Schlampe, die ich am liebsten auch umbringen würde.\nIch konnte nicht anders. Ich wollte ihm nur wehtun, aber ich habe es zu weit getrieben.\nIch hasse ihn und wenn ich recht darüber nachdenke, hat er es verdient!“\n");
                            Console.WriteLine("Man hört leise Aufschreie und das Klirren von Geschirr, das jemand aus Versehen fallen lässt.\n");
                            Console.WriteLine("Karen Lee wurde von Detective Shelby verhaftet und in Gewahrsam genommen.\nWährend der Untersuchungen im Labor wurde bestätigt, dass das Gift, das zur Tötung des Gastgebers verwendet wurde, Zyankali war.\nAuch wurde das Gegengift Hydroxocobalamin nachgewiesen, das bei der Behandlung von Zyankali-Vergiftungen eingesetzt wird.\nKaren wurde vor Gericht gestellt und aufgrund der erdrückenden Beweise, einschließlich ihres eigenen Geständnisses, für den Mord an Arthur Morgan verurteilt.\n");
                            Console.WriteLine("THE END");
                            SoundPlayer detektivmusik = new SoundPlayer(@"C:\Users\lukeb\OneDrive\Desktop\Finalgame\FinalgameDetectiveConan.wav");
                            detektivmusik.Play();
                            Console.ReadLine();
                            Environment.Exit(0);
                        }

                        else if (Spielereingabe == "1")
                        {
                            switch (Raum)
                            {
                                case 1:
                                    i++;
                                    Flur();
                                    break;

                                case 2:
                                    i++;
                                    Bad();
                                    break;

                                case 3:
                                    i++;
                                    Abstellkammer();
                                    break;

                                case 4:
                                    i++;
                                    Kaminzimmer();
                                    break;

                                case 5:
                                    i++;
                                    Bibliothek();
                                    break;

                                case 6:
                                    i++;
                                    Schlafzimmer();
                                    break;

                                case 7:
                                    i++;
                                    Esszimmer();
                                    break;

                                case 8:
                                    i++;
                                    Kueche();
                                    break;

                            }
                        }

                        else
                        {
                            Console.WriteLine("Leider falsch!\n");
                            Console.WriteLine("Drücke Enter um fortzufahren. ");

                            Console.ReadLine();
                        }


                    } while (x < 4);
                    Console.WriteLine("Der Mörder ist abgehauen. ");
                    Console.ReadLine();
                    Environment.Exit(0);

                }
                else if (Spielereingabe.ToLower() == "nein")
                {
                    switch (Raum)
                    {
                        case 1:

                            Flur();
                            break;

                        case 2:

                            Bad();
                            break;

                        case 3:

                            Abstellkammer();
                            break;

                        case 4:

                            Kaminzimmer();
                            break;

                        case 5:

                            Bibliothek();
                            break;

                        case 6:

                            Schlafzimmer();
                            break;

                        case 7:

                            Esszimmer();
                            break;

                        case 8:

                            Kueche();
                            break;

                    }
                }

                else if (leichegefunden == 0)
                {
                    Console.WriteLine("Du hast noch nicht genung Beweise gefunden.\n");
                    Console.WriteLine("Drücke Enter um fortzufahren. ");

                    Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("Error");
                }
            }

        }
        #endregion
    }
}