namespace WindowsFormIntro
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
            this.res = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.Button();
            this.subt = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.multip = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // res
            // 
            this.res.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.res.Location = new System.Drawing.Point(253, 198);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(46, 30);
            this.res.TabIndex = 0;
            this.res.Text = "=";
            this.res.UseVisualStyleBackColor = true;
            this.res.Click += new System.EventHandler(this.result_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // sum
            // 
            this.sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sum.Location = new System.Drawing.Point(208, 91);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(39, 30);
            this.sum.TabIndex = 7;
            this.sum.Text = "/";
            this.sum.UseVisualStyleBackColor = true;
            this.sum.Click += new System.EventHandler(this.operation_click);
            // 
            // subt
            // 
            this.subt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subt.Location = new System.Drawing.Point(209, 163);
            this.subt.Name = "subt";
            this.subt.Size = new System.Drawing.Size(38, 29);
            this.subt.TabIndex = 8;
            this.subt.Text = "-";
            this.subt.UseVisualStyleBackColor = true;
            this.subt.Click += new System.EventHandler(this.operation_click);
            // 
            // div
            // 
            this.div.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.div.Location = new System.Drawing.Point(208, 127);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(39, 30);
            this.div.TabIndex = 9;
            this.div.Text = "*";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.operation_click);
            // 
            // multip
            // 
            this.multip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multip.Location = new System.Drawing.Point(209, 198);
            this.multip.Name = "multip";
            this.multip.Size = new System.Drawing.Size(38, 30);
            this.multip.TabIndex = 10;
            this.multip.Text = "+";
            this.multip.UseVisualStyleBackColor = true;
            this.multip.Click += new System.EventHandler(this.operation_click);
            // 
            // display
            // 
            this.display.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.display.Location = new System.Drawing.Point(16, 12);
            this.display.Name = "display";
            this.display.ReadOnly = true;
            this.display.Size = new System.Drawing.Size(283, 30);
            this.display.TabIndex = 11;
            this.display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(16, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 30);
            this.button1.TabIndex = 12;
            this.button1.Text = "C";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.clear_all);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(70, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 30);
            this.button2.TabIndex = 13;
            this.button2.Text = "CE";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(131, 56);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 30);
            this.button3.TabIndex = 14;
            this.button3.Text = "BACK";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(115, 92);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(39, 30);
            this.button4.TabIndex = 15;
            this.button4.Text = "8";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.numbers_click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(70, 92);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(39, 30);
            this.button5.TabIndex = 16;
            this.button5.Text = "7";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.numbers_click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(160, 92);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(39, 30);
            this.button6.TabIndex = 17;
            this.button6.Text = "9";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.numbers_click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(16, 93);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(48, 30);
            this.button7.TabIndex = 18;
            this.button7.Text = "MC";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(16, 129);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(48, 30);
            this.button8.TabIndex = 19;
            this.button8.Text = "MR";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(16, 165);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(48, 30);
            this.button9.TabIndex = 20;
            this.button9.Text = "MS";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button10.Location = new System.Drawing.Point(16, 201);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(48, 30);
            this.button10.TabIndex = 21;
            this.button10.Text = "M+";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button11.Location = new System.Drawing.Point(253, 91);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(46, 30);
            this.button11.TabIndex = 22;
            this.button11.Text = "sqrt";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button12.Location = new System.Drawing.Point(253, 127);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(46, 30);
            this.button12.TabIndex = 23;
            this.button12.Text = "%";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button13.Location = new System.Drawing.Point(253, 162);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(46, 30);
            this.button13.TabIndex = 24;
            this.button13.Text = "1/x";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button14.Location = new System.Drawing.Point(160, 129);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(39, 30);
            this.button14.TabIndex = 27;
            this.button14.Text = "6";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.numbers_click);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button15.Location = new System.Drawing.Point(70, 129);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(39, 30);
            this.button15.TabIndex = 26;
            this.button15.Text = "4";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.numbers_click);
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button16.Location = new System.Drawing.Point(115, 129);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(39, 30);
            this.button16.TabIndex = 25;
            this.button16.Text = "5";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.numbers_click);
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button17.Location = new System.Drawing.Point(160, 165);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(39, 30);
            this.button17.TabIndex = 30;
            this.button17.Text = "3";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.numbers_click);
            // 
            // button18
            // 
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button18.Location = new System.Drawing.Point(70, 165);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(39, 30);
            this.button18.TabIndex = 29;
            this.button18.Text = "1";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.numbers_click);
            // 
            // button19
            // 
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button19.Location = new System.Drawing.Point(115, 165);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(39, 30);
            this.button19.TabIndex = 28;
            this.button19.Text = "2";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.numbers_click);
            // 
            // button20
            // 
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button20.Location = new System.Drawing.Point(160, 198);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(39, 30);
            this.button20.TabIndex = 33;
            this.button20.Text = ".";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button21.Location = new System.Drawing.Point(70, 198);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(39, 30);
            this.button21.TabIndex = 32;
            this.button21.Text = "0";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.numbers_click);
            // 
            // button22
            // 
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button22.Location = new System.Drawing.Point(115, 198);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(39, 30);
            this.button22.TabIndex = 31;
            this.button22.Text = "+/-";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            this.button23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button23.Location = new System.Drawing.Point(209, 56);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(39, 30);
            this.button23.TabIndex = 34;
            this.button23.Text = "x!";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            this.button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button24.Location = new System.Drawing.Point(254, 57);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(45, 30);
            this.button24.TabIndex = 35;
            this.button24.Text = "x^3";
            this.button24.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 252);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.display);
            this.Controls.Add(this.multip);
            this.Controls.Add(this.div);
            this.Controls.Add(this.subt);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.res);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button res;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sum;
        private System.Windows.Forms.Button subt;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button multip;
        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
    }
}

