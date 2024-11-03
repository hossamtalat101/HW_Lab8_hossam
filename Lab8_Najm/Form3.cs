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
    public partial class Form3 : Form
    {
        private Button btnAdd = new Button();
        private Button btnDelete = new Button();
        private Button btnDeleteAll = new Button();
        private Button btnSum = new Button();
        private Button btnAvg = new Button();
        private TextBox textBox1 = new TextBox();
        private TextBox txtSumResult = new TextBox();
        private TextBox txtAvgResult = new TextBox();
        private ListBox listBox1 = new ListBox();
        public Form3()
        {
            InitializeComponent();
            Start();

            Random r = new Random();
            for (int i=0;i<10;i++)
            {
                int n = r.Next(1, 10);
                if (!repeated(listBox1,n.ToString()))
                    listBox1.Items.Add(n);
            }
        }
        private void Start()
        {
            textBox1.Location = new Point(20,20);
            textBox1.Size = new Size(100, 30);
            listBox1.Location = new Point(20, 50);
            listBox1.Size = new Size(100, 150);
            txtAvgResult.Location = new Point(20, 230);
            txtAvgResult.Size = new Size(100, 30);
            txtSumResult.Location=new Point(20,200);
            txtSumResult.Size = new Size(100, 30);
            btnAdd.Location = new Point(150, 20);
            btnAdd.Size = new Size(70, 30);
            btnAdd.Text = "إظافة";
            btnDelete.Location = new Point(150, 60);
            btnDelete.Size = btnAdd.Size;
            btnDelete.Text = "حذف";
            btnDeleteAll.Location = new Point(150, 100);
            btnDeleteAll.Size = btnAdd.Size;
            btnDeleteAll.Text = "حذف الكل";
            btnSum.Location = new Point(150, 200);
            btnSum.Size = btnAdd.Size;
            btnSum.Text = "المجموع";
            btnAvg.Location = new Point(150,230);
            btnAvg.Size = btnAdd.Size;
            btnAvg.Text = "المعدل";
            this.Controls.Add(textBox1);
            this.Controls.Add(listBox1);
            this.Controls.Add(txtAvgResult);
            this.Controls.Add(txtSumResult);
            this.Controls.Add(btnAdd);
            this.Controls.Add(btnDelete);
            this.Controls.Add(btnDeleteAll);
            this.Controls.Add(btnSum);
            this.Controls.Add(btnAvg);

            btnAdd.Click += btnAdd_Click;
            btnDelete.Click += btnDelete_Click;
            btnDeleteAll.Click += btnDeleteAll_Click;
            btnSum.Click += btnSum_Click;
            btnAvg.Click += btnAvg_Click;

        }
        private void btnAdd_Click(object sender,EventArgs e)
        {
            if(isNumric(textBox1.Text.Trim()))
            {
                if((Convert.ToInt32(textBox1.Text)<100))
                {
                    if (!repeated(listBox1, textBox1.Text))
                    {
                        listBox1.Items.Add(textBox1.Text);
                        textBox1.Clear();
                        textBox1.Focus();
                    }
                    else
                    {
                        MessageBox.Show("العدد موجود مسبقا");
                        textBox1.Clear();
                        textBox1.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("العدد المدخل أكبر من 100");
                    textBox1.Clear();
                    textBox1.Focus();
                }
            }
            else
            {
                MessageBox.Show("الرجاء إدخال عدد");
                textBox1.Clear();
                textBox1.Focus();
            }
        }
        private void btnDelete_Click(object sender,EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
        private void btnDeleteAll_Click(object sender,EventArgs e)
        {
            listBox1.Items.Clear();
        }
        int s = 0;
        private void btnSum_Click(object sender,EventArgs e)
        {
           
            for (int i = 0; i < listBox1.Items.Count; i++)
                s += Convert.ToInt16(listBox1.Items[i]);
            txtSumResult.Text = s.ToString();
        }
        private void btnAvg_Click(object sender,EventArgs e)
        {
            float avg = s / listBox1.Items.Count;
            txtAvgResult.Text = avg.ToString();
        }
        private  bool isNumric(string st)
        {
            for (int i = 0; i < st.Length; i++)
                if (st[i] < 48 || st[i] > 57)
                    return false;
            return true;
        }
        private bool repeated(ListBox list,string str)
        {
            for(int i=0;i<list.Items.Count;i++)
            {
                if (list.Items[i].ToString() == str)
                    return true;
            }
            return false;
        }
    }
}
