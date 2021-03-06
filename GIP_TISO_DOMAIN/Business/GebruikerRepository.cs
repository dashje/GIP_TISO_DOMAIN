﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIP_TISO_DOMAIN.Business
{
    static class GebruikerRepository
    {
        private static List<Gebruiker> _gebruikers = new List<Gebruiker>();
        public static List<Gebruiker> Gebruikers
        {
            get { return _gebruikers; }
            set { _gebruikers = value; }
        }
        public static void addGebruikers(Gebruiker item)
        {
            _gebruikers.Add(item);
        }

        public static Gebruiker getLogin (string Name,string Password)
        {
            foreach (Gebruiker gebruiker in _gebruikers)
            {
                if (gebruiker.Name == Name && gebruiker.Password == Password)
                { return gebruiker; }
            }
            return null;
        }
    }
}
