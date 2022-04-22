namespace ClassLibrarySort
{
    public static class Sort
    {
        #region Random arrays
        static Random random = new Random();
        static string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        /// <summary>
        /// Генерирует массив из n случайных чисел типа int в диапазоне [min, max).
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
                res[i] = random.Next(min, max);
            }
            return res;
        }

        /// <summary>
        /// Генерирует массив из n случайных чисел типа double в диапазоне [min, max).
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
        /// Генерирует массив из n случайных чисел типа long в диапазоне [min, max).
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
                res[i] = GenerateRandomLong(min, max);
            }
            return res;
        }

        /// <summary>
        /// Генерирует случайное число типа long в диапазоне [min, max)
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
        /// Генерирует массив из n строк, состоящих из заглавных латинстких букв, длина которых в диапазоне [minLen, maxLen)
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
                int len = random.Next(minLen, maxLen);
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
    }
}