namespace Lab8_Najm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtLengthOfAllText = new System.Windows.Forms.TextBox();
            this.txtLengthTextSelect = new System.Windows.Forms.TextBox();
            this.txtCountWord = new System.Windows.Forms.TextBox();
            this.btnLengthAllText = new System.Windows.Forms.Button();
            this.btnLengthSelectText = new System.Windows.Forms.Button();
            this.btnCountWord = new System.Windows.Forms.Button();
            this.btnDeleteSelectText = new System.Windows.Forms.Button();
            this.btnCancleSelect = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnCut = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnPase = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSwap = new System.Windows.Forms.TextBox();
            this.btnSwap = new System.Windows.Forms.Button();
            this.btnLengthTextAonlySpace = new System.Windows.Forms.Button();
            this.btnLengthSelectTextOnlySpace = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearchBefore = new System.Windows.Forms.Button();
            this.btnSearchAfter = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(751, 81);
            this.textBox1.TabIndex = 0;
            // 
            // txtLengthOfAllText
            // 
            this.txtLengthOfAllText.Location = new System.Drawing.Point(656, 143);
            this.txtLengthOfAllText.Name = "txtLengthOfAllText";
            this.txtLengthOfAllText.Size = new System.Drawing.Size(106, 24);
            this.txtLengthOfAllText.TabIndex = 2;
            // 
            // txtLengthTextSelect
            // 
            this.txtLengthTextSelect.Location = new System.Drawing.Point(531, 143);
            this.txtLengthTextSelect.Name = "txtLengthTextSelect";
            this.txtLengthTextSelect.Size = new System.Drawing.Size(119, 24);
            this.txtLengthTextSelect.TabIndex = 5;
            // 
            // txtCountWord
            // 
            this.txtCountWord.Location = new System.Drawing.Point(434, 143);
            this.txtCountWord.Name = "txtCountWord";
            this.txtCountWord.Size = new System.Drawing.Size(91, 24);
            this.txtCountWord.TabIndex = 6;
            // 
            // btnLengthAllText
            // 
            this.btnLengthAllText.Location = new System.Drawing.Point(656, 108);
            this.btnLengthAllText.Name = "btnLengthAllText";
            this.btnLengthAllText.Size = new System.Drawing.Size(106, 29);
            this.btnLengthAllText.TabIndex = 7;
            this.btnLengthAllText.Text = "طول النص كامل";
            this.btnLengthAllText.UseVisualStyleBackColor = true;
            this.btnLengthAllText.Click += new System.EventHandler(this.btnLengthAllText_Click);
            // 
            // btnLengthSelectText
            // 
            this.btnLengthSelectText.Location = new System.Drawing.Point(531, 108);
            this.btnLengthSelectText.Name = "btnLengthSelectText";
            this.btnLengthSelectText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnLengthSelectText.Size = new System.Drawing.Size(119, 29);
            this.btnLengthSelectText.TabIndex = 8;
            this.btnLengthSelectText.Text = "طول النص المحدد";
            this.btnLengthSelectText.UseVisualStyleBackColor = true;
            this.btnLengthSelectText.Click += new System.EventHandler(this.btnLengthSelectText_Click);
            // 
            // btnCountWord
            // 
            this.btnCountWord.Location = new System.Drawing.Point(434, 108);
            this.btnCountWord.Name = "btnCountWord";
            this.btnCountWord.Size = new System.Drawing.Size(91, 29);
            this.btnCountWord.TabIndex = 9;
            this.btnCountWord.Text = "عدد الكلمات";
            this.btnCountWord.UseVisualStyleBackColor = true;
            this.btnCountWord.Click += new System.EventHandler(this.btnCountWord_Click);
            // 
            // btnDeleteSelectText
            // 
            this.btnDeleteSelectText.Location = new System.Drawing.Point(304, 108);
            this.btnDeleteSelectText.Name = "btnDeleteSelectText";
            this.btnDeleteSelectText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDeleteSelectText.Size = new System.Drawing.Size(124, 29);
            this.btnDeleteSelectText.TabIndex = 10;
            this.btnDeleteSelectText.Text = "حذف النص المحدد";
            this.btnDeleteSelectText.UseVisualStyleBackColor = true;
            this.btnDeleteSelectText.Click += new System.EventHandler(this.btnDeleteSelectText_Click);
            // 
            // btnCancleSelect
            // 
            this.btnCancleSelect.Location = new System.Drawing.Point(201, 108);
            this.btnCancleSelect.Name = "btnCancleSelect";
            this.btnCancleSelect.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnCancleSelect.Size = new System.Drawing.Size(97, 29);
            this.btnCancleSelect.TabIndex = 11;
            this.btnCancleSelect.Text = "إالغاء التحديد";
            this.btnCancleSelect.UseVisualStyleBackColor = true;
            this.btnCancleSelect.Click += new System.EventHandler(this.btnCancleSelect_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(139, 108);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnCopy.Size = new System.Drawing.Size(56, 29);
            this.btnCopy.TabIndex = 12;
            this.btnCopy.Text = "نسخ";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnCut
            // 
            this.btnCut.Location = new System.Drawing.Point(75, 108);
            this.btnCut.Name = "btnCut";
            this.btnCut.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnCut.Size = new System.Drawing.Size(56, 29);
            this.btnCut.TabIndex = 13;
            this.btnCut.Text = "قص";
            this.btnCut.UseVisualStyleBackColor = true;
            this.btnCut.Click += new System.EventHandler(this.btnCut_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 108);
            this.btnClear.Name = "btnClear";
            this.btnClear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnClear.Size = new System.Drawing.Size(56, 29);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "تنظيف";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(433, 328);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(329, 148);
            this.textBox2.TabIndex = 15;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(433, 293);
            this.btnBack.Name = "btnBack";
            this.btnBack.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnBack.Size = new System.Drawing.Size(159, 29);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "تراجع";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnPase
            // 
            this.btnPase.Location = new System.Drawing.Point(598, 293);
            this.btnPase.Name = "btnPase";
            this.btnPase.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnPase.Size = new System.Drawing.Size(164, 29);
            this.btnPase.TabIndex = 17;
            this.btnPase.Text = "لصق";
            this.btnPase.UseVisualStyleBackColor = true;
            this.btnPase.Click += new System.EventHandler(this.btnPase_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSwap);
            this.groupBox1.Controls.Add(this.btnSwap);
            this.groupBox1.Location = new System.Drawing.Point(435, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(328, 114);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "إستبدال النص";
            // 
            // txtSwap
            // 
            this.txtSwap.Location = new System.Drawing.Point(115, 35);
            this.txtSwap.Name = "txtSwap";
            this.txtSwap.Size = new System.Drawing.Size(119, 24);
            this.txtSwap.TabIndex = 20;
            // 
            // btnSwap
            // 
            this.btnSwap.Location = new System.Drawing.Point(130, 68);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(91, 29);
            this.btnSwap.TabIndex = 19;
            this.btnSwap.Text = "إستبدال";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // btnLengthTextAonlySpace
            // 
            this.btnLengthTextAonlySpace.Location = new System.Drawing.Point(222, 143);
            this.btnLengthTextAonlySpace.Name = "btnLengthTextAonlySpace";
            this.btnLengthTextAonlySpace.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnLengthTextAonlySpace.Size = new System.Drawing.Size(206, 29);
            this.btnLengthTextAonlySpace.TabIndex = 19;
            this.btnLengthTextAonlySpace.Text = "طول النص كاملا بدون فراغات";
            this.btnLengthTextAonlySpace.UseVisualStyleBackColor = true;
            this.btnLengthTextAonlySpace.Click += new System.EventHandler(this.btnLengthTextAonlySpace_Click);
            // 
            // btnLengthSelectTextOnlySpace
            // 
            this.btnLengthSelectTextOnlySpace.Location = new System.Drawing.Point(12, 143);
            this.btnLengthSelectTextOnlySpace.Name = "btnLengthSelectTextOnlySpace";
            this.btnLengthSelectTextOnlySpace.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnLengthSelectTextOnlySpace.Size = new System.Drawing.Size(206, 29);
            this.btnLengthSelectTextOnlySpace.TabIndex = 20;
            this.btnLengthSelectTextOnlySpace.Text = "طول النص المحدد بدون فراغات";
            this.btnLengthSelectTextOnlySpace.UseVisualStyleBackColor = true;
            this.btnLengthSelectTextOnlySpace.Click += new System.EventHandler(this.btnLengthSelectTextOnlySpace_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(91, 30);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(195, 24);
            this.txtSearch.TabIndex = 20;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(276, 63);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(130, 29);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "بحث";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSearchBefore);
            this.groupBox2.Controls.Add(this.btnSearchAfter);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Location = new System.Drawing.Point(12, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(415, 109);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بحث";
            // 
            // btnSearchBefore
            // 
            this.btnSearchBefore.Location = new System.Drawing.Point(4, 63);
            this.btnSearchBefore.Name = "btnSearchBefore";
            this.btnSearchBefore.Size = new System.Drawing.Size(130, 29);
            this.btnSearchBefore.TabIndex = 22;
            this.btnSearchBefore.Text = "بحث عن السابق";
            this.btnSearchBefore.UseVisualStyleBackColor = true;
            this.btnSearchBefore.Click += new System.EventHandler(this.btnSearchBefore_Click);
            // 
            // btnSearchAfter
            // 
            this.btnSearchAfter.Location = new System.Drawing.Point(140, 63);
            this.btnSearchAfter.Name = "btnSearchAfter";
            this.btnSearchAfter.Size = new System.Drawing.Size(130, 29);
            this.btnSearchAfter.TabIndex = 21;
            this.btnSearchAfter.Text = "بحث عن التالي";
            this.btnSearchAfter.UseVisualStyleBackColor = true;
            this.btnSearchAfter.Click += new System.EventHandler(this.btnSearchAfter_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(264, 328);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(130, 148);
            this.listBox1.TabIndex = 22;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(65, 328);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(130, 148);
            this.listBox2.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(264, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 29);
            this.button1.TabIndex = 23;
            this.button1.Text = "احرف الكلمة المحددة";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(65, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 29);
            this.button2.TabIndex = 24;
            this.button2.Text = "كلمات النص المحدد";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 488);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnLengthSelectTextOnlySpace);
            this.Controls.Add(this.btnLengthTextAonlySpace);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPase);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCut);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnCancleSelect);
            this.Controls.Add(this.btnDeleteSelectText);
            this.Controls.Add(this.btnCountWord);
            this.Controls.Add(this.btnLengthSelectText);
            this.Controls.Add(this.btnLengthAllText);
            this.Controls.Add(this.txtCountWord);
            this.Controls.Add(this.txtLengthTextSelect);
            this.Controls.Add(this.txtLengthOfAllText);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtLengthOfAllText;
        private System.Windows.Forms.TextBox txtLengthTextSelect;
        private System.Windows.Forms.TextBox txtCountWord;
        private System.Windows.Forms.Button btnLengthAllText;
        private System.Windows.Forms.Button btnLengthSelectText;
        private System.Windows.Forms.Button btnCountWord;
        private System.Windows.Forms.Button btnDeleteSelectText;
        private System.Windows.Forms.Button btnCancleSelect;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnCut;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnPase;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSwap;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.Button btnLengthTextAonlySpace;
        private System.Windows.Forms.Button btnLengthSelectTextOnlySpace;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSearchBefore;
        private System.Windows.Forms.Button btnSearchAfter;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

