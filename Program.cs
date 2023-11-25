/*
***********************************************************************************
    Задача 1: 
    Задайте одномерный массив из 10 целых чисел от 1 до 100. 
    Найдите количество элементов массива, значения которых лежат в отрезке [20,90].
    массив [10 21 14 93 23] => 2
***********************************************************************************
    Задача 2: 
    Задайте массив на 10 целых чисел. Напишите программу, 
    которая определяет количество чётных чисел в массиве.
    массив [6 7 19 34 3 1 4 7 9 1] => 3
    массив [1 8 43 4 55 60 3 2 1 3] => 4
***********************************************************************************
    Задача 3: 
    Задайте массив из вещественных чисел с ненулевой дробной частью. 
    Найдите разницу между максимальным и минимальным элементов массива.
    массив [2.2 0.4 9.11 7.2 78.98] => 78.58
    массив [1.22 4.5 3.33] => 3.28
***********************************************************************************
    Задача 4**(не обязательно): 
    Дано натуральное число в диапазоне от 1 до 100 000. 
    Создайте массив, состоящий из цифр этого числа. Старший разряд числа должен 
    располагаться на 0-м индексе массива, младший – на последнем. 
    Размер массива должен быть равен количеству цифр.
    425 => [4 2 5]
    8741 => [8 7 4 1]
    4 => [4]
***********************************************************************************
*/


namespace HomeMadeSeminar3
{
public class Program
    {
        public static void Main(string [] args)
        {
            string stringLoad = "Введите номер задачи (от 1 до 4) => ";
            System.Console.Write(stringLoad);
            Tasks(NumberInTerminal(4,stringLoad));
        }

        /*Функция ввода чисел в терминале*/
        public static int NumberInTerminal(int numberDigits, string repeatString)
        {
            string ? numString = Console.ReadLine();
            int numInt = 0;
            while ((!Int32.TryParse(numString,out numInt)) 
                    || !(numInt > 0) 
                    || !(numInt <= numberDigits)
                  )
            {
                System.Console.WriteLine("Ошибка ввода, повторите");
                System.Console.Write(repeatString);
                numString = Console.ReadLine(); 
            }
            return numInt;
        }
        public static void Tasks(int task)
        {
            Random rand = new Random();

            System.Console.Write($"Задача №{task}:");
            if (task == 1)
            {
                int size = 10; // массив из 10 элементов
                int [] array = new int[size];
                int count = 0;
                for (int i = 0; i < size; i++)
                {
                    array[i] = rand.Next(1, 101);
                }
                System.Console.WriteLine($"Задайте одномерный массив из 10 целых чисел от 1 до 100.");
                System.Console.WriteLine("Найдите количество элементов массива, значения которых лежат в отрезке [20,90].");
                System.Console.WriteLine("Решение");
                System.Console.Write("Массив задается рандомно => [");
                for (int item = 0; item < array.Length; item++)
                {
                    System.Console.Write($"{array[item]}");//(item + " ")
                    if (item < array.Length-1)
                    {
                        System.Console.Write(", ");
                    }
                    if ((array[item] >= 20) && (array[item] <= 90)){
                        count++;
                    }
                }
                System.Console.Write($"] => {count}");
            }
            if (task == 2)
            {
                System.Console.WriteLine($"Задайте массив на 10 целых чисел. Напишите программу,");
                System.Console.WriteLine("которая определяет количество чётных чисел в массиве.");
                System.Console.WriteLine("Решение");
                int size = 10; // массив из 10 элементов
                int [] array = new int[size];
                int count = 0;
                for (int i = 0; i < size; i++)
                {
                    array[i] = rand.Next(-100, 101); 
                }
                System.Console.Write("Массив задается рандомно => [");
                for (int item = 0; item < array.Length; item++)
                {
                    System.Console.Write($"{array[item]}");//(item + " ")
                    if (item < array.Length-1)
                    {
                        System.Console.Write(", ");
                    }
                    if (array[item]%2 == 0){
                        count++;
                    }
                }
                System.Console.Write($"] Количество четных чисел => {count}");
            }
            if (task == 3)
            {
                System.Console.WriteLine($"Задайте массив из вещественных чисел с ненулевой дробной частью.");
                System.Console.WriteLine("Найдите разницу между максимальным и минимальным элементов массива.");
                System.Console.WriteLine("Решение");
                int minValue = 1;
                int maxValue = 100;
                int size = 10; // массив из 10 элементов
                double [] array = new double[size];
                int count = 0;
                for (int i = 0; i < size; i++)
                {
                    array[i] = Math.Round(minValue + (maxValue - minValue) * rand.NextDouble(),2); 
                }
                double maxNum = array[0];
                double minNum = array[0];
                System.Console.Write("Массив задается рандомно => [");
                for (int item = 0; item < array.Length; item++)
                {
                    System.Console.Write($"{array[item]}");//(item + " ")
                    if (item < array.Length-1)
                    {
                        System.Console.Write(", ");
                    }
                    else{System.Console.WriteLine("]");}
                    if (array[item] > maxNum){
                        maxNum = array[item];
                    }
                    if (array[item] < minNum){
                        minNum = array[item];
                    }
                }
                System.Console.Write($"Разница между максимальным {maxNum} и минимальным {minNum} значением в массиве => {maxNum - minNum}");
            }
            if (task == 4)
            {
                string stringLoad = "Введите натуральное число в диапазоне от 1 до 100 000 => ";
                int number = 0;
                int digitOfNum = 0;
                int item = 1;
                System.Console.WriteLine($"Дано натуральное число в диапазоне от 1 до 100 000.");
                System.Console.WriteLine("Создайте массив, состоящий из цифр этого числа. Старший разряд числа должен");
                System.Console.WriteLine("располагаться на 0-м индексе массива, младший – на последнем.");
                System.Console.WriteLine("Размер массива должен быть равен количеству цифр.");
                System.Console.WriteLine("Решение");
                System.Console.Write(stringLoad);
                number = NumberInTerminal(100000,stringLoad); //Считали число
                System.Console.Write($"{number} => ");
                if (number < 10){digitOfNum = 1;}
                    else{
                            digitOfNum = (int)Math.Log10(number) + 1;
                        }
                int [] array = new int[digitOfNum]; 
                while (item <= digitOfNum)
                {
                    array[digitOfNum - item] = number%10;
                    number /= 10;
                    item++;
                }
                // Выводим массив
                stringLoad = string.Empty;
                for (int items = 0; items < array.Length; items++)
                {
                    stringLoad += array[items];
                    if (items < array.Length-1)
                    {
                        stringLoad += " ";
                    }
                }
                System.Console.Write("[" + stringLoad + "]");
            }
        } 
    }

}