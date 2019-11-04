using System;
using System.Collections.Generic;
using System.Text;

namespace queue {
    class Queue<T> {

        private T[] queue;
        private int count = 0; // också size
        //sizen på en kö är väll lämplig att vara lika stor som kön ? eller finns det fördela med att den ska vara stor? som med Stack?

        public int Count {
            get { return count; }
        }

        // Eftersom jag anser att det inte finns någon fördel med en större kö än vad kön är skapas alltid kön som 0
        //Sedan för man Enqueuea själv
        public Queue() {
            queue = new T[0];
        }

        //lägger till längst fram i kön 
        public void Enqueue(T value) {
            ReSize(count + 1);
            // lägg till sisti kön (störst index)
            queue[count] = value;
            count++;
        }

        public T Dequeue() {
            if (queue.Length > 0) {
                // Eftersom första (först i kön) elementet ska bort måste allt flyttas fram.
                T[] temp = queue;

                queue = new T[count];

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
                return default;
             
            }

        }

        private void ReSize(int size) {
            T[] temp = queue;

            queue = new T[size];

            for (int i = 0; i < count; i++) {
                queue[i] = temp[i];
            }
        }

        public void Clear() {
            count = 0;
            queue = new T[0];
        }

        public T Peek() {
            //Retunera Första värdet som också är först i kön
            return queue[0];
        }


        // Om man vill skriva ett visst index ut kön (eller hela.)
        public T this[int i] {
            get { return queue[i]; }
            set { queue[i] = value; }
        }
    }
}
