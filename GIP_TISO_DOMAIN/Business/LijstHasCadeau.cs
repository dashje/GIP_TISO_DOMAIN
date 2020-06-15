using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GIP_TISO_DOMAIN.Business
{
    public class LijstHasCadeau
    {
        private int _fk_lijst;
        private int _fk_cadeau;
        private string _gekochtjaofnee;

        public int FK_Lijst
        {
            get { return _fk_lijst; }
        }
        public int FK_Cadeau
        {
            get { return _fk_cadeau; }
        }
        public string GekochtJaOfNee
        {
            get { return _gekochtjaofnee; }
        }

        public LijstHasCadeau(int Fk_lijst,int FK_Cadeau,string GekochtJaOfNee)
        {
            _fk_lijst = Fk_lijst;
            _fk_cadeau = FK_Cadeau;
            _gekochtjaofnee = GekochtJaOfNee;
        }
        public LijstHasCadeau(string GekochtJaOfNee)
        {
            _gekochtjaofnee = GekochtJaOfNee;
        }
    }
}
