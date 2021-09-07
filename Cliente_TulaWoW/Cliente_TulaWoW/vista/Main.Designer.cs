
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
            this.ucNavBar1 = new Cliente_TulaWoW.vista.user_controls.UCNavBar();
            this.ucShopItem_rc1 = new Cliente_TulaWoW.vista.user_controls.UCShopItem_rc();
            this.ucShopItem_rc2 = new Cliente_TulaWoW.vista.user_controls.UCShopItem_rc();
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
            this.customPanel1.Controls.Add(this.ucShopItem_rc2);
            this.customPanel1.Controls.Add(this.ucShopItem_rc1);
            this.customPanel1.Controls.Add(this.ucNavBar1);
            this.customPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customPanel1.Location = new System.Drawing.Point(0, 0);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(1024, 576);
            this.customPanel1.TabIndex = 2;
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
            // ucShopItem_rc1
            // 
            this.ucShopItem_rc1.BackColor = System.Drawing.Color.Transparent;
            this.ucShopItem_rc1.BtnBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(75)))), ((int)(((byte)(21)))));
            this.ucShopItem_rc1.BtnBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(47)))), ((int)(((byte)(1)))));
            this.ucShopItem_rc1.BtnHoverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(85)))), ((int)(((byte)(31)))));
            this.ucShopItem_rc1.BtnHoverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(57)))), ((int)(((byte)(11)))));
            this.ucShopItem_rc1.Fondo = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.ucShopItem_rc1.Habilidades = ((System.Drawing.Image)(resources.GetObject("ucShopItem_rc1.Habilidades")));
            this.ucShopItem_rc1.Img = ((System.Drawing.Image)(resources.GetObject("ucShopItem_rc1.Img")));
            this.ucShopItem_rc1.Location = new System.Drawing.Point(559, 76);
            this.ucShopItem_rc1.Name = "ucShopItem_rc1";
            this.ucShopItem_rc1.Nombre = "BLOOD ELF";
            this.ucShopItem_rc1.Size = new System.Drawing.Size(400, 248);
            this.ucShopItem_rc1.TabIndex = 1;
            // 
            // ucShopItem_rc2
            // 
            this.ucShopItem_rc2.BackColor = System.Drawing.Color.Transparent;
            this.ucShopItem_rc2.BtnBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(75)))), ((int)(((byte)(21)))));
            this.ucShopItem_rc2.BtnBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(47)))), ((int)(((byte)(1)))));
            this.ucShopItem_rc2.BtnHoverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(85)))), ((int)(((byte)(31)))));
            this.ucShopItem_rc2.BtnHoverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(57)))), ((int)(((byte)(11)))));
            this.ucShopItem_rc2.Fondo = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.ucShopItem_rc2.Habilidades = ((System.Drawing.Image)(resources.GetObject("ucShopItem_rc2.Habilidades")));
            this.ucShopItem_rc2.Img = ((System.Drawing.Image)(resources.GetObject("ucShopItem_rc2.Img")));
            this.ucShopItem_rc2.Location = new System.Drawing.Point(100, 76);
            this.ucShopItem_rc2.Name = "ucShopItem_rc2";
            this.ucShopItem_rc2.Nombre = "DRAENEI";
            this.ucShopItem_rc2.Size = new System.Drawing.Size(400, 248);
            this.ucShopItem_rc2.TabIndex = 2;
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
        private vista.user_controls.UCShopItem_rc ucShopItem_rc2;
        private vista.user_controls.UCShopItem_rc ucShopItem_rc1;
    }
}