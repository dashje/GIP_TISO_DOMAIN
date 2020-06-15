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
        private Gebruiker _activeGebruiker;
        private Lijst _activeLijst;
        private Lijst _chosenLijst;
        private Lijst _currentLijst;
        private Lijst _currentLijstID;
        private Random rnd = new Random();

        public Controller()
        {
            _persistController = new Persistence.Controller();
            CadeauRepository.Cadeaus = _persistController.getCadeausFromDB();
            GebruikerRepository.Gebruikers = _persistController.getGebruikersFromDB();
            LijstRepository.Lijsten = _persistController.getWishlistsFromDB();
            _activeGebruiker = null;
            _activeLijst = null;
            _currentLijst = null;
            _currentLijstID = null;
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
        public void addWishlistsToDB(Lijst item)
        {
            _persistController.addWishlistsToDB(item);
            LijstRepository.addLijst(item);
        }
        public Gebruiker getLogin (string Name,string Password)
        {
            _activeGebruiker= GebruikerRepository.getLogin(Name, Password);
            return _activeGebruiker;
        }
        public Lijst CreateList (string Naam)
        {
            _activeLijst = new Lijst(Naam, GetCode().ToString(), "Ja", _activeGebruiker.ID);
            _persistController.addWishlistsToDB(_activeLijst);
            LijstRepository.Lijsten = _persistController.getWishlistsFromDB();
            _activeLijst = LijstRepository.getLastList();
            return _activeLijst;
        }
        public Cadeau addCadeauToList(int IndexCadeau)
        {
            Cadeau cadeau = CadeauRepository.Cadeaus[IndexCadeau];
            LijstHasCadeau item = new LijstHasCadeau(_activeLijst.ID, IndexCadeau, "Nee");
            LHCRepository.addLHCToRepo(item);
            _persistController.addLHCToDB(item);

            return cadeau;
        }
        public void removeCadeauFromList(int IndexCadeau)
        {
            LijstHasCadeau item = _persistController.getLHCFromWishlist(_activeLijst.ID)[IndexCadeau];
            LHCRepository.removeLHCFromRepo(item);
            _persistController.removeLHCFromWishlist(item);
        }
        public List<Cadeau> getCadeausFromCode(int indexLijst)
        {
           return _persistController.getLHCFromCode(indexLijst);
            
            
        }
        public List<Lijst> getCadeausFromGebruiker()
        {
            return _persistController.getLHCFromGebruiker(_activeGebruiker.ID);
        }
        public List<LijstHasCadeau> getCadeausFromID()
        {
            return _persistController.getLHCFromID(_currentLijstID.ID);
        }

        public int GetCode()
        {
            int number;
            bool gevonden = false;
            do
            {
                number = rnd.Next(1, 10000);
                foreach (Lijst item in LijstRepository.Lijsten)
                {
                    if (item.Code == number.ToString())
                    { gevonden = true; }
                }
            } while (gevonden);
            return number;
        }
        
        public Lijst getLijst (string Code)
        {
            return LijstRepository.getLijst(Code);
        }
        public Lijst getLijstFromID (int ID)
        {
            return LijstRepository.getLijstFromID(ID);
        }
        public void setCurrentLijstID(Lijst ID)
        {
            _currentLijstID=ID;
        }
        public Lijst getCurrentLijstID()
        {
            return _currentLijstID;
        }
        public List<Lijst> getLijstFromGebruiker (int Gebruiker)
        {
            return LijstRepository.getLijstFromGebruiker(_activeGebruiker.ID);
        }
        public void removeCadeauFromWishlist(int index)
        {
            //Het element op plaats index in de lijst van cadeaus in de actieve wishlist moet weg
            LijstHasCadeau lhc = LHCRepository.getCadeausFromList(_activeLijst.ID)[index];
            _persistController.removeLHCFromWishlist(lhc);
            LHCRepository.removeLHCFromRepo(lhc);
        }
        public void setActiveGebruiker(Gebruiker item)
        {
            _activeGebruiker = item;
        }
        public Gebruiker getActiveGebruiker()
        {
            return _activeGebruiker;
        }
        public void setCurrentLijst(Lijst item)
        {
            _currentLijst =item;
        }
        public Lijst getCurrentLijst()
        {
            return _currentLijst;
        }

    }
}
