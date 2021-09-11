
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
            this.ucShopItem2 = new Cliente_TulaWoW.vista.user_controls.UCShopItem();
            this.ucShopItem1 = new Cliente_TulaWoW.vista.user_controls.UCShopItem();
            this.ucShopItem3 = new Cliente_TulaWoW.vista.user_controls.UCShopItem();
            this.ucNavBar1 = new Cliente_TulaWoW.vista.user_controls.UCNavBar();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.ucShopItem4 = new Cliente_TulaWoW.vista.user_controls.UCShopItem();
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
            this.customPanel1.Controls.Add(this.ucShopItem4);
            this.customPanel1.Controls.Add(this.ucShopItem3);
            this.customPanel1.Controls.Add(this.ucShopItem1);
            this.customPanel1.Controls.Add(this.ucShopItem2);
            this.customPanel1.Controls.Add(this.ucNavBar1);
            this.customPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customPanel1.Location = new System.Drawing.Point(0, 0);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(1024, 576);
            this.customPanel1.TabIndex = 2;
            // 
            // ucShopItem2
            // 
            this.ucShopItem2.BackColor = System.Drawing.Color.Transparent;
            this.ucShopItem2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucShopItem2.BackgroundImage")));
            this.ucShopItem2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucShopItem2.Fondo = ((System.Drawing.Image)(resources.GetObject("ucShopItem2.Fondo")));
            this.ucShopItem2.ItemDesc = "Raza";
            this.ucShopItem2.ItemName = "Blood elf";
            this.ucShopItem2.ItemPrice = "10 DP";
            this.ucShopItem2.Location = new System.Drawing.Point(100, 100);
            this.ucShopItem2.Margin = new System.Windows.Forms.Padding(0);
            this.ucShopItem2.MaximumSize = new System.Drawing.Size(200, 300);
            this.ucShopItem2.MinimumSize = new System.Drawing.Size(200, 300);
            this.ucShopItem2.Name = "ucShopItem2";
            this.ucShopItem2.Padding = new System.Windows.Forms.Padding(10);
            this.ucShopItem2.Size = new System.Drawing.Size(200, 300);
            this.ucShopItem2.TabIndex = 2;
            // 
            // ucShopItem1
            // 
            this.ucShopItem1.BackColor = System.Drawing.Color.Transparent;
            this.ucShopItem1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucShopItem1.BackgroundImage")));
            this.ucShopItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucShopItem1.Fondo = ((System.Drawing.Image)(resources.GetObject("ucShopItem1.Fondo")));
            this.ucShopItem1.ItemDesc = "Clase";
            this.ucShopItem1.ItemName = "Death knight";
            this.ucShopItem1.ItemPrice = "50 DP";
            this.ucShopItem1.Location = new System.Drawing.Point(412, 100);
            this.ucShopItem1.Margin = new System.Windows.Forms.Padding(0);
            this.ucShopItem1.MaximumSize = new System.Drawing.Size(200, 300);
            this.ucShopItem1.MinimumSize = new System.Drawing.Size(200, 300);
            this.ucShopItem1.Name = "ucShopItem1";
            this.ucShopItem1.Padding = new System.Windows.Forms.Padding(10);
            this.ucShopItem1.Size = new System.Drawing.Size(200, 300);
            this.ucShopItem1.TabIndex = 3;
            // 
            // ucShopItem3
            // 
            this.ucShopItem3.BackColor = System.Drawing.Color.Transparent;
            this.ucShopItem3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucShopItem3.BackgroundImage")));
            this.ucShopItem3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucShopItem3.Fondo = ((System.Drawing.Image)(resources.GetObject("ucShopItem3.Fondo")));
            this.ucShopItem3.ItemDesc = "Raza";
            this.ucShopItem3.ItemName = "Draenei";
            this.ucShopItem3.ItemPrice = "10 DP";
            this.ucShopItem3.Location = new System.Drawing.Point(724, 100);
            this.ucShopItem3.Margin = new System.Windows.Forms.Padding(0);
            this.ucShopItem3.MaximumSize = new System.Drawing.Size(200, 300);
            this.ucShopItem3.MinimumSize = new System.Drawing.Size(200, 300);
            this.ucShopItem3.Name = "ucShopItem3";
            this.ucShopItem3.Padding = new System.Windows.Forms.Padding(10);
            this.ucShopItem3.Size = new System.Drawing.Size(200, 300);
            this.ucShopItem3.TabIndex = 4;
            // 
            // ucNavBar1
            // 
            this.ucNavBar1.BackColor = System.Drawing.Color.Transparent;
            this.ucNavBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucNavBar1.Location = new System.Drawing.Point(0, 0);
            this.ucNavBar1.Name = "ucNavBar1";
            this.ucNavBar1.Size = new System.Drawing.Size(1024, 70);
            this.ucNavBar1.TabIndex = 0;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.ucNavBar1;
            // 
            // ucShopItem4
            // 
            this.ucShopItem4.BackColor = System.Drawing.Color.Transparent;
            this.ucShopItem4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucShopItem4.BackgroundImage")));
            this.ucShopItem4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucShopItem4.Fondo = ((System.Drawing.Image)(resources.GetObject("ucShopItem4.Fondo")));
            this.ucShopItem4.ItemDesc = "Raza";
            this.ucShopItem4.ItemName = "Elfo de sangre";
            this.ucShopItem4.ItemPrice = "10 DP";
            this.ucShopItem4.Location = new System.Drawing.Point(100, 428);
            this.ucShopItem4.Margin = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.ucShopItem4.MaximumSize = new System.Drawing.Size(200, 300);
            this.ucShopItem4.MinimumSize = new System.Drawing.Size(200, 300);
            this.ucShopItem4.Name = "ucShopItem4";
            this.ucShopItem4.Padding = new System.Windows.Forms.Padding(10);
            this.ucShopItem4.Size = new System.Drawing.Size(200, 300);
            this.ucShopItem4.TabIndex = 5;
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
        private vista.user_controls.UCShopItem ucShopItem2;
        private vista.user_controls.UCShopItem ucShopItem3;
        private vista.user_controls.UCShopItem ucShopItem1;
        private vista.user_controls.UCShopItem ucShopItem4;
    }
}