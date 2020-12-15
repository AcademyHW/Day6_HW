using System;
using System.Collections.Generic;

namespace Day6_HW.Task3
{
    class Brackets
    {
        public string Sequence { get; private set; }

        public Brackets(string sequence)
        {
            Sequence = sequence;
        }
        
        public int CalculateNotCloseBrackets() // ( ) - closed brackets (return 0), (( ) - not closed bracket (return 1), ))() - error (return -2)
        {
            Stack<char> brackets = new Stack<char>();
            var bracketErrors = 0;
            for (int i = 0; i < Sequence.Length; i++)
            {
                try
                {
                    if (Sequence[i] == '(')
                    {
                        brackets.Push('1');
                    }
                    else if (Sequence[i] == ')' && brackets.Count != 0)
                    {
                        brackets.Pop();
                    }
                    else if (Sequence[i] == ')' && brackets.Count == 0)
                    {
                        bracketErrors--;
                        throw new Exception();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Found close bracket , but not found open bracket");
                }
            }
            return bracketErrors == 0 ? brackets.Count : bracketErrors;
        }
    }
}
