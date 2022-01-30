using System;


namespace akomarec_L1MD5_29
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //char[] tabI = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            //char[] tabJ = new char[tabI.Length];
            //for (int i = 0; i < tabI.Length; i++)
            //{
            //    int k = i+1;
            //    if (k > tabI.Length-1)
            //    {
            //        k = k - tabI.Length;
            //    }
            //    tabJ[i] = tabI[k];
            //}
            //foreach (char c in tabJ)
            //{
            //    Console.WriteLine(c);

            //}
            char[,] tabNumber = new char [26, 26];
            for (int j = 0; j < 26; j++)
            {
                for (int i = 0; i < 26; i++)
                {
                    int k = i + j + 65;
                    if (k > 90)
                    {
                        tabNumber[i, j] = (char)(k - 26);
                    }
                    else 
                    { 
                        tabNumber[i, j] = (char)(i + j + 65); 
                    }
                }
            }
            Console.WriteLine("Введите текст для шифрования:");
            string text = Console.ReadLine();
            var textArray = text.ToCharArray();
            Console.WriteLine("Введите ключ из не менее чем 10 символов:");
            string key = Console.ReadLine();
            var n = key.Length;
            while (n < 10)
            {
                Console.WriteLine("Введите ключ из не менее чем 10 символов:");
                string key1 = Console.ReadLine();
                n = key1.Length;
                key = key1;
            }
            var keyArray = key.ToCharArray();
            Console.WriteLine(key);
            Console.WriteLine(key.Length);
            char[] cipherKey = new char[26];
            cipherKey.
            for (int i = 0; i < 26; i++)
            {

                if (i <= key.Length-1)
                {
                    cipherKey[i] = keyArray[i];

                    //if (i%key.Length == 0)
                    //{
                    //   int k = key.Length;
                    //}

                }
                else
                {
                    int k = 10;
                    if (i % key.Length == 0)
                    cipherKey[i] = keyArray[i - k];
                }
            }
            
                Console.WriteLine(cipherKey);
            
            Console.ReadLine();
            
        }
    }
}
