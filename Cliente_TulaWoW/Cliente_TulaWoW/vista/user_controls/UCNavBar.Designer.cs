
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
            this.ucNavBar_buttonTienda = new Cliente_TulaWoW.vista.user_controls.UCNavBar_button();
            this.ucNavBar_buttonCambios = new Cliente_TulaWoW.vista.user_controls.UCNavBar_button();
            this.ucNavBar_buttonJuego = new Cliente_TulaWoW.vista.user_controls.UCNavBar_button();
            this.SuspendLayout();
            // 
            // ucNavBar_buttonTienda
            // 
            this.ucNavBar_buttonTienda.BackColor = System.Drawing.Color.Transparent;
            this.ucNavBar_buttonTienda.Check = false;
            this.ucNavBar_buttonTienda.Location = new System.Drawing.Point(375, 22);
            this.ucNavBar_buttonTienda.Name = "ucNavBar_buttonTienda";
            this.ucNavBar_buttonTienda.Size = new System.Drawing.Size(97, 27);
            this.ucNavBar_buttonTienda.TabIndex = 2;
            this.ucNavBar_buttonTienda.Txt = "TIENDA";
            this.ucNavBar_buttonTienda.ButtonClick += new System.EventHandler(this.ucNavBar_buttonTienda_ButtonClick);
            // 
            // ucNavBar_buttonCambios
            // 
            this.ucNavBar_buttonCambios.BackColor = System.Drawing.Color.Transparent;
            this.ucNavBar_buttonCambios.Check = false;
            this.ucNavBar_buttonCambios.Location = new System.Drawing.Point(225, 22);
            this.ucNavBar_buttonCambios.Name = "ucNavBar_buttonCambios";
            this.ucNavBar_buttonCambios.Size = new System.Drawing.Size(120, 27);
            this.ucNavBar_buttonCambios.TabIndex = 1;
            this.ucNavBar_buttonCambios.Txt = "CAMBIOS";
            this.ucNavBar_buttonCambios.ButtonClick += new System.EventHandler(this.ucNavBar_buttonCambios_ButtonClick);
            // 
            // ucNavBar_buttonJuego
            // 
            this.ucNavBar_buttonJuego.BackColor = System.Drawing.Color.Transparent;
            this.ucNavBar_buttonJuego.Check = true;
            this.ucNavBar_buttonJuego.Location = new System.Drawing.Point(100, 22);
            this.ucNavBar_buttonJuego.Name = "ucNavBar_buttonJuego";
            this.ucNavBar_buttonJuego.Size = new System.Drawing.Size(95, 27);
            this.ucNavBar_buttonJuego.TabIndex = 0;
            this.ucNavBar_buttonJuego.Txt = "JUEGO";
            this.ucNavBar_buttonJuego.ButtonClick += new System.EventHandler(this.ucNavBar_buttonJuego_ButtonClick);
            // 
            // UCNavBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.ucNavBar_buttonTienda);
            this.Controls.Add(this.ucNavBar_buttonCambios);
            this.Controls.Add(this.ucNavBar_buttonJuego);
            this.Name = "UCNavBar";
            this.Size = new System.Drawing.Size(1024, 70);
            this.ResumeLayout(false);

        }

        #endregion

        private UCNavBar_button ucNavBar_buttonJuego;
        private UCNavBar_button ucNavBar_buttonCambios;
        private UCNavBar_button ucNavBar_buttonTienda;
    }
}
