using System;

using System.Data.OleDb;


namespace integrirane_na_bd_access
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string con = "Privider=Microsoft.ACE.OLEDB.0.12; Data Source:Documents:Лексикон.accdb";
            string queryString ="SELECT Номер в клас, Трите имена FROM schoolmates WHERE град= Пловдив";
            using (OleDbConnection connection = new OleDbConnection(con))
            {
                OleDbCommand oleDbCommand = new OleDbCommand(queryString, connection);
                connection.Open();
                OleDbDataReader reader = oleDbCommand.ExecuteReader();
                while(reader.Read())
                {
                    Console.Write(reader[0].ToString()+ " ");
                    Console.WriteLine(reader[1]+" ", reader[2] + " ", reader[3] + " ", reader[4] + " ");
                }
                reader.Close();
                Console.WriteLine("Done");
            }

        }
    }
}
