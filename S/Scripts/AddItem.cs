using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Sql;
using System.IO;
using System.Linq;
using System.Data.SqlClient;
using System.Threading;

namespace S.Scripts
{
    class AddItem
    {
        static public string path, FileName, word;
        static public List<string> arbah = new List<string>();
      
        static  public void add()
        {
            Console.Clear();
            Console.WriteLine("Добавление слов");
            using (SqlConnection connection = new SqlConnection("Data Source=DVAR; Initial Catalog=Proba; Integrated Security=True; "))
            {
                connection.Open();
                connection.Close();
            }
            Console.Write("Ведите путь к папке с файлом новых слов:");
            path= Console.ReadLine();

            Console.Write("Полное имя файла:");
            FileName = Console.ReadLine();
            path+=@"\";
           
                using (StreamReader SR = new StreamReader(path + FileName))
                {
                    word = SR.ReadToEnd();


                }
                arbah.AddRange(word.Split("\n"));

            try 
            {
               
               for (int i = 0; i < arbah.Count; i++)
               {
                    string sql = "INSERT try VALUES('" +arbah[i]+ "')";

                        using (SqlConnection connection = new SqlConnection("Data Source=DVAR; Initial Catalog=Proba; Integrated Security=True"))
                        {
                            connection.Open();
                                SqlCommand command = new SqlCommand(sql, connection);
                                command.ExecuteNonQuery();
                            connection.Close();
                        }
               }
                Console.WriteLine("\r\n" + "Все загружено");
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
                Console.WriteLine("что-то пошло не так");
            }

        }


    }
}
