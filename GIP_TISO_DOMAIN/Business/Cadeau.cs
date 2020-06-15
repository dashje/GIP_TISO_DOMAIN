using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIP_TISO_DOMAIN.Business
{
    public class Cadeau
    {
        //velden
        private int _id;
        private string _name;
        private string _description;
        private string _website;
        //eigenschappen
        public int ID
        {
            get { return _id; }
        }
        public string Name
        {
            get { return _name; }
        }
        public string Description
        {
            get { return _description; }
        }
        public string Website
        {
            get { return _website; }
        }

        public Cadeau(int ID,string Name,string Description,string Website)
        {
            _id = ID;
            _name = Name;
            _description = Description;
            _website = Website;
        }
        public Cadeau(string Name,string Description,string Website)
        {
            _id = 0;
            _name = Name;
            _description = Description;
            _website = Website;
        }

        public override string ToString()
        {
            return _name.ToString() + " , " + _description.ToString() + " : " + _website.ToString();
        }

    }
}
