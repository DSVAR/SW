using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Sql;
using System.Text.RegularExpressions;

namespace S.Scripts
{
    class task
    {
        static public string dictionary,language;
        static public void words()
        {
            Console.WriteLine("Тестовое задание \r\n");

            Console.Write("Введите слова от 3-х до 15 символов:");
            dictionary = Console.ReadLine();

            Console.WriteLine();
            if (Regex.IsMatch(dictionary, "^[А-Яа-я]+$"))
            {
                language = "RU";
            }
            else
            {
                language = "EN";
            }


                if (language == "RU")
                {

                }
                else
                {

                }
        }



    }
}
