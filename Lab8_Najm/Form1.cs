using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8_Najm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox1.RightToLeft = RightToLeft.Yes;
            textBox1.Font = new Font("Tohama", 20);
            textBox1.Text = "حسام طلعت سعيد ناجي";
            textBox2.RightToLeft = RightToLeft.Yes;
        }

        string CopyText;

        private void btnLengthAllText_Click(object sender, EventArgs e)
        {
            txtLengthOfAllText.Text = textBox1.Text.Length.ToString();
        }

        private void btnLengthSelectText_Click(object sender, EventArgs e)
        {
            txtLengthTextSelect.Text = textBox1.SelectedText.Length.ToString();
            //txtLengthTextSelect.Text = textBox1.SelectionLength.ToString();
        }

        private void btnCountWord_Click(object sender, EventArgs e)
        { 
            //string[] temp = textBox1.Text.Split(' ');
            //txtCountWord.Text = temp.Length.ToString();

            string[] temp2 = textBox1.Text.Split(' ');
            int x = 0;
            for(int i=0;i<temp2.Length;i++)
            {
                if (temp2[i] != "")
                    x++;
            }
            txtCountWord.Text = x.ToString();
            
            //int c = 1;
            //string s = textBox1.Text;
            //for(int i=0;i<s.Length;i++)
            //{
            //    if ( s[i] == ' ' && s[i+1] != ' ')
            //        c++;
            //}
            //txtCountWord.Text = c.ToString();
        }

        private void btnDeleteSelectText_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectionLength > 0)
                textBox1.SelectedText = null;
            else
                MessageBox.Show("قم بتحديد النص", "خطأ");
        }

        private void btnCancleSelect_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectionLength != 0)
                textBox1.SelectionStart = 0;
            else
            {
                MessageBox.Show("قم بتحديد النص", "خطأ");
                textBox1.Focus();
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            CopyText = textBox1.SelectedText;
        }

        private void btnCut_Click(object sender, EventArgs e)
        {
            CopyText = textBox1.SelectedText;
            textBox1.SelectedText = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
                textBox1.Text = null;
        }

        private void btnPase_Click(object sender, EventArgs e)
        {
            textBox2.Text += CopyText;
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            if(textBox1.SelectionLength>0)
            {
                textBox1.SelectedText = txtSwap.Text;
            }
            else
                MessageBox.Show("قم بتحديد النص", "خطأ");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
            textBox2.Undo();
        }

        private void btnLengthTextAonlySpace_Click(object sender, EventArgs e)
        {
            int n = 0;
            for(int i=0;i<textBox1.Text.Length;i++)
            {
                if (textBox1.Text[i] != ' ')
                    n++;
            }
            MessageBox.Show($"طول النص كاملا بدون الفراغات: {n}");
        }

        private void btnLengthSelectTextOnlySpace_Click(object sender, EventArgs e)
        {
            int n = 0 ;
            for (int i=0;i<textBox1.SelectedText.Length;i++)
            {
                if (textBox1.SelectedText[i] != ' ')
                    n++;
            }
            MessageBox.Show($"طول النص المحدد بدون الفراغات: {n}");

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() != "")
            {
                int index = textBox1.Text.IndexOf(txtSearch.Text, 0);
                if (index > -1)
                {
                    textBox1.SelectionStart = index;
                    textBox1.SelectionLength = txtSearch.Text.Length;
                    textBox1.Focus();
                }
                else
                    MessageBox.Show("لا يوجد");
            }
            else
            {
                MessageBox.Show("قم بادخال النص الذي تريد البحث عنه");
                txtSearch.Focus();
            }

        }

        private void btnSearchAfter_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() != "")
            {
                int index = textBox1.Text.IndexOf(txtSearch.Text, textBox1.SelectionStart + textBox1.SelectionLength);
                if (index > -1)
                {
                    textBox1.Focus();
                    textBox1.Select(index, txtSearch.Text.Length);
                }
                else
                    MessageBox.Show("النص الذي تبحث عنه غير موجود");
            }
            else
                MessageBox.Show("أدخل النص الذي تريد البحث عنه");
        }

        private void btnSearchBefore_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() != "")
            {
                int index = textBox1.Text.LastIndexOf(txtSearch.Text, textBox1.SelectionStart - textBox1.SelectionLength);
                if (index > -1)
                {
                    textBox1.Focus();
                    textBox1.Select(index, txtSearch.Text.Length);
                }
                else
                    MessageBox.Show("لا يوجد");
            }
            else
            {
                MessageBox.Show("قم بادخال النص الذي تريد البحث عنه");
                txtSearch.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string temp = textBox1.SelectedText;
            for(int i=0;i<temp.Length;i++)
            {
                listBox1.Items.Add(temp[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            string[] temp = textBox1.SelectedText.Split(' ');
            for (int i = 0; i < temp.Length; i++)
                listBox2.Items.Add(temp[i]);
            
        }
    }
}
