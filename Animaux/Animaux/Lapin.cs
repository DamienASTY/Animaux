using System;
using System.Collections.Generic;
using System.Text;

namespace Animaux.Animaux
{
    class Lapin: Animal
    {
        private int _oreilles { get; set; }
        public Lapin(string name, string dateNaissance, int puce, int taille, bool estConcours, int oreilles)
            : base(name, dateNaissance, puce, taille, estConcours)
        {
            _oreilles = oreilles;
        }

        public string Bondir()
        {
            return "Je bondit";
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
            return $"Je suis un Lapin : je m'appelle : {_name}, je suis né le {_dateNaissance}, je mesure {_taille} ma puce est {_puce} et mes oreilles font {_oreilles} centimètres";
        }
    }
}
