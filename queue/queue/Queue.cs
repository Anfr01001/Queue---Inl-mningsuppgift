using System;
using System.Collections.Generic;
using System.Text;

namespace queue {
    class Queue {

        private string[] queue;
        private int count = 0; // också size
        //sizen på en kö är väll lämplig att vara lika stor som kön ? eller finns det fördela med att den ska vara stor? som med Stack?

        public int Count {
            get { return count; }
        }

        // Eftersom jag anser att det inte finns någon fördel med en större kö än vad kön är skapas alltid kön som 0
        //Sedan för man Enqueuea själv
        public Queue() {
            queue = new string[0];
        }

        //lägger till längst fram i kön 
        public void Enqueue(string value) {
            ReSize(count + 1);
            // lägg till sisti kön (störst index)
            queue[count] = value;
            count++;
        }

        public string Dequeue() {
            if (queue.Length > 0) {
                // Eftersom första (först i kön) elementet ska bort måste allt flyttas fram.
                string[] temp = queue;

                queue = new string[count];

                // i = 1 på  för att inte få med det första elementet (det som ska tas bort)
                for (int i = 1; i < count; i++) {
                    queue[i - 1] = temp[i];
                }

                count--;
                ReSize(count);

                // retunera temp 0 för queue 0 är redan omgjord (retunerar det som togs bort)
                return temp[0];
            } else {
                // om kön är tom ska man inte kunna Dequeue (då blir det utanför index)
                return null;
            }

        }

        private void ReSize(int size) {
            string[] temp = queue;

            queue = new string[size];

            for (int i = 0; i < count; i++) {
                queue[i] = temp[i];
            }
        }

        public void Clear() {
            count = 0;
            queue = new string[0];
        }

        public string Peek() {
            //Retunera Första värdet som också är först i kön
            return queue[0];
        }


        // Om man vill skriva ett visst index ut kön (eller hela.)
        public string this[int i] {
            get { return queue[i]; }
            set { queue[i] = value; }
        }
    }
}
