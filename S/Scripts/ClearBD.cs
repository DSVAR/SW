using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Threading;

namespace S.Scripts
{
    class ClearBD
    {
        static public string bd;
        static public void delet()
        {
            Console.Clear();
            Console.WriteLine("Какую базу очистить RU-EN");
            string language = Console.ReadLine();
            if (language == "RU" || language == "ru" || language == "Ru")
            {
                Console.WriteLine("Очищение русской базы");
                bd = "[Proba].[dbo].[try]";
                alice();
            }

            else 
            {
                Console.WriteLine("Очищение английской базы");
                bd = "[Proba].[dbo].[tryEN]";
                alice();
            }
        }


        static public void alice()
        {
            try
            {
                int jk;
                string sql = "DELETE "+bd;

                using (SqlConnection connection = new SqlConnection("Data Source = DVAR; Initial Catalog = Proba; Integrated Security = True;"))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    jk = command.ExecuteNonQuery();
                    connection.Close();
                }

                Console.WriteLine("База очищена");

                Console.WriteLine("\r\n" + "Удаленно " + jk + " слов");
                Thread.Sleep(1000);
                Console.WriteLine("Через 2 секунды вернется главное меню");
                Thread.Sleep(1000);
                Console.WriteLine("1 СЕКУНДА");
                Thread.Sleep(1000);
                Console.WriteLine("ВОЗВРАТ");
                Thread.Sleep(1000);

                MainMenu.maiMenu();
            }
            catch
            {
                Console.WriteLine("Что-то пошло не так");
                MainMenu.maiMenu();
            }
        }

    }
}
