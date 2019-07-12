// File name: Program.cs
// Project Name: Optional_Parameters
// Author: Orndoff, Robert K.
// Date created: 07/11/2019
// Date last modified: 07/11/2019
//
// Q: Using your own words in a comment at the top of your .cs file, describe "syntactic sugar".
// A: Syntactic sugar is a syntax shortcut when writing code and an inherent feature of a language.  It allows one to write shorter, more concise code
//  which still logically flows and accomplishes the same result of other, more verbose syntax.
//
// C#
using System;

namespace Optional_Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            SomeMathStuff();
            SomeMathStuff(3, 3); //comment this out to run overloaded method.
            SomeMathStuff(2);  //comment this out to run overloaded method.
            SomeMathStuff(secondNum: 5);  //comment this out to run overloaded method.
        }
        static void SomeMathStuff(int firstNum = 1, int secondNum = 2) //comment this whole method out to run the overloaded method.
        {
            string firstNumResult = "nothing";
            string secondNumResult = "nothing";
            if (firstNum % 2 == 0)
            {
                firstNumResult = "even";
            }
            else
            {
                firstNumResult = "odd";
            }
            if (secondNum % 2 == 0)
            {
                secondNumResult = "even";
            }
            else
            {
                secondNumResult = "odd";
            }
            Console.WriteLine($"The first number ({firstNum}) is {firstNumResult}!  The second number ({secondNum}) is {secondNumResult}!");
        }

        // Overloading Method - uncomment from below this line to run.
        //static void SomeMathStuff(int firstNum, int secondNum)  
        //{
        //    string firstNumResult = "nothing";
        //    string secondNumResult = "nothing";
        //    if (firstNum % 2 == 0)
        //    {
        //        firstNumResult = "even";
        //    }
        //    else
        //    {
        //        firstNumResult = "odd";
        //    }
        //    if (secondNum % 2 == 0)
        //    {
        //        secondNumResult = "even";
        //    }
        //    else
        //    {
        //        secondNumResult = "odd";
        //    }
        //    Console.WriteLine($"The first number ({firstNum}) is {firstNumResult}!  The second number ({secondNum}) is {secondNumResult}!");
        //}


        // Calls the two-parameter method with defaults
        //static void SomeMathStuff(int firstNum)
        //{
        //    SomeMathStuff(firstNum, 1);
        //}


        // Calls the one-parameter method with a default value
        // OR
        // Calls the two-parameter method with a default values
        //static void SomeMathStuff()
        //{
        //    SomeMathStuff(5);
        //    SomeMathStuff(5,6);
        //}
    }
}
