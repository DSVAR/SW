using S.Scripts;
using System;
using System.Collections.Generic;
using System.Text;


namespace S
{
    class MainMenu
    {
       
        static public int Answer;


        static public void maiMenu()
        {
            Console.Clear();

            Console.WriteLine("Тестовое задание" + "\r\n");

            Console.WriteLine("1. Задание");
            Console.WriteLine("2. Добавить слова ");
            Console.WriteLine("3. Очистить базу" + "\r\n");
        Begin:
            Console.Write("Ведите число:");
            try
            {
                Answer = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Строка имела не правильный вод");
                goto Begin;
            }

            if (Answer > 3 || Answer < 1)
            {
                Console.WriteLine("Нету таких пунктов");
                goto Begin;
            }


            switch (Answer)
            {

                case 1:
                    {
                        task.words();
                        break;
                    }

                case 2:
                    {
                        AddItem.add();
                        break;
                    }

                case 3:
                    {
                        ClearBD.delet();
                        break;
                    }

        

            }

        }
    }
}
