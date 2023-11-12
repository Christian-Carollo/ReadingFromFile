using System;
using System.IO;

class Program
{
    static void Main()
    {

        //@"C:\Users\Administrator.DESKTOP-95RB6IG\Desktop\FileLettura.txt"
        Console.Write("Inserisci il percorso del file: ");
        string percorsoFile = Console.ReadLine();

        //Ciao sono il Developer Christian
        Console.Write("Inserisci il contenuto del file: ");
        string contenutoFile = Console.ReadLine();


        // Ottieni il percorso assoluto se è un percorso relativo
        percorsoFile = Path.GetFullPath(percorsoFile);

        // Verifica se il percorso del file è valido
        if (File.Exists(percorsoFile))
        {
            if (!string.IsNullOrWhiteSpace(contenutoFile))
            {
                // Leggi e stampa il contenuto del file
                File.WriteAllText(percorsoFile, contenutoFile);

                string nuovoContenuto = File.ReadAllText(percorsoFile);

                Console.WriteLine(nuovoContenuto);
            }
            else
            {
                Console.WriteLine("Il contenuto del file non può essere vuoto o con soli spazi.");
            }

        }
        else
        {
            Console.WriteLine("Il percorso specificato non è valido.");
        }
    }

 
}