
namespace Cliente_TulaWoW.vista.user_controls
{
    partial class UCNavBar_button
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
            this.glbl_Text = new Cliente_TulaWoW.vista.custom.CustomGLabel();
            this.SuspendLayout();
            // 
            // glbl_Text
            // 
            this.glbl_Text.AutoSize = true;
            this.glbl_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.glbl_Text.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glbl_Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.glbl_Text.Location = new System.Drawing.Point(0, 0);
            this.glbl_Text.Name = "glbl_Text";
            this.glbl_Text.Size = new System.Drawing.Size(120, 27);
            this.glbl_Text.TabIndex = 2;
            this.glbl_Text.Text = "CAMBIOS";
            this.glbl_Text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.glbl_Text.Click += new System.EventHandler(this.glbl_Text_Click);
            this.glbl_Text.MouseEnter += new System.EventHandler(this.glbl_Text_MouseEnter);
            this.glbl_Text.MouseLeave += new System.EventHandler(this.glbl_Text_MouseLeave);
            // 
            // UCNavBar_button
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.glbl_Text);
            this.Name = "UCNavBar_button";
            this.Size = new System.Drawing.Size(120, 27);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private custom.CustomGLabel glbl_Text;
    }
}
