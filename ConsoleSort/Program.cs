using ClassLibrarySort;
using System.Diagnostics;

// Просто добавил для тестирования, когда всё будет готово - уберём консольное приложение
namespace ConsoleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = Sort.GenerateArrayInt(int.MinValue, int.MaxValue-1, 1000000);
            Stopwatch sw = Stopwatch.StartNew();   
            Sort.MergeSort(arr, true, new CancellationToken());
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);

            var arr2 = Sort.GenerateArrayInt(int.MinValue, int.MaxValue-1, 1000000);
            sw.Restart();
            Sort.QuickSort(arr2, true, new CancellationToken());
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}