using System.Collections.Generic;
using System;

namespace Day6_HW.Task1
{
    class Notary
    {
        public Queue<int> Clients = new Queue<int>();

        public void AddClients()
        {

            var index = 0;
            while (true)
            {
                if (Clients.Count == 6)
                {
                    Console.WriteLine("Client {0} can entry", Clients.Dequeue());
                    index = index == 6 ? 0 : index--;
                }
                else
                {

                    Clients.Enqueue(index + 1);
                    index++;
                }
            }

        }
    }
}
