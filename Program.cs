using System;

namespace test
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            bool alive = true;
            byte bit1 = 1;
            sbyte bit2 = -102;
            short n1 = 2;
            int a = 10;
            uint b = 25;
            long c = 134234234;
            ulong d = 12312312312312;
            float e = 0.223f;
            double bl = -23.34;
            char sym = 'A';
            string text = "Hello";
            object n = "everything";
            //------- Неявное приведение --------
            int num = 2147483647;
            long bigNum = num;

            char ch = '2';
            ushort ch2 = ch;

            sbyte it = 123;
            float fl = it;

            float odin = 1.24f;
            double dva = odin;

            uint kak = 15;
            ulong tak = kak;

            //-------- Явное приведение --------- ;
            double x = 1234.7;
            int j;
            j = (int)x;
            System.Console.WriteLine(j);


            char kek = 'b';
            byte lol;
            lol = (byte)kek;
            System.Console.WriteLine(lol);

            float ak = 4.7f;
            sbyte rt;
            rt = (sbyte)ak;
            System.Console.WriteLine(rt);

            short sm = 98;
            char ms;
            ms = (char)sm;
            System.Console.WriteLine(ms);

            uint G = 83;
            char sd;
            sd = (char)G;
            System.Console.WriteLine(sd);

            // Упаковка Распаковка 

            int yp = 123;
            object h = yp;

            h = 123;
            yp = (int)h;

            // Неявно типиризированная

            var i = 12;
            var p = 1.24;
            var f = 14.5f;

            // Nullable 

            int? ne = null;
            double? be = null;
            bool? ce = null;

            //---------Строки--------- 


            Console.WriteLine("Hello World");
            Console.WriteLine(String.Compare("Hello", "World"));

            string str1 = "Hello ,my name is Vadim";
            string str2 = " I'm 19 years old.";
            string str3 = "And student of FIT";
            Console.WriteLine(str1 + str2); // Сцепление

            if (str1.Contains("Hello")) // Проверка на подстроку
            {
                Console.WriteLine("Cодержит");
            }
            Console.WriteLine(str3.Insert(4, "i am ")); // Вставка

            Console.WriteLine(str3.Remove(0, 3)); // Удаление

            String str4 = "";
            String str5 = "Star";
            str4 = String.Copy(str5); // Копирование 
            Console.WriteLine(str4);

            String s = "Ivan Vanya Ivanushka"; // Разделение строки на подстроки
            String[] words = s.Split(new char[] { ' ' });
            for (int v = 0; v < 3; v++)
            {
                Console.WriteLine(words[v]);
            }

            string s1 = ""; // Пустая и Null строки 
            string s2 = null;
            Console.WriteLine(String.IsNullOrEmpty(s1));
            Console.WriteLine(String.IsNullOrEmpty(s2));

            System.Text.StringBuilder sb = new System.Text.StringBuilder("Yo whatsup ");
            sb.Append("dude ");
            Console.WriteLine(sb);
            sb.Remove(0, 3);
            Console.WriteLine(sb); // Добавление в начало и в конец
            sb.Insert(0, ":)");
            Console.WriteLine(sb); 

            //---------Массивы--------

            // Объявляем двумерный массив
            int[,] myArr = new int[4, 5];

            Random ran = new Random();

            // Инициализируем данный массив
            for (int m = 0; m < 4; m++)
            {
                for (int t = 0; t < 5; t++)
                {
                    myArr[m,t] = ran.Next(1, 15);
                    Console.Write("{0}\t", myArr[m, t]);
                }
                Console.WriteLine();
            }

            // Одномерный массив 
            Console.WriteLine("-----------------");
            int[] odmas = new int[5];
            Random rand = new Random();
            for (int ik = 0; ik < 5; ik++)
            {
                odmas[ik] = rand.Next(1, 15);
                Console.WriteLine("{0}\t", odmas[ik]);

            }
            Console.WriteLine("Длина массива: ");
            Console.WriteLine(odmas.Length);

            // Меняем местами
            int[] mas4 = new int[5]{1,2,3,4,5};
            int chisl,nomer;
            Console.WriteLine("Изначальный массив: ");
            for (int q = 0; q < 5;q++)
            {
                Console.WriteLine(mas4[q]);
            }
            Console.WriteLine("Введите номер элемента массива");
            nomer = int.Parse(Console.ReadLine());
            chisl =int.Parse(Console.ReadLine());
            Console.WriteLine("Элементы массива:");
            for (int w = 0; w < 5;w++)
            {
                if(nomer==mas4[w])
                {
                    mas4[w] = chisl;
                    
                }

                Console.WriteLine(mas4[w]);
            }

            //--------Cтупенчатый массив-------
            int z = 0;
            // Объявляем ступенчатый массив
            int[][] myArrz = new int[4][];
            myArrz[0] = new int[4];
            myArrz[1] = new int[6];
            myArrz[2] = new int[3];


            // Инициализируем ступенчатый массив
            for (z=0; z < 4; z++)
            {
                myArrz[0][z] = z;
                Console.Write("{0}\t", myArrz[0][z]);
            }

            Console.WriteLine();
            for (z = 0; z < 6; z++)
            {
                myArrz[1][z] = z;
                Console.Write("{0}\t", myArrz[1][z]);
            }

            Console.WriteLine();
            for (z = 0; z < 3; z++)
            {
                myArrz[2][z] = z;
                Console.Write("{0}\t", myArrz[2][z]);
            }

            Console.WriteLine();

            // d
            var array = new object[0];
            var stroka = "";
        }
    }
}
       
    

