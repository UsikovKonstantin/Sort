using ClassLibrarySort;

// Просто добавил для тестирования, когда всё будет готово - уберём консольное приложение
namespace ConsoleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = Sort.GenerateArrayString(1, 100, 100);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}