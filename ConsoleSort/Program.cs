using ClassLibrarySort;

// Просто добавил для тестирования, когда всё будет готово - уберём консольное приложение
namespace ConsoleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = Sort.GenerateArrayDouble(1, 10000000, 100);
            Sort.QuickSort(arr, false, 0, arr.Length - 1);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}