using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace Lesson5

{
    class Program
    {
        static void Main1()
        {
            int[] myArray = { 1, 5, 7, 9, 10 };
            int sumWithFor = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                sumWithFor += myArray[i];
            }
            Console.WriteLine($"Sum with for operator is {sumWithFor}");

            int SumWithForEach = 0;
            foreach (var item in myArray)
            {
                SumWithForEach += item;
            }
            Console.WriteLine($"Sum with for each operator is {SumWithForEach}");
        }
        static void Main5()
        {
            bool isContinue = false;
            do
            {
                Console.WriteLine("Do You Want To Continue? Yes/No");
                string userAnswer = Console.ReadLine();
                isContinue = userAnswer.ToLower() == "yes";

                Console.WriteLine(isContinue ? "Do you want to continue" : "You Choose To Exit");

            } while (isContinue);
        }
        static void Main3()
        {
            Console.WriteLine("Do You Want To Continue? Yes/No");
            while (true)
            {
                string userAnswer = Console.ReadLine();
                bool isContinue = userAnswer.ToLower() == "yes";
                if (isContinue)
                {
                    Console.WriteLine("Do you want to continue");
                    continue;
                }
                Console.WriteLine("You Choose To Exit");
                break;
                
            }
            int i = 0;
            while (i<100)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.ReadLine();


        }
        static void Main2()
        {
            //loops
            for (int i = 0; i <=100; i++)
            {
                if (i>70)
                {
                    break;
                }
                if (i/10>=1 && i%10 ==0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }

        static void Main()
        {
            //Chagiranda
            ArrayList list = CreateAndInitializeArrayList(30, "Bu gun", DateTime.Now);
            PrintArrayList(list);
        }
       
        //Return tipli metod
        static ArrayList CreateAndInitializeArrayList(int itemcount, string text, DateTime date)
        {
            ArrayList list = new ArrayList();
            for (int i = 0; i < itemcount; i++)
            {
                list.Add(i);
            }
            list.Add(1);
            list.Add(text);
            list.Add(date);
            return list;
        }

        //return olmayan void metod
        static void PrintArrayList (ArrayList list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }





    }


    
}