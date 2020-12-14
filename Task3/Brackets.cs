
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

        public int CalculateNotCloseBrackets()
        {
            Stack<char> brackets = new Stack<char>();
            for (int i = 0; i < Sequence.Length; i++)
            {
                if (Sequence[i]=='(')
                {
                    brackets.Push('1');
                }
                if (Sequence[i]==')' && brackets.Count != 0)
                {
                    brackets.Pop();
                }
            }
            return brackets.Count;
        }
    }
}
