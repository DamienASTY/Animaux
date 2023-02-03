using System;
using System.Collections.Generic;
using System.Text;

namespace Animaux.Animaux
{
    abstract class Animal
    {
        protected string _name { get; set; }
        protected string _dateNaissance { get; set; }
        protected int _puce { get; set; }
        protected int _taille { get; set; }
        protected bool _estConcours { get; set; }
        public Animal(string name, string dateNaissance, int puce, int taille, bool estConcours)
        {
            _name = name;
            _dateNaissance = dateNaissance;
            _puce = puce;
            _taille = taille;
            _estConcours = estConcours;
        }
    }
}
