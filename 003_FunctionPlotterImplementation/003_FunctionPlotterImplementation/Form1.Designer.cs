﻿namespace _003_FunctionPlotterImplementation
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
            this.Txt_m = new System.Windows.Forms.TextBox();
            this.Txt_t = new System.Windows.Forms.TextBox();
            this.Lbl_m = new System.Windows.Forms.Label();
            this.Lbl_t = new System.Windows.Forms.Label();
            this.Btn_Done = new System.Windows.Forms.Button();
            this.ListView1 = new System.Windows.Forms.ListView();
            this.ListView2 = new System.Windows.Forms.ListView();
            this.Lbl_Range = new System.Windows.Forms.Label();
            this.Lbl_Range_1 = new System.Windows.Forms.Label();
            this.Txt_Lo = new System.Windows.Forms.TextBox();
            this.Txt_Hi = new System.Windows.Forms.TextBox();
            this.Lbl_i = new System.Windows.Forms.Label();
            this.Txt_i = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Txt_m
            // 
            this.Txt_m.Location = new System.Drawing.Point(34, 9);
            this.Txt_m.Name = "Txt_m";
            this.Txt_m.Size = new System.Drawing.Size(35, 20);
            this.Txt_m.TabIndex = 0;
            // 
            // Txt_t
            // 
            this.Txt_t.Location = new System.Drawing.Point(34, 35);
            this.Txt_t.Name = "Txt_t";
            this.Txt_t.Size = new System.Drawing.Size(35, 20);
            this.Txt_t.TabIndex = 1;
            // 
            // Lbl_m
            // 
            this.Lbl_m.AutoSize = true;
            this.Lbl_m.Location = new System.Drawing.Point(13, 12);
            this.Lbl_m.Name = "Lbl_m";
            this.Lbl_m.Size = new System.Drawing.Size(15, 13);
            this.Lbl_m.TabIndex = 2;
            this.Lbl_m.Text = "m";
            // 
            // Lbl_t
            // 
            this.Lbl_t.AutoSize = true;
            this.Lbl_t.Location = new System.Drawing.Point(18, 35);
            this.Lbl_t.Name = "Lbl_t";
            this.Lbl_t.Size = new System.Drawing.Size(10, 13);
            this.Lbl_t.TabIndex = 3;
            this.Lbl_t.Text = "t";
            // 
            // Btn_Done
            // 
            this.Btn_Done.Location = new System.Drawing.Point(12, 227);
            this.Btn_Done.Name = "Btn_Done";
            this.Btn_Done.Size = new System.Drawing.Size(75, 23);
            this.Btn_Done.TabIndex = 4;
            this.Btn_Done.Text = "Done";
            this.Btn_Done.UseVisualStyleBackColor = true;
            this.Btn_Done.Click += new System.EventHandler(this.Btn_done_Click);
            // 
            // ListView1
            // 
            this.ListView1.Location = new System.Drawing.Point(203, 35);
            this.ListView1.Name = "ListView1";
            this.ListView1.Size = new System.Drawing.Size(73, 360);
            this.ListView1.TabIndex = 5;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            // 
            // ListView2
            // 
            this.ListView2.Location = new System.Drawing.Point(282, 35);
            this.ListView2.Name = "ListView2";
            this.ListView2.Size = new System.Drawing.Size(73, 360);
            this.ListView2.TabIndex = 6;
            this.ListView2.UseCompatibleStateImageBehavior = false;
            // 
            // Lbl_Range
            // 
            this.Lbl_Range.AutoSize = true;
            this.Lbl_Range.Location = new System.Drawing.Point(48, 85);
            this.Lbl_Range.Name = "Lbl_Range";
            this.Lbl_Range.Size = new System.Drawing.Size(39, 13);
            this.Lbl_Range.TabIndex = 7;
            this.Lbl_Range.Text = "Range";
            // 
            // Lbl_Range_1
            // 
            this.Lbl_Range_1.AutoSize = true;
            this.Lbl_Range_1.Location = new System.Drawing.Point(61, 104);
            this.Lbl_Range_1.Name = "Lbl_Range_1";
            this.Lbl_Range_1.Size = new System.Drawing.Size(10, 13);
            this.Lbl_Range_1.TabIndex = 8;
            this.Lbl_Range_1.Text = "-";
            // 
            // Txt_Lo
            // 
            this.Txt_Lo.Location = new System.Drawing.Point(12, 101);
            this.Txt_Lo.Name = "Txt_Lo";
            this.Txt_Lo.Size = new System.Drawing.Size(43, 20);
            this.Txt_Lo.TabIndex = 9;
            // 
            // Txt_Hi
            // 
            this.Txt_Hi.Location = new System.Drawing.Point(77, 101);
            this.Txt_Hi.Name = "Txt_Hi";
            this.Txt_Hi.Size = new System.Drawing.Size(43, 20);
            this.Txt_Hi.TabIndex = 10;
            // 
            // Lbl_i
            // 
            this.Lbl_i.AutoSize = true;
            this.Lbl_i.Location = new System.Drawing.Point(33, 124);
            this.Lbl_i.Name = "Lbl_i";
            this.Lbl_i.Size = new System.Drawing.Size(54, 13);
            this.Lbl_i.TabIndex = 11;
            this.Lbl_i.Text = "Increment";
            // 
            // Txt_i
            // 
            this.Txt_i.Location = new System.Drawing.Point(42, 140);
            this.Txt_i.Name = "Txt_i";
            this.Txt_i.Size = new System.Drawing.Size(29, 20);
            this.Txt_i.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 407);
            this.Controls.Add(this.Txt_i);
            this.Controls.Add(this.Lbl_i);
            this.Controls.Add(this.Txt_Hi);
            this.Controls.Add(this.Txt_Lo);
            this.Controls.Add(this.Lbl_Range_1);
            this.Controls.Add(this.Lbl_Range);
            this.Controls.Add(this.ListView2);
            this.Controls.Add(this.ListView1);
            this.Controls.Add(this.Btn_Done);
            this.Controls.Add(this.Lbl_t);
            this.Controls.Add(this.Lbl_m);
            this.Controls.Add(this.Txt_t);
            this.Controls.Add(this.Txt_m);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_m;
        private System.Windows.Forms.TextBox Txt_t;
        private System.Windows.Forms.Label Lbl_m;
        private System.Windows.Forms.Label Lbl_t;
        private System.Windows.Forms.Button Btn_Done;
        private System.Windows.Forms.ListView ListView1;
        private System.Windows.Forms.ListView ListView2;
        private System.Windows.Forms.Label Lbl_Range;
        private System.Windows.Forms.Label Lbl_Range_1;
        private System.Windows.Forms.TextBox Txt_Lo;
        private System.Windows.Forms.TextBox Txt_Hi;
        private System.Windows.Forms.Label Lbl_i;
        private System.Windows.Forms.TextBox Txt_i;
    }
}

