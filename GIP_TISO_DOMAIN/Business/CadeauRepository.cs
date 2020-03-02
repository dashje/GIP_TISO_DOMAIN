using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIP_TISO_DOMAIN.Business
{
    class CadeauRepository
    {
        private static List<Cadeau> _cadeaus = new List<Cadeau>();
        public static List<Cadeau> Cadeaus
        {
            get { return _cadeaus; }
            set { _cadeaus = value; }
        }
        public static void addCadeaus(Cadeau item)
        {
            _cadeaus.Add(item);
        }
    }
}
