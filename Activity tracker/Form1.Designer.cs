
namespace Activity_tracker
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
            this.zagolovok = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.addlabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.TypeField = new System.Windows.Forms.ComboBox();
            this.DisField = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.closelabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.ridelabel = new System.Windows.Forms.Label();
            this.runlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.zagolovok.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // zagolovok
            // 
            this.zagolovok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.zagolovok.Controls.Add(this.closelabel);
            this.zagolovok.Controls.Add(this.label1);
            this.zagolovok.Dock = System.Windows.Forms.DockStyle.Top;
            this.zagolovok.Location = new System.Drawing.Point(0, 0);
            this.zagolovok.Margin = new System.Windows.Forms.Padding(4);
            this.zagolovok.Name = "zagolovok";
            this.zagolovok.Size = new System.Drawing.Size(1180, 116);
            this.zagolovok.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(370, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "Activity Tracker";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // addlabel
            // 
            this.addlabel.AutoSize = true;
            this.addlabel.Location = new System.Drawing.Point(13, 40);
            this.addlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addlabel.Name = "addlabel";
            this.addlabel.Size = new System.Drawing.Size(126, 19);
            this.addlabel.TabIndex = 1;
            this.addlabel.Text = "Add new activity:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(234)))), ((int)(((byte)(106)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.TypeField);
            this.panel1.Controls.Add(this.DisField);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.addlabel);
            this.panel1.Location = new System.Drawing.Point(0, 124);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1514, 112);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(156)))), ((int)(((byte)(48)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(969, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 77);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TypeField
            // 
            this.TypeField.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TypeField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(92)))), ((int)(((byte)(87)))));
            this.TypeField.FormattingEnabled = true;
            this.TypeField.Items.AddRange(new object[] {
            "Run",
            "Ride"});
            this.TypeField.Location = new System.Drawing.Point(719, 37);
            this.TypeField.Name = "TypeField";
            this.TypeField.Size = new System.Drawing.Size(160, 27);
            this.TypeField.TabIndex = 5;
            this.TypeField.Text = "Select activity type";
            // 
            // DisField
            // 
            this.DisField.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DisField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(92)))), ((int)(((byte)(87)))));
            this.DisField.Location = new System.Drawing.Point(518, 37);
            this.DisField.Multiline = true;
            this.DisField.Name = "DisField";
            this.DisField.Size = new System.Drawing.Size(144, 38);
            this.DisField.TabIndex = 4;
            this.DisField.Text = "Distance";
            this.DisField.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.DisField.Enter += new System.EventHandler(this.DisField_Enter);
            this.DisField.Leave += new System.EventHandler(this.DisField_Leave);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(92)))), ((int)(((byte)(87)))));
            this.textBox2.Location = new System.Drawing.Point(341, 37);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(144, 38);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Finish time";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(92)))), ((int)(((byte)(87)))));
            this.textBox1.Location = new System.Drawing.Point(160, 37);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 38);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Start time";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // closelabel
            // 
            this.closelabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.closelabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(22)))), ((int)(((byte)(0)))));
            this.closelabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closelabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.closelabel.Location = new System.Drawing.Point(1149, 0);
            this.closelabel.Name = "closelabel";
            this.closelabel.Size = new System.Drawing.Size(32, 32);
            this.closelabel.TabIndex = 1;
            this.closelabel.Text = "X";
            this.closelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closelabel.Click += new System.EventHandler(this.closelabel_Click);
            this.closelabel.MouseEnter += new System.EventHandler(this.closelabel_MouseEnter);
            this.closelabel.MouseLeave += new System.EventHandler(this.closelabel_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(218)))), ((int)(((byte)(73)))));
            this.panel2.Location = new System.Drawing.Point(17, 266);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(707, 59);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(218)))), ((int)(((byte)(73)))));
            this.panel3.Location = new System.Drawing.Point(17, 345);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(707, 59);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(218)))), ((int)(((byte)(73)))));
            this.panel4.Location = new System.Drawing.Point(17, 426);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(707, 59);
            this.panel4.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.panel5.Controls.Add(this.runlabel);
            this.panel5.Controls.Add(this.ridelabel);
            this.panel5.Location = new System.Drawing.Point(798, 266);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(355, 219);
            this.panel5.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(221)))));
            this.panel6.Controls.Add(this.textBox4);
            this.panel6.Controls.Add(this.textBox3);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Location = new System.Drawing.Point(719, 508);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(434, 122);
            this.panel6.TabIndex = 7;
            // 
            // ridelabel
            // 
            this.ridelabel.AutoSize = true;
            this.ridelabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ridelabel.Location = new System.Drawing.Point(126, 9);
            this.ridelabel.Name = "ridelabel";
            this.ridelabel.Size = new System.Drawing.Size(109, 19);
            this.ridelabel.TabIndex = 0;
            this.ridelabel.Text = "Longest ride:";
            this.ridelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // runlabel
            // 
            this.runlabel.AutoSize = true;
            this.runlabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.runlabel.Location = new System.Drawing.Point(126, 101);
            this.runlabel.Name = "runlabel";
            this.runlabel.Size = new System.Drawing.Size(95, 19);
            this.runlabel.TabIndex = 1;
            this.runlabel.Text = "Logest run:";
            this.runlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.runlabel.Click += new System.EventHandler(this.runlabel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(25, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total ride distance:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(25, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Total run distance:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(230, 23);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(119, 27);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(230, 74);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(119, 27);
            this.textBox4.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 632);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.zagolovok);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Activity Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.zagolovok.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel zagolovok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label addlabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox DisField;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox TypeField;
        private System.Windows.Forms.Label closelabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label ridelabel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label runlabel;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

