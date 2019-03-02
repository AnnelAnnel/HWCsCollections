using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListWork
{
    class Program
    {
        static void Main(string[] args)
        {
            secondMax();
            //aboveAvg();
            //printReverse();
            //isSame();
            //vowelsFirst();
            //positiveFirst();

        }
        public static Random rnd = new Random();
        //1.Создать коллекцию List<int>.Вывести на экран позицию
        //  и значение элемента, являющегося вторым максимальным 
        //  значением в коллекции.Вывести на экран сумму элементов на четных позициях.
        public static void secondMax()
        {
            int x = 0;
            List<int> list = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                x = rnd.Next(1, 20);
                list.Add(x);
            }
            var tmp = list.Where(c => c != list.Max()).ToList();
            int secondMax = tmp.Max();     
        
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i]+" ");
            }
            
            Console.WriteLine("\nSecond max is {0} at {1}", secondMax, list.IndexOf(secondMax));

            //2.	Удалить все нечетные элементы списка List<int>

            var even = list.Where(e => e % 2 == 0).ToList();
            Console.WriteLine("Без нечетных:");
            for (int i = 0; i < even.Count; i++)
            {
                Console.Write(even[i] + " ");
            }           
        }

        //3.	Дана коллекция типа List<double>. Вывести на экран элементы списка,
        //        значение которых больше среднего арифметического всех элементов коллекции.

        public static void aboveAvg()
        {
            double x = 0;
            List<double> list = new List<double>();
            for (int i = 0; i < 10; i++)
            {
                x = rnd.Next(1, 30);
                list.Add(x);
            }
            double avg = list.Average();
            Console.WriteLine("Изначальный список");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
               
            }
      
            Console.WriteLine("\nПечать элементов больше среднего арифметического {0}", avg);
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > avg)
                {
                    Console.Write(list[i] + " ");
                }
            }
            Console.WriteLine();
        }


        //4.	Напечатать содержимое текстового файла t, выписывая 
        //        литеры каждой его строки в обратном порядке.
        public static void printReverse()
        {
            
            string tmpr = "Тутанхамон — фараон Древнего Египта из XVIII династии Нового царства, правивший приблизительно в 1332—1323 годах до н. э. Его обнаруженная Говардом Картером в 1922 году практически не тронутая гробница KV62 в Долине Царей стала сенсацией и возродила интерес публики к Древнему Египту. Фараон и его золотая погребальная маска (ныне выставлена в Каирском египетском музее) с тех пор остаются популярными символами, а «мистические» смерти участников экспедиции 1922 года привели к возникновению понятия «проклятие фараонов».";
            
            StreamWriter SW = new StreamWriter(new FileStream("myText.txt", FileMode.Create, FileAccess.Write));
            SW.Write(tmpr);
            SW.Close();

            string readPath = @"myText.txt";
            List<string> txt = File.ReadAllLines(readPath).ToList();
            string tmp = "";
            for (int i = 0; i < txt.Count; i++)
            {
                tmp += txt[i];
            }
            Console.WriteLine(tmp);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nПечать букв в словах текста в обратном порядке");
            Console.ForegroundColor = ConsoleColor.White;
            string[] t2=tmp.Split(' ');
            List<string> reversed = new List<string>();
          
            for (int i = 0; i < t2.Length; i++)
            {               
                char[] arr = t2[i].ToCharArray();
                Array.Reverse(arr);
                tmp= new string(arr)+" ";
                reversed.Add(tmp);                
            }
            
            for (int i = 0; i < reversed.Count; i++)
            {
                Console.Write(reversed[i]);
            }
        }
        
        //5.	Даны 2 строки s1 и s2. Из каждой можно читать по одному символу.
        //        Выяснить, является ли строка s2 обратной s1.
        public static bool isSame()
        {
            Console.WriteLine("Введите строку 1");
            string s1 = Console.ReadLine();
            Console.WriteLine("Введите строку 2");
            string s2 = Console.ReadLine();
            string tmp = "";
            if (s1.Length == s2.Length)
            {
                char[] arr = s2.ToCharArray();
                Array.Reverse(arr);
                tmp = new string(arr);
                if (s1 == tmp)
                {
                    Console.WriteLine("Строки обратны друг другу");
                    return true;
                }
                else
                {
                    Console.WriteLine("Строки не обратны друг другу");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Размеры строк не совпадают и одна не может быть обратной другой");
                return false;
            }
        }

        //6.	Дан текстовый файл.За один просмотр файла напечатать элементы 
        //        файла в следующем порядке: сначала все слова, начинающиеся
        //        на гласную букву, потом все слова, начинающиеся 
        //        на согласную букву, сохраняя исходный порядок в каждой группе слов.

        public static void vowelsFirst()
        {
            string tmpr = "Тутанхамон — фараон Древнего Египта из XVIII династии Нового царства, правивший приблизительно в 1332—1323 годах до н. э. Его обнаруженная Говардом Картером в 1922 году практически не тронутая гробница KV62 в Долине Царей стала сенсацией и возродила интерес публики к Древнему Египту. Фараон и его золотая погребальная маска (ныне выставлена в Каирском египетском музее) с тех пор остаются популярными символами, а «мистические» смерти участников экспедиции 1922 года привели к возникновению понятия «проклятие фараонов».";

            StreamWriter SW = new StreamWriter(new FileStream("myText.txt", FileMode.Create, FileAccess.Write));
            SW.Write(tmpr);
            SW.Close();

            string readPath = @"myText.txt";

            List<string> txt = File.ReadAllLines(readPath).ToList();
            
            string vowels = "АЕЁИОУЭЮЯаеёиоуыэюя";
            string tmp = "";
            for (int i = 0; i < txt.Count; i++)
            {
                tmp += txt[i];
            }


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Исходный текст");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(tmp);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Слова, начинающиеся с гласных звуков");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string[] tmp2 = tmp.Split(' ');
            for (int i = 0; i < tmp2.Length; i++)
            {
                char[] arr = tmp2[i].ToCharArray();
                if (vowels.Any(x => x == arr[0]))
                    Console.Write(tmp2[i]+ " ");
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nСлова, начинающиеся с согласных звуков");
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < tmp2.Length; i++)
            {
                char[] arr = tmp2[i].ToCharArray();
                if (!(vowels.Any(x => x == arr[0])))
                    Console.Write(tmp2[i] + " ");
            }
            Console.ForegroundColor = ConsoleColor.White;            
        }

        //7.	Дан файл, содержащий числа. За один просмотр файла напечатать 
        //        элементы файла в следующем порядке: сначала все 
        //        положительные числа, потом все отрицательные числа,
        //        сохраняя исходный порядок в каждой группе чисел.
        public static void positiveFirst()
        {
            //генерирую массив интов и записывю в файл:
            
            int[] arr = new int[20];
            string tmp = "";
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-20, 20);
                tmp += arr[i].ToString() + " ";
            }
            StreamWriter SW = new StreamWriter(new FileStream("myNumbers.txt", FileMode.Create, FileAccess.Write));
            SW.Write(tmp);
            SW.Close();

            string readPath = @"myNumbers.txt";

            List<string> numbers = File.ReadAllLines(readPath).ToList();
                       

            for (int i = 0; i < numbers.Count; i++)
            {
                tmp += numbers[i];
            }
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Исходные числа");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(tmp);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Положительные числа");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string[] tmp2 = tmp.Split(' ');
            
            for (int i = 0; i < tmp2.Length; i++)
            {
                if ((!tmp2[i].StartsWith("-")))
                    Console.Write("{0} ", tmp2[i]);
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nОтрицательные числа");
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < tmp2.Length; i++)
            {
                if (tmp2[i].StartsWith("-"))
                    Console.Write("{0} ", tmp2[i]);
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}







