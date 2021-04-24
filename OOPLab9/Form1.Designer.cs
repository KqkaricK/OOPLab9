
namespace OOPLab9
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.darkButton1 = new DarkUI.Controls.DarkButton();
            this.darkButton2 = new DarkUI.Controls.DarkButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.darkButton3 = new DarkUI.Controls.DarkButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.darkComboBox1 = new DarkUI.Controls.DarkComboBox();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // darkButton1
            // 
            this.darkButton1.Location = new System.Drawing.Point(16, 278);
            this.darkButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.darkButton1.Name = "darkButton1";
            this.darkButton1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.darkButton1.Size = new System.Drawing.Size(100, 28);
            this.darkButton1.TabIndex = 0;
            this.darkButton1.Text = "Открыть";
            this.darkButton1.Click += new System.EventHandler(this.darkButton1_Click);
            // 
            // darkButton2
            // 
            this.darkButton2.Enabled = false;
            this.darkButton2.Location = new System.Drawing.Point(496, 274);
            this.darkButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.darkButton2.Name = "darkButton2";
            this.darkButton2.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.darkButton2.Size = new System.Drawing.Size(103, 28);
            this.darkButton2.TabIndex = 1;
            this.darkButton2.Text = "Сохранить";
            this.darkButton2.Click += new System.EventHandler(this.darkButton2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Location = new System.Drawing.Point(16, 59);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(472, 208);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // darkButton3
            // 
            this.darkButton3.Enabled = false;
            this.darkButton3.Location = new System.Drawing.Point(496, 12);
            this.darkButton3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.darkButton3.Name = "darkButton3";
            this.darkButton3.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.darkButton3.Size = new System.Drawing.Size(103, 28);
            this.darkButton3.TabIndex = 4;
            this.darkButton3.Text = "Сортровать";
            this.darkButton3.Click += new System.EventHandler(this.darkButton3_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(496, 59);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(472, 208);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 7;
            // 
            // darkComboBox1
            // 
            this.darkComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.darkComboBox1.FormattingEnabled = true;
            this.darkComboBox1.Location = new System.Drawing.Point(16, 15);
            this.darkComboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.darkComboBox1.Name = "darkComboBox1";
            this.darkComboBox1.Size = new System.Drawing.Size(471, 23);
            this.darkComboBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 322);
            this.Controls.Add(this.darkComboBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.darkButton3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.darkButton2);
            this.Controls.Add(this.darkButton1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "OOPLab 9";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private DarkUI.Controls.DarkButton darkButton1;
        private DarkUI.Controls.DarkButton darkButton2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private DarkUI.Controls.DarkButton darkButton3;
        private System.Windows.Forms.ListBox listBox1;
        private DarkUI.Controls.DarkComboBox darkComboBox1;
    }
}

