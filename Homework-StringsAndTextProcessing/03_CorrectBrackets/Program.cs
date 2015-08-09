using System;

class CorrectBrackets
    {
        static void Main()
        {
            // Write a program to check if in a given expression the brackets are put correctly.
            // Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).

            string expression = Console.ReadLine();

            bool isCorrect = true;
            for (int i = 1; i < expression.Length - 1; i++)
            {
                if ((expression[i] == '(' && expression[i - 1] == ')') || (expression[i] == ')' && expression[i + 1] == '('))
                {
                    isCorrect = false;
                }

            }

            Console.WriteLine("Correct expression: {0}", isCorrect);
        }
    }

