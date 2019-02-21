namespace calculator
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
            this.Input = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Seven = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.Divided = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.Times = new System.Windows.Forms.Button();
            this.One = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.Zero = new System.Windows.Forms.Button();
            this.Decimal = new System.Windows.Forms.Button();
            this.Equals = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Input.Location = new System.Drawing.Point(12, 42);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(641, 20);
            this.Input.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.Seven, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Eight, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Nine, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Divided, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.Four, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Five, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Six, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Times, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.One, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Two, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Three, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.Plus, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.Zero, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Decimal, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Equals, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.Minus, 3, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 94);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(640, 376);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // Seven
            // 
            this.Seven.Location = new System.Drawing.Point(3, 3);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(154, 88);
            this.Seven.TabIndex = 0;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = true;
            this.Seven.Click += new System.EventHandler(this.Seven_Click);
            // 
            // Eight
            // 
            this.Eight.Location = new System.Drawing.Point(163, 3);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(154, 88);
            this.Eight.TabIndex = 1;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = true;
            this.Eight.Click += new System.EventHandler(this.Eight_Click);
            // 
            // Nine
            // 
            this.Nine.Location = new System.Drawing.Point(323, 3);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(154, 88);
            this.Nine.TabIndex = 2;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = true;
            this.Nine.Click += new System.EventHandler(this.Nine_Click);
            // 
            // Divided
            // 
            this.Divided.Location = new System.Drawing.Point(483, 3);
            this.Divided.Name = "Divided";
            this.Divided.Size = new System.Drawing.Size(154, 88);
            this.Divided.TabIndex = 3;
            this.Divided.Text = "/";
            this.Divided.UseVisualStyleBackColor = true;
            this.Divided.Click += new System.EventHandler(this.Divided_Click);
            // 
            // Four
            // 
            this.Four.Location = new System.Drawing.Point(3, 97);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(154, 88);
            this.Four.TabIndex = 4;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = true;
            this.Four.Click += new System.EventHandler(this.Four_Click);
            // 
            // Five
            // 
            this.Five.Location = new System.Drawing.Point(163, 97);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(154, 88);
            this.Five.TabIndex = 5;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = true;
            this.Five.Click += new System.EventHandler(this.Five_Click);
            // 
            // Six
            // 
            this.Six.Location = new System.Drawing.Point(323, 97);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(154, 88);
            this.Six.TabIndex = 6;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = true;
            this.Six.Click += new System.EventHandler(this.Six_Click);
            // 
            // Times
            // 
            this.Times.Location = new System.Drawing.Point(483, 97);
            this.Times.Name = "Times";
            this.Times.Size = new System.Drawing.Size(154, 88);
            this.Times.TabIndex = 7;
            this.Times.Text = "*";
            this.Times.UseVisualStyleBackColor = true;
            this.Times.Click += new System.EventHandler(this.Times_Click);
            // 
            // One
            // 
            this.One.Location = new System.Drawing.Point(3, 191);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(154, 88);
            this.One.TabIndex = 8;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = true;
            this.One.Click += new System.EventHandler(this.One_Click);
            // 
            // Two
            // 
            this.Two.Location = new System.Drawing.Point(163, 191);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(154, 88);
            this.Two.TabIndex = 9;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = true;
            this.Two.Click += new System.EventHandler(this.Two_Click);
            // 
            // Three
            // 
            this.Three.Location = new System.Drawing.Point(323, 191);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(154, 88);
            this.Three.TabIndex = 10;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = true;
            this.Three.Click += new System.EventHandler(this.Three_Click);
            // 
            // Plus
            // 
            this.Plus.Location = new System.Drawing.Point(483, 191);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(154, 88);
            this.Plus.TabIndex = 11;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // Zero
            // 
            this.Zero.Location = new System.Drawing.Point(3, 285);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(154, 88);
            this.Zero.TabIndex = 12;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = true;
            this.Zero.Click += new System.EventHandler(this.Zero_Click);
            // 
            // Decimal
            // 
            this.Decimal.Location = new System.Drawing.Point(163, 285);
            this.Decimal.Name = "Decimal";
            this.Decimal.Size = new System.Drawing.Size(154, 88);
            this.Decimal.TabIndex = 13;
            this.Decimal.Text = ".";
            this.Decimal.UseVisualStyleBackColor = true;
            this.Decimal.Click += new System.EventHandler(this.Decimal_Click);
            // 
            // Equals
            // 
            this.Equals.Location = new System.Drawing.Point(323, 285);
            this.Equals.Name = "Equals";
            this.Equals.Size = new System.Drawing.Size(154, 88);
            this.Equals.TabIndex = 14;
            this.Equals.Text = "=";
            this.Equals.UseVisualStyleBackColor = true;
            this.Equals.Click += new System.EventHandler(this.Equals_Click);
            // 
            // Minus
            // 
            this.Minus.Location = new System.Drawing.Point(483, 285);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(154, 88);
            this.Minus.TabIndex = 15;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(297, 12);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 2;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 482);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Input);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Seven;
        private System.Windows.Forms.Button Eight;
        private System.Windows.Forms.Button Nine;
        private System.Windows.Forms.Button Divided;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Six;
        private System.Windows.Forms.Button Times;
        private System.Windows.Forms.Button One;
        private System.Windows.Forms.Button Two;
        private System.Windows.Forms.Button Three;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Zero;
        private System.Windows.Forms.Button Decimal;
        private System.Windows.Forms.Button Equals;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Clear;
    }
}

