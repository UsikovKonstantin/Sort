using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrarySort;
using System.Threading;

namespace TestProjectSort
{
    [TestClass]
    public class UnitTest
    {
        CancellationToken sourse = new CancellationToken();
        [TestMethod]
        public void BubbleSort_ReturnsArr()
        {
            int[] a = new int[] { 8, 6, 0, 5, 1, 4, 9, 2, 7, 10, 3 };
            int[] a1 = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] b = new int[] { 8, 6, 0, 5, 1, 4, 9, 2, 7, 10, 3 };
            int[] b1 = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            string[] c = new string[] { "Сортировка", "это", "последовательное", "расположение", "или", "разбиение", "на", "группы", "чего-либо", "в", "зависимости", "от", "выбранного", "критерия" };
            string[] c1 = new string[] { "в", "выбранного", "группы", "зависимости", "или", "критерия", "на", "от", "последовательное", "разбиение", "расположение", "Сортировка", "чего-либо", "это" };
            string[] d = new string[] { "Сортировка", "это", "последовательное", "расположение", "или", "разбиение", "на", "группы", "чего-либо", "в", "зависимости", "от", "выбранного", "критерия" };
            string[] d1 = new string[] { "это", "чего-либо", "Сортировка", "расположение", "разбиение", "последовательное", "от", "на", "критерия", "или", "зависимости", "группы", "выбранного", "в" };
            double[] e = new double[] { 5.06, -3.13, 9.33, -3.94, 6.20, 1.44, 6.87, 5.93, -4.54, -2.98, -8.80, 4.29, 0.59, 7.10, 2.01, 7.87, 9.04, -1.05, 8.67, 0.05 };
            double[] e1 = new double[] { -8.80, -4.54, -3.94, -3.13, -2.98, -1.05, 0.05, 0.59, 1.44, 2.01, 4.29, 5.06, 5.93, 6.20, 6.87, 7.10, 7.87, 8.67, 9.04, 9.33 };
            double[] f = new double[] { 5.06, -3.13, 9.33, -3.94, 6.20, 1.44, 6.87, 5.93, -4.54, -2.98, -8.80, 4.29, 0.59, 7.10, 2.01, 7.87, 9.04, -1.05, 8.67, 0.05 };
            double[] f1 = new double[] { 9.33, 9.04, 8.67, 7.87, 7.10, 6.87, 6.20, 5.93, 5.06, 4.29, 2.01, 1.44, 0.59, 0.05, -1.05, -2.98, -3.13, -3.94, -4.54, -8.80 };
            Sort.BubbleSort(a, true, sourse);
            Sort.BubbleSort(b, false, sourse);
            Sort.BubbleSort(c, true, sourse);
            Sort.BubbleSort(d, false, sourse);
            Sort.BubbleSort(e, true, sourse);
            Sort.BubbleSort(f, false, sourse);
            CollectionAssert.AreEqual(a, a1);
            CollectionAssert.AreEqual(b, b1);
            CollectionAssert.AreEqual(c, c1);
            CollectionAssert.AreEqual(d, d1);
            CollectionAssert.AreEqual(e, e1);
            CollectionAssert.AreEqual(f, f1);
        }
        [TestMethod]
        public void InsertSort_ReturnsArr()
        {
            int[] a = new int[] { 8, 6, 0, 5, 1, 4, 9, 2, 7, 10, 3 };
            int[] a1 = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] b = new int[] { 8, 6, 0, 5, 1, 4, 9, 2, 7, 10, 3 };
            int[] b1 = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            string[] c = new string[] { "Сортировка", "это", "последовательное", "расположение", "или", "разбиение", "на", "группы", "чего-либо", "в", "зависимости", "от", "выбранного", "критерия" };
            string[] c1 = new string[] { "в", "выбранного", "группы", "зависимости", "или", "критерия", "на", "от", "последовательное", "разбиение", "расположение", "Сортировка", "чего-либо", "это" };
            string[] d = new string[] { "Сортировка", "это", "последовательное", "расположение", "или", "разбиение", "на", "группы", "чего-либо", "в", "зависимости", "от", "выбранного", "критерия" };
            string[] d1 = new string[] { "это", "чего-либо", "Сортировка", "расположение", "разбиение", "последовательное", "от", "на", "критерия", "или", "зависимости", "группы", "выбранного", "в" };
            double[] e = new double[] { 5.06, -3.13, 9.33, -3.94, 6.20, 1.44, 6.87, 5.93, -4.54, -2.98, -8.80, 4.29, 0.59, 7.10, 2.01, 7.87, 9.04, -1.05, 8.67, 0.05 };
            double[] e1 = new double[] { -8.80, -4.54, -3.94, -3.13, -2.98, -1.05, 0.05, 0.59, 1.44, 2.01, 4.29, 5.06, 5.93, 6.20, 6.87, 7.10, 7.87, 8.67, 9.04, 9.33 };
            double[] f = new double[] { 5.06, -3.13, 9.33, -3.94, 6.20, 1.44, 6.87, 5.93, -4.54, -2.98, -8.80, 4.29, 0.59, 7.10, 2.01, 7.87, 9.04, -1.05, 8.67, 0.05 };
            double[] f1 = new double[] { 9.33, 9.04, 8.67, 7.87, 7.10, 6.87, 6.20, 5.93, 5.06, 4.29, 2.01, 1.44, 0.59, 0.05, -1.05, -2.98, -3.13, -3.94, -4.54, -8.80 };
            Sort.InsertSort(a, true, sourse);
            Sort.InsertSort(b, false, sourse);
            Sort.InsertSort(c, true, sourse);
            Sort.InsertSort(d, false, sourse);
            Sort.InsertSort(e, true, sourse);
            Sort.InsertSort(f, false, sourse);
            CollectionAssert.AreEqual(a, a1);
            CollectionAssert.AreEqual(b, b1);
            CollectionAssert.AreEqual(c, c1);
            CollectionAssert.AreEqual(d, d1);
            CollectionAssert.AreEqual(e, e1);
            CollectionAssert.AreEqual(f, f1);
        }
        [TestMethod]
        public void MergeSort_ReturnsArr()
        {
            int[] a = new int[] { 8, 6, 0, 5, 1, 4, 9, 2, 7, 10, 3 };
            int[] a1 = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] b = new int[] { 8, 6, 0, 5, 1, 4, 9, 2, 7, 10, 3 };
            int[] b1 = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            string[] c = new string[] { "Сортировка", "это", "последовательное", "расположение", "или", "разбиение", "на", "группы", "чего-либо", "в", "зависимости", "от", "выбранного", "критерия" };
            string[] c1 = new string[] { "в", "выбранного", "группы", "зависимости", "или", "критерия", "на", "от", "последовательное", "разбиение", "расположение", "Сортировка", "чего-либо", "это" };
            string[] d = new string[] { "Сортировка", "это", "последовательное", "расположение", "или", "разбиение", "на", "группы", "чего-либо", "в", "зависимости", "от", "выбранного", "критерия" };
            string[] d1 = new string[] { "это", "чего-либо", "Сортировка", "расположение", "разбиение", "последовательное", "от", "на", "критерия", "или", "зависимости", "группы", "выбранного", "в" };
            double[] e = new double[] { 5.06, -3.13, 9.33, -3.94, 6.20, 1.44, 6.87, 5.93, -4.54, -2.98, -8.80, 4.29, 0.59, 7.10, 2.01, 7.87, 9.04, -1.05, 8.67, 0.05 };
            double[] e1 = new double[] { -8.80, -4.54, -3.94, -3.13, -2.98, -1.05, 0.05, 0.59, 1.44, 2.01, 4.29, 5.06, 5.93, 6.20, 6.87, 7.10, 7.87, 8.67, 9.04, 9.33 };
            double[] f = new double[] { 5.06, -3.13, 9.33, -3.94, 6.20, 1.44, 6.87, 5.93, -4.54, -2.98, -8.80, 4.29, 0.59, 7.10, 2.01, 7.87, 9.04, -1.05, 8.67, 0.05 };
            double[] f1 = new double[] { 9.33, 9.04, 8.67, 7.87, 7.10, 6.87, 6.20, 5.93, 5.06, 4.29, 2.01, 1.44, 0.59, 0.05, -1.05, -2.98, -3.13, -3.94, -4.54, -8.80 };
            Sort.MergeSort(a, true, 0, a.Length - 1, sourse);
            Sort.MergeSort(b, false, 0, b.Length - 1, sourse);
            Sort.MergeSort(c, true, 0, c.Length - 1, sourse);
            Sort.MergeSort(d, false, 0, d.Length - 1, sourse);
            Sort.MergeSort(e, true, 0, e.Length - 1, sourse);
            Sort.MergeSort(f, false, 0, f.Length - 1, sourse);
            CollectionAssert.AreEqual(a, a1);
            CollectionAssert.AreEqual(b, b1);
            CollectionAssert.AreEqual(c, c1);
            CollectionAssert.AreEqual(d, d1);
            CollectionAssert.AreEqual(e, e1);
            CollectionAssert.AreEqual(f, f1);
        }
        [TestMethod]
        public void QuickSort_ReturnsArr()
        {
            int[] a = new int[] { 8, 6, 0, 5, 1, 4, 9, 2, 7, 10, 3 };
            int[] a1 = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] b = new int[] { 8, 6, 0, 5, 1, 4, 9, 2, 7, 10, 3 };
            int[] b1 = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            string[] c = new string[] { "Сортировка", "это", "последовательное", "расположение", "или", "разбиение", "на", "группы", "чего-либо", "в", "зависимости", "от", "выбранного", "критерия" };
            string[] c1 = new string[] { "в", "выбранного", "группы", "зависимости", "или", "критерия", "на", "от", "последовательное", "разбиение", "расположение", "Сортировка", "чего-либо", "это" };
            string[] d = new string[] { "Сортировка", "это", "последовательное", "расположение", "или", "разбиение", "на", "группы", "чего-либо", "в", "зависимости", "от", "выбранного", "критерия" };
            string[] d1 = new string[] { "это", "чего-либо", "Сортировка", "расположение", "разбиение", "последовательное", "от", "на", "критерия", "или", "зависимости", "группы", "выбранного", "в" };
            double[] e = new double[] { 5.06, -3.13, 9.33, -3.94, 6.20, 1.44, 6.87, 5.93, -4.54, -2.98, -8.80, 4.29, 0.59, 7.10, 2.01, 7.87, 9.04, -1.05, 8.67, 0.05 };
            double[] e1 = new double[] { -8.80, -4.54, -3.94, -3.13, -2.98, -1.05, 0.05, 0.59, 1.44, 2.01, 4.29, 5.06, 5.93, 6.20, 6.87, 7.10, 7.87, 8.67, 9.04, 9.33 };
            double[] f = new double[] { 5.06, -3.13, 9.33, -3.94, 6.20, 1.44, 6.87, 5.93, -4.54, -2.98, -8.80, 4.29, 0.59, 7.10, 2.01, 7.87, 9.04, -1.05, 8.67, 0.05 };
            double[] f1 = new double[] { 9.33, 9.04, 8.67, 7.87, 7.10, 6.87, 6.20, 5.93, 5.06, 4.29, 2.01, 1.44, 0.59, 0.05, -1.05, -2.98, -3.13, -3.94, -4.54, -8.80 };
            Sort.QuickSort(a, true, 0, a.Length - 1, sourse);
            Sort.QuickSort(b, false, 0, b.Length - 1, sourse);
            Sort.QuickSort(c, true, 0, c.Length - 1, sourse);
            Sort.QuickSort(d, false, 0, d.Length - 1, sourse);
            Sort.QuickSort(e, true, 0, e.Length - 1, sourse);
            Sort.QuickSort(f, false, 0, f.Length - 1, sourse);
            CollectionAssert.AreEqual(a, a1);
            CollectionAssert.AreEqual(b, b1);
            CollectionAssert.AreEqual(c, c1);
            CollectionAssert.AreEqual(d, d1);
            CollectionAssert.AreEqual(e, e1);
            CollectionAssert.AreEqual(f, f1);
        }
        [TestMethod]
        public void Compare_ReturnsIndex()
        {
            Assert.AreEqual(Sort.Compare(1, 1), 0);
            Assert.AreEqual(Sort.Compare(2, 1), 1);
            Assert.AreEqual(Sort.Compare(1, 2), -1);
        }
    }
}