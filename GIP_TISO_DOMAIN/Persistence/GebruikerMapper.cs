using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GIP_TISO_DOMAIN.Business;
using MySql.Data.MySqlClient;

namespace GIP_TISO_DOMAIN.Persistence
{
    class GebruikerMapper
    {
        //veld waarmee we de toegang tot de databank definiëren
        private string _connectionString;
        public GebruikerMapper()
        {
            _connectionString =
               "server=localhost;user id=root;password=1234;database=wishlist";
        }
        public GebruikerMapper(string connectionstring)
        {
            _connectionString = connectionstring;
        }
        public List<Gebruiker> getGebruikersFromDB()
        {
            MySqlConnection conn = new MySqlConnection(_connectionString);

            //Het SQL-commando definiëren
            string opdracht = "SELECT * FROM wishlist.gebruiker";
            MySqlCommand cmd = new MySqlCommand(opdracht, conn);

            List<Gebruiker> itemLijst = new List<Gebruiker>();
            conn.Open();
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                Gebruiker item = new Gebruiker(
                Convert.ToInt16(dataReader[0]),
                dataReader[1].ToString(),
                dataReader[2].ToString(),
                Convert.ToInt16(dataReader[3]),
                dataReader[4].ToString(),
                dataReader[5].ToString()
                );
                itemLijst.Add(item);
            }
            conn.Close();
            return itemLijst;
        }

        public void addGebruikersToDB(Gebruiker gebruiker)
        {
            //de connectie met de databank maken

            MySqlConnection conn = new MySqlConnection(_connectionString);

            //Het SQL-commando definiëren

            string opdracht = "INSERT INTO wishlist.gebruiker(Naam, Email, Leeftijd, Geslacht, Passwoord) VALUES(@name, @email, @age, @sex, @passw)";

            MySqlCommand cmd = new MySqlCommand(opdracht, conn);

            //voeg de waarden toe, je haalt ze uit het object eval

            cmd.Parameters.AddWithValue("name", gebruiker.Name);

            cmd.Parameters.AddWithValue("email", gebruiker.Email);

            cmd.Parameters.AddWithValue("age", gebruiker.Age);

            cmd.Parameters.AddWithValue("sex", gebruiker.Sex);

            cmd.Parameters.AddWithValue("passw", gebruiker.Password);

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }
        public void deleteGebruikerInDB(int id)
        {
            MySqlConnection conn = new MySqlConnection(_connectionString);

            //Het SQL-commando definiëren

            string opdracht = ("delete from wishlist.gebruiker where (id=@idparameter)");
            MySqlCommand cmd = new MySqlCommand(opdracht, conn);
            cmd.Parameters.AddWithValue("idparameter", id);

            conn.Open();
            cmd.ExecuteNonQuery();

            conn.Close();
        }
        public void changeGebruikerInDB(Gebruiker gebruiker, int id)
        {
            MySqlConnection conn = new MySqlConnection(_connectionString);

            //Het SQL-commando definiëren

            string opdracht = ("UPDATE wishlist.gebruiker SET Naam = @name, Email = @email, Leeftijd = @age, Geslacht = @sex, Passwoord = @passw WHERE (id = @idparameter);");
            MySqlCommand cmd = new MySqlCommand(opdracht, conn);
            cmd.Parameters.AddWithValue("name", gebruiker.Name);

            cmd.Parameters.AddWithValue("email", gebruiker.Email);

            cmd.Parameters.AddWithValue("age", gebruiker.Age);

            cmd.Parameters.AddWithValue("sex", gebruiker.Sex);

            cmd.Parameters.AddWithValue("passw", gebruiker.Password);

            conn.Open();
            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}
