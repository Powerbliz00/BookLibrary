
/***
Questo programma in C# mostra una lista di titoli di libri con un prefisso "Titolo: ". Inizia definendo un array di stringhe contenente i titoli dei libri. Successivamente, utilizza un ciclo per iterare su ciascun titolo e concatenarlo con la stringa "Titolo: " prima di stamparlo a console. Infine, visualizzerà i titoli dei libri con il prefisso "Titolo: " su console.
***/


// Importazione del namespace 'System' che contiene le classi fondamentali e le funzionalità di input/output
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(Greetings());
        // Creazione di un nuovo array di stringhe chiamato 'Library' che contiene alcuni titoli di libri predefiniti
        string[] Library = {
            "Harry Potter",
            "Le cronache di Narnia",
            "Il Signore degli anelli",
            "Il giovane Holden",
            "Cronache del Ghiaccio e del Fuoco",
            "Divergent",
            "Hunger Games"
        };
        // Iterazione su ciascun elemento dell'array 'Library'
        foreach (string book in Library)
        {   
            // Creazione di una nuova stringa 'BookLibrary' che concatena la stringa "Titolo: " con il titolo del libro  
            string BookLibrary = string.Concat("Titolo: ", book);
            // Stampa a console il titolo del libro preceduto da "Titolo: " Output: Titolo: Harry Potter 
            Console.WriteLine(BookLibrary);
        }

// funzione di benvenuto
        static string Greetings(){
            string decoration = "\n(*)===(*)===(*)===(*)===(*)===(*)===(*)===(*)===(*)===(*)\n";
            return $"{decoration}Benvenuti nella Biblioteca Digitale - scritto in C#! \nEcco la lista dei libri disponibili attualmente:{decoration}";
        };

    }
}

