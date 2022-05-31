namespace TempConversion
{
    partial class txt_
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
            this.btn_fahrenheit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_fahrenheit = new System.Windows.Forms.TextBox();
            this.txt_celsuis = new System.Windows.Forms.TextBox();
            this.txt_kelvin = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_celsuis = new System.Windows.Forms.Button();
            this.btn_kelvin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_fahrenheit
            // 
            this.btn_fahrenheit.AutoSize = true;
            this.btn_fahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fahrenheit.ForeColor = System.Drawing.Color.Coral;
            this.btn_fahrenheit.Location = new System.Drawing.Point(25, 39);
            this.btn_fahrenheit.Name = "btn_fahrenheit";
            this.btn_fahrenheit.Size = new System.Drawing.Size(101, 24);
            this.btn_fahrenheit.TabIndex = 0;
            this.btn_fahrenheit.Text = "Fahrenheit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(55, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Celsuis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(65, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kelvin";
            // 
            // txt_fahrenheit
            // 
            this.txt_fahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fahrenheit.Location = new System.Drawing.Point(151, 38);
            this.txt_fahrenheit.Name = "txt_fahrenheit";
            this.txt_fahrenheit.Size = new System.Drawing.Size(118, 29);
            this.txt_fahrenheit.TabIndex = 3;
            // 
            // txt_celsuis
            // 
            this.txt_celsuis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_celsuis.Location = new System.Drawing.Point(151, 88);
            this.txt_celsuis.Name = "txt_celsuis";
            this.txt_celsuis.Size = new System.Drawing.Size(118, 29);
            this.txt_celsuis.TabIndex = 4;
            // 
            // txt_kelvin
            // 
            this.txt_kelvin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_kelvin.Location = new System.Drawing.Point(151, 133);
            this.txt_kelvin.Name = "txt_kelvin";
            this.txt_kelvin.Size = new System.Drawing.Size(118, 29);
            this.txt_kelvin.TabIndex = 5;
            this.txt_kelvin.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(287, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_celsuis
            // 
            this.btn_celsuis.Location = new System.Drawing.Point(287, 94);
            this.btn_celsuis.Name = "btn_celsuis";
            this.btn_celsuis.Size = new System.Drawing.Size(75, 23);
            this.btn_celsuis.TabIndex = 7;
            this.btn_celsuis.Text = "Convert";
            this.btn_celsuis.UseVisualStyleBackColor = true;
            // 
            // btn_kelvin
            // 
            this.btn_kelvin.Location = new System.Drawing.Point(287, 139);
            this.btn_kelvin.Name = "btn_kelvin";
            this.btn_kelvin.Size = new System.Drawing.Size(75, 23);
            this.btn_kelvin.TabIndex = 8;
            this.btn_kelvin.Text = "Convert";
            this.btn_kelvin.UseVisualStyleBackColor = true;
            // 
            // txt_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 210);
            this.Controls.Add(this.btn_kelvin);
            this.Controls.Add(this.btn_celsuis);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_kelvin);
            this.Controls.Add(this.txt_celsuis);
            this.Controls.Add(this.txt_fahrenheit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_fahrenheit);
            this.Name = "txt_";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btn_fahrenheit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_fahrenheit;
        private System.Windows.Forms.TextBox txt_celsuis;
        private System.Windows.Forms.TextBox txt_kelvin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_celsuis;
        private System.Windows.Forms.Button btn_kelvin;
    }
}

