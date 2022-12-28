using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapSort
{
    public class Worst
    {
        public void HeapSort(int[] array)
        {
            // Baue den Heap auf
            for (int i = array.Length / 2 - 1; i >= 0; i--)
            {
                Heapify(array, array.Length, i);
            }
            Console.WriteLine("So sieht der Aufgebaute Heap aus:");
            foreach (var zahl in array)
            {
                Console.WriteLine(zahl);

            }
            Console.WriteLine("---------------------------------");

            // Extrahiere elemente eins nach dem anderen vom heap
            for (int i = array.Length - 1; i >= 0; i--)
            {
                // Verschiebe den Root ans ende
                int temp = array[0];
                array[0] = array[i];
                array[i] = temp;

                Heapify(array, i, 0);
            }
            Console.WriteLine("So sieht es sortiert aus:");
            foreach (var zahl in array)
            {
                Console.WriteLine(zahl);
            }
            Console.WriteLine("---------------------------------");
        }

        private void Heapify(int[] array, int heapSize, int rootIndex)
        {
            int grössteZahl = rootIndex;
            int leftChildIndex = 2 * rootIndex + 1;
            int rightChildIndex = 2 * rootIndex + 2;

            // Kontrolliere ob linkes "child" grösser ist als der root
            if (leftChildIndex < heapSize && array[leftChildIndex] > array[grössteZahl])
            {
                grössteZahl = leftChildIndex;
            }

            // Kontrolliere ob rechtes "child" grösser ist als das grösste bis dato
            if (rightChildIndex < heapSize && array[rightChildIndex] > array[grössteZahl])
            {
                grössteZahl = rightChildIndex;
            }

            // falls das grösste nicht der root ist, swape und führe den heapify weiter aus.
            if (grössteZahl != rootIndex)
            {
                int temp = array[rootIndex];
                array[rootIndex] = array[grössteZahl];
                array[grössteZahl] = temp;
                Heapify(array, heapSize, grössteZahl);
            }
        }
    }
}
