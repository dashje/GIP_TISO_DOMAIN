using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIP_TISO_DOMAIN.Business
{
    public class Wishlist
    {
        private int _id;
        private int _idGebruiker;
        private int _idCadeau;
        private string _code;

        public int IDGebruiker
        {
            get { return _idGebruiker; }
        }
        public int IDCadeau
        {
            get { return _idCadeau; }
        }
        public int IDWishlist
        {
            get { return _id; }
        }
        public string Code
        {
            get { return _code; }
        }
        public Wishlist(int IDWishlist,int IDGebruiker,int IDCadeau,string Code)
        {
            _id = IDWishlist;
            _idGebruiker = IDGebruiker;
            _idCadeau = IDCadeau;
            _code = Code;
        }
        public Wishlist(int IDGebruiker, int IDCadeau)
        {
            _idGebruiker = IDGebruiker;
            _idCadeau = IDCadeau;
            _code = Code;
        }

    }
}
