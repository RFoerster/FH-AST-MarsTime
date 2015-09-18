namespace MarsTime
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_CalcIntervall = new System.Windows.Forms.Button();
            this.txt_int1_from_hour = new System.Windows.Forms.TextBox();
            this.txt_int1_from_minute = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_int1_to_minute = new System.Windows.Forms.TextBox();
            this.txt_int1_to_hour = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_int2_to_minute = new System.Windows.Forms.TextBox();
            this.txt_int2_to_hour = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_int2_from_minute = new System.Windows.Forms.TextBox();
            this.txt_int2_from_hour = new System.Windows.Forms.TextBox();
            this.btn_ResetForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_CalcIntervall
            // 
            this.btn_CalcIntervall.Location = new System.Drawing.Point(30, 86);
            this.btn_CalcIntervall.Name = "btn_CalcIntervall";
            this.btn_CalcIntervall.Size = new System.Drawing.Size(164, 23);
            this.btn_CalcIntervall.TabIndex = 23;
            this.btn_CalcIntervall.Text = "Calculate Intervall State";
            this.btn_CalcIntervall.UseVisualStyleBackColor = true;
            this.btn_CalcIntervall.Click += new System.EventHandler(this.btn_CalcIntervall_Click);
            // 
            // txt_int1_from_hour
            // 
            this.txt_int1_from_hour.Location = new System.Drawing.Point(152, 20);
            this.txt_int1_from_hour.Name = "txt_int1_from_hour";
            this.txt_int1_from_hour.Size = new System.Drawing.Size(42, 20);
            this.txt_int1_from_hour.TabIndex = 1;
            // 
            // txt_int1_from_minute
            // 
            this.txt_int1_from_minute.Location = new System.Drawing.Point(210, 20);
            this.txt_int1_from_minute.Name = "txt_int1_from_minute";
            this.txt_int1_from_minute.Size = new System.Drawing.Size(42, 20);
            this.txt_int1_from_minute.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mars Intervall 1 (hh:mm)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = ":";
            // 
            // txt_int1_to_minute
            // 
            this.txt_int1_to_minute.Location = new System.Drawing.Point(328, 20);
            this.txt_int1_to_minute.Name = "txt_int1_to_minute";
            this.txt_int1_to_minute.Size = new System.Drawing.Size(42, 20);
            this.txt_int1_to_minute.TabIndex = 14;
            // 
            // txt_int1_to_hour
            // 
            this.txt_int1_to_hour.Location = new System.Drawing.Point(270, 20);
            this.txt_int1_to_hour.Name = "txt_int1_to_hour";
            this.txt_int1_to_hour.Size = new System.Drawing.Size(42, 20);
            this.txt_int1_to_hour.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = ":";
            // 
            // txt_int2_to_minute
            // 
            this.txt_int2_to_minute.Location = new System.Drawing.Point(328, 46);
            this.txt_int2_to_minute.Name = "txt_int2_to_minute";
            this.txt_int2_to_minute.Size = new System.Drawing.Size(42, 20);
            this.txt_int2_to_minute.TabIndex = 22;
            // 
            // txt_int2_to_hour
            // 
            this.txt_int2_to_hour.Location = new System.Drawing.Point(270, 46);
            this.txt_int2_to_hour.Name = "txt_int2_to_hour";
            this.txt_int2_to_hour.Size = new System.Drawing.Size(42, 20);
            this.txt_int2_to_hour.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(197, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Mars Intervall 2 (hh:mm)";
            // 
            // txt_int2_from_minute
            // 
            this.txt_int2_from_minute.Location = new System.Drawing.Point(210, 46);
            this.txt_int2_from_minute.Name = "txt_int2_from_minute";
            this.txt_int2_from_minute.Size = new System.Drawing.Size(42, 20);
            this.txt_int2_from_minute.TabIndex = 17;
            // 
            // txt_int2_from_hour
            // 
            this.txt_int2_from_hour.Location = new System.Drawing.Point(152, 46);
            this.txt_int2_from_hour.Name = "txt_int2_from_hour";
            this.txt_int2_from_hour.Size = new System.Drawing.Size(42, 20);
            this.txt_int2_from_hour.TabIndex = 16;
            // 
            // btn_ResetForm
            // 
            this.btn_ResetForm.Location = new System.Drawing.Point(222, 86);
            this.btn_ResetForm.Name = "btn_ResetForm";
            this.btn_ResetForm.Size = new System.Drawing.Size(148, 23);
            this.btn_ResetForm.TabIndex = 24;
            this.btn_ResetForm.Text = "Reset Form";
            this.btn_ResetForm.UseVisualStyleBackColor = true;
            this.btn_ResetForm.Click += new System.EventHandler(this.btn_ResetForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 253);
            this.Controls.Add(this.btn_ResetForm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_int2_to_minute);
            this.Controls.Add(this.txt_int2_to_hour);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_int2_from_minute);
            this.Controls.Add(this.txt_int2_from_hour);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_int1_to_minute);
            this.Controls.Add(this.txt_int1_to_hour);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_int1_from_minute);
            this.Controls.Add(this.txt_int1_from_hour);
            this.Controls.Add(this.btn_CalcIntervall);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_CalcIntervall;
        private System.Windows.Forms.TextBox txt_int1_from_hour;
        private System.Windows.Forms.TextBox txt_int1_from_minute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_int1_to_minute;
        private System.Windows.Forms.TextBox txt_int1_to_hour;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_int2_to_minute;
        private System.Windows.Forms.TextBox txt_int2_to_hour;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_int2_from_minute;
        private System.Windows.Forms.TextBox txt_int2_from_hour;
        private System.Windows.Forms.Button btn_ResetForm;
    }
}

