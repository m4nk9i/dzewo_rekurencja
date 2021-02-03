namespace dzewo_rekurencja
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.trackBar5 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(287, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 636);
            this.panel1.TabIndex = 0;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(13, 54);
            this.trackBar1.Maximum = 60;
            this.trackBar1.Minimum = -60;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(241, 45);
            this.trackBar1.TabIndex = 1;
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(13, 106);
            this.trackBar2.Maximum = 60;
            this.trackBar2.Minimum = -60;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(241, 45);
            this.trackBar2.TabIndex = 2;
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(13, 158);
            this.trackBar3.Maximum = 60;
            this.trackBar3.Minimum = -60;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(241, 45);
            this.trackBar3.TabIndex = 3;
            // 
            // trackBar4
            // 
            this.trackBar4.Location = new System.Drawing.Point(13, 232);
            this.trackBar4.Maximum = 100;
            this.trackBar4.Minimum = 10;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(240, 45);
            this.trackBar4.TabIndex = 4;
            this.trackBar4.Value = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(177, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // trackBar5
            // 
            this.trackBar5.Location = new System.Drawing.Point(13, 344);
            this.trackBar5.Minimum = 3;
            this.trackBar5.Name = "trackBar5";
            this.trackBar5.Size = new System.Drawing.Size(241, 45);
            this.trackBar5.TabIndex = 6;
            this.trackBar5.Value = 3;
            this.trackBar5.Scroll += new System.EventHandler(this.trackBar5_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 663);
            this.Controls.Add(this.trackBar5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.trackBar4);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar trackBar5;
    }
}

