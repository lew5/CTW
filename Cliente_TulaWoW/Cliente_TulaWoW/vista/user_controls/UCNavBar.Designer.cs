
namespace Cliente_TulaWoW.vista.user_controls
{
    partial class UCNavBar
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
            this.ucNavBar_button3 = new Cliente_TulaWoW.vista.user_controls.UCNavBar_button();
            this.ucNavBar_button2 = new Cliente_TulaWoW.vista.user_controls.UCNavBar_button();
            this.ucNavBar_button1 = new Cliente_TulaWoW.vista.user_controls.UCNavBar_button();
            this.SuspendLayout();
            // 
            // ucNavBar_button3
            // 
            this.ucNavBar_button3.BackColor = System.Drawing.Color.Transparent;
            this.ucNavBar_button3.Check = false;
            this.ucNavBar_button3.Location = new System.Drawing.Point(375, 22);
            this.ucNavBar_button3.Name = "ucNavBar_button3";
            this.ucNavBar_button3.Size = new System.Drawing.Size(97, 27);
            this.ucNavBar_button3.TabIndex = 2;
            this.ucNavBar_button3.Txt = "TIENDA";
            // 
            // ucNavBar_button2
            // 
            this.ucNavBar_button2.BackColor = System.Drawing.Color.Transparent;
            this.ucNavBar_button2.Check = false;
            this.ucNavBar_button2.Location = new System.Drawing.Point(225, 22);
            this.ucNavBar_button2.Name = "ucNavBar_button2";
            this.ucNavBar_button2.Size = new System.Drawing.Size(120, 27);
            this.ucNavBar_button2.TabIndex = 1;
            this.ucNavBar_button2.Txt = "CAMBIOS";
            // 
            // ucNavBar_button1
            // 
            this.ucNavBar_button1.BackColor = System.Drawing.Color.Transparent;
            this.ucNavBar_button1.Check = true;
            this.ucNavBar_button1.Location = new System.Drawing.Point(100, 22);
            this.ucNavBar_button1.Name = "ucNavBar_button1";
            this.ucNavBar_button1.Size = new System.Drawing.Size(95, 27);
            this.ucNavBar_button1.TabIndex = 0;
            this.ucNavBar_button1.Txt = "JUEGO";
            // 
            // UCNavBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.ucNavBar_button3);
            this.Controls.Add(this.ucNavBar_button2);
            this.Controls.Add(this.ucNavBar_button1);
            this.Name = "UCNavBar";
            this.Size = new System.Drawing.Size(1024, 70);
            this.ResumeLayout(false);

        }

        #endregion

        private UCNavBar_button ucNavBar_button1;
        private UCNavBar_button ucNavBar_button2;
        private UCNavBar_button ucNavBar_button3;
    }
}
