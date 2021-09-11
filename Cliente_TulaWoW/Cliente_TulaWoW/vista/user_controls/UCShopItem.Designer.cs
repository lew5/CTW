
namespace Cliente_TulaWoW.vista.user_controls
{
    partial class UCShopItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCShopItem));
            this.glbl_ItemName = new Guna.UI.WinForms.GunaLabel();
            this.glbl_ItemDesc = new Guna.UI.WinForms.GunaLabel();
            this.glbl_ItemPrice = new Guna.UI.WinForms.GunaLabel();
            this.ggbtn_buy = new Guna.UI.WinForms.GunaGradientButton();
            this.SuspendLayout();
            // 
            // glbl_ItemName
            // 
            this.glbl_ItemName.AutoSize = true;
            this.glbl_ItemName.BackColor = System.Drawing.Color.Transparent;
            this.glbl_ItemName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glbl_ItemName.ForeColor = System.Drawing.Color.White;
            this.glbl_ItemName.Location = new System.Drawing.Point(10, 200);
            this.glbl_ItemName.Margin = new System.Windows.Forms.Padding(0);
            this.glbl_ItemName.Name = "glbl_ItemName";
            this.glbl_ItemName.Size = new System.Drawing.Size(132, 25);
            this.glbl_ItemName.TabIndex = 0;
            this.glbl_ItemName.Text = "Elfo de sangre";
            this.glbl_ItemName.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // glbl_ItemDesc
            // 
            this.glbl_ItemDesc.AutoSize = true;
            this.glbl_ItemDesc.BackColor = System.Drawing.Color.Transparent;
            this.glbl_ItemDesc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glbl_ItemDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.glbl_ItemDesc.Location = new System.Drawing.Point(13, 225);
            this.glbl_ItemDesc.Margin = new System.Windows.Forms.Padding(0);
            this.glbl_ItemDesc.Name = "glbl_ItemDesc";
            this.glbl_ItemDesc.Size = new System.Drawing.Size(43, 21);
            this.glbl_ItemDesc.TabIndex = 1;
            this.glbl_ItemDesc.Text = "Raza";
            this.glbl_ItemDesc.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // glbl_ItemPrice
            // 
            this.glbl_ItemPrice.AutoSize = true;
            this.glbl_ItemPrice.BackColor = System.Drawing.Color.Transparent;
            this.glbl_ItemPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glbl_ItemPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(150)))), ((int)(((byte)(1)))));
            this.glbl_ItemPrice.Location = new System.Drawing.Point(10, 260);
            this.glbl_ItemPrice.Margin = new System.Windows.Forms.Padding(0);
            this.glbl_ItemPrice.Name = "glbl_ItemPrice";
            this.glbl_ItemPrice.Size = new System.Drawing.Size(70, 30);
            this.glbl_ItemPrice.TabIndex = 2;
            this.glbl_ItemPrice.Text = "10 DP";
            this.glbl_ItemPrice.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // ggbtn_buy
            // 
            this.ggbtn_buy.AnimationHoverSpeed = 0.07F;
            this.ggbtn_buy.AnimationSpeed = 0.03F;
            this.ggbtn_buy.BackColor = System.Drawing.Color.Transparent;
            this.ggbtn_buy.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(75)))), ((int)(((byte)(21)))));
            this.ggbtn_buy.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(47)))), ((int)(((byte)(1)))));
            this.ggbtn_buy.BorderColor = System.Drawing.Color.Black;
            this.ggbtn_buy.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ggbtn_buy.FocusedColor = System.Drawing.Color.Empty;
            this.ggbtn_buy.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ggbtn_buy.ForeColor = System.Drawing.Color.White;
            this.ggbtn_buy.Image = null;
            this.ggbtn_buy.ImageSize = new System.Drawing.Size(20, 20);
            this.ggbtn_buy.Location = new System.Drawing.Point(100, 263);
            this.ggbtn_buy.Margin = new System.Windows.Forms.Padding(0);
            this.ggbtn_buy.Name = "ggbtn_buy";
            this.ggbtn_buy.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(85)))), ((int)(((byte)(31)))));
            this.ggbtn_buy.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(57)))), ((int)(((byte)(11)))));
            this.ggbtn_buy.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ggbtn_buy.OnHoverForeColor = System.Drawing.Color.White;
            this.ggbtn_buy.OnHoverImage = null;
            this.ggbtn_buy.OnPressedColor = System.Drawing.Color.Black;
            this.ggbtn_buy.OnPressedDepth = 10;
            this.ggbtn_buy.Radius = 12;
            this.ggbtn_buy.Size = new System.Drawing.Size(90, 24);
            this.ggbtn_buy.TabIndex = 3;
            this.ggbtn_buy.Text = "COMPRAR";
            this.ggbtn_buy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ggbtn_buy.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // UCShopItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.ggbtn_buy);
            this.Controls.Add(this.glbl_ItemPrice);
            this.Controls.Add(this.glbl_ItemDesc);
            this.Controls.Add(this.glbl_ItemName);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.MaximumSize = new System.Drawing.Size(200, 300);
            this.MinimumSize = new System.Drawing.Size(200, 300);
            this.Name = "UCShopItem";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(200, 300);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel glbl_ItemName;
        private Guna.UI.WinForms.GunaLabel glbl_ItemDesc;
        private Guna.UI.WinForms.GunaLabel glbl_ItemPrice;
        private Guna.UI.WinForms.GunaGradientButton ggbtn_buy;
    }
}
