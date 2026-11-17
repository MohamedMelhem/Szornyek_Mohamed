using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace Szornyek_Mohamed
{

    internal class SzornyAdatbazis
    {
        private readonly string connectionString = "Server=localhost;Database=szornyek;User Id=root;Password=;";

        public List<Szorny> AdatokBetoltese()
        {
            var szornyek = new List<Szorny>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "select * from szornyek";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            Szorny szorny = new Szorny(

                                    reader.GetInt32("Id"),
                                    reader.GetString("Nev"),
                                    reader.GetInt32("VeszelyessegSzint"),
                                    reader.GetString("Elohely"),
                                    reader.GetString("FoGyengeseg"),
                                    reader.GetString("LeggyakoribbZsakmany"),
                                    reader.GetBoolean("VeszelyesE")


                                );

                            szornyek.Add(szorny);
                        }
                    }
                }
            }

            return szornyek;
        }
    }
}
