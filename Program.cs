using System;


namespace akomarec_L1MD5_29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nomer; // Номер в алфавите
            int d; // Смещение
            string s; //Результат
            int j, f; // Переменная для циклов
            int t = 0; // Преременная для нумерации символов ключа.
            

            Console.WriteLine("Введите СТРОЧНЫМИ СИМВОЛАМИ текст для шифрования:");
            string text = Console.ReadLine();
            char [] massage = text.ToCharArray(); // создаем массив символов сообщения
            Console.WriteLine("Введите СТРОЧНЫМИ СИМВОЛАМИ ключ из не менее чем 5 символов:");
            string k = Console.ReadLine();
            var n = k.Length;
            while (n < 5)
            {
                Console.WriteLine("Введите СТРОЧНЫМИ СИМВОЛАМИ ключ из не менее чем 5 символов:");
                string k1 = Console.ReadLine();
                n = k1.Length;
                k = k1;
            }
            char [] key = k.ToCharArray(); // создаём массив символов ключа
            char[] alfavit = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' }; // создаём массив символов алфавита

            
            for (int i = 0; i < massage.Length; i++) // Перебираем каждый символ сообщения
            {
                // Ищем индекс буквы
                for (j = 0; j < alfavit.Length; j++) // Ищем индекс символа сообщения

                {
                    if (massage[i] == alfavit[j]) // сравниваем с алфавитом
                    {
                        break;
                    }
                }

                if (j != 26) // Если j равно 26, значит символ не из алфавита
                {
                    nomer = j; // Индекс буквы

                    
                    if (t > key.Length - 1) { t = 0; } // Ключ закончился - начинаем сначала.

                    
                    for (f = 0; f < alfavit.Length; f++) // Ищем индекс буквы ключа
                    {
                        if (key[t] == alfavit[f]) // сравниваем с алфавитом
                        {
                            break;
                        }
                    }

                    t++;

                    if (f != 26) // Если f равно 26, значит символ не из алфавита
                    {
                        d = nomer + f;
                    }
                    else
                    {
                        d = nomer;
                    }
                    
                    if (d > 25) // Проверяем, чтобы не вышли за пределы алфавита
                    {
                        d = d - 26;
                    }

                    massage[i] = alfavit[d]; // Меняем букву на зашифрованную
                }
                else
                {
                    t++; // не забываем про инкремент
                }
            }

            s = new string(massage); // Собираем символы обратно в строку.
            Console.WriteLine($"Зашифрованниое сообщение: {s}");

            // -----------------------расшифровка сообщения-----------------------------------
            char[,] tabNumber = new char[26, 26]; // создаём двумерный массив Таблицы Виженера
            for (int j1 = 0; j1 < 26; j1++)
            {
                for (int i1 = 0; i1 < 26; i1++)
                {
                    int k1 = i1 + j1 + 65;
                    if (k1 > 90)
                    {
                        tabNumber[i1, j1] = (char)(k1 - 26);
                    }
                    else
                    {
                        tabNumber[i1, j1] = (char)(i1 + j1 + 65);
                    }
                }
            }

            char[] cipher = s.ToCharArray(); // разбираем строку зашифрованного сообщения обратно в массив символов
            t = 0;
            
            for (int i = 0; i < cipher.Length; i++) // Перебираем каждый символ ключа по кругу. Количество прогонов равно количеству символов шифра.
            {
                if (t > key.Length - 1) { t = 0; } // Ключ закончился - начинаем сначала.
                
                for (j = 0; j < alfavit.Length; j++) // Ищем индекс буквы ключа
                {
                    if (key[t] == alfavit[j])
                    {
                        break;
                    }
                 
                }
                t++;
                int kodLiter;
                for ( kodLiter = 0; kodLiter < 26; kodLiter++)
                {
                    if (tabNumber[j, kodLiter] == cipher[i]) // перебираем по столбцам (J)
                                                             // и по строкам (kodLiter) таблицы Виженера
                                                             // символы зашифрованного сообщения
                    {
                        break;
                    }
 
                }
                if (kodLiter != 26) // Если f равно 26, значит символ не из алфавита
                {
                    massage[i] = alfavit[kodLiter];
                    
                }
                else
                {
                    massage[i] = cipher[i]; // иначе - переписываем символ "как есть"
                }

            }
            s = new string(massage); // собираем расшифрованное сообщение в строку
            Console.WriteLine($"Расшифрованное сообщение: {s}");

            Console.ReadLine();

        }
    }
}
// как-то так))), инерфейсы, формы и др. я ещё не учил...