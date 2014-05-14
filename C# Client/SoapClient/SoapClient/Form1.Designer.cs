namespace SoapClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnKGtoPound = new System.Windows.Forms.Button();
            this.btnPoundToKg = new System.Windows.Forms.Button();
            this.nudToKg = new System.Windows.Forms.NumericUpDown();
            this.nudFromPound = new System.Windows.Forms.NumericUpDown();
            this.nudFromkg = new System.Windows.Forms.NumericUpDown();
            this.nudToPound = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudToKg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFromPound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFromkg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudToPound)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kilograms To Pound";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "KG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(230, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "LBS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(94, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "LBS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(230, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "KG";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Pound To Kilograms  ";
            // 
            // btnKGtoPound
            // 
            this.btnKGtoPound.Location = new System.Drawing.Point(286, 42);
            this.btnKGtoPound.Name = "btnKGtoPound";
            this.btnKGtoPound.Size = new System.Drawing.Size(102, 23);
            this.btnKGtoPound.TabIndex = 10;
            this.btnKGtoPound.Text = "Convert";
            this.btnKGtoPound.UseVisualStyleBackColor = true;
            this.btnKGtoPound.Click += new System.EventHandler(this.btnKGtoPound_Click);
            // 
            // btnPoundToKg
            // 
            this.btnPoundToKg.Location = new System.Drawing.Point(286, 133);
            this.btnPoundToKg.Name = "btnPoundToKg";
            this.btnPoundToKg.Size = new System.Drawing.Size(102, 23);
            this.btnPoundToKg.TabIndex = 11;
            this.btnPoundToKg.Text = "Convert";
            this.btnPoundToKg.UseVisualStyleBackColor = true;
            this.btnPoundToKg.Click += new System.EventHandler(this.btnPoundToKg_Click);
            // 
            // nudToKg
            // 
            this.nudToKg.DecimalPlaces = 3;
            this.nudToKg.Location = new System.Drawing.Point(148, 136);
            this.nudToKg.Name = "nudToKg";
            this.nudToKg.Size = new System.Drawing.Size(76, 20);
            this.nudToKg.TabIndex = 15;
            this.nudToKg.Value = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            // 
            // nudFromPound
            // 
            this.nudFromPound.DecimalPlaces = 3;
            this.nudFromPound.Location = new System.Drawing.Point(16, 136);
            this.nudFromPound.Name = "nudFromPound";
            this.nudFromPound.Size = new System.Drawing.Size(76, 20);
            this.nudFromPound.TabIndex = 14;
            // 
            // nudFromkg
            // 
            this.nudFromkg.DecimalPlaces = 3;
            this.nudFromkg.Location = new System.Drawing.Point(16, 45);
            this.nudFromkg.Name = "nudFromkg";
            this.nudFromkg.Size = new System.Drawing.Size(76, 20);
            this.nudFromkg.TabIndex = 12;
            // 
            // nudToPound
            // 
            this.nudToPound.DecimalPlaces = 3;
            this.nudToPound.Location = new System.Drawing.Point(148, 45);
            this.nudToPound.Name = "nudToPound";
            this.nudToPound.Size = new System.Drawing.Size(76, 20);
            this.nudToPound.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 203);
            this.Controls.Add(this.nudToKg);
            this.Controls.Add(this.nudFromPound);
            this.Controls.Add(this.nudToPound);
            this.Controls.Add(this.nudFromkg);
            this.Controls.Add(this.btnPoundToKg);
            this.Controls.Add(this.btnKGtoPound);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Weight Converter Client";
            ((System.ComponentModel.ISupportInitialize)(this.nudToKg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFromPound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFromkg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudToPound)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnKGtoPound;
        private System.Windows.Forms.Button btnPoundToKg;
        private System.Windows.Forms.NumericUpDown nudToKg;
        private System.Windows.Forms.NumericUpDown nudFromPound;
        private System.Windows.Forms.NumericUpDown nudFromkg;
        private System.Windows.Forms.NumericUpDown nudToPound;
    }
}

