using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrarySort;
using System.Threading;

namespace TestProjectSort
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void BubbleSort_ReturnsArr()
        {
            int[] a = new int[] { 8, 6, 0, 5, 1, 4, 9, 2, 7, 10, 3 };
            CancellationToken a1 = new CancellationToken();
            int[] a2 = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] b = new int[] { 8, 6, 0, 5, 1, 4, 9, 2, 7, 10, 3 };
            CancellationToken b1 = new CancellationToken();
            int[] b2 = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            string[] c = new string[] { "Сортировка", "это", "последовательное", "расположение", "или", "разбиение", "на", "группы", "чего-либо", "в", "зависимости", "от", "выбранного", "критерия" };
            CancellationToken c1 = new CancellationToken();
            string[] c2 = new string[] { "в", "выбранного", "группы", "зависимости", "или", "критерия", "на", "от", "последовательное", "разбиение", "расположение", "Сортировка", "чего-либо", "это" };
            string[] d = new string[] { "Сортировка", "это", "последовательное", "расположение", "или", "разбиение", "на", "группы", "чего-либо", "в", "зависимости", "от", "выбранного", "критерия" };
            CancellationToken d1 = new CancellationToken();
            string[] d2 = new string[] { "это", "чего-либо", "Сортировка", "расположение", "разбиение", "последовательное", "от", "на", "критерия", "или", "зависимости", "группы", "выбранного", "в" };
            double[] e = new double[] { 5.06, -3.13, 9.33, -3.94, 6.20, 1.44, 6.87, 5.93, -4.54, -2.98, -8.80, 4.29, 0.59, 7.10, 2.01, 7.87, 9.04, -1.05, 8.67, 0.05 };
            CancellationToken e1 = new CancellationToken();
            double[] e2 = new double[] { -8.80, -4.54, -3.94, -3.13, -2.98, -1.05, 0.05, 0.59, 1.44, 2.01, 4.29, 5.06, 5.93, 6.20, 6.87, 7.10, 7.87, 8.67, 9.04, 9.33 };
            double[] f = new double[] { 5.06, -3.13, 9.33, -3.94, 6.20, 1.44, 6.87, 5.93, -4.54, -2.98, -8.80, 4.29, 0.59, 7.10, 2.01, 7.87, 9.04, -1.05, 8.67, 0.05 };
            CancellationToken f1 = new CancellationToken();
            double[] f2 = new double[] { 9.33, 9.04, 8.67, 7.87, 7.10, 6.87, 6.20, 5.93, 5.06, 4.29, 2.01, 1.44, 0.59, 0.05, -1.05, -2.98, -3.13, -3.94, -4.54, -8.80 };
            Sort.BubbleSort(a, true, a1);
            Sort.BubbleSort(b, false, b1);
            Sort.BubbleSort(c, true, c1);
            Sort.BubbleSort(d, false, d1);
            Sort.BubbleSort(e, true, e1);
            Sort.BubbleSort(f, false, f1);
            CollectionAssert.AreEqual(a, a2);
            CollectionAssert.AreEqual(b, b2);
            CollectionAssert.AreEqual(c, c2);
            CollectionAssert.AreEqual(d, d2);
            CollectionAssert.AreEqual(e, e2);
            CollectionAssert.AreEqual(f, f2);
        }
        [TestMethod]
        public void InsertSort_ReturnsArr()
        {
            int[] a = new int[] { 8, 6, 0, 5, 1, 4, 9, 2, 7, 10, 3 };
            CancellationToken a1 = new CancellationToken();
            int[] a2 = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] b = new int[] { 8, 6, 0, 5, 1, 4, 9, 2, 7, 10, 3 };
            CancellationToken b1 = new CancellationToken();
            int[] b2 = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            string[] c = new string[] { "Сортировка", "это", "последовательное", "расположение", "или", "разбиение", "на", "группы", "чего-либо", "в", "зависимости", "от", "выбранного", "критерия" };
            CancellationToken c1 = new CancellationToken();
            string[] c2 = new string[] { "в", "выбранного", "группы", "зависимости", "или", "критерия", "на", "от", "последовательное", "разбиение", "расположение", "Сортировка", "чего-либо", "это" };
            string[] d = new string[] { "Сортировка", "это", "последовательное", "расположение", "или", "разбиение", "на", "группы", "чего-либо", "в", "зависимости", "от", "выбранного", "критерия" };
            CancellationToken d1 = new CancellationToken();
            string[] d2 = new string[] { "это", "чего-либо", "Сортировка", "расположение", "разбиение", "последовательное", "от", "на", "критерия", "или", "зависимости", "группы", "выбранного", "в" };
            double[] e = new double[] { 5.06, -3.13, 9.33, -3.94, 6.20, 1.44, 6.87, 5.93, -4.54, -2.98, -8.80, 4.29, 0.59, 7.10, 2.01, 7.87, 9.04, -1.05, 8.67, 0.05 };
            CancellationToken e1 = new CancellationToken();
            double[] e2 = new double[] { -8.80, -4.54, -3.94, -3.13, -2.98, -1.05, 0.05, 0.59, 1.44, 2.01, 4.29, 5.06, 5.93, 6.20, 6.87, 7.10, 7.87, 8.67, 9.04, 9.33 };
            double[] f = new double[] { 5.06, -3.13, 9.33, -3.94, 6.20, 1.44, 6.87, 5.93, -4.54, -2.98, -8.80, 4.29, 0.59, 7.10, 2.01, 7.87, 9.04, -1.05, 8.67, 0.05 };
            CancellationToken f1 = new CancellationToken();
            double[] f2 = new double[] { 9.33, 9.04, 8.67, 7.87, 7.10, 6.87, 6.20, 5.93, 5.06, 4.29, 2.01, 1.44, 0.59, 0.05, -1.05, -2.98, -3.13, -3.94, -4.54, -8.80 };
            Sort.InsertSort(a, true, a1);
            Sort.InsertSort(b, false, b1);
            Sort.InsertSort(c, true, c1);
            Sort.InsertSort(d, false, d1);
            Sort.InsertSort(e, true, e1);
            Sort.InsertSort(f, false, f1);
            CollectionAssert.AreEqual(a, a2);
            CollectionAssert.AreEqual(b, b2);
            CollectionAssert.AreEqual(c, c2);
            CollectionAssert.AreEqual(d, d2);
            CollectionAssert.AreEqual(e, e2);
            CollectionAssert.AreEqual(f, f2);
        }
        [TestMethod]
        public void MergeSort_ReturnsArr()
        {
            int[] a = new int[] { 8, 6, 0, 5, 1, 4, 9, 2, 7, 10, 3 };
            CancellationToken a1 = new CancellationToken();
            int[] a2 = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] b = new int[] { 8, 6, 0, 5, 1, 4, 9, 2, 7, 10, 3 };
            CancellationToken b1 = new CancellationToken();
            int[] b2 = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            string[] c = new string[] { "Сортировка", "это", "последовательное", "расположение", "или", "разбиение", "на", "группы", "чего-либо", "в", "зависимости", "от", "выбранного", "критерия" };
            CancellationToken c1 = new CancellationToken();
            string[] c2 = new string[] { "в", "выбранного", "группы", "зависимости", "или", "критерия", "на", "от", "последовательное", "разбиение", "расположение", "Сортировка", "чего-либо", "это" };
            string[] d = new string[] { "Сортировка", "это", "последовательное", "расположение", "или", "разбиение", "на", "группы", "чего-либо", "в", "зависимости", "от", "выбранного", "критерия" };
            CancellationToken d1 = new CancellationToken();
            string[] d2 = new string[] { "это", "чего-либо", "Сортировка", "расположение", "разбиение", "последовательное", "от", "на", "критерия", "или", "зависимости", "группы", "выбранного", "в" };
            double[] e = new double[] { 5.06, -3.13, 9.33, -3.94, 6.20, 1.44, 6.87, 5.93, -4.54, -2.98, -8.80, 4.29, 0.59, 7.10, 2.01, 7.87, 9.04, -1.05, 8.67, 0.05 };
            CancellationToken e1 = new CancellationToken();
            double[] e2 = new double[] { -8.80, -4.54, -3.94, -3.13, -2.98, -1.05, 0.05, 0.59, 1.44, 2.01, 4.29, 5.06, 5.93, 6.20, 6.87, 7.10, 7.87, 8.67, 9.04, 9.33 };
            double[] f = new double[] { 5.06, -3.13, 9.33, -3.94, 6.20, 1.44, 6.87, 5.93, -4.54, -2.98, -8.80, 4.29, 0.59, 7.10, 2.01, 7.87, 9.04, -1.05, 8.67, 0.05 };
            CancellationToken f1 = new CancellationToken();
            double[] f2 = new double[] { 9.33, 9.04, 8.67, 7.87, 7.10, 6.87, 6.20, 5.93, 5.06, 4.29, 2.01, 1.44, 0.59, 0.05, -1.05, -2.98, -3.13, -3.94, -4.54, -8.80 };
            Sort.MergeSort(a, true, 0, a.Length - 1, a1);
            Sort.MergeSort(b, false, 0, b.Length - 1, b1);
            Sort.MergeSort(c, true, 0, c.Length - 1, c1);
            Sort.MergeSort(d, false, 0, d.Length - 1, d1);
            Sort.MergeSort(e, true, 0, e.Length - 1, e1);
            Sort.MergeSort(f, false, 0, f.Length - 1, f1);
            CollectionAssert.AreEqual(a, a2);
            CollectionAssert.AreEqual(b, b2);
            CollectionAssert.AreEqual(c, c2);
            CollectionAssert.AreEqual(d, d2);
            CollectionAssert.AreEqual(e, e2);
            CollectionAssert.AreEqual(f, f2);
        }
        [TestMethod]
        public void QuickSort_ReturnsArr()
        {
            int[] a = new int[] { 8, 6, 0, 5, 1, 4, 9, 2, 7, 10, 3 };
            CancellationToken a1 = new CancellationToken();
            int[] a2 = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] b = new int[] { 8, 6, 0, 5, 1, 4, 9, 2, 7, 10, 3 };
            CancellationToken b1 = new CancellationToken();
            int[] b2 = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            string[] c = new string[] { "Сортировка", "это", "последовательное", "расположение", "или", "разбиение", "на", "группы", "чего-либо", "в", "зависимости", "от", "выбранного", "критерия" };
            CancellationToken c1 = new CancellationToken();
            string[] c2 = new string[] { "в", "выбранного", "группы", "зависимости", "или", "критерия", "на", "от", "последовательное", "разбиение", "расположение", "Сортировка", "чего-либо", "это" };
            string[] d = new string[] { "Сортировка", "это", "последовательное", "расположение", "или", "разбиение", "на", "группы", "чего-либо", "в", "зависимости", "от", "выбранного", "критерия" };
            CancellationToken d1 = new CancellationToken();
            string[] d2 = new string[] { "это", "чего-либо", "Сортировка", "расположение", "разбиение", "последовательное", "от", "на", "критерия", "или", "зависимости", "группы", "выбранного", "в" };
            double[] e = new double[] { 5.06, -3.13, 9.33, -3.94, 6.20, 1.44, 6.87, 5.93, -4.54, -2.98, -8.80, 4.29, 0.59, 7.10, 2.01, 7.87, 9.04, -1.05, 8.67, 0.05 };
            CancellationToken e1 = new CancellationToken();
            double[] e2 = new double[] { -8.80, -4.54, -3.94, -3.13, -2.98, -1.05, 0.05, 0.59, 1.44, 2.01, 4.29, 5.06, 5.93, 6.20, 6.87, 7.10, 7.87, 8.67, 9.04, 9.33 };
            double[] f = new double[] { 5.06, -3.13, 9.33, -3.94, 6.20, 1.44, 6.87, 5.93, -4.54, -2.98, -8.80, 4.29, 0.59, 7.10, 2.01, 7.87, 9.04, -1.05, 8.67, 0.05 };
            CancellationToken f1 = new CancellationToken();
            double[] f2 = new double[] { 9.33, 9.04, 8.67, 7.87, 7.10, 6.87, 6.20, 5.93, 5.06, 4.29, 2.01, 1.44, 0.59, 0.05, -1.05, -2.98, -3.13, -3.94, -4.54, -8.80 };
            Sort.QuickSort(a, true, 0, a.Length - 1, a1);
            Sort.QuickSort(b, false, 0, b.Length - 1, b1);
            Sort.QuickSort(c, true, 0, c.Length - 1, c1);
            Sort.QuickSort(d, false, 0, d.Length - 1, d1);
            Sort.QuickSort(e, true, 0, e.Length - 1, e1);
            Sort.QuickSort(f, false, 0, f.Length - 1, f1);
            CollectionAssert.AreEqual(a, a2);
            CollectionAssert.AreEqual(b, b2);
            CollectionAssert.AreEqual(c, c2);
            CollectionAssert.AreEqual(d, d2);
            CollectionAssert.AreEqual(e, e2);
            CollectionAssert.AreEqual(f, f2);
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