namespace DesafioHerenciaWindowsForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rbtnPiso = new System.Windows.Forms.RadioButton();
            this.rbtLocal = new System.Windows.Forms.RadioButton();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblPrecioBase = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtPrecioBase = new System.Windows.Forms.TextBox();
            this.txtMetrosCuadrados = new System.Windows.Forms.TextBox();
            this.lblMetrosCuadrados = new System.Windows.Forms.Label();
            this.lblCantVentana = new System.Windows.Forms.Label();
            this.lblCantAños = new System.Windows.Forms.Label();
            this.rbtnNuevo = new System.Windows.Forms.RadioButton();
            this.rbtnSegundaMano = new System.Windows.Forms.RadioButton();
            this.lblCantPisos = new System.Windows.Forms.Label();
            this.grpboxInmueble = new System.Windows.Forms.GroupBox();
            this.gpboxEstado = new System.Windows.Forms.GroupBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblCalcular = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtCantAños = new System.Windows.Forms.TextBox();
            this.txtCantVentanas = new System.Windows.Forms.TextBox();
            this.txtPiso = new System.Windows.Forms.TextBox();
            this.grpboxInmueble.SuspendLayout();
            this.gpboxEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtnPiso
            // 
            this.rbtnPiso.AutoSize = true;
            this.rbtnPiso.Location = new System.Drawing.Point(75, 19);
            this.rbtnPiso.Name = "rbtnPiso";
            this.rbtnPiso.Size = new System.Drawing.Size(45, 17);
            this.rbtnPiso.TabIndex = 0;
            this.rbtnPiso.TabStop = true;
            this.rbtnPiso.Text = "Piso";
            this.rbtnPiso.UseVisualStyleBackColor = true;
            this.rbtnPiso.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbtLocal
            // 
            this.rbtLocal.AutoSize = true;
            this.rbtLocal.Location = new System.Drawing.Point(6, 19);
            this.rbtLocal.Name = "rbtLocal";
            this.rbtLocal.Size = new System.Drawing.Size(51, 17);
            this.rbtLocal.TabIndex = 1;
            this.rbtLocal.TabStop = true;
            this.rbtLocal.Text = "Local";
            this.rbtLocal.UseVisualStyleBackColor = true;
            this.rbtLocal.CheckedChanged += new System.EventHandler(this.rbtLocal_CheckedChanged);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(74, 58);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 2;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblPrecioBase
            // 
            this.lblPrecioBase.AutoSize = true;
            this.lblPrecioBase.Location = new System.Drawing.Point(65, 349);
            this.lblPrecioBase.Name = "lblPrecioBase";
            this.lblPrecioBase.Size = new System.Drawing.Size(61, 13);
            this.lblPrecioBase.TabIndex = 3;
            this.lblPrecioBase.Text = "PrecioBase";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(49, 74);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 4;
            // 
            // txtPrecioBase
            // 
            this.txtPrecioBase.Location = new System.Drawing.Point(49, 365);
            this.txtPrecioBase.Name = "txtPrecioBase";
            this.txtPrecioBase.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioBase.TabIndex = 5;
            // 
            // txtMetrosCuadrados
            // 
            this.txtMetrosCuadrados.Location = new System.Drawing.Point(49, 122);
            this.txtMetrosCuadrados.Name = "txtMetrosCuadrados";
            this.txtMetrosCuadrados.Size = new System.Drawing.Size(100, 20);
            this.txtMetrosCuadrados.TabIndex = 7;
            // 
            // lblMetrosCuadrados
            // 
            this.lblMetrosCuadrados.AutoSize = true;
            this.lblMetrosCuadrados.Location = new System.Drawing.Point(52, 106);
            this.lblMetrosCuadrados.Name = "lblMetrosCuadrados";
            this.lblMetrosCuadrados.Size = new System.Drawing.Size(93, 13);
            this.lblMetrosCuadrados.TabIndex = 8;
            this.lblMetrosCuadrados.Text = "Metros Cuadrados";
            // 
            // lblCantVentana
            // 
            this.lblCantVentana.AutoSize = true;
            this.lblCantVentana.Location = new System.Drawing.Point(49, 252);
            this.lblCantVentana.Name = "lblCantVentana";
            this.lblCantVentana.Size = new System.Drawing.Size(97, 13);
            this.lblCantVentana.TabIndex = 9;
            this.lblCantVentana.Text = "Cantidad Ventanas";
            // 
            // lblCantAños
            // 
            this.lblCantAños.AutoSize = true;
            this.lblCantAños.Location = new System.Drawing.Point(52, 204);
            this.lblCantAños.Name = "lblCantAños";
            this.lblCantAños.Size = new System.Drawing.Size(91, 13);
            this.lblCantAños.TabIndex = 11;
            this.lblCantAños.Text = "Cantidad de Años";
            // 
            // rbtnNuevo
            // 
            this.rbtnNuevo.AutoSize = true;
            this.rbtnNuevo.Location = new System.Drawing.Point(3, 19);
            this.rbtnNuevo.Name = "rbtnNuevo";
            this.rbtnNuevo.Size = new System.Drawing.Size(57, 17);
            this.rbtnNuevo.TabIndex = 12;
            this.rbtnNuevo.TabStop = true;
            this.rbtnNuevo.Text = "Nuevo";
            this.rbtnNuevo.UseVisualStyleBackColor = true;
            this.rbtnNuevo.CheckedChanged += new System.EventHandler(this.rbtnNuevo_CheckedChanged);
            // 
            // rbtnSegundaMano
            // 
            this.rbtnSegundaMano.AutoSize = true;
            this.rbtnSegundaMano.Location = new System.Drawing.Point(65, 19);
            this.rbtnSegundaMano.Name = "rbtnSegundaMano";
            this.rbtnSegundaMano.Size = new System.Drawing.Size(98, 17);
            this.rbtnSegundaMano.TabIndex = 13;
            this.rbtnSegundaMano.TabStop = true;
            this.rbtnSegundaMano.Text = "Segunda Mano";
            this.rbtnSegundaMano.UseVisualStyleBackColor = true;
            // 
            // lblCantPisos
            // 
            this.lblCantPisos.AutoSize = true;
            this.lblCantPisos.Location = new System.Drawing.Point(58, 301);
            this.lblCantPisos.Name = "lblCantPisos";
            this.lblCantPisos.Size = new System.Drawing.Size(82, 13);
            this.lblCantPisos.TabIndex = 15;
            this.lblCantPisos.Text = "Numero de Piso";
            // 
            // grpboxInmueble
            // 
            this.grpboxInmueble.Controls.Add(this.rbtLocal);
            this.grpboxInmueble.Controls.Add(this.rbtnPiso);
            this.grpboxInmueble.Location = new System.Drawing.Point(43, 12);
            this.grpboxInmueble.Name = "grpboxInmueble";
            this.grpboxInmueble.Size = new System.Drawing.Size(123, 43);
            this.grpboxInmueble.TabIndex = 17;
            this.grpboxInmueble.TabStop = false;
            this.grpboxInmueble.Text = "Inmueble";
            // 
            // gpboxEstado
            // 
            this.gpboxEstado.Controls.Add(this.rbtnNuevo);
            this.gpboxEstado.Controls.Add(this.rbtnSegundaMano);
            this.gpboxEstado.Location = new System.Drawing.Point(22, 148);
            this.gpboxEstado.Name = "gpboxEstado";
            this.gpboxEstado.Size = new System.Drawing.Size(168, 45);
            this.gpboxEstado.TabIndex = 18;
            this.gpboxEstado.TabStop = false;
            this.gpboxEstado.Text = "Estado";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(42, 400);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(121, 23);
            this.btnCalcular.TabIndex = 19;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblCalcular
            // 
            this.lblCalcular.AutoSize = true;
            this.lblCalcular.BackColor = System.Drawing.SystemColors.Control;
            this.lblCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblCalcular.Location = new System.Drawing.Point(46, 446);
            this.lblCalcular.Name = "lblCalcular";
            this.lblCalcular.Size = new System.Drawing.Size(100, 13);
            this.lblCalcular.TabIndex = 20;
            this.lblCalcular.Text = "El precio es de: ";
            this.lblCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(58, 468);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(24, 16);
            this.lblPrecio.TabIndex = 21;
            this.lblPrecio.Text = "$0";
            // 
            // txtCantAños
            // 
            this.txtCantAños.Location = new System.Drawing.Point(49, 220);
            this.txtCantAños.Name = "txtCantAños";
            this.txtCantAños.Size = new System.Drawing.Size(100, 20);
            this.txtCantAños.TabIndex = 22;
            this.txtCantAños.Text = "0";
            // 
            // txtCantVentanas
            // 
            this.txtCantVentanas.Location = new System.Drawing.Point(49, 268);
            this.txtCantVentanas.Name = "txtCantVentanas";
            this.txtCantVentanas.Size = new System.Drawing.Size(100, 20);
            this.txtCantVentanas.TabIndex = 23;
            this.txtCantVentanas.Text = "0";
            // 
            // txtPiso
            // 
            this.txtPiso.Location = new System.Drawing.Point(49, 317);
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Size = new System.Drawing.Size(100, 20);
            this.txtPiso.TabIndex = 24;
            this.txtPiso.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(211, 517);
            this.Controls.Add(this.txtPiso);
            this.Controls.Add(this.txtCantVentanas);
            this.Controls.Add(this.txtCantAños);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCalcular);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.gpboxEstado);
            this.Controls.Add(this.grpboxInmueble);
            this.Controls.Add(this.lblCantPisos);
            this.Controls.Add(this.lblCantAños);
            this.Controls.Add(this.lblCantVentana);
            this.Controls.Add(this.lblMetrosCuadrados);
            this.Controls.Add(this.txtMetrosCuadrados);
            this.Controls.Add(this.txtPrecioBase);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblPrecioBase);
            this.Controls.Add(this.lblDireccion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Inmobiliaria";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpboxInmueble.ResumeLayout(false);
            this.grpboxInmueble.PerformLayout();
            this.gpboxEstado.ResumeLayout(false);
            this.gpboxEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnPiso;
        private System.Windows.Forms.RadioButton rbtLocal;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblPrecioBase;
        private System.Windows.Forms.TextBox txtPrecioBase;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtMetrosCuadrados;
        private System.Windows.Forms.Label lblMetrosCuadrados;
        private System.Windows.Forms.Label lblCantVentana;
        private System.Windows.Forms.Label lblCantAños;
        private System.Windows.Forms.RadioButton rbtnNuevo;
        private System.Windows.Forms.RadioButton rbtnSegundaMano;
        private System.Windows.Forms.Label lblCantPisos;
        private System.Windows.Forms.GroupBox grpboxInmueble;
        private System.Windows.Forms.GroupBox gpboxEstado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblCalcular;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtCantAños;
        private System.Windows.Forms.TextBox txtCantVentanas;
        private System.Windows.Forms.TextBox txtPiso;
    }
}

