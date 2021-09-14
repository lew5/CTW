
namespace Cliente_TulaWoW.test
{
    partial class tForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.tUCscroll1 = new Cliente_TulaWoW.test.tUCscroll();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 70);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tUCscroll1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1024, 506);
            this.panel2.TabIndex = 1;
            // 
            // tUCscroll1
            // 
            this.tUCscroll1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tUCscroll1.Location = new System.Drawing.Point(0, 0);
            this.tUCscroll1.Margin = new System.Windows.Forms.Padding(0);
            this.tUCscroll1.MaximumSize = new System.Drawing.Size(1024, 506);
            this.tUCscroll1.MinimumSize = new System.Drawing.Size(1024, 506);
            this.tUCscroll1.Name = "tUCscroll1";
            this.tUCscroll1.Padding = new System.Windows.Forms.Padding(100, 0, 100, 0);
            this.tUCscroll1.Size = new System.Drawing.Size(1024, 506);
            this.tUCscroll1.TabIndex = 0;
            // 
            // tForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 576);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tForm";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private tUCscroll tUCscroll1;
    }
}