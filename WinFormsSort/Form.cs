using ClassLibrarySort;
namespace WinFormsSort
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
            Update_Gen_Labels();
        }

        private void Tx_Test_Count_TextChanged(object sender, EventArgs e)
        {
            Terminate_all();
            if (Tx_Test_Count.Text == "")
            {
                Tx_Test_Count.Text = "1";
            }
            try
            {
                int.Parse(Tx_Test_Count.Text);
            }
            catch (Exception)
            {
                string resu = "";
                for (int i = 0; i < Tx_Test_Count.TextLength; i++)
                {
                    if (Tx_Test_Count.Text[i] >= '0' && Tx_Test_Count.Text[i] <= '9')
                    {
                        resu += Tx_Test_Count.Text[i];
                    }
                }
                Tx_Test_Count.Text = resu;
            }

            if (int.Parse(Tx_Test_Count.Text) > 1000)
            {
                Tx_Test_Count.Text = "1000";
            }
            if (int.Parse(Tx_Test_Count.Text) < 1)
            {
                Tx_Test_Count.Text = "1";
            }

        }
        private void Tx_Min_TextChanged(object sender, EventArgs e)
        {
            Terminate_all();
            Tx_Unsorted.Text = "";
            Tx_Sorted.Text = "";
            Bt_Test.Enabled = false;
            if (Tx_Min.Text == "")
            {
                Tx_Min.Text = "1";
            }
            if (Ch_Int.Checked)
            {
                try
                {
                    int.Parse(Tx_Min.Text);
                }
                catch (Exception)
                {
                    string resu = "";
                    for (int i = 0; i < Tx_Min.TextLength; i++)
                    {
                        if (Tx_Min.Text[i] >= '0' && Tx_Min.Text[i] <= '9')
                        {
                            resu += Tx_Min.Text[i];
                        }
                    }
                    Tx_Min.Text = resu;
                }
                if (double.Parse(Tx_Min.Text) > int.MaxValue - 1)
                {
                    Tx_Min.Text = (int.MaxValue - 1).ToString();
                }
                if (double.Parse(Tx_Min.Text) < int.MinValue)
                {
                    Tx_Min.Text = int.MinValue.ToString();
                }
            }
            else if (Ch_Long.Checked)
            {
                try
                {
                    long.Parse(Tx_Min.Text);
                }
                catch (Exception)
                {
                    string resu = "";
                    for (int i = 0; i < Tx_Min.TextLength; i++)
                    {
                        if (Tx_Min.Text[i] >= '0' && Tx_Min.Text[i] <= '9')
                        {
                            resu += Tx_Min.Text[i];
                        }
                    }
                    Tx_Min.Text = resu;
                }
                if (double.Parse(Tx_Min.Text) > long.MaxValue - 1)
                {
                    Tx_Min.Text = (long.MaxValue - 1).ToString();
                }
                if (double.Parse(Tx_Min.Text) < long.MinValue)
                {
                    Tx_Min.Text = long.MinValue.ToString();
                }
            }
            else if (Ch_Double.Checked)
            {
                string resu;
                try
                {
                    double.Parse(Tx_Min.Text);
                }
                catch (Exception)
                {
                    resu = "";
                    for (int i = 0; i < Tx_Min.TextLength; i++)
                    {
                        if (Tx_Min.Text[i] >= '0' && Tx_Min.Text[i] <= '9')
                        {
                            resu += Tx_Min.Text[i];
                        }
                    }
                    Tx_Min.Text = resu;
                }
                resu = "";
                for (int i = 0; i < Tx_Min.TextLength; i++)
                {
                    if ((Tx_Min.Text[i] >= '0' && Tx_Min.Text[i] <= '9') || Tx_Min.Text[i] == System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator.ToCharArray()[0] || (Tx_Min.Text[i] == 'E') || (Tx_Min.Text[i] == '+') || (Tx_Min.Text[i] == '-'))
                    {
                        resu += Tx_Min.Text[i];
                    }
                }
                Tx_Min.Text = resu;
                if (double.Parse(Tx_Min.Text) > 1e50)
                {
                    Tx_Min.Text = (1e50).ToString();
                }
                if (double.Parse(Tx_Min.Text) < -1e50)
                {
                    Tx_Min.Text = (-1e50).ToString();
                }
            }
            else
            {
                try
                {
                    int.Parse(Tx_Min.Text);
                }
                catch (Exception)
                {
                    string resu = "";
                    for (int i = 0; i < Tx_Min.TextLength; i++)
                    {
                        if (Tx_Min.Text[i] >= '0' && Tx_Min.Text[i] <= '9')
                        {
                            resu += Tx_Min.Text[i];
                        }
                    }
                    Tx_Min.Text = resu;
                }
                if (int.Parse(Tx_Min.Text) > 1000)
                {
                    Tx_Min.Text = "1000";
                }
                if (int.Parse(Tx_Min.Text) < 1)
                {
                    Tx_Min.Text = "1";
                }
            }

        }

        private void Tx_Max_TextChanged(object sender, EventArgs e)
        {
            Terminate_all();
            Tx_Unsorted.Text = "";
            Tx_Sorted.Text = "";
            Bt_Test.Enabled = false;
            if (Tx_Max.Text == "")
            {
                Tx_Max.Text = "1";
            }
            if (Ch_Int.Checked)
            {
                try
                {
                    int.Parse(Tx_Max.Text);
                }
                catch (Exception)
                {
                    string resu = "";
                    for (int i = 0; i < Tx_Max.TextLength; i++)
                    {
                        if (Tx_Max.Text[i] >= '0' && Tx_Max.Text[i] <= '9')
                        {
                            resu += Tx_Max.Text[i];
                        }
                    }
                    Tx_Max.Text = resu;
                }
                if (double.Parse(Tx_Max.Text) > int.MaxValue - 1)
                {
                    Tx_Max.Text = (int.MaxValue - 1).ToString();
                }
                if (double.Parse(Tx_Max.Text) < int.MinValue)
                {
                    Tx_Max.Text = int.MaxValue.ToString();
                }
            }
            else if (Ch_Long.Checked)
            {
                try
                {
                    long.Parse(Tx_Max.Text);
                }
                catch (Exception)
                {
                    string resu = "";
                    for (int i = 0; i < Tx_Max.TextLength; i++)
                    {
                        if (Tx_Max.Text[i] >= '0' && Tx_Max.Text[i] <= '9')
                        {
                            resu += Tx_Max.Text[i];
                        }
                    }
                    Tx_Max.Text = resu;
                }
                if (double.Parse(Tx_Max.Text) > long.MaxValue - 1)
                {
                    Tx_Max.Text = (long.MaxValue - 1).ToString();
                }
                if (double.Parse(Tx_Max.Text) < long.MinValue)
                {
                    Tx_Max.Text = long.MaxValue.ToString();
                }
            }
            else if (Ch_Double.Checked)
            {
                string resu;
                try
                {
                    double.Parse(Tx_Max.Text);
                }
                catch (Exception)
                {
                    resu = "";
                    for (int i = 0; i < Tx_Max.TextLength; i++)
                    {
                        if (Tx_Max.Text[i] >= '0' && Tx_Max.Text[i] <= '9')
                        {
                            resu += Tx_Max.Text[i];
                        }
                    }
                    Tx_Max.Text = resu;
                }
                resu = "";
                for (int i = 0; i < Tx_Max.TextLength; i++)
                {
                    if ((Tx_Max.Text[i] >= '0' && Tx_Max.Text[i] <= '9') || Tx_Max.Text[i] == System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator.ToCharArray()[0] || (Tx_Max.Text[i] == 'E') || (Tx_Max.Text[i] == '+') || (Tx_Max.Text[i] == '-'))
                    {
                        resu += Tx_Max.Text[i];
                    }
                }
                Tx_Max.Text = resu;
                if (double.Parse(Tx_Max.Text) > 1e50)
                {
                    Tx_Max.Text = (1e50).ToString();
                }
                if (double.Parse(Tx_Max.Text) < -1e50)
                {
                    Tx_Max.Text = (-1e50).ToString();
                }
            }
            else
            {
                try
                {
                    int.Parse(Tx_Max.Text);
                }
                catch (Exception)
                {
                    string resu = "";
                    for (int i = 0; i < Tx_Max.TextLength; i++)
                    {
                        if (Tx_Max.Text[i] >= '0' && Tx_Max.Text[i] <= '9')
                        {
                            resu += Tx_Max.Text[i];
                        }
                    }
                    Tx_Max.Text = resu;
                }
                if (int.Parse(Tx_Max.Text) > 50)
                {
                    Tx_Max.Text = "50";
                }
                if (int.Parse(Tx_Max.Text) < 1)
                {
                    Tx_Max.Text = "1";
                }
            }
        }

        private void Tx_Element_Count_TextChanged(object sender, EventArgs e)
        {
            Terminate_all();
            Tx_Unsorted.Text = "";
            Tx_Sorted.Text = "";
            Bt_Test.Enabled = false;
            if (Tx_Element_Count.Text == "")
            {
                Tx_Element_Count.Text = "1";
            }
            try
            {
                int.Parse(Tx_Element_Count.Text);
            }
            catch (Exception)
            {
                string resu = "";
                for (int i = 0; i < Tx_Element_Count.TextLength; i++)
                {
                    if (Tx_Element_Count.Text[i] >= '0' && Tx_Element_Count.Text[i] <= '9')
                    {
                        resu += Tx_Element_Count.Text[i];
                    }
                }
                Tx_Element_Count.Text = resu;
            }
            if (int.Parse(Tx_Element_Count.Text) > 10000)
            {
                Tx_Element_Count.Text = "10000";
            }
            if (int.Parse(Tx_Element_Count.Text) < 1)
            {
                Tx_Element_Count.Text = "1";
            }
        }

        private void Ch_Int_CheckedChanged(object sender, EventArgs e)
        {
            Terminate_all();
            Tx_Unsorted.Text = "";
            Tx_Sorted.Text = "";
            Bt_Test.Enabled = false;
            if (Ch_Int.Checked)
            {
                Ch_Long.Checked = false;
                Ch_Double.Checked = false;
                Ch_Str.Checked = false;
            }
            else if (!Ch_Int.Checked && !Ch_Long.Checked && !Ch_Double.Checked && !Ch_Str.Checked)
            {
                Ch_Int.Checked = true;
            }
            Update_Gen_Labels();
            Tx_Min_TextChanged(sender, e);
            Tx_Max_TextChanged(sender, e);
        }

        private void Ch_Long_CheckedChanged(object sender, EventArgs e)
        {
            Terminate_all();
            Tx_Unsorted.Text = "";
            Tx_Sorted.Text = "";
            Bt_Test.Enabled = false;
            if (Ch_Long.Checked)
            {
                Ch_Int.Checked = false;
                Ch_Double.Checked = false;
                Ch_Str.Checked = false;
            }
            else if (!Ch_Int.Checked && !Ch_Long.Checked && !Ch_Double.Checked && !Ch_Str.Checked)
            {
                Ch_Long.Checked = true;
            }
            Update_Gen_Labels();
            Tx_Min_TextChanged(sender, e);
            Tx_Max_TextChanged(sender, e);
        }

        private void Ch_Double_CheckedChanged(object sender, EventArgs e)
        {
            Terminate_all();
            Tx_Unsorted.Text = "";
            Tx_Sorted.Text = "";
            Bt_Test.Enabled = false;
            if (Ch_Double.Checked)
            {
                Ch_Long.Checked = false;
                Ch_Int.Checked = false;
                Ch_Str.Checked = false;
            }
            else if (!Ch_Int.Checked && !Ch_Long.Checked && !Ch_Double.Checked && !Ch_Str.Checked)
            {
                Ch_Double.Checked = true;
            }
            Update_Gen_Labels();
            Tx_Min_TextChanged(sender, e);
            Tx_Max_TextChanged(sender, e);
        }

        private void Ch_Str_CheckedChanged(object sender, EventArgs e)
        {
            Terminate_all();
            Tx_Unsorted.Text = "";
            Tx_Sorted.Text = "";
            Bt_Test.Enabled = false;
            if (Ch_Str.Checked)
            {
                Ch_Long.Checked = false;
                Ch_Double.Checked = false;
                Ch_Int.Checked = false;
            }
            else if (!Ch_Int.Checked && !Ch_Long.Checked && !Ch_Double.Checked && !Ch_Str.Checked)
            {
                Ch_Str.Checked = true;
            }
            Update_Gen_Labels();
            Tx_Min_TextChanged(sender, e);
            Tx_Max_TextChanged(sender, e);
        }
        void Update_Gen_Labels()
        {
            if (Ch_Str.Checked)
            {
                Lb_Max.Text = "Максимальная длина";
                Lb_Min.Text = "Минимальная длина";
            }
            else
            {
                Lb_Max.Text = "Максимальное значение";
                Lb_Min.Text = "Минимальное значение";
            }
        }
        List<(Thread thr, CancellationTokenSource cts)> threads = new();
        private void Bt_Generate_Click(object sender, EventArgs e)
        {
            Terminate_all();
            Tx_Sorted.Text = "";
            Bt_Test.Enabled = true;
            if (double.Parse(Tx_Min.Text) > double.Parse(Tx_Max.Text))
            {
                (Tx_Min.Text, Tx_Max.Text) = (Tx_Max.Text, Tx_Min.Text);
            }
            if (Ch_Int.Checked)
            {
                var lst = Sort.GenerateArrayInt(int.Parse(Tx_Min.Text), int.Parse(Tx_Max.Text), int.Parse(Tx_Element_Count.Text)).ToList();
                Tx_Unsorted.Text = Fast_Output(lst);
            }
            if (Ch_Long.Checked)
            {
                var lst = Sort.GenerateArrayLong(long.Parse(Tx_Min.Text), long.Parse(Tx_Max.Text), long.Parse(Tx_Element_Count.Text)).ToList();
                Tx_Unsorted.Text = Fast_Output(lst);
            }
            if (Ch_Double.Checked)
            {
                var lst = Sort.GenerateArrayDouble(double.Parse(Tx_Min.Text), double.Parse(Tx_Max.Text), long.Parse(Tx_Element_Count.Text)).ToList();
                Tx_Unsorted.Text = Fast_Output(lst);
            }
            if (Ch_Str.Checked)
            {
                var lst = Sort.GenerateArrayString(int.Parse(Tx_Min.Text), int.Parse(Tx_Max.Text), long.Parse(Tx_Element_Count.Text)).ToList();
                Tx_Unsorted.Text = Fast_Output(lst);
            }

        }
        string Fast_Output<T>(List<T> lst)
        {
            string output;
            long str_len_estimate = 0;
            for (int i = 0; i < lst.Count; i++)
            {
                str_len_estimate += lst[i].ToString().Length;
            }
            str_len_estimate += lst.Count - 1;
            char[] chars = new char[str_len_estimate];
            long index = 0;
            for (int i = 0; i < lst.Count; i++)
            {
                string number = lst[i].ToString();
                for (int j = 0; j < number.Length; j++)
                {
                    chars[index] = number[j];
                    index++;
                }
                if (i != lst.Count - 1)
                {
                    chars[index] = ',';
                }
                index++;
            }
            output = new string(chars);
            return output;
        }
        private void Bt_Test_Click(object sender, EventArgs e)
        {
            Terminate_all();
            Tx_Sorted.Text = "";
            int tests = int.Parse(Tx_Test_Count.Text);
            List<string> lss = Tx_Unsorted.Text.Split(',').ToList();
            if (Ch_Str.Checked)
            {
                Make_Sort(lss, tests);
            }
            if (Ch_Int.Checked)
            {
                List<int> lst = new();
                lst.Capacity = lss.Count;
                foreach (var item in lss)
                {
                    lst.Add(int.Parse(item));
                }
                Make_Sort(lst, tests);
            }
            if (Ch_Long.Checked)
            {
                List<long> lst = new();
                lst.Capacity = lss.Count;
                foreach (var item in lss)
                {
                    lst.Add(long.Parse(item));
                }
                Make_Sort(lst, tests);
            }
            if (Ch_Double.Checked)
            {
                List<double> lst = new();
                lst.Capacity = lss.Count;
                foreach (var item in lss)
                {
                    lst.Add(double.Parse(item));
                }
                Make_Sort(lst, tests);
            }

        }
        void Terminate_all()
        {
            for (int i = 0; i < threads.Count; i++)
            {
                if (threads[i].thr.Name == "For")
                {
                    threads[i].cts.Cancel();
                }
            }
            Thread.Sleep(10);
            for (int i = threads.Count - 1; i >= 0; i--)
            {
                threads[i].cts.Cancel();
                threads.RemoveAt(i);
            }
            threads.Clear();
        }
        void Make_Sort<T>(List<T> lss, int tests)
        {
            System.Diagnostics.Stopwatch bublw = new(), insew = new(), mergw = new(), quicw = new();
            Thread srqt = new(srq), srmt = new(srm), srit = new(sri), srbt = new(srb);
            void srq(object cto)
            {
                CancellationToken ct = (CancellationToken)cto;
                var lst = lss.ToArray();
                Sort.QuickSort(lst, Ch_Ascend.Checked, ct);
                Sort.QuickSort(lst, Ch_Ascend.Checked, 0, lst.Length - 1, ct);
                if (ct.IsCancellationRequested)
                {
                    return;
                }
                if (Tx_Sorted.Text == "")
                {
                    Invoke(() => Tx_Sorted.Text = Fast_Output(lst.ToList()));
                }
            }
            void srm(object cto)
            {
                CancellationToken ct = (CancellationToken)cto;
                var lst = lss.ToArray();
                Sort.MergeSort(lst, Ch_Ascend.Checked, ct);
                Sort.MergeSort(lst, Ch_Ascend.Checked, 0, lst.Length - 1, ct);
                if (ct.IsCancellationRequested)
                {
                    return;
                }
                if (Tx_Sorted.Text == "")
                {
                    Invoke(() => Tx_Sorted.Text = Fast_Output(lst.ToList()));
                }
            }
            void sri(object cto)
            {
                CancellationToken ct = (CancellationToken)cto;
                var lst = lss.ToArray();
                Sort.InsertSort(lst, Ch_Ascend.Checked, ct);
                if (ct.IsCancellationRequested)
                {
                    return;
                }
                if (Tx_Sorted.Text == "")
                {
                    Invoke(() => Tx_Sorted.Text = Fast_Output(lst.ToList()));
                }
            }
            void srb(object cto)
            {
                CancellationToken ct = (CancellationToken)cto;
                var lst = lss.ToArray();
                Sort.BubbleSort(lst, Ch_Ascend.Checked, ct);
                if (ct.IsCancellationRequested)
                {
                    return;
                }
                if (Tx_Sorted.Text == "")
                {
                    Invoke(() => Tx_Sorted.Text = Fast_Output(lst.ToList()));
                }
            }
            CancellationTokenSource srqc = new(), srmc = new(), sric = new(), srbc = new();
            threads.Add((srqt, srqc));
            threads.Add((srmt, srmc));
            threads.Add((srit, sric));
            threads.Add((srbt, srbc));
            srqt.Start(srqc.Token);
            srmt.Start(srmc.Token);
            srit.Start(sric.Token);
            srbt.Start(srbc.Token);
            Thread forbut = new(forbub), forint = new(forins), formet = new(former), forqut = new(forqui);
            CancellationTokenSource foric = new(), forbc = new(), formc = new(), forqc = new();
            forbut.Name = "For";
            forint.Name = "For";
            formet.Name = "For";
            forqut.Name = "For";
            threads.Add((forbut, forbc));
            threads.Add((forint, foric));
            threads.Add((formet, formc));
            threads.Add((forqut, forqc));
            forbut.Start(forbc.Token);
            forint.Start(foric.Token);
            formet.Start(formc.Token);
            forqut.Start(forqc.Token);
            bool Thr_Is_Run(string name)
            {
                for (int i = 0; i < threads.Count; i++)
                {
                    if (threads[i].thr.ThreadState == ThreadState.Running && threads[i].thr.Name == name)
                    {
                        return true;
                    }
                }
                return false;
            }
            void forbub(object cto)
            {
                CancellationToken ct = (CancellationToken)cto;
                for (int i = 0; i <= tests;)
                {

                    if (!Thr_Is_Run("bublt"))
                    {
                        i++;
                        Thread bublt = new(bublf);
                        bublt.Name = "bublt";
                        CancellationTokenSource cts = new();
                        threads.Add((bublt, cts));
                        if (i >= 2 && i % ((tests / 10) + 1) == 0)
                        {
                            string output = "";
                            output += $"Сортировка данного массива методом пузырька в среднем требует {Math.Round(bublw.Elapsed.TotalMilliseconds / i, 3)} мс {Environment.NewLine}";
                            output += "Тест в процессе выполнения";
                            Invoke(() => Tx_Test_Result_Bubble.Text = output);
                        }
                        if (ct.IsCancellationRequested)
                        {
                            return;
                        }
                        bublt.Start(cts.Token);
                    }
                    else
                    {
                        if (ct.IsCancellationRequested)
                        {
                            return;
                        }
                    }
                }
                string outrut = "";
                outrut += $"Сортировка данного массива методом пузырька в среднем требует {Math.Round(bublw.Elapsed.TotalMilliseconds / tests, 3)} мс {Environment.NewLine}";
                outrut += "Тест окончен";
                Invoke(() => Tx_Test_Result_Bubble.Text = outrut);
            }
            void forins(object cto)
            {
                CancellationToken ct = (CancellationToken)cto;
                for (int i = 0; i <= tests;)
                {
                    if (!Thr_Is_Run("inset"))
                    {
                        i++;
                        Thread inset = new(insef);
                        inset.Name = "inset";
                        CancellationTokenSource cts = new();
                        threads.Add((inset, cts));
                        if (i >= 2 && i % ((tests / 10) + 1) == 0)
                        {
                            string output = "";
                            output += $"Сортировка данного массива методом вставки в среднем требует {Math.Round(insew.Elapsed.TotalMilliseconds / i, 3)} мс {Environment.NewLine}";
                            output += "Тест в процессе выполнения";
                            Invoke(() => Tx_Test_Result_Insert.Text = output);
                        }
                        if (ct.IsCancellationRequested)
                        {
                            return;
                        }
                        inset.Start(cts.Token);
                    }
                    else
                    {
                        if (ct.IsCancellationRequested)
                        {
                            return;
                        }
                    }
                }
                string outrut = "";
                outrut += $"Сортировка данного массива методом вставки в среднем требует {Math.Round(insew.Elapsed.TotalMilliseconds / tests, 3)} мс {Environment.NewLine}";
                outrut += "Тест окончен";
                Invoke(() => Tx_Test_Result_Insert.Text = outrut);
            }
            void former(object cto)
            {
                CancellationToken ct = (CancellationToken)cto;
                for (int i = 0; i <= tests;)
                {

                    if (!Thr_Is_Run("mergt"))
                    {
                        i++;
                        Thread mergt = new(mergf);
                        mergt.Name = "mergt";
                        CancellationTokenSource cts = new();
                        threads.Add((mergt, cts));
                        if (i >= 2 && i % ((tests / 10) + 1) == 0)
                        {
                            string output = "";
                            output += $"Сортировка данного массива методом слияния в среднем требует {Math.Round(mergw.Elapsed.TotalMilliseconds / i, 3)} мс {Environment.NewLine}";
                            output += "Тест в процессе выполнения";
                            Invoke(() => Tx_Test_Result_Merge.Text = output);
                        }
                        if (ct.IsCancellationRequested)
                        {
                            return;
                        }
                        mergt.Start(cts.Token);
                    }
                    else
                    {
                        if (ct.IsCancellationRequested)
                        {
                            return;
                        }
                    }
                }
                string outrut = "";
                outrut += $"Сортировка данного массива методом слияния в среднем требует {Math.Round(mergw.Elapsed.TotalMilliseconds / tests, 3)} мс {Environment.NewLine}";
                outrut += "Тест окончен";
                Invoke(() => Tx_Test_Result_Merge.Text = outrut);
            }
            void forqui(object cto)
            {
                CancellationToken ct = (CancellationToken)cto;
                for (int i = 0; i <= tests;)
                {

                    if (!Thr_Is_Run("quict"))
                    {
                        i++;
                        Thread quict = new(quicf);
                        quict.Name = "quict";
                        CancellationTokenSource cts = new();
                        threads.Add((quict, cts));
                        if (i >= 2 && i % ((tests / 10) + 1) == 0)
                        {
                            string output = "";
                            output += $"Сортировка данного массива методом быстрой сортировки в среднем требует {Math.Round(quicw.Elapsed.TotalMilliseconds / i, 3)} мс {Environment.NewLine}";
                            output += "Тест в процессе выполнения";
                            Invoke(() => Tx_Test_Result_Quick.Text = output);
                        }
                        if (ct.IsCancellationRequested)
                        {
                            return;
                        }
                        quict.Start(cts.Token);
                    }
                    else
                    {
                        if (ct.IsCancellationRequested)
                        {
                            return;
                        }
                    }
                }
                string outrut = "";
                outrut += $"Сортировка данного массива методом быстрой сортировки в среднем требует {Math.Round(quicw.Elapsed.TotalMilliseconds / tests, 3)} мс {Environment.NewLine}";
                outrut += "Тест окончен";
                Invoke(() => Tx_Test_Result_Quick.Text = outrut);
            }
            void bublf(object cto)
            {
                CancellationToken ct = (CancellationToken)cto;
                bublw.Start();
                Sort.BubbleSort(lss.ToArray(), Ch_Ascend.Checked, ct);
                bublw.Stop();
            }

            void insef(object cto)
            {
                CancellationToken ct = (CancellationToken)cto;
                insew.Start();
                Sort.InsertSort(lss.ToArray(), Ch_Ascend.Checked, ct);
                insew.Stop();
            }

            void mergf(object cto)
            {
                CancellationToken ct = (CancellationToken)cto;
                mergw.Start();
                Sort.MergeSort(lss.ToArray(), Ch_Ascend.Checked, ct);
                Sort.MergeSort(lss.ToArray(), Ch_Ascend.Checked, 0, lss.Count - 1, ct);
                mergw.Stop();
            }

            void quicf(object cto)
            {
                CancellationToken ct = (CancellationToken)cto;
                quicw.Start();
                Sort.QuickSort(lss.ToArray(), Ch_Ascend.Checked, ct);
                Sort.QuickSort(lss.ToArray(), Ch_Ascend.Checked, 0, lss.Count - 1, ct);
                quicw.Stop();
            }
        }

        private void Ch_Ascend_CheckedChanged(object sender, EventArgs e)
        {
            Terminate_all();
            Tx_Sorted.Text = "";
        }
    }
}