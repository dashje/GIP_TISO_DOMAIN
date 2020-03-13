using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIP_TISO_DOMAIN.Business
{
    public class Gebruiker
    {
        //velden
        private int _id;
        private string _name;
        private string _email;
        private int _age;
        private string _sex;
        private string _password;
        //eigenschappen
        public int ID
        {
            get { return _id; }
        }
        public string Name
        {
            get { return _name; }
        }
        public string Email
        {
            get { return _email; }
        }
        public int Age
        {
            get { return _age; }
        }
        public string Sex
        {
            get { return _sex; }
        }
        public string Password
        {
            get { return _password; }
        }

        public Gebruiker(int ID,string Name,string Email,int Age,string Sex,string Password)
        {
            _id = ID;
            _name = Name;
            _email = Email;
            _age = Age;
            _sex = Sex;
            _password = Password;
        }
        public Gebruiker(string Name, string Email, int Age, string Sex, string Password)
        {
            _id = 0;
            _name = Name;
            _email = Email;
            _age = Age;
            _sex = Sex;
            _password = Password;
        }
    }
}
