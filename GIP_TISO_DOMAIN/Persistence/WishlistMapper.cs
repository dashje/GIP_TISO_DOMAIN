using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GIP_TISO_DOMAIN.Business;
using MySql.Data.MySqlClient;

namespace GIP_TISO_DOMAIN.Persistence
{
    class WishlistMapper
    {
        //veld waarmee we de toegang tot de databank definiëren
        private string _connectionString;
        public WishlistMapper()
        {
            _connectionString =
               "server=localhost;user id=root;password=1234;database=gipsql";
        }
        public WishlistMapper(string connectionstring)
        {
            _connectionString = connectionstring;
        }
        public List<Wishlist> getWishlistsFromDB()
        {
            MySqlConnection conn = new MySqlConnection(_connectionString);

            //Het SQL-commando definiëren
            string opdracht = "SELECT * FROM gipsql.wishlist";
            MySqlCommand cmd = new MySqlCommand(opdracht, conn);

            List<Wishlist> itemLijst = new List<Wishlist>();
            conn.Open();
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                Wishlist item = new Wishlist(
                Convert.ToInt16(dataReader[2]),
                Convert.ToInt16(dataReader[3])
                );
                itemLijst.Add(item);
            }
            conn.Close();
            return itemLijst;
        }

        public void addWishlistToDB(Wishlist wishlist)
        {
            //de connectie met de databank maken

            MySqlConnection conn = new MySqlConnection(_connectionString);

            //Het SQL-commando definiëren

            string opdracht = "INSERT INTO gipsql.wishlist(Code, FK_idGebruiker, FK_idCadeau) VALUES(@code, @fkidG, @fkidC)";

            MySqlCommand cmd = new MySqlCommand(opdracht, conn);

            //voeg de waarden toe, je haalt ze uit het object eval

            cmd.Parameters.AddWithValue("code", wishlist.Code);

            cmd.Parameters.AddWithValue("fkidG", wishlist.IDGebruiker);

            cmd.Parameters.AddWithValue("fkidC", wishlist.IDCadeau);

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }
        public void deleteWishlistInDB(int IDWishlist)
        {
            MySqlConnection conn = new MySqlConnection(_connectionString);

            //Het SQL-commando definiëren

            string opdracht = ("delete from gipsql.wishlist where (id=@idparameter)");
            MySqlCommand cmd = new MySqlCommand(opdracht, conn);
            cmd.Parameters.AddWithValue("idparameter", IDWishlist);

            conn.Open();
            cmd.ExecuteNonQuery();

            conn.Close();
        }
        public void changeWishlistInDB(Wishlist wishlist, int IDWishlist)
        {
            MySqlConnection conn = new MySqlConnection(_connectionString);

            //Het SQL-commando definiëren

            string opdracht = ("UPDATE gipsql.wishlist SET Code = @code, IDGebruiker = @fkidG, IDCadeau = @fkidC WHERE (IDWishlist = @idparameter);");
            MySqlCommand cmd = new MySqlCommand(opdracht, conn);
            cmd.Parameters.AddWithValue("code", wishlist.Code);

            cmd.Parameters.AddWithValue("fkidG", wishlist.IDGebruiker);

            cmd.Parameters.AddWithValue("fkidC", wishlist.IDWishlist);

            conn.Open();
            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}

