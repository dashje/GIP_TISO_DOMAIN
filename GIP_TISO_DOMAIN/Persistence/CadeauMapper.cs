using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GIP_TISO_DOMAIN.Business;
using MySql.Data.MySqlClient;

namespace GIP_TISO_DOMAIN.Persistence
{
    class CadeauMapper
    {
        //veld waarmee we de toegang tot de databank definiëren
        private string _connectionString;
        public CadeauMapper()
        {
            _connectionString =
               "server=localhost;user id=root;password=1234;database=wishlist";
        }
        public CadeauMapper(string connectionstring)
        {
            _connectionString = connectionstring;
        }
        public List<Cadeau> getCadeausFromDB()
        {
            MySqlConnection conn = new MySqlConnection(_connectionString);

            //Het SQL-commando definiëren
            string opdracht = "SELECT * FROM wishlist.cadeau";
            MySqlCommand cmd = new MySqlCommand(opdracht, conn);

            List<Cadeau> itemLijst = new List<Cadeau>();
            conn.Open();
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                Cadeau item = new Cadeau(
                Convert.ToInt16(dataReader[0]),
                dataReader[1].ToString(),
                dataReader[2].ToString(),
                dataReader[3].ToString()
                );
                itemLijst.Add(item);
            }
            conn.Close();
            return itemLijst;
        }
    

        public void addCadeausToDB(Cadeau cadeau)
        {
            //de connectie met de databank maken

            MySqlConnection conn = new MySqlConnection(_connectionString);

            //Het SQL-commando definiëren

            string opdracht = "INSERT INTO wishlist.cadeau(Naam, Omschrijving, Website) VALUES(@name, @omsc, @web)";

            MySqlCommand cmd = new MySqlCommand(opdracht, conn);

            //voeg de waarden toe, je haalt ze uit het object eval

            cmd.Parameters.AddWithValue("name", cadeau.Name);

            cmd.Parameters.AddWithValue("omsc", cadeau.Description);

            cmd.Parameters.AddWithValue("web", cadeau.Website);

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }
        public void deleteCadeauInDB(int id)
        {
            MySqlConnection conn = new MySqlConnection(_connectionString);

            //Het SQL-commando definiëren
            string opdracht = "delete from wishlist.cadeau where (id=@idparameter)";

            MySqlCommand cmd = new MySqlCommand(opdracht, conn);
            //voeg de waarden toe, je haalt ze uit het object eval
            cmd.Parameters.AddWithValue("idparameter", id);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        
    }
        public void changeCadeauInDB(Cadeau cadeau, int id)
        {
            MySqlConnection conn = new MySqlConnection(_connectionString);

            //Het SQL-commando definiëren

            string opdracht = ("UPDATE wishlist.cadeau SET Naam = @name, Omschrijving = @omsc, Website = @web, GekochtJaOfNee= @geko WHERE (id = @idparameter);");
            MySqlCommand cmd = new MySqlCommand(opdracht, conn);
            cmd.Parameters.AddWithValue("name", cadeau.Name);

            cmd.Parameters.AddWithValue("omsc", cadeau.Description);

            cmd.Parameters.AddWithValue("web", cadeau.Website);

            cmd.Parameters.AddWithValue("idparameter", id);

            conn.Open();
            cmd.ExecuteNonQuery();

            conn.Close();
        }
        public List<Cadeau> getLHCFromGebruiker(int indexGebruiker)
        {
            MySqlConnection conn = new MySqlConnection(_connectionString);

            //Het SQL-commando definiëren
            string opdracht = " SELECT cadeau.* FROM wishlist.cadeau inner join lijst_has_cadeau on FK_cadeau = id_Cadeau where FK_Lijst = @indxL;";
            MySqlCommand cmd = new MySqlCommand(opdracht, conn);
            cmd.Parameters.AddWithValue("indxL", indexGebruiker);

            List<Cadeau> itemLijst = new List<Cadeau>();
            conn.Open();
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                Cadeau item = new Cadeau(
                Convert.ToInt16(dataReader[0]),
                dataReader[1].ToString(),
                dataReader[2].ToString(),
                dataReader[3].ToString()

                );
                itemLijst.Add(item);
            }
            conn.Close();
            return itemLijst;
        }
    }
}
