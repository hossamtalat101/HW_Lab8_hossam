
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Lab8_Najm
{
    public partial class Form2 : Form
    {
        private TextBox textBox1 = new TextBox();
        private TextBox textBox2 = new TextBox();
        private Button btnCopy = new Button();
        private Button btnCut = new Button();
        private Button btnPaste = new Button();
        private Button btnBack = new Button();

        private List<string> operations = new List<string>(); // مكدس لتخزين العمليات
        private string temp;

        public Form2()
        {
            InitializeComponent();
            Start();
        }

        private void Start()
        {
            textBox1.Location = new Point(5, 5);
            textBox1.Size = new Size(200, 100);
            textBox1.Text = "لغة C# من أهم اللغات في تصميم تطبيقات سطحرالمكتب وتطوير الألعاب";
            textBox1.RightToLeft = RightToLeft.Yes;
            textBox1.Multiline = true;
            textBox1.Font = new Font("Tohama", 10);

            textBox2.Top = textBox1.Bottom + 10;
            textBox2.Size = new Size(200, 120);
            textBox2.Multiline = true;

            btnCopy.Text = "نسخ";
            btnCopy.Size = new Size(60, 30);
            btnCopy.Location = new Point(230, 10);
            btnPaste.Text = "لصق";
            btnPaste.Size = new Size(60, 30);
            btnPaste.Location = new Point(230, 50);
            btnCut.Text = "قص";
            btnCut.Size = new Size(60, 30);
            btnCut.Location = new Point(230, 90);
            btnBack.Text = "تراجع";
            btnBack.Size = new Size(60, 30);
            btnBack.Location = new Point(230, 130);

            this.Controls.Add(textBox1);
            this.Controls.Add(textBox2);
            this.Controls.Add(btnCopy);
            this.Controls.Add(btnPaste);
            this.Controls.Add(btnCut);
            this.Controls.Add(btnBack);

            btnCopy.Click += btnCopy_Click;
            btnPaste.Click += btnPaste_Click;
            btnCut.Click += btnCut_Click;
            btnBack.Click += btnBack_Click; // إضافة حدث زر التراجع
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            temp = textBox1.SelectedText;
            operations.Add($"نسخ: {temp}"); // تخزين العملية
            LimitOperations();
        }

        private void btnCut_Click(object sender, EventArgs e)
        {
            temp = textBox1.SelectedText;
            textBox1.SelectedText = null;
            operations.Add($"قص: {temp}"); // تخزين العملية
            LimitOperations();
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            textBox2.Text += temp;
            operations.Add($"لصق: {temp}"); // تخزين العملية
            LimitOperations();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (operations.Count > 0)
            {
                string lastOperation = operations[operations.Count - 1]; // الحصول على آخر عملية
                operations.RemoveAt(operations.Count - 1); // إزالة آخر عملية
                MessageBox.Show($"تم التراجع عن: {lastOperation}");
            }
            else
            {
                MessageBox.Show("لا توجد عمليات للتراجع عنها.");
            }
        }

        private void LimitOperations()
        {
            // التأكد من عدم تجاوز 10 عمليات
            if (operations.Count > 10)
            {
                operations.RemoveAt(0); // إزالة أقدم عملية
            }
        }
    }
}


