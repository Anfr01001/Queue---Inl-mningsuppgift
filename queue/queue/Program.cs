using System;
using System.Collections.Generic;

namespace queue {
    class Program {
        static void Main(string[] args) {

            Queue<string> queue = new Queue<string>();

            //List<int> hej = new List<int>()
          

            string input;

            // Exempel element för kön
            queue.Enqueue("Ett");
            queue.Enqueue("Två");
            queue.Enqueue("Tre");

            Console.WriteLine("E för Enqueue | D för Dequeue | P för Peek | C för clear | S för skriv ut");

            input = Console.ReadLine();

            // En loop som låter en testa kön med kommandona 
            while (true) {
                switch (input) {
                    case "E":
                        Console.WriteLine("Skriv in det du vill köa");
                        queue.Enqueue(Console.ReadLine());
                        Console.WriteLine("Tillagd i kön");
                        break;

                    case "D":
                        Console.WriteLine("Dequeueade " + queue.Dequeue());
                        break;

                    case "P":
                        Console.WriteLine("Första elementet i kön är " + queue.Peek());
                        break;

                    case "C":
                        queue.Clear();
                        Console.WriteLine("Kön är nu tom");
                        break;

                    case "S":
                        for (int i = 0; i < queue.Count; i++) {
                            Console.Write(queue[i] + " | ");
                        }
                        Console.WriteLine(" ");
                        break;

                    default:
                        Console.WriteLine("Det där var inget kommando!");
                        break;
                }

                input = Console.ReadLine();

            }

        }
    }
}
