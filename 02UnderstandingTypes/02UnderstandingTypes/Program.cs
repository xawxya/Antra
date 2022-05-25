using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02UnderstandingTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String str = "hi, exe? ABBA! Hog fully a string: ExE.Bob";

            printPalindromes(str);


        }
        //Size Practice
        public static void printSizes()
        {
            Console.WriteLine(sizeof(sbyte));
            Console.WriteLine(sizeof(byte));
            Console.WriteLine(sizeof(short));
            Console.WriteLine(sizeof(ushort));
            Console.WriteLine(sizeof(int));
            Console.WriteLine(sizeof(uint));
            Console.WriteLine(sizeof(long));
            Console.WriteLine(sizeof(ulong));
            Console.WriteLine(sizeof(float));
            Console.WriteLine(sizeof(double));
            Console.WriteLine(sizeof(decimal));
        }
        public static void convertTime(int num)
        {
            Console.WriteLine(num + " Centuries");
            int year = num * 100;
            Console.WriteLine(year + " years");
            int days = (int) (year * 365.24);
            Console.WriteLine(days + " days");
            int hours = days * 24;
            Console.WriteLine(hours + " hours");
            int minutes = hours * 60;
            Console.WriteLine(minutes + " minutes");
            long seconds = hours * 1000;
            Console.WriteLine(seconds + " seconds");
            long milliseconds = seconds * 1000;
            Console.WriteLine(milliseconds + " milliseconds");
            long microseconds = milliseconds * 1000;
            Console.WriteLine(microseconds + " microseconds");
            long nanoseconds = microseconds * 1000;
            Console.WriteLine(nanoseconds + " nanoseconds");
        }

        //Loop Practice
        public static void guessNumber()
        {
            int correctNumber = new Random().Next(10) + 1;
            int guessedNumber = 0;
            while (guessedNumber != correctNumber)
            {
                guessedNumber = int.Parse(Console.ReadLine());
                if (guessedNumber > correctNumber) { Console.WriteLine("Try Smaller"); }
                else if (guessedNumber < correctNumber) { Console.WriteLine("Try Bigger"); }
            }
            Console.WriteLine("Correct!");
            
        }
        
        public static void printPyramid()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4 - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < 2*i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }

        public static void getAge()
        {
            Console.Write("Enter a year: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Enter a month: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Enter a day: ");
            int day = int.Parse(Console.ReadLine());

            DateTime inputDate = new DateTime(year, month, day);
            DateTime today = DateTime.Now;
            double days = (today - inputDate).TotalDays;
            Console.WriteLine("You are " + Math.Ceiling(days) + " days old");
        }

        public static void greeting()
        {
            DateTime currentTime = DateTime.Now;
            int currentHour = currentTime.Hour;
            if (currentHour < 5 || currentHour > 21)
            {
                Console.WriteLine("Good Night");
            } else if (currentHour < 9)
            {
                Console.WriteLine("Good Morning");
            } else if (currentHour < 16)
            {
                Console.WriteLine("Good Afternoon");
            } else if (currentHour < 21)
            {
                Console.WriteLine("Good Evening");
            }
        }

        public static void Counting()
        {
            for (int i = 1; i < 5; i++)
            {
                Console.Write(0 + ",");
                int j = i;
                while (j < 25)
                {   
                    if (j == 24)
                    {
                        Console.Write(j);
                    }else {
                        Console.Write(j + ",");
                    }
                    j = j + i;
                }
                Console.WriteLine(" ");
            }
        }

        //Practice Arrays
        public static void copyArray()
        {
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }

            int[] arr2 = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr2[i] = arr[i];
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i] + " ");
            }
        }

        public static void shoppinglist()
        {
            List<String> list = new List<String>();
            while (true) 
            {
                Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
                String operation = Console.ReadLine();
                char input1 = operation[0];
                char input2 = operation[1];
                String itemName = operation.Substring(1, operation.Length - 1);
                if (input1 == '+' && input2 == ' ')
                {
                    list.Add(itemName);
                } else if (input1 == '-' && input2 == ' ')
                {
                    list.Remove(itemName);
                } else if (input1 == '-' && input2 == '-')
                {
                    list.Clear();
                }
            }
        }

        public static int[] FindPrimesInRange(int startNum, int endNum)
        {
             List<int> primeList = new List<int>();
            for (int i = startNum; i <= endNum; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= i/2; j++)
                {
                    if (i%j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime && !primeList.Contains(i) && i != 1) {
                    primeList.Add(i);
                }
            }

            int[] result = primeList.ToArray();
            return result;
        }

        public static int[] findSum(int[] arr, int k)
        {
            int len = arr.Length;
            int[] result = new int[len];
       
            for (int i = 0; i < len; i++)
            {
                int temp = 0;
                int index = i - 1;
                for (int j = 0; j < k; j++)
                {
                    if (index < 0)
                    {
                        index = len - 1; 
                    }
                    temp += arr[index];
                    index--;
                }
                result[i] = temp;
            }
            return result;
        }

        public static void longestSubsequence(int[] arr)
        {
            int last = arr[0];
            int max = 1;
            int maxInt = last;
            int count = 1;
            for (int i = 1; i < arr.Length; i++)
            {   
                if (arr[i] == last)
                {
                    count++;
                } else
                {
                    int temp = max;
                    max = Math.Max(count, max);
                    if (max > temp)
                    {
                        maxInt = last;
                    }
                    count = 1;
                    last = arr[i];
                }

                if (i == arr.Length - 1 && count > max)
                {
                    max = count;
                    maxInt = arr[i];
                } 
            }

            for (int i = 0; i < max; i++)
            {
                Console.Write(maxInt + " ");
            }
        }

        //Practice Strings
        public static void reverseString()
        {
            String str = Console.ReadLine();
            char[] arr = str.ToCharArray();
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i]);
            }
        }


        public static void printPalindromes(String str)
        {
            char[] carr = str.ToCharArray();
            List<String> list = new List<String>();
            int start = 0;
            for (int i = 0; i < carr.Length; i++)
            {
                if (!Char.IsLetter(carr[start]) && Char.IsLetter(carr[i]))
                {
                    start = i;
                }
                if (!Char.IsLetter(carr[i]) && Char.IsLetter(carr[start]))
                {
                    String temp = str.Substring(start, i - start);
                    list.Add(temp);
                    start = i;
                }
            }
            List<String> panList = new List<String>();
            foreach(String s in list)
            {
                char[] temp = s.ToCharArray();
                int len = temp.Length;
                bool isPan = true;
                if (len == 1) { continue; }
                for (int i = 0; i <= len/2; i++)
                {
                    if (temp[i] != temp[len - 1 - i])
                    {
                        isPan = false;
                        break;
                    }
                }
                if(isPan)
                {
                    panList.Add(s);
                }
            }

            foreach(String s in panList)
            {
                Console.Write(s + ",");
            }

        }


    }
}
