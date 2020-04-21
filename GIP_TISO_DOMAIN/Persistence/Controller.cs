using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GIP_TISO_DOMAIN.Business;
using MySql.Data.MySqlClient;

namespace GIP_TISO_DOMAIN.Persistence
{
    class Controller
    {
        private string _connectionstring;
        public Controller()
        { _connectionstring = "server = localhost; user id = root;password=1234; database=gip_de_Decker_pieter-jan"; }
        public Controller(string connectionstring)
        { _connectionstring = connectionstring; }

        public List<Cadeau> getCadeausFromDB()
        {
            CadeauMapper mapper = new CadeauMapper(_connectionstring);
            return mapper.getCadeausFromDB();
        }

        public void addCadeausToDB(Cadeau item)
        {
            CadeauMapper mapper = new CadeauMapper(_connectionstring);
            mapper.addCadeausToDB(item);
        }
        public List<Gebruiker> getGebruikersFromDB()
        {
            GebruikerMapper mapper = new GebruikerMapper(_connectionstring);
            return mapper.getGebruikersFromDB();
        }
        public void addGebruikerToDB(Gebruiker item)
        {
            GebruikerMapper mapper = new GebruikerMapper(_connectionstring);
            mapper.addGebruikersToDB(item);
        }
        public List<Wishlist> getWishlistsFromDB()
        {
            WishlistMapper mapper = new WishlistMapper(_connectionstring);
            return mapper.getWishlistsFromDB();
        }
        public void addWishlistsToDB(Wishlist item)
        {
            WishlistMapper mapper = new WishlistMapper(_connectionstring);
            mapper.addWishlistToDB(item);
        }
        public void deleteWishlistsFromDB(int IDWishlist)
        {
            WishlistMapper mapper = new WishlistMapper(_connectionstring);
            mapper.deleteWishlistInDB(IDWishlist);
        }
        public void changeWishlistFromDB(Wishlist item,int IDCadeau)
        {
            WishlistMapper mapper = new WishlistMapper(_connectionstring);
            mapper.changeWishlistInDB(item,IDCadeau);
        }
        public void removeCadeau(int id)
        {
            CadeauMapper mapper = new CadeauMapper(_connectionstring);
            mapper.deleteCadeauInDB(id);

        }
    }
}
