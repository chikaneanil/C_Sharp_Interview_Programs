using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1.String_Program
{
    class DuplicateCharacter
    {

        //------------------------------------ The simple way of Implementation to remove duplicate characters --------------------- //

        //static void Main(string[] args) 
        //{
        //    Console.WriteLine("Enter String");
        //    string inputstring = Console.ReadLine();
        //    string resultString = string.Empty;

        //    for (int i = 0; i < inputstring.Length; i++) {
        //        if (!resultString.Contains(inputstring[i])) {
        //            resultString += inputstring[i];
        //        }
        //    }
        //    Console.WriteLine("After Removing Duplicate " + resultString);
        //    Console.ReadKey();
        //}

        //---------------------------------------  Using LINQ to Remove Duplicate Characters From a String ----------------------------//

        //static void Main(string[] args) 
        //{
        //    Console.Write("Enter a String : ");
        //    string inputString = Console.ReadLine();

        //    var uniqueCharArray = inputString.ToCharArray().Distinct().ToArray();
        //    var resultString = new string(uniqueCharArray);
        //    Console.WriteLine("After Removing Duplicates : " + resultString);
        //    Console.ReadKey();
        //}
    }
}

