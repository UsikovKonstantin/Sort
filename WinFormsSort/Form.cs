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
            if (Tx_Min.Text == "")
            {
                Tx_Min.Text = "1";
            }
            try
            {
                double.Parse(Tx_Min.Text);
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
            if (Ch_Int.Checked)
            {
                if (double.Parse(Tx_Min.Text) > int.MaxValue)
                {
                    Tx_Min.Text = int.MaxValue.ToString();
                }
                if (double.Parse(Tx_Min.Text) < int.MinValue)
                {
                    Tx_Min.Text = int.MinValue.ToString();
                }
            }
            else if (Ch_Long.Checked)
            {
                if (double.Parse(Tx_Min.Text) > long.MaxValue)
                {
                    Tx_Min.Text = long.MaxValue.ToString();
                }
                if (double.Parse(Tx_Min.Text) < long.MinValue)
                {
                    Tx_Min.Text = long.MinValue.ToString();
                }
            }
            else if (Ch_Double.Checked)
            {
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
            if (Tx_Max.Text == "")
            {
                Tx_Max.Text = "1";
            }
            try
            {
                double.Parse(Tx_Max.Text);
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
            if (Ch_Int.Checked)
            {
                if (double.Parse(Tx_Max.Text) > int.MaxValue)
                {
                    Tx_Max.Text = int.MaxValue.ToString();
                }
                if (double.Parse(Tx_Max.Text) < int.MinValue)
                {
                    Tx_Max.Text = int.MaxValue.ToString();
                }
            }
            else if (Ch_Long.Checked)
            {
                if (double.Parse(Tx_Max.Text) > long.MaxValue)
                {
                    Tx_Max.Text = long.MaxValue.ToString();
                }
                if (double.Parse(Tx_Max.Text) < long.MinValue)
                {
                    Tx_Max.Text = long.MaxValue.ToString();
                }
            }
            else if (Ch_Double.Checked)
            {
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
                if (int.Parse(Tx_Max.Text) > 1000)
                {
                    Tx_Max.Text = "1000";
                }
                if (int.Parse(Tx_Max.Text) < 1)
                {
                    Tx_Max.Text = "1";
                }
            }
        }

        private void Tx_Element_Count_TextChanged(object sender, EventArgs e)
        {
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
            if (int.Parse(Tx_Element_Count.Text) > 10000000)
            {
                Tx_Element_Count.Text = "10000000";
            }
            if (int.Parse(Tx_Element_Count.Text) < 1)
            {
                Tx_Element_Count.Text = "1";
            }
        }

        private void Ch_Int_CheckedChanged(object sender, EventArgs e)
        {
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
        }

        private void Ch_Long_CheckedChanged(object sender, EventArgs e)
        {
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
        }

        private void Ch_Double_CheckedChanged(object sender, EventArgs e)
        {
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
        }

        private void Ch_Str_CheckedChanged(object sender, EventArgs e)
        {
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
            int tests = int.Parse(Tx_Test_Count.Text);
            List<string> lss = Tx_Unsorted.Text.Split(',').ToList();
            if (Ch_Str.Checked)
            {
                Make_Sort(lss,tests);
            }
            if (Ch_Int.Checked)
            {
                List<int> lst = new();
                lst.Capacity = lss.Count;
                foreach (var item in lss)
                {
                    lst.Add(int.Parse(item));
                }
                Make_Sort(lst,tests);
            }
            if (Ch_Long.Checked)
            {
                List<long> lst = new();
                lst.Capacity = lss.Count;
                foreach (var item in lss)
                {
                    lst.Add(long.Parse(item));
                }
                Make_Sort(lst,tests);
            }
            if (Ch_Double.Checked)
            {
                List<double> lst = new();
                lst.Capacity = lss.Count;
                foreach (var item in lss)
                {
                    lst.Add(double.Parse(item));
                }
                Make_Sort(lst,tests);
            }

        }
        void Make_Sort<T>(List<T> lss,int tests)
        {
            System.Diagnostics.Stopwatch bublw = new(), insew = new(), mergw = new(), quicw = new();

            Thread forbut = new(forbub), forint = new(forins), formet = new(former), forqut = new(forqui);
            forbut.Start();
            forint.Start();
            formet.Start();
            forqut.Start();
            bool Thr_Is_Run(string name)
            {
                foreach (var item in threads)
                {
                    if (item.thr.ThreadState == ThreadState.Running && item.thr.Name == name)
                    {
                        return true;
                    }
                }
                return false;
            }
            void forbub()
            {
                for (int i = 0; i < tests; i++)
                {
                    Thread bublt = new(bublf);
                    if (!Thr_Is_Run("bublt"))
                    {
                        bublt.Start();
                    }
                    else
                    {
                        i--;
                    }
                }
            }
            void forins()
            {
                for (int i = 0; i < tests; i++)
                {
                    Thread inset = new(insef);
                    if (!Thr_Is_Run("inset"))
                    {
                        inset.Start();
                    }
                    else
                    {
                        i--;
                    }
                }
            }
            void former()
            {
                for (int i = 0; i < tests; i++)
                {
                    Thread mergt = new(mergf);
                    if (!Thr_Is_Run("mergt"))
                    {
                        mergt.Start();
                    }
                    else
                    {
                        i--;
                    }
                }
            }
            void forqui()
            {
                for (int i = 0; i < tests; i++)
                {
                    Thread quict = new(quicf);
                    if (!Thr_Is_Run("quict"))
                    {
                        quict.Start();
                    }
                    else
                    {
                        i--;
                    }
                }
            }
            void bublf()
            {
                bublw.Start();
                Sort.BubbleSort(lss.ToArray(), true);
                bublw.Stop();
            }

            void insef()
            {
                insew.Start();
                Sort.InsertSort(lss.ToArray(), true);
                insew.Stop();
            }

            void mergf()
            {
                mergw.Start();
                Sort.MergeSort(lss.ToArray(), true,0,lss.Count-1);
                mergw.Stop();
            }

            void quicf()
            {
                quicw.Start();
                Sort.QuickSort(lss.ToArray(), true,0,lss.Count-1);
                quicw.Stop();
            }
        }
    }
}