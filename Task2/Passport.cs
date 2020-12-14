using System;

namespace Day6_HW.Task2
{
    class Passport
    {
        public string FullName { get; private set; }
        public int Series { get; private set; }
        public int Number { get; private set; }
        public Passport(string fullName, int series = 0000)
        {
            FullName = fullName;
            var random = new Random();
            Series = series == 0000 ? random.Next(8000, 8999) : series;
            Number = random.Next(100000, 999999);
        }
    }
}
