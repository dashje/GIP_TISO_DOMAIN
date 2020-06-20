using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIP_TISO_DOMAIN.Business
{
    static class LijstRepository
    {
        private static List<Lijst> _lijsten = new List<Lijst>();
        public static List<Lijst> Lijsten
        {
            get { return _lijsten; }
            set { _lijsten = value; }
        }
        public static void addLijst(Lijst item)
        {
            _lijsten.Add(item);
        }
        public static Lijst getLastList()
        {
            return _lijsten[_lijsten.Count-1];
        }

        public static Lijst getLijst (string Code)
        {
            foreach (Lijst Lijsten in _lijsten)
            {
                if (Lijsten.Code == Code)
                { return Lijsten; }
            }
            return null;
        }
  
        public static List<Lijst> getLijstFromGebruiker (int Gebruiker)
        {
            List<Lijst> returnLijst = new List<Lijst>();
            foreach (Lijst item in _lijsten)
            {
                if (item.FK_gebruiker == Gebruiker)
                { returnLijst.Add(item); }
            }
            return returnLijst;
        }

    }
}
