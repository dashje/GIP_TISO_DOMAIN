using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using GIP_TISO_DOMAIN.Business;

namespace GIP_TISO_DOMAIN.Persistence
{
    class LHCMapper
    {
         //veld waarmee we de toegang tot de databank definiëren
        private string _connectionString;
        public LHCMapper()
        {
            _connectionString =
               "server=localhost;user id=root;password=1234;database=wishlist";
        }
        public LHCMapper(string connectionstring)
        {
            _connectionString = connectionstring;
        }
        public List<LijstHasCadeau> getLHCFromDB()
        {
            MySqlConnection conn = new MySqlConnection(_connectionString);

            //Het SQL-commando definiëren
            string opdracht = "SELECT * FROM wishlist.lijst_has_cadeau";
            MySqlCommand cmd = new MySqlCommand(opdracht, conn);

            List<LijstHasCadeau> itemLijst = new List<LijstHasCadeau>();
            conn.Open();
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                LijstHasCadeau item = new LijstHasCadeau(
                Convert.ToInt16(dataReader[0]),
                Convert.ToInt16(dataReader[1]),
                dataReader[2].ToString()

                );
                itemLijst.Add(item);
            }
            conn.Close();
            return itemLijst;
        }
        public void AddLHCToDB(LijstHasCadeau lhc)
        {
            //de connectie met de databank maken

            MySqlConnection conn = new MySqlConnection(_connectionString);

            //Het SQL-commando definiëren

            string opdracht = "INSERT INTO wishlist.lijst_has_cadeau(FK_Lijst, FK_Cadeau, GekochtJaOfNee) VALUES(@fkl, @fkc, @status)";

            MySqlCommand cmd = new MySqlCommand(opdracht, conn);

            //voeg de waarden toe, je haalt ze uit het object eval

            cmd.Parameters.AddWithValue("fkl", lhc.FK_Lijst);

            cmd.Parameters.AddWithValue("fkc", lhc.FK_Cadeau);

            cmd.Parameters.AddWithValue("status", lhc.GekochtJaOfNee);


            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }
        public void deleteLHCFromDB(LijstHasCadeau item)
        {
            MySqlConnection conn = new MySqlConnection(_connectionString);

            //Het SQL-commando definiëren

            string opdracht = ("delete from wishlist.lijst_has_cadeau where FK_Lijst=@fk_naarLijst and FK_Cadeau=@fk_naarCadeau");
            MySqlCommand cmd = new MySqlCommand(opdracht, conn);
            cmd.Parameters.AddWithValue("fk_naarCadeau", item.FK_Cadeau);
            cmd.Parameters.AddWithValue("fk_naarLijst", item.FK_Lijst);

            conn.Open();
            cmd.ExecuteNonQuery();

            conn.Close();
        }
        public List<LijstHasCadeau> getLHCFromWishlist(int FK_Lijst)
        {
            MySqlConnection conn = new MySqlConnection(_connectionString);

            //Het SQL-commando definiëren
            string opdracht = "SELECT * FROM wishlist.lijst_has_cadeau where FK_Lijst = @FK";
            MySqlCommand cmd = new MySqlCommand(opdracht, conn);
            cmd.Parameters.AddWithValue("FK", FK_Lijst);

            List<LijstHasCadeau> itemLijst = new List<LijstHasCadeau>();
            conn.Open();
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                LijstHasCadeau item = new LijstHasCadeau(
                Convert.ToInt16(dataReader[0]),
                Convert.ToInt16(dataReader[1]),
                dataReader[2].ToString()

                );
                itemLijst.Add(item);
            }
            conn.Close();
            return itemLijst;
        }
        public List<Cadeau> getLHCFromCode(int indexLijst)
        {
            MySqlConnection conn = new MySqlConnection(_connectionString);

            //Het SQL-commando definiëren
            string opdracht = " SELECT cadeau.*,GekochtJaOfNee FROM wishlist.cadeau inner join lijst_has_cadeau on id_Cadeau = FK_Cadeau where FK_Lijst = @indxL;";
            MySqlCommand cmd = new MySqlCommand(opdracht, conn);
            cmd.Parameters.AddWithValue("indxL", indexLijst);

            List<Cadeau> itemLijst = new List<Cadeau>();
            conn.Open();
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                Cadeau item = new Cadeau(
                Convert.ToInt16(dataReader[0]),
                dataReader[1].ToString(),
                dataReader[2].ToString(),
                dataReader[3].ToString(),
                dataReader[4].ToString()

                );
                itemLijst.Add(item);
            }
            conn.Close();
            return itemLijst;
        }
        public void changeConvert(int id, string status)
        {
            MySqlConnection connection = new MySqlConnection(_connectionString);
            MySqlCommand command = new MySqlCommand("UPDATE wishlist.Lijst_Has_Cadeau SET GekochtJaOfNee = @status WHERE (FK_Lijst = @id);", connection);
            command.Parameters.AddWithValue("id", id);
            command.Parameters.AddWithValue("status", status);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
    
}
