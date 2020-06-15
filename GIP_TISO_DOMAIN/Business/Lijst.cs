using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIP_TISO_DOMAIN.Business
{
    public class Lijst
    {
        private int _id;
        private string _name;
        private string _code;
        private string _zichtbaar;
        private int _fk_gebruiker;

        public int ID
        {
            get { return _id; }
        }
        public string Name
        {
            get { return _name; }
        }
        public string Code
        {
            get { return _code; }
        }
        public string Zichtbaar
        {
            get { return _zichtbaar; }
        }
        public int FK_gebruiker
        {
            get { return _fk_gebruiker; }
        }
        public Lijst(int ID,string Name,string Code,string Zichtbaar,int FK_gebruiker)
        {
            _id = ID;
            _name = Name;
            _code = Code;
            _zichtbaar = Zichtbaar;
            _fk_gebruiker = FK_gebruiker;
        }
        public Lijst(string Name,string Code,string Zichtbaar,int FK_gebruiker)
        {
            _id = 0;
            _name = Name;
            _code = Code;
            _zichtbaar = Zichtbaar;
            _fk_gebruiker = FK_gebruiker;
        }
        public override string ToString()
        {
            return _name.ToString();
        }

    }
}
