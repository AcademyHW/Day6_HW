using System;

namespace Day6_HW
{
    class Program
    {
        static string SearchFullName (Task2.Passport[] passports, int number)
        {
            foreach (var passport in passports)
            {
                if (number == passport.Number)
                {
                    return passport.FullName;
                }
            }
            return "not found";
        }

        static void Main(string[] args)
        {
            //Task1 - while true cycle
            //var task1 = new Task1.Notary();
            //task1.AddClients();

            //Task2 
            var random = new Random();
            Task2.Passport[] passports = new Task2.Passport[random.Next(10,15)];
            for (int i = 0; i < passports.Length; i++)
            {
                passports[i] = i % 2==0 ? 
                    new Task2.Passport($"Client {i}") : 
                    new Task2.Passport($"Client {i}", i*1000);
                Console.WriteLine("Full name is \t{0}\nSeries is \t{1}\nNumber is\t{2}\n"
                    ,passports[i].FullName,passports[i].Series, passports[i].Number);
            }
            Console.WriteLine("Go search FullName client who have number = ");
            Console.WriteLine(
                SearchFullName(passports, Convert.ToInt32(Console.ReadLine()))
                );

            //Task3
            var brackets = new Task3.Brackets("asdasdassd(asdasd)(asd)asd(asd)asd(asd(asd(asd)asd))))");
            Console.WriteLine(brackets.CalculateNotCloseBrackets()); 
        }
    }
}
