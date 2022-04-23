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

        private void Tx_Unsorted_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tx_Min_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tx_Max_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tx_Element_Count_TextChanged(object sender, EventArgs e)
        {

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
                Lb_Max.Text = "Max length";
                Lb_Min.Text = "Min length";
            }
            else
            {
                Lb_Max.Text = "Max value";
                Lb_Min.Text = "Min value";
            }
        }
    }
}