namespace IanDelgado_Proyecto_Progra2
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblOperador = new System.Windows.Forms.Label();
            this.nada = new System.Windows.Forms.Panel();
            this.lbltur = new System.Windows.Forms.Label();
            this.boton2 = new System.Windows.Forms.Button();
            this.boton1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fall0 = new System.Windows.Forms.Label();
            this.aci0 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblFallos = new System.Windows.Forms.Label();
            this.lblAciertos = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtRespuesta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.nada.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Aquamarine;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(407, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Juego ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Thistle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Operación";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblNum1
            // 
            this.lblNum1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNum1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNum1.Location = new System.Drawing.Point(60, 123);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(73, 26);
            this.lblNum1.TabIndex = 2;
            this.lblNum1.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblOperador
            // 
            this.lblOperador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOperador.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOperador.Location = new System.Drawing.Point(154, 123);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(95, 26);
            this.lblOperador.TabIndex = 3;
            this.lblOperador.Click += new System.EventHandler(this.label4_Click);
            // 
            // nada
            // 
            this.nada.BackColor = System.Drawing.Color.LightGreen;
            this.nada.Controls.Add(this.lbltur);
            this.nada.Controls.Add(this.boton2);
            this.nada.Controls.Add(this.boton1);
            this.nada.Controls.Add(this.label5);
            this.nada.Controls.Add(this.label4);
            this.nada.Controls.Add(this.fall0);
            this.nada.Controls.Add(this.label1);
            this.nada.Controls.Add(this.aci0);
            this.nada.Controls.Add(this.lbl1);
            this.nada.Controls.Add(this.lblFallos);
            this.nada.Controls.Add(this.lblAciertos);
            this.nada.Controls.Add(this.lblNivel);
            this.nada.Controls.Add(this.btnAceptar);
            this.nada.Controls.Add(this.txtRespuesta);
            this.nada.Controls.Add(this.label3);
            this.nada.Controls.Add(this.label7);
            this.nada.Controls.Add(this.label6);
            this.nada.Controls.Add(this.lblNum2);
            this.nada.Controls.Add(this.label2);
            this.nada.Controls.Add(this.lblOperador);
            this.nada.Controls.Add(this.lblNum1);
            this.nada.Location = new System.Drawing.Point(2, 1);
            this.nada.Name = "nada";
            this.nada.Size = new System.Drawing.Size(962, 568);
            this.nada.TabIndex = 4;
            this.nada.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbltur
            // 
            this.lbltur.BackColor = System.Drawing.Color.Yellow;
            this.lbltur.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbltur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltur.Location = new System.Drawing.Point(699, 200);
            this.lbltur.Name = "lbltur";
            this.lbltur.Size = new System.Drawing.Size(91, 67);
            this.lbltur.TabIndex = 20;
            this.lbltur.Text = "TURNO";
            this.lbltur.Click += new System.EventHandler(this.label8_Click);
            // 
            // boton2
            // 
            this.boton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton2.Location = new System.Drawing.Point(770, 113);
            this.boton2.Name = "boton2";
            this.boton2.Size = new System.Drawing.Size(100, 55);
            this.boton2.TabIndex = 19;
            this.boton2.Text = "Presione Aquí";
            this.boton2.UseVisualStyleBackColor = true;
            this.boton2.Click += new System.EventHandler(this.boton2_Click_1);
            // 
            // boton1
            // 
            this.boton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton1.Location = new System.Drawing.Point(614, 113);
            this.boton1.Name = "boton1";
            this.boton1.Size = new System.Drawing.Size(100, 55);
            this.boton1.TabIndex = 18;
            this.boton1.Text = "Presione Aquí";
            this.boton1.UseVisualStyleBackColor = true;
            this.boton1.Click += new System.EventHandler(this.btnAceptar_Click_1);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(749, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 27);
            this.label5.TabIndex = 17;
            this.label5.Text = "2 Jugadores";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(592, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 27);
            this.label4.TabIndex = 16;
            this.label4.Text = "1 Jugador";
            // 
            // fall0
            // 
            this.fall0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fall0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fall0.Location = new System.Drawing.Point(524, 371);
            this.fall0.Name = "fall0";
            this.fall0.Size = new System.Drawing.Size(84, 24);
            this.fall0.TabIndex = 15;
            this.fall0.Text = "0";
            // 
            // aci0
            // 
            this.aci0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aci0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aci0.Location = new System.Drawing.Point(337, 371);
            this.aci0.Name = "aci0";
            this.aci0.Size = new System.Drawing.Size(84, 24);
            this.aci0.TabIndex = 14;
            this.aci0.Text = "0";
            this.aci0.Click += new System.EventHandler(this.aci0_Click);
            // 
            // lbl1
            // 
            this.lbl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(154, 371);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(84, 24);
            this.lbl1.TabIndex = 13;
            this.lbl1.Text = "1";
            // 
            // lblFallos
            // 
            this.lblFallos.AutoSize = true;
            this.lblFallos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFallos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFallos.Location = new System.Drawing.Point(524, 335);
            this.lblFallos.Name = "lblFallos";
            this.lblFallos.Size = new System.Drawing.Size(72, 27);
            this.lblFallos.TabIndex = 12;
            this.lblFallos.Text = "Fallos";
            // 
            // lblAciertos
            // 
            this.lblAciertos.AutoSize = true;
            this.lblAciertos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAciertos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAciertos.Location = new System.Drawing.Point(337, 332);
            this.lblAciertos.Name = "lblAciertos";
            this.lblAciertos.Size = new System.Drawing.Size(93, 27);
            this.lblAciertos.TabIndex = 11;
            this.lblAciertos.Text = "Aciertos";
            this.lblAciertos.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblNivel
            // 
            this.lblNivel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.Location = new System.Drawing.Point(154, 335);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(84, 24);
            this.lblNivel.TabIndex = 10;
            this.lblNivel.Text = "Nivel";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(226, 212);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 55);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click_1);
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.Location = new System.Drawing.Point(226, 173);
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.Size = new System.Drawing.Size(100, 26);
            this.txtRespuesta.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ponga su respuesta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(489, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(382, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "=";
            // 
            // lblNum2
            // 
            this.lblNum2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNum2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNum2.Location = new System.Drawing.Point(270, 123);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(75, 26);
            this.lblNum2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 564);
            this.Controls.Add(this.nada);
            this.Name = "Form1";
            this.Text = "Juego de numeros";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.nada.ResumeLayout(false);
            this.nada.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.Panel nada;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtRespuesta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAciertos;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Label lblFallos;
        private System.Windows.Forms.Label fall0;
        private System.Windows.Forms.Label aci0;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button boton2;
        private System.Windows.Forms.Button boton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbltur;
    }
}

