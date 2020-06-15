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
        { _connectionstring = "server = localhost; user id = root;password=1234; database=wishlist"; }
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
        public List<Lijst> getWishlistsFromDB()
        {
            LijstMapper mapper = new LijstMapper(_connectionstring);
            return mapper.getListsFromDB();
        }
        public void addWishlistsToDB(Lijst item)
        {
            LijstMapper mapper = new LijstMapper(_connectionstring);
            mapper.addLijstToDB(item);
        }
        public void removeCadeau(int id)
        {
            CadeauMapper mapper = new CadeauMapper(_connectionstring);
            mapper.deleteCadeauInDB(id);

        }
        public List<LijstHasCadeau> getLHCFromWishlist(int FK_Lijst)
        {
            LHCMapper mapper = new LHCMapper(_connectionstring);
            return mapper.getLHCFromWishlist(FK_Lijst);
        }
        public List<Cadeau> getLHCFromCode(int indexLijst)
        {
            LHCMapper mapper = new LHCMapper(_connectionstring);
            return mapper.getLHCFromCode(indexLijst);
        }
        public List<Lijst> getLHCFromGebruiker(int indexGebruiker)
        {
            LijstMapper mapper = new LijstMapper(_connectionstring);
            return mapper.getLijstFromDB(indexGebruiker);
        }
        public List<LijstHasCadeau> getLHCFromID(int indexID)
        {
            LijstMapper mapper = new LijstMapper(_connectionstring);
            return mapper.getLHCFromID(indexID);
        }
        public void removeLHCFromWishlist(LijstHasCadeau item)
        {
            LHCMapper mapper = new LHCMapper(_connectionstring);
            mapper.deleteLHCFromDB(item);
        }
        public void addLHCToDB(LijstHasCadeau lhc)
        {
            LHCMapper mapper = new LHCMapper(_connectionstring);
            mapper.AddLHCToDB(lhc);
        }
       
    }
}
