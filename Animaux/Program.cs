using System;
using Animaux.Animaux;

namespace Animaux
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chien et Chats et Lapin");

            Chien chien = new Chien("Arthur", "-11 septembre 2001", 0, 170, true);
            Chat chat = new Chat("Roméo", "12 décembre 2012", 0, 50, true);
            Lapin lapin = new Lapin("Nathan", "13 janvier 1945", 0, 50, true, 1999);

            Console.WriteLine(chien);
            Console.WriteLine(chat);
            Console.WriteLine(lapin);
        }
    }
}
