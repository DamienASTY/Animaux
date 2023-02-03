﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animaux.Animaux
{
    class Chien: Animal
    {
        private bool _esConcour { get; set; }
        public Chien(string name, string dateNaissance, int puce, int taille, bool estConcours)
            : base (name, dateNaissance, puce, taille, estConcours)
        {

        }

        public string Aboyer()
        {
            return "J'aboie !";
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
            return $"Je suis un Chien : je m'appelle : {_name}, je suis né le {_dateNaissance}, je mesure {_taille} ma puce est {_puce}";
        }
    }
}
