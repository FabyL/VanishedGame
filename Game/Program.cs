using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var yuzo = new Yuzo();
            EinführungsText(yuzo);
            Spielen(yuzo);
        }
        public static void Spielen(Yuzo yuzo)
        {
            Console.WriteLine("Was willst du tun?: (Gebe Bett, Korb, Flasche oder Waffe ein, um dahin zu gehen.)");
            if(yuzo.YuzosWaffe!=null)
            {
                Console.WriteLine("Gebe Waffe ein, um deine Waffe anzuschauen.");
            }

            var Auswahl = Console.ReadLine();

            if (Auswahl == "Bett")
            {
                GeheZumStartBett(yuzo);
            }
            else if (Auswahl == "Korb")
            {
                GeheZumStartKorb(yuzo);
            }
            else if (Auswahl == "Flasche")
            {
                GeheZurStartFlasche(yuzo);
            }
            else if (Auswahl == "Waffe")
            {
                InspiziereWaffe(yuzo);
                Spielen(yuzo);
            }
            else
            {
                Console.WriteLine("Bitte gebe nur: Bett, Korb oder Flasche ein.");
                Spielen(yuzo);
            }
        }
        
        
        public static void EinführungsText(Yuzo yuzo)
        {
            Console.WriteLine("Du befindest dich in einer Höhle und dein schädel brummt.");
            Console.WriteLine("Du kannst dich an nichts mehr erinnern und siehst dich um.");
            Console.WriteLine("Du siehst: Ein improvisiertes Bett, einen gefüllten Tragekorb und eine Kürbisflasche.");
        }
        public static void GeheZumStartBett(Yuzo yuzo)
        {
            Console.WriteLine("Du stehst vor dem Bett. Möchtest du ein schläfchen machen? (Schreib: Ja/Nein)");
            var Auswahl = Console.ReadLine();
            if (Auswahl == "Ja")
            {
                FindeStartAst(yuzo);
            }
            else if (Auswahl != "Ja")
            {
                Console.WriteLine("Du bist fit genug.");
            }
            Spielen(yuzo);
        }
        public static void FindeStartAst(Yuzo yuzo)
        {
            if (yuzo.YuzosWaffe == null)
            {
                Console.WriteLine("Zwischen den Laken findest du ein Ast.");
                Console.WriteLine("Möchtest du den Ast mitnehmen? (Schreib: Ja/Nein)");
                var Auswahl = Console.ReadLine();
                if (Auswahl == "Ja")
                {
                    yuzo.YuzosWaffe = new Waffe { Name = "Ast", Haltbarkeit = 20, Schaden = 1 };
                    Console.WriteLine("Du hast den Ast mitgenommen.");
                }
                else if (Auswahl != "Ja")
                {
                    Console.WriteLine("Du lässt den Ast liegen.");
                }
            }
            else
            {
                Console.WriteLine("Du fühlst dich erholt.");
            }
            Spielen(yuzo);
        }
        public static void GeheZumStartKorb(Yuzo yuzo)
        {
            if (yuzo.hatKorb)
            {
                Console.WriteLine("Du hast den Korb schon mitgenommen.");
            }
            else
            {
                Console.WriteLine("Der Korb ist gefüllt mit Nahrung. Möchtest du den Korb mitnehmen? (Schreib: Ja/Nein)");
                var Auswahl = Console.ReadLine();
                if (Auswahl == "Ja")
                {
                    Console.WriteLine("Du nimmst den Korb mit.");
                    yuzo.hatKorb = true;
                }
                else if (Auswahl != "Ja")
                {
                    Console.WriteLine("Du lässt den Korb stehen.");
                }
            }
            Spielen(yuzo);
        }
        public static void GeheZurStartFlasche(Yuzo yuzo)
        {
            if (yuzo.hatFlasche)
            {
                Console.WriteLine("Du hast die Flasche schon mitgenommen.");
            }
            else
            { 
            Console.WriteLine("Die Flasche ist mit Wasser gefüllt. Möchtest du draus trinken und die Flasche mitnehmen? (Schreib: Ja/Nein)");
            var Auswahl = Console.ReadLine();
            if (Auswahl == "Ja")
            {
                Console.WriteLine("Das Wasser erfrischt dich und du verstaust die Flasche in den Korb.");
                    yuzo.hatFlasche = true;
            }
            else if (Auswahl != "Ja")
            {
                Console.WriteLine("Was willst du tun?: (Gib Bett oder Korb ein, um dahin zu gehen.)");
                }
            }
            Spielen(yuzo);
        }
        public static void InspiziereWaffe(Yuzo yuzo)
        {
            if (yuzo.YuzosWaffe != null)
            {
                Console.WriteLine($"Name: {yuzo.YuzosWaffe.Name}, Schaden: {yuzo.YuzosWaffe.Schaden}, Haltbarkeit: {yuzo.YuzosWaffe.Haltbarkeit}");
            }
            else
            {
                Console.WriteLine("Du hast keine Waffe.");
            }
        }



    }
}