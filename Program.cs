using System;

namespace Lab2
{
    class MainClass
    {
        public static int Getmax(int[] array)
        {
            int max = array[0];
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }
            return max;

        }
        public static int Getmin(int[] array)
        {
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                    min = array[i];
            }
            return min;

        }
        public static void Main(string[] args)
        {
            string s1 = "hello yo";
            int[] numbers = { 3, 32, 16, 27, 55, 43, 2, 34 };
            int max;
            int min,sum=0;
            string s2 = s1.Substring(0,1);
            max = Getmax(numbers);
            min = Getmin(numbers);
            sum = max + min;
            var kar = (max, min,sum,s2);
            (int, string, char, string, ulong) kor = (12, "Years", 'J', "Old", 123113);//Задаем кортеж

            var named = (Name:"Tommy", age:54); //Именование 
            var named2 = (Name: "Tommy", age: 54);

            var tuple = (12, "You sobaka");
            (int value, string text) = tuple; // Распаковка 

            Console.WriteLine(kor.Item1);
            Console.WriteLine(kor.Item3);
            Console.WriteLine(kor.Item4);

            Console.WriteLine(named.Equals(named2));// Сравнение
            Console.WriteLine(kar);
            Console.WriteLine(tuple);


        }
    }
}
