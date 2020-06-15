using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIP_TISO_DOMAIN.Business
{
    static class LHCRepository
    {
        private static List<LijstHasCadeau> _lhcList = new List<LijstHasCadeau>();

        public static List<LijstHasCadeau> LHCList
        {
            get { return _lhcList; }
            set { _lhcList = value; }
        }
        public static void removeLHCFromRepo(LijstHasCadeau lhc)
        {
            _lhcList.Remove(lhc);
        }

        public static void addLHCToRepo(LijstHasCadeau lhc)
        {
            _lhcList.Add(lhc);
        }
        public static List<LijstHasCadeau> getCadeausFromList(int FK_Lijst)
        {
            List<LijstHasCadeau> returnLijst = new List<LijstHasCadeau>();
            foreach(LijstHasCadeau item in _lhcList)
            {
                if (FK_Lijst == item.FK_Lijst)
                {
                    returnLijst.Add(item);
                }
            }
            return returnLijst;        
        }
    }
}
