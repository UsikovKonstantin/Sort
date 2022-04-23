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

        }

        private void Tx_Test_Trust_TextChanged(object sender, EventArgs e)
        {

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
                for (int i = 0; i <Tx_Element_Count.TextLength; i++)
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
    }
}