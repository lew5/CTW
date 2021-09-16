
namespace Cliente_TulaWoW.vista.user_controls
{
    partial class UCSeccionCambios
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
            this.button1 = new System.Windows.Forms.Button();
            this.gunaVScrollBar1 = new Guna.UI.WinForms.GunaVScrollBar();
            this.customFlowLayoutPanel1 = new Cliente_TulaWoW.CustomFlowLayoutPanel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(487, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gunaVScrollBar1
            // 
            this.gunaVScrollBar1.LargeChange = 10;
            this.gunaVScrollBar1.Location = new System.Drawing.Point(930, 30);
            this.gunaVScrollBar1.Maximum = 100;
            this.gunaVScrollBar1.Name = "gunaVScrollBar1";
            this.gunaVScrollBar1.ScrollIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.gunaVScrollBar1.Size = new System.Drawing.Size(10, 463);
            this.gunaVScrollBar1.TabIndex = 4;
            this.gunaVScrollBar1.ThumbColor = System.Drawing.Color.Chocolate;
            this.gunaVScrollBar1.ThumbHoverColor = System.Drawing.Color.Peru;
            this.gunaVScrollBar1.ThumbPressedColor = System.Drawing.Color.SaddleBrown;
            // 
            // customFlowLayoutPanel1
            // 
            this.customFlowLayoutPanel1.AutoScroll = true;
            this.customFlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.customFlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customFlowLayoutPanel1.Location = new System.Drawing.Point(90, 30);
            this.customFlowLayoutPanel1.Name = "customFlowLayoutPanel1";
            this.customFlowLayoutPanel1.Size = new System.Drawing.Size(844, 466);
            this.customFlowLayoutPanel1.TabIndex = 0;
            // 
            // UCSeccionCambios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaVScrollBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.customFlowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(1024, 506);
            this.MinimumSize = new System.Drawing.Size(1024, 506);
            this.Name = "UCSeccionCambios";
            this.Padding = new System.Windows.Forms.Padding(90, 30, 90, 10);
            this.Size = new System.Drawing.Size(1024, 506);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomFlowLayoutPanel customFlowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private Guna.UI.WinForms.GunaVScrollBar gunaVScrollBar1;
    }
}
