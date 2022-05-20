using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mimimimetr
{
    class WorkWithDataBase 
    {
        public List<string[]> GetListOfElementFromDataBase(string query)
        {
            List<string[]> data = new List<string[]>();
            SQLiteConnection myConnection = new SQLiteConnection(@"Data Source=.\..\..\DataBase\PathToImage.db");
            try
            {
                myConnection.Open();
                var read = myConnection.CreateCommand();
                read.CommandText = query;
                using (var reader = read.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        data.Add(new string[3]);

                        data[data.Count - 1][0] = reader[0].ToString();
                        data[data.Count - 1][1] = reader[1].ToString();
                        data[data.Count - 1][2] = reader[2].ToString();
                    }
                    reader.Close();
                }

            }
            catch(SQLiteException e)
            {
                Console.WriteLine("Неверно указан путь до БД: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            myConnection.Close();
            return data;
        }

    }
}

    
