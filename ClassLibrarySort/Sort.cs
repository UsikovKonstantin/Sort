namespace ClassLibrarySort
{
    public static class Sort
    {
        #region Random arrays
        static Random random = new Random();
        static string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        /// <summary>
        /// Генерирует массив из n случайных чисел типа int в диапазоне [min, max].
        /// </summary>
        /// <param name="min"> минимальное число </param>
        /// <param name="max"> максимальное число </param>
        /// <param name="n"> количесво чисел </param>
        /// <returns> массив случайных чисел </returns>
        public static int[] GenerateArrayInt(int min, int max, long n)
        {
            int[] res = new int[n];
            for (int i = 0; i < n; i++)
            {
                res[i] = random.Next(min, max + 1);
            }
            return res;
        }

        /// <summary>
        /// Генерирует массив из n случайных чисел типа double в диапазоне [min, max].
        /// </summary>
        /// <param name="min"> минимальное число </param>
        /// <param name="max"> максимальное число </param>
        /// <param name="n"> количесво чисел </param>
        /// <returns> массив случайных чисел </returns>
        public static double[] GenerateArrayDouble(double min, double max, long n)
        {
            double[] res = new double[n];
            for (int i = 0; i < n; i++)
            {
                res[i] = min + random.NextDouble() * (max - min);
            }
            return res;
        }

        /// <summary>
        /// Генерирует массив из n случайных чисел типа long в диапазоне [min, max].
        /// </summary>
        /// <param name="min"> минимальное число </param>
        /// <param name="max"> максимальное число </param>
        /// <param name="n"> количесво чисел </param>
        /// <returns> массив случайных чисел </returns>
        public static long[] GenerateArrayLong(long min, long max, long n)
        {
            long[] res = new long[n];
            for (int i = 0; i < n; i++)
            {
                res[i] = GenerateRandomLong(min, max + 1);
            }
            return res;
        }

        /// <summary>
        /// Генерирует случайное число типа long в диапазоне [min, max]
        /// </summary>
        /// <param name="min"> минимальное число </param>
        /// <param name="max"> максимальное число </param>
        /// <returns> случайное число </returns>
        public static long GenerateRandomLong(long min, long max)
        {
            byte[] buf = new byte[8];
            random.NextBytes(buf);
            long longRand = BitConverter.ToInt64(buf, 0);
            return Math.Abs(longRand % (max - min)) + min;
        }

        /// <summary>
        /// Генерирует массив из n строк, состоящих из заглавных латинстких букв, длина которых в диапазоне [minLen, maxLen]
        /// </summary>
        /// <param name="minLen"> минимальная длина </param>
        /// <param name="maxLen"> максимальная длина </param>
        /// <param name="n"> количесво строк </param>
        /// <returns> массив случайных чисел </returns>
        public static string[] GenerateArrayString(int minLen, int maxLen, long n)
        {
            string[] res = new string[n];
            for (int i = 0; i < n; i++)
            {
                int len = random.Next(minLen, maxLen + 1);
                char[] str = new char[len];
                for (int j = 0; j < len; j++)
                {
                    str[j] = letters[random.Next(0, 26)];
                }
                res[i] = new string(str);
            }
            return res;
        }
        #endregion

        #region Sort
        /// <summary>
        /// Сортировка пузырьком.
        /// </summary>
        /// <typeparam name="T"> тип массива </typeparam>
        /// <param name="arr"> массив для сортировки </param>
        /// <param name="ascending"> если по возрастанию - true, иначе - false </param>
        public static void BubbleSort<T>(T[] arr, bool ascending)
        {
            bool swaps;
            for (int i = arr.Length - 1; i > 0; i--)
            {
                swaps = false;
                for (int j = 0; j < i; j++)
                {
                    if (ascending ? Compare(arr[j], arr[j + 1]) == 1 : Compare(arr[j], arr[j + 1]) == -1)
                    {
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                        swaps = true;
                    }
                }
                if (!swaps)
                {
                    break;
                }
            }
        }

        /// <summary>
        /// Сортировка вставками.
        /// </summary>
        /// <typeparam name="T"> тип массива </typeparam>
        /// <param name="arr"> массив для сортировки </param>
        /// <param name="ascending"> если по возрастанию - true, иначе - false </param>
        public static void InsertSort<T>(T[] arr, bool ascending)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int j = i;
                while (ascending ? Compare(arr[j], arr[j - 1]) == -1 : Compare(arr[j], arr[j - 1]) == 1)
                {
                    (arr[j], arr[j - 1]) = (arr[j - 1], arr[j]);
                    j--;
                    if (j == 0)
                    {
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Сортировка слиянием.
        /// </summary>
        /// <typeparam name="T"> тип массива </typeparam>
        /// <param name="arr"> массив для сортировки </param>
        /// <param name="ascending"> если по возрастанию - true, иначе - false </param>
        /// <param name="left"> левая граница сортировки (как правило, 0) </param>
        /// <param name="right"> правая граница сортировки (как правило, длина массива - 1) </param>
        public static void MergeSort<T>(T[] arr, bool ascending, int left, int right)
        {
            if (right - left > 1)
            {
                int a1 = left;
                int b1 = (left + right) / 2;
                int a2 = (left + right) / 2 + 1;
                int b2 = right;
                MergeSort(arr, ascending, a1, b1);
                MergeSort(arr, ascending, a2, b2);
                T[] M = new T[right - left + 1];
                for (int k = left; k <= right; k++)
                    M[k - left] = arr[k];
                int i = a1;
                int j = a2;
                for (int k = left; k <= right; k++)
                    if (i <= b1 && j <= b2)
                        if (ascending ? Compare(M[i - left], M[j - left]) == 1 : Compare(M[i - left], M[j - left]) == -1)
                        {
                            arr[k] = M[i - left];
                            i++;
                        }
                        else
                        {
                            arr[k] = M[j - left];
                            j++;
                        } 
                    else
                        if (i > b1)
                        {
                            arr[k] = M[j - left];
                            j++;
                        }
                        else
                        {
                            arr[k] = M[i - left];
                            i++;
                        }
                
            }
            else
                if (right - left == 1)
                    if (ascending ? Compare(arr[left], arr[right]) == -1 : Compare(arr[left], arr[right]) == 1)
                        (arr[left], arr[right]) = (arr[right], arr[left]);
        }

        /// <summary>
        /// Быстрая сортировка.
        /// </summary>
        /// <typeparam name="T"> тип массива </typeparam>
        /// <param name="arr"> массив для сортировки </param>
        /// <param name="ascending"> если по возрастанию - true, иначе - false </param>
        /// <param name="left"> левая граница сортировки (как правило, 0) </param>
        /// <param name="right"> правая граница сортировки (как правило, длина массива - 1) </param>
        public static void QuickSort<T>(T[] arr, bool ascending, int left, int right)
        {
            int a = left;
            int b = right;
            T p = arr[(left + right) / 2];
            while (a < b)
            {
                while (ascending ? Compare(arr[a], p) == -1 : Compare(arr[a], p) == 1)
                    a++;
                while (ascending ? Compare(arr[b], p) == 1 : Compare(arr[b], p) == -1)
                    b--;
                if (a <= b)
                {
                    (arr[a], arr[b]) = (arr[b], arr[a]);
                    a++;
                    b--;
                }
            }
            if (left < b)
                QuickSort(arr, ascending, left, b);
            if (a < right)
                QuickSort(arr, ascending, a, right);
        }

        /// <summary>
        /// Сравнение двух объектов (o1 и o2).
        /// </summary>
        /// <param name="o1"> первый объект </param>
        /// <param name="o2"> второй объект </param>
        /// <returns> 1, если o1 > o2; -1, если o1 < o2; 0, если o1 == o2 </returns>
        public static int Compare(object o1, object o2)
        {
            if (o1 is string)
                return string.Compare(o1.ToString(), o2.ToString());
            else 
                if (Convert.ToDouble(o1) < Convert.ToDouble(o2))
                    return -1;
                else if (Convert.ToDouble(o1) > Convert.ToDouble(o2))
                    return 1;
                else
                    return 0;
        }
        #endregion
    }
}