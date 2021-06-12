using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
namespace Practise_2
{


    public class Program
    {



        static void Main(string[] args)
        {
            EnterValue:
            Console.WriteLine("Enter the Value to be sorted");
            var test = Console.ReadLine();
            int result;
            if(int.TryParse(test, out result))
            {
                Console.WriteLine("Enter only alphabets");
                goto EnterValue;
            }

            char[] Ainput = test.ToCharArray();

            foreach (var item in Ainput)
            {
                if (!char.IsLetter(item))
                {
                    Console.WriteLine("Enter only alphabets");
                    goto EnterValue;
                }



            }

            List<char> Linput= Ainput.ToList();

            //Linput.alp

            //Linput.Sort((x,y)=> x.CompareTo(y));
            Linput.Sort();

            foreach (var item in Linput)
            {
                Console.Write(item);
            }
            

            


        }






    }
}









