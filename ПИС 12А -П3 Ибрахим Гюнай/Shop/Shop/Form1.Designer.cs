namespace Shop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Addproduct = new System.Windows.Forms.Button();
            this.Removeproduct = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Addproduct
            // 
            this.Addproduct.Location = new System.Drawing.Point(216, 254);
            this.Addproduct.Name = "Addproduct";
            this.Addproduct.Size = new System.Drawing.Size(96, 53);
            this.Addproduct.TabIndex = 0;
            this.Addproduct.Text = "Add";
            this.Addproduct.UseVisualStyleBackColor = true;
            this.Addproduct.Click += new System.EventHandler(this.Addproduct_Click);
            // 
            // Removeproduct
            // 
            this.Removeproduct.Location = new System.Drawing.Point(459, 243);
            this.Removeproduct.Name = "Removeproduct";
            this.Removeproduct.Size = new System.Drawing.Size(96, 53);
            this.Removeproduct.TabIndex = 1;
            this.Removeproduct.Text = "Remove";
            this.Removeproduct.UseVisualStyleBackColor = true;
            this.Removeproduct.Click += new System.EventHandler(this.Removeproduct_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(321, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(111, 23);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Removeproduct);
            this.Controls.Add(this.Addproduct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Addproduct;
        private Button Removeproduct;
        private TextBox textBox1;
    }
}