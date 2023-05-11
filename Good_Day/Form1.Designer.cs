using System;

namespace Good_Day
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
            this.L1 = new System.Windows.Forms.Label();
            this.L2 = new System.Windows.Forms.Label();
            this.L3 = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.L5 = new System.Windows.Forms.Label();
            this.L4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // L1
            // 
            resources.ApplyResources(this.L1, "L1");
            this.L1.BackColor = System.Drawing.Color.White;
            this.L1.Name = "L1";
            // 
            // L2
            // 
            resources.ApplyResources(this.L2, "L2");
            this.L2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(32)))), ((int)(((byte)(0)))));
            this.L2.ForeColor = System.Drawing.Color.White;
            this.L2.Name = "L2";
            // 
            // L3
            // 
            resources.ApplyResources(this.L3, "L3");
            this.L3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(32)))), ((int)(((byte)(0)))));
            this.L3.ForeColor = System.Drawing.Color.White;
            this.L3.Name = "L3";
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1;
            this.Timer.Tick += new System.EventHandler(this.Tick);
            // 
            // L5
            // 
            resources.ApplyResources(this.L5, "L5");
            this.L5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(48)))), ((int)(((byte)(0)))));
            this.L5.ForeColor = System.Drawing.Color.White;
            this.L5.Name = "L5";
            // 
            // L4
            // 
            resources.ApplyResources(this.L4, "L4");
            this.L4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(32)))), ((int)(((byte)(0)))));
            this.L4.ForeColor = System.Drawing.Color.White;
            this.L4.Name = "L4";
            // 
            // Screen
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.L4);
            this.Controls.Add(this.L5);
            this.Controls.Add(this.L3);
            this.Controls.Add(this.L2);
            this.Controls.Add(this.L1);
            this.MaximizeBox = false;
            this.Name = "Screen";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label L1;
        private System.Windows.Forms.Label L2;
        private System.Windows.Forms.Timer Timer;
        public System.Windows.Forms.Label L3;
        private System.Windows.Forms.Label L5;
        private System.Windows.Forms.Label L4;
    }
}

