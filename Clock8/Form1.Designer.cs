
namespace Clock8
{
    partial class Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Screen));
            this.L0 = new System.Windows.Forms.Label();
            this.L1 = new System.Windows.Forms.Label();
            this.L2 = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // L0
            // 
            this.L0.AutoSize = true;
            this.L0.Font = new System.Drawing.Font("Arial", 60F, System.Drawing.FontStyle.Bold);
            this.L0.ForeColor = System.Drawing.Color.White;
            this.L0.Location = new System.Drawing.Point(0, 0);
            this.L0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L0.Name = "L0";
            this.L0.Size = new System.Drawing.Size(0, 115);
            this.L0.TabIndex = 1;
            this.L0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // L1
            // 
            this.L1.AutoEllipsis = true;
            this.L1.AutoSize = true;
            this.L1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.L1.Font = new System.Drawing.Font("Times New Roman", 60F, System.Drawing.FontStyle.Bold);
            this.L1.ForeColor = System.Drawing.Color.White;
            this.L1.Location = new System.Drawing.Point(100, 135);
            this.L1.Margin = new System.Windows.Forms.Padding(0);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(73, 114);
            this.L1.TabIndex = 2;
            this.L1.Text = " ";
            this.L1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // L2
            // 
            this.L2.AutoEllipsis = true;
            this.L2.AutoSize = true;
            this.L2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.L2.Font = new System.Drawing.Font("Times New Roman", 60F, System.Drawing.FontStyle.Bold);
            this.L2.ForeColor = System.Drawing.Color.White;
            this.L2.Location = new System.Drawing.Point(0, 271);
            this.L2.Margin = new System.Windows.Forms.Padding(0);
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(198, 114);
            this.L2.TabIndex = 3;
            this.L2.Text = "      ";
            this.L2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1;
            this.Timer.Tick += new System.EventHandler(this.Tick);
            // 
            // Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(456, 383);
            this.Controls.Add(this.L2);
            this.Controls.Add(this.L1);
            this.Controls.Add(this.L0);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Screen";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "השעון הקטן ד";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L0;
        private System.Windows.Forms.Label L1;
        private System.Windows.Forms.Label L2;
        private System.Windows.Forms.Timer Timer;
    }
}

