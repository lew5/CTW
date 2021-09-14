
namespace Cliente_TulaWoW
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.customPanel1 = new Cliente_TulaWoW.CustomPanel();
            this.cpnl_seccionContenedor = new System.Windows.Forms.Panel();
            this.ucNavBar1 = new Cliente_TulaWoW.vista.user_controls.UCNavBar();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.customPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 20;
            this.gunaElipse1.TargetControl = this;
            // 
            // customPanel1
            // 
            this.customPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("customPanel1.BackgroundImage")));
            this.customPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.customPanel1.Controls.Add(this.cpnl_seccionContenedor);
            this.customPanel1.Controls.Add(this.ucNavBar1);
            this.customPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customPanel1.Location = new System.Drawing.Point(0, 0);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(1024, 576);
            this.customPanel1.TabIndex = 2;
            // 
            // cpnl_seccionContenedor
            // 
            this.cpnl_seccionContenedor.BackColor = System.Drawing.Color.Transparent;
            this.cpnl_seccionContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cpnl_seccionContenedor.Location = new System.Drawing.Point(0, 70);
            this.cpnl_seccionContenedor.Margin = new System.Windows.Forms.Padding(0);
            this.cpnl_seccionContenedor.Name = "cpnl_seccionContenedor";
            this.cpnl_seccionContenedor.Size = new System.Drawing.Size(1024, 506);
            this.cpnl_seccionContenedor.TabIndex = 1;
            // 
            // ucNavBar1
            // 
            this.ucNavBar1.BackColor = System.Drawing.Color.Transparent;
            this.ucNavBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucNavBar1.Location = new System.Drawing.Point(0, 0);
            this.ucNavBar1.Name = "ucNavBar1";
            this.ucNavBar1.Size = new System.Drawing.Size(1024, 70);
            this.ucNavBar1.TabIndex = 0;
            this.ucNavBar1.ButtonJuegoClick += new System.EventHandler(this.ucNavBar1_ButtonJuegoClick);
            this.ucNavBar1.ButtonCambiosClick += new System.EventHandler(this.ucNavBar1_ButtonCambiosClick);
            this.ucNavBar1.ButtonTiendaClick += new System.EventHandler(this.ucNavBar1_ButtonTiendaClick);
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.ucNavBar1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(12)))), ((int)(((byte)(9)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1024, 576);
            this.Controls.Add(this.customPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.customPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private CustomPanel customPanel1;
        private vista.user_controls.UCNavBar ucNavBar1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private System.Windows.Forms.Panel cpnl_seccionContenedor;
    }
}