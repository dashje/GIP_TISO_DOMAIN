using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GIP_TISO_DOMAIN.Persistence;

namespace GIP_TISO_DOMAIN.Business
{
    public class Controller
    {
        private Persistence.Controller _persistController;

        public Controller()
        {
            _persistController = new Persistence.Controller();
            CadeauRepository.Cadeaus = _persistController.getCadeausFromDB();
            GebruikerRepository.Gebruikers = _persistController.getGebruikersFromDB();
            WishlistRepository.Wishlists = _persistController.getWishlistsFromDB();
        }
        public List<Cadeau> getCadeausFromDB()
        {
            return CadeauRepository.Cadeaus;
        }

        public void addCadeausToDB(Cadeau item)
        {
            _persistController.addCadeausToDB(item);
            CadeauRepository.addCadeaus(item);
        }
        public List<Gebruiker> getGebruikersFromDB()
        {
            return GebruikerRepository.Gebruikers;
        }
        public void addGebruikersToDB(Gebruiker item)
        {
            _persistController.addGebruikerToDB(item);
            GebruikerRepository.addGebruikers(item);
        }
        public List<Wishlist> getWishlistsFromDB()
        {
            return WishlistRepository.Wishlists;
        }
        public void addWishlistsToDB(Wishlist item)
        {
            _persistController.addWishlistsToDB(item);
            WishlistRepository.addWishlists(item);
        }
        public Gebruiker getLogin (string Name,string Password)
        {
            return GebruikerRepository.getLogin(Name, Password);
        }
        public void deleteCadeauToDB(int ID)
        {
            _persistController.removeCadeau(ID);
            CadeauRepository.Cadeaus = _persistController.getCadeausFromDB();
        }
    }
}
