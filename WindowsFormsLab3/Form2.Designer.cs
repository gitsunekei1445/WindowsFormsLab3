namespace WindowsFormsLab3
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.hr = new System.Windows.Forms.TextBox();
            this.pice = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sad = new System.Windows.Forms.RadioButton();
            this.bad = new System.Windows.Forms.RadioButton();
            this.g1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.g1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // hr
            // 
            this.hr.Location = new System.Drawing.Point(426, 139);
            this.hr.Name = "hr";
            this.hr.Size = new System.Drawing.Size(124, 20);
            this.hr.TabIndex = 1;
            // 
            // pice
            // 
            this.pice.Location = new System.Drawing.Point(392, 219);
            this.pice.Name = "pice";
            this.pice.Size = new System.Drawing.Size(124, 20);
            this.pice.TabIndex = 2;
            this.pice.Text = "0";
            this.pice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.pice.TextChanged += new System.EventHandler(this.pice_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "คำนวน";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "เวลาที่ใช้งาน";
            // 
            // sad
            // 
            this.sad.AutoSize = true;
            this.sad.Location = new System.Drawing.Point(6, 29);
            this.sad.Name = "sad";
            this.sad.Size = new System.Drawing.Size(97, 19);
            this.sad.TabIndex = 7;
            this.sad.TabStop = true;
            this.sad.Text = "โปรโมชั่น SAD";
            this.sad.UseVisualStyleBackColor = true;
            // 
            // bad
            // 
            this.bad.AutoSize = true;
            this.bad.Location = new System.Drawing.Point(6, 58);
            this.bad.Name = "bad";
            this.bad.Size = new System.Drawing.Size(97, 19);
            this.bad.TabIndex = 8;
            this.bad.TabStop = true;
            this.bad.Text = "โปรโมชั่น BAD";
            this.bad.UseVisualStyleBackColor = true;
            // 
            // g1
            // 
            this.g1.Controls.Add(this.button2);
            this.g1.Controls.Add(this.sad);
            this.g1.Controls.Add(this.bad);
            this.g1.Location = new System.Drawing.Point(23, 33);
            this.g1.Name = "g1";
            this.g1.Size = new System.Drawing.Size(299, 182);
            this.g1.TabIndex = 9;
            this.g1.TabStop = false;
            this.g1.Text = "เลือกโปรโมชั่น";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "ค่าใช้จ่าย";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(114, 245);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(387, 333);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "ราคาเริ่มที่";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(449, 46);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(52, 20);
            this.textBoxA.TabIndex = 13;
            this.textBoxA.Text = "0";
            this.textBoxA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(507, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "บาท";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(507, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "นาที";
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(449, 72);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(52, 20);
            this.textBoxB.TabIndex = 16;
            this.textBoxB.Text = "0";
            this.textBoxB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(374, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "โทรฟรี";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(507, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "บาท/นาที";
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(449, 98);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(52, 20);
            this.textBoxC.TabIndex = 19;
            this.textBoxC.Text = "0";
            this.textBoxC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(374, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "โทรครั้งต่อไป";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.33962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(28, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(234, 63);
            this.button2.TabIndex = 9;
            this.button2.Text = "เลือก";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(522, 222);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "บาท";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(584, 590);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.g1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pice);
            this.Controls.Add(this.hr);
            this.Name = "Form2";
            this.Text = "Form2";
            this.g1.ResumeLayout(false);
            this.g1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox hr;
        private System.Windows.Forms.TextBox pice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton sad;
        private System.Windows.Forms.RadioButton bad;
        private System.Windows.Forms.GroupBox g1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer timer1;
    }
}