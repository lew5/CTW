
namespace Cliente_TulaWoW.vista.user_controls
{
    partial class UCCambio
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
            this.pnl_cambio = new System.Windows.Forms.Panel();
            this.pnl_contenedorDetalleCambio = new System.Windows.Forms.Panel();
            this.glbl_detalleCambio = new Guna.UI.WinForms.GunaLabel();
            this.pnl_contenedorCambio = new System.Windows.Forms.Panel();
            this.glbl_cambio = new Guna.UI.WinForms.GunaLabel();
            this.pnl_cambio.SuspendLayout();
            this.pnl_contenedorDetalleCambio.SuspendLayout();
            this.pnl_contenedorCambio.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_cambio
            // 
            this.pnl_cambio.Controls.Add(this.pnl_contenedorDetalleCambio);
            this.pnl_cambio.Controls.Add(this.pnl_contenedorCambio);
            this.pnl_cambio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_cambio.Location = new System.Drawing.Point(0, 0);
            this.pnl_cambio.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_cambio.Name = "pnl_cambio";
            this.pnl_cambio.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.pnl_cambio.Size = new System.Drawing.Size(790, 81);
            this.pnl_cambio.TabIndex = 3;
            // 
            // pnl_contenedorDetalleCambio
            // 
            this.pnl_contenedorDetalleCambio.Controls.Add(this.glbl_detalleCambio);
            this.pnl_contenedorDetalleCambio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_contenedorDetalleCambio.Location = new System.Drawing.Point(5, 40);
            this.pnl_contenedorDetalleCambio.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_contenedorDetalleCambio.MinimumSize = new System.Drawing.Size(780, 0);
            this.pnl_contenedorDetalleCambio.Name = "pnl_contenedorDetalleCambio";
            this.pnl_contenedorDetalleCambio.Size = new System.Drawing.Size(780, 41);
            this.pnl_contenedorDetalleCambio.TabIndex = 2;
            // 
            // glbl_detalleCambio
            // 
            this.glbl_detalleCambio.AutoSize = true;
            this.glbl_detalleCambio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.glbl_detalleCambio.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glbl_detalleCambio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(181)))), ((int)(((byte)(117)))));
            this.glbl_detalleCambio.Location = new System.Drawing.Point(0, 0);
            this.glbl_detalleCambio.MaximumSize = new System.Drawing.Size(768, 0);
            this.glbl_detalleCambio.Name = "glbl_detalleCambio";
            this.glbl_detalleCambio.Size = new System.Drawing.Size(24, 30);
            this.glbl_detalleCambio.TabIndex = 1;
            this.glbl_detalleCambio.Text = "a";
            this.glbl_detalleCambio.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // pnl_contenedorCambio
            // 
            this.pnl_contenedorCambio.Controls.Add(this.glbl_cambio);
            this.pnl_contenedorCambio.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_contenedorCambio.Location = new System.Drawing.Point(5, 0);
            this.pnl_contenedorCambio.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_contenedorCambio.Name = "pnl_contenedorCambio";
            this.pnl_contenedorCambio.Size = new System.Drawing.Size(780, 40);
            this.pnl_contenedorCambio.TabIndex = 3;
            // 
            // glbl_cambio
            // 
            this.glbl_cambio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.glbl_cambio.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glbl_cambio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(98)))), ((int)(((byte)(31)))));
            this.glbl_cambio.Location = new System.Drawing.Point(0, 0);
            this.glbl_cambio.Name = "glbl_cambio";
            this.glbl_cambio.Size = new System.Drawing.Size(780, 40);
            this.glbl_cambio.TabIndex = 0;
            this.glbl_cambio.Text = "HABILIDADES";
            this.glbl_cambio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.glbl_cambio.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // UCCambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Controls.Add(this.pnl_cambio);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(790, 10000);
            this.MinimumSize = new System.Drawing.Size(790, 0);
            this.Name = "UCCambio";
            this.Size = new System.Drawing.Size(790, 81);
            this.Load += new System.EventHandler(this.UCCambio_Load);
            this.pnl_cambio.ResumeLayout(false);
            this.pnl_contenedorDetalleCambio.ResumeLayout(false);
            this.pnl_contenedorDetalleCambio.PerformLayout();
            this.pnl_contenedorCambio.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_cambio;
        private System.Windows.Forms.Panel pnl_contenedorDetalleCambio;
        private Guna.UI.WinForms.GunaLabel glbl_detalleCambio;
        private System.Windows.Forms.Panel pnl_contenedorCambio;
        private Guna.UI.WinForms.GunaLabel glbl_cambio;
    }
}
