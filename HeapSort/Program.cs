namespace HeapSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            Worst worst = new Worst();
            int[] array = { 41, 7, 65, 9, 23, 2, 16, 31, 53, 3 };
            worst.HeapSort(array);
        }
    }
}