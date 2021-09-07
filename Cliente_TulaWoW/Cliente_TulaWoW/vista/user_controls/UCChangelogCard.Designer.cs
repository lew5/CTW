
namespace Cliente_TulaWoW.vista.user_controls
{
    partial class UCChangelogCard
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
            this.glpnl_contenedor = new Guna.UI.WinForms.GunaLinePanel();
            this.glpnl_contenedorFechaCambio = new Guna.UI.WinForms.GunaLinePanel();
            this.glbl_fechaCambio = new Guna.UI.WinForms.GunaLabel();
            this.glpnl_contenedor.SuspendLayout();
            this.glpnl_contenedorFechaCambio.SuspendLayout();
            this.SuspendLayout();
            // 
            // glpnl_contenedor
            // 
            this.glpnl_contenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.glpnl_contenedor.Controls.Add(this.glpnl_contenedorFechaCambio);
            this.glpnl_contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.glpnl_contenedor.LineBottom = 1;
            this.glpnl_contenedor.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(27)))), ((int)(((byte)(16)))));
            this.glpnl_contenedor.LineLeft = 1;
            this.glpnl_contenedor.LineRight = 1;
            this.glpnl_contenedor.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.glpnl_contenedor.LineTop = 1;
            this.glpnl_contenedor.Location = new System.Drawing.Point(0, 0);
            this.glpnl_contenedor.Margin = new System.Windows.Forms.Padding(0);
            this.glpnl_contenedor.Name = "glpnl_contenedor";
            this.glpnl_contenedor.Padding = new System.Windows.Forms.Padding(5);
            this.glpnl_contenedor.Size = new System.Drawing.Size(800, 50);
            this.glpnl_contenedor.TabIndex = 0;
            // 
            // glpnl_contenedorFechaCambio
            // 
            this.glpnl_contenedorFechaCambio.Controls.Add(this.glbl_fechaCambio);
            this.glpnl_contenedorFechaCambio.Dock = System.Windows.Forms.DockStyle.Top;
            this.glpnl_contenedorFechaCambio.LineBottom = 2;
            this.glpnl_contenedorFechaCambio.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(27)))), ((int)(((byte)(16)))));
            this.glpnl_contenedorFechaCambio.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.glpnl_contenedorFechaCambio.Location = new System.Drawing.Point(5, 5);
            this.glpnl_contenedorFechaCambio.Margin = new System.Windows.Forms.Padding(0);
            this.glpnl_contenedorFechaCambio.Name = "glpnl_contenedorFechaCambio";
            this.glpnl_contenedorFechaCambio.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.glpnl_contenedorFechaCambio.Size = new System.Drawing.Size(790, 40);
            this.glpnl_contenedorFechaCambio.TabIndex = 2;
            // 
            // glbl_fechaCambio
            // 
            this.glbl_fechaCambio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.glbl_fechaCambio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glbl_fechaCambio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(58)))), ((int)(((byte)(1)))));
            this.glbl_fechaCambio.Location = new System.Drawing.Point(0, 0);
            this.glbl_fechaCambio.Name = "glbl_fechaCambio";
            this.glbl_fechaCambio.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.glbl_fechaCambio.Size = new System.Drawing.Size(790, 38);
            this.glbl_fechaCambio.TabIndex = 0;
            this.glbl_fechaCambio.Text = "Changes made on 2021/08/14";
            this.glbl_fechaCambio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.glbl_fechaCambio.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // UCChangelogCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.glpnl_contenedor);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(800, 10000);
            this.MinimumSize = new System.Drawing.Size(800, 0);
            this.Name = "UCChangelogCard";
            this.Size = new System.Drawing.Size(800, 50);
            this.Load += new System.EventHandler(this.UCChangelogCard_Load);
            this.glpnl_contenedor.ResumeLayout(false);
            this.glpnl_contenedorFechaCambio.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLinePanel glpnl_contenedor;
        private Guna.UI.WinForms.GunaLabel glbl_fechaCambio;
        private Guna.UI.WinForms.GunaLinePanel glpnl_contenedorFechaCambio;
    }
}
