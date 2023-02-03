using System;
using System.Collections.Generic;
using System.Text;

namespace Animaux.Animaux
{
    class Chat: Animal
    {
        public Chat(string name, string dateNaissance, int puce, int taille, bool estConcours)
            : base(name, dateNaissance, puce, taille, estConcours)
        {

        }

        public string Miauler()
        {
            return "Meooow";
        }

        public string Dormir()
        {
            return "AMIMIR !";
        }

        public string Manger()
        {
            return "HMMM miam des croquettes";
        }

        public override string ToString()
        {
            return $"Je suis un Chat : je m'appelle : {_name}, je suis né le {_dateNaissance}, je mesure {_taille} ma puce est {_puce}";
        }
    }
}
