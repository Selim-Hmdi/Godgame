﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GodGame
{
    public class Dauphin : EtreVivantReproduction
    {
        public Dauphin(string p_nom, byte p_nombreParents, String p_sexe) :
            base(p_nom, p_nombreParents, Regne.Animal, GenreVivant.EucaryotesMulticellulaires, p_sexe)
        {
        }

        public override void Deplace()
        {
            Console.WriteLine($"{m_nom} nage");
        }

        public EtreVivant Reproduction(EtreVivant p_etreVivant)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{m_nom} est un dauphin de sexe {m_sexe} ayant {m_nombreParents} parent(s) de regne Animal et est un eucaryote multicellulaires";
        }

    }
}
