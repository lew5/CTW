
namespace Cliente_TulaWoW.vista.user_controls
{
    partial class UCShopItem_rc
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCShopItem_rc));
            this.gepnl_fondo = new Guna.UI.WinForms.GunaElipsePanel();
            this.gtpbox_img = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.gtpbox_habilidades = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.glbl_nombre = new Guna.UI.WinForms.GunaLabel();
            this.ggbtn_comprar = new Guna.UI.WinForms.GunaGradientButton();
            this.gepnl_fondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gtpbox_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gtpbox_habilidades)).BeginInit();
            this.SuspendLayout();
            // 
            // gepnl_fondo
            // 
            this.gepnl_fondo.BackColor = System.Drawing.Color.Transparent;
            this.gepnl_fondo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.gepnl_fondo.Controls.Add(this.ggbtn_comprar);
            this.gepnl_fondo.Controls.Add(this.glbl_nombre);
            this.gepnl_fondo.Controls.Add(this.gtpbox_habilidades);
            this.gepnl_fondo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gepnl_fondo.Location = new System.Drawing.Point(0, 48);
            this.gepnl_fondo.Name = "gepnl_fondo";
            this.gepnl_fondo.Radius = 20;
            this.gepnl_fondo.Size = new System.Drawing.Size(400, 200);
            this.gepnl_fondo.TabIndex = 0;
            // 
            // gtpbox_img
            // 
            this.gtpbox_img.BackColor = System.Drawing.Color.Transparent;
            this.gtpbox_img.BaseColor = System.Drawing.Color.Black;
            this.gtpbox_img.Image = ((System.Drawing.Image)(resources.GetObject("gtpbox_img.Image")));
            this.gtpbox_img.Location = new System.Drawing.Point(208, 0);
            this.gtpbox_img.Margin = new System.Windows.Forms.Padding(0);
            this.gtpbox_img.MaximumSize = new System.Drawing.Size(192, 248);
            this.gtpbox_img.MinimumSize = new System.Drawing.Size(192, 248);
            this.gtpbox_img.Name = "gtpbox_img";
            this.gtpbox_img.Size = new System.Drawing.Size(192, 248);
            this.gtpbox_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gtpbox_img.TabIndex = 0;
            this.gtpbox_img.TabStop = false;
            // 
            // gtpbox_habilidades
            // 
            this.gtpbox_habilidades.BaseColor = System.Drawing.Color.Black;
            this.gtpbox_habilidades.Image = ((System.Drawing.Image)(resources.GetObject("gtpbox_habilidades.Image")));
            this.gtpbox_habilidades.Location = new System.Drawing.Point(20, 60);
            this.gtpbox_habilidades.Name = "gtpbox_habilidades";
            this.gtpbox_habilidades.Size = new System.Drawing.Size(119, 57);
            this.gtpbox_habilidades.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.gtpbox_habilidades.TabIndex = 0;
            this.gtpbox_habilidades.TabStop = false;
            // 
            // glbl_nombre
            // 
            this.glbl_nombre.AutoSize = true;
            this.glbl_nombre.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glbl_nombre.ForeColor = System.Drawing.Color.White;
            this.glbl_nombre.Location = new System.Drawing.Point(13, 10);
            this.glbl_nombre.Name = "glbl_nombre";
            this.glbl_nombre.Size = new System.Drawing.Size(153, 38);
            this.glbl_nombre.TabIndex = 1;
            this.glbl_nombre.Text = "DRAENEI";
            this.glbl_nombre.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // ggbtn_comprar
            // 
            this.ggbtn_comprar.AnimationHoverSpeed = 0.07F;
            this.ggbtn_comprar.AnimationSpeed = 0.03F;
            this.ggbtn_comprar.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(75)))), ((int)(((byte)(21)))));
            this.ggbtn_comprar.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(47)))), ((int)(((byte)(1)))));
            this.ggbtn_comprar.BorderColor = System.Drawing.Color.Black;
            this.ggbtn_comprar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ggbtn_comprar.FocusedColor = System.Drawing.Color.Empty;
            this.ggbtn_comprar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ggbtn_comprar.ForeColor = System.Drawing.Color.White;
            this.ggbtn_comprar.Image = null;
            this.ggbtn_comprar.ImageSize = new System.Drawing.Size(20, 20);
            this.ggbtn_comprar.Location = new System.Drawing.Point(20, 140);
            this.ggbtn_comprar.Name = "ggbtn_comprar";
            this.ggbtn_comprar.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(85)))), ((int)(((byte)(31)))));
            this.ggbtn_comprar.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(57)))), ((int)(((byte)(11)))));
            this.ggbtn_comprar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ggbtn_comprar.OnHoverForeColor = System.Drawing.Color.White;
            this.ggbtn_comprar.OnHoverImage = null;
            this.ggbtn_comprar.OnPressedColor = System.Drawing.Color.Black;
            this.ggbtn_comprar.Radius = 20;
            this.ggbtn_comprar.Size = new System.Drawing.Size(100, 40);
            this.ggbtn_comprar.TabIndex = 2;
            this.ggbtn_comprar.Text = "COMPRAR";
            this.ggbtn_comprar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ggbtn_comprar.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // UCShopItem_rc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gtpbox_img);
            this.Controls.Add(this.gepnl_fondo);
            this.Name = "UCShopItem_rc";
            this.Size = new System.Drawing.Size(400, 248);
            this.gepnl_fondo.ResumeLayout(false);
            this.gepnl_fondo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gtpbox_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gtpbox_habilidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel gepnl_fondo;
        private Guna.UI.WinForms.GunaTransfarantPictureBox gtpbox_img;
        private Guna.UI.WinForms.GunaTransfarantPictureBox gtpbox_habilidades;
        private Guna.UI.WinForms.GunaLabel glbl_nombre;
        private Guna.UI.WinForms.GunaGradientButton ggbtn_comprar;
    }
}
