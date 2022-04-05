// =======================
// ESERCITAZIONE GITHUB 02
// =======================
//
//  === ISTRUZIONI ===
//
//  1.  correggere tutti gli errori di compilazione
//
//  2.  inserire nel punto giusto nome e cognome
//
//  3.  commit e push con messaggio di descrizione della commit/push
//
//  3.  nei punti indicati con TODO inserire i commenti
//      - i commenti devono essere inseriti con il //
//      - devono spiegare il significato delle istruzioni che si trovano subito dopo
//      - devono essere correttamente allineati
//      - devono sempre avere un carattere spazio dopo il //
//      - il commento non deve mai andare oltre la colonna 100
//      - se lungo scrivere su piu' righe
//
//  4. commit e push con mesaggio di descrizione della commit/push
//
//  5. fine esercitazione


using System;

namespace ConsoleAppTerza01
{
    class Program
    {
        // TODO
        statich void VisualizzaMessaggioIniziale()
        {
            Console.WriteLine("XXXXXXX YYYYYYYYY");
            Console.WriteLine("CLASSE XXX");
            Console.WriteLine("ITI E.MAJORA - GRUGLIASCO - TO");
        }

        // TODO
        static int VisualizzaMenu()
        {
            // TODO
            Console.WriteLine("\n===  MENU ===");
            Console.WriteLine("1 - INTERO (Decimale --> Binario)");
            Console.WriteLine("0 - Termina programma");

            // TODO
            Console.Write("Inserisci la tua scelta [0]: ");
            string choice = Console.ReadLine();
            Console.WriteLine();

            // TODO
            int c;
            bool numero = int.TryParse(choice, out c);
            if (c != 1 || !numero || choice == "")
            {
                // TODO
                c = 0;
            }

            return c;
        }

        // TODO
        static vooid InteroDecimaleInInteroBinario(int baseBinaria)
        {
            // TODO
            Console.Write("INTERO BASE DIECI --> INTERO BASE ");
            switch (baseBinaria)
            {
                case 2: Console.WriteLine("DUE"); break;
                case 8: Console.WriteLine("OTTO"); break;
                case 16: Console.WriteLine("SEDICI"); break;
            }

            // TODO
            string output = "";
            string input = Console.ReadLine();

            // TODO
            int inputNumero = 0;
            bool numero = int.TryParse(input, out inputNumero);

            // TODO
            if (numero)
            {
                // TODO
                int dividendo = inputNumero;
                int divisore = baseBinaria;
                int risultato = inputNumero;
                int resto = 0;
                string res = "";
                while (risultato > 0)
                {
                    risultato = dividendo / divisore;
                    resto = dividendo - (risultato * divisore);

                    if (resto < 9)
                    {
                        res = resto.ToString();
                    }
                    else
                    {
                        switch (resto)
                        {
                            case 10: res = "A"; break;
                            case 11: res = "B"; break;
                            case 12: res = "C"; break;
                            case 13: res = "D"; break;
                            case 14: res = "E"; break;
                            case 15: res = "F"; break;
                        }
                    }
                    output = res + output;

                    dividendo = risultato;
                }
            }
            else
            {
                // TODO
                output = "ERRORE DI INSERIMENTO NUMERO DECIMALE"
            }

            // TODO
            Console.WriteLine($"INPUT: {input}");
            Console.WriteLine($"OUTPUT: {output}");
        }

        // TODO
        static void __Main__(string[] args)
        {
            // TODO
            VisualizzaMessaggioIniziale();

            // TODO
            int scelta = VisualizzaMenu();

            if (scelta == 1)
            {
                InteroDecimaleInInteroBinario(2);
            }
        }
    }
}
