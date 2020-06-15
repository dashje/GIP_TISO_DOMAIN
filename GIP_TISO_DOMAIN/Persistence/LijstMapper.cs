using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using GIP_TISO_DOMAIN.Business;

namespace GIP_TISO_DOMAIN.Persistence
{
    class LijstMapper
    {
        //veld waarmee we de toegang tot de databank definiëren
        private string _connectionString;
        public LijstMapper()
        {
            _connectionString =
               "server=localhost;user id=root;password=1234;database=wishlist";
        }
        public LijstMapper(string connectionstring)
        {
            _connectionString = connectionstring;
        }
        public List<Lijst> getListsFromDB()
        {
            MySqlConnection conn = new MySqlConnection(_connectionString);

            //Het SQL-commando definiëren
            string opdracht = "SELECT * FROM wishlist.lijst";
            MySqlCommand cmd = new MySqlCommand(opdracht, conn);

            List<Lijst> itemLijst = new List<Lijst>();
            conn.Open();
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                Lijst item = new Lijst(
                Convert.ToInt16(dataReader[0]),
                dataReader[1].ToString(),
                dataReader[2].ToString(),
                dataReader[3].ToString(),
                Convert.ToInt16(dataReader[4])
                );
                itemLijst.Add(item);
            }
            conn.Close();
            return itemLijst;
        }


        public void addLijstToDB(Lijst lijst)
        {
            //de connectie met de databank maken

            MySqlConnection conn = new MySqlConnection(_connectionString);

            //Het SQL-commando definiëren

            string opdracht = "INSERT INTO wishlist.lijst(Naam, Code, Zichtbaar, FK_Gebruiker) VALUES(@name, @code, @zichtb, @fkg)";

            MySqlCommand cmd = new MySqlCommand(opdracht, conn);

            //voeg de waarden toe, je haalt ze uit het object eval

            cmd.Parameters.AddWithValue("name", lijst.Name);

            cmd.Parameters.AddWithValue("code", lijst.Code);

            cmd.Parameters.AddWithValue("zichtb", lijst.Zichtbaar);

            cmd.Parameters.AddWithValue("fkg", lijst.FK_gebruiker);

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }
        public List<Lijst>getLijstFromDB(int indexGebruiker)
        {
            //de connectie met de databank maken

            MySqlConnection conn = new MySqlConnection(_connectionString);

            //Het SQL-commando definiëren

            string opdracht = "SELECT * FROM wishlist.lijst where fk_gebruiker = @indxG;";
            MySqlCommand cmd = new MySqlCommand(opdracht, conn);
            cmd.Parameters.AddWithValue("indxG", indexGebruiker);
            List<Lijst> itemLijst = new List<Lijst>();
            conn.Open();
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                Lijst item = new Lijst(
                Convert.ToInt16(dataReader[0]),
                dataReader[1].ToString(),
                dataReader[2].ToString(),
                dataReader[3].ToString(),
                Convert.ToInt16(dataReader[4])

                );
                itemLijst.Add(item);
            }
            conn.Close();
            return itemLijst;
        }
        public List<LijstHasCadeau> getLHCFromID(int FK_Lijst)
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


    }
}
