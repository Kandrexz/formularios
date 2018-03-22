namespace formularios
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
            this.Formulario = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textrut = new System.Windows.Forms.TextBox();
            this.textapellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textnom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textdireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.combociudad = new System.Windows.Forms.ComboBox();
            this.Guardar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Guardado = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rut = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.apellido = new System.Windows.Forms.Label();
            this.direccion = new System.Windows.Forms.Label();
            this.ciudad = new System.Windows.Forms.Label();
            this.Formulario.SuspendLayout();
            this.Guardado.SuspendLayout();
            this.SuspendLayout();
            // 
            // Formulario
            // 
            this.Formulario.Controls.Add(this.button2);
            this.Formulario.Controls.Add(this.Guardar);
            this.Formulario.Controls.Add(this.combociudad);
            this.Formulario.Controls.Add(this.label5);
            this.Formulario.Controls.Add(this.textdireccion);
            this.Formulario.Controls.Add(this.label4);
            this.Formulario.Controls.Add(this.textnom);
            this.Formulario.Controls.Add(this.label3);
            this.Formulario.Controls.Add(this.textapellido);
            this.Formulario.Controls.Add(this.label2);
            this.Formulario.Controls.Add(this.textrut);
            this.Formulario.Controls.Add(this.label1);
            this.Formulario.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Formulario.Location = new System.Drawing.Point(21, 12);
            this.Formulario.Name = "Formulario";
            this.Formulario.Size = new System.Drawing.Size(234, 374);
            this.Formulario.TabIndex = 0;
            this.Formulario.TabStop = false;
            this.Formulario.Text = "Ingreso de alumno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rut";
            // 
            // textrut
            // 
            this.textrut.Location = new System.Drawing.Point(9, 42);
            this.textrut.Name = "textrut";
            this.textrut.Size = new System.Drawing.Size(109, 20);
            this.textrut.TabIndex = 1;
            // 
            // textapellido
            // 
            this.textapellido.Location = new System.Drawing.Point(9, 122);
            this.textapellido.Name = "textapellido";
            this.textapellido.Size = new System.Drawing.Size(109, 20);
            this.textapellido.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido";
            // 
            // textnom
            // 
            this.textnom.Location = new System.Drawing.Point(9, 82);
            this.textnom.Name = "textnom";
            this.textnom.Size = new System.Drawing.Size(109, 20);
            this.textnom.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre";
            // 
            // textdireccion
            // 
            this.textdireccion.Location = new System.Drawing.Point(9, 162);
            this.textdireccion.Name = "textdireccion";
            this.textdireccion.Size = new System.Drawing.Size(109, 20);
            this.textdireccion.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Direccion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ciudad";
            // 
            // combociudad
            // 
            this.combociudad.FormattingEnabled = true;
            this.combociudad.Items.AddRange(new object[] {
            "Antofagasta",
            "Arica",
            "Calama",
            "Cerro Toco",
            "Copiapó",
            "Iquique",
            "La Tirana",
            "Coquimbo",
            "La Serena",
            "Pisco Elqui",
            "Reserva Nacional Pingüino de Humboldt",
            "Curicó",
            "Los Andes / Portillo",
            "Olmué",
            "Rancagua",
            "San Fernando",
            "Santa Cruz",
            "Santiago",
            "Talca",
            "Valparaíso",
            "Viña del Mar",
            "Zapallar",
            "Chillán",
            "Concepción",
            "Frutillar",
            "Lonquimay",
            "Los Ángeles",
            "Osorno",
            "Puerto Montt",
            "Puerto Octay",
            "Puerto Varas",
            "Santuario de la Naturaleza Carlos Anwandter",
            "Temuco",
            "Valdivia",
            "Villarrica",
            "Ancud",
            "Castro",
            "Dalcahue",
            "Chaitén",
            "Chile Chico",
            "Cochrane",
            "Coyhaique",
            "Fiordo Quitralco",
            "Puyuhuapi",
            "Villa O\'Higgins",
            "Porvenir",
            "Puerto Natales",
            "Punta Arenas",
            "Mahatua",
            "Ovahe",
            "Poike",
            "Puna Pau",
            "Rohoi",
            "Tongariki"});
            this.combociudad.Location = new System.Drawing.Point(9, 202);
            this.combociudad.Name = "combociudad";
            this.combociudad.Size = new System.Drawing.Size(121, 22);
            this.combociudad.TabIndex = 10;
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(6, 230);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 11;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(110, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Guardado
            // 
            this.Guardado.Controls.Add(this.ciudad);
            this.Guardado.Controls.Add(this.direccion);
            this.Guardado.Controls.Add(this.apellido);
            this.Guardado.Controls.Add(this.nombre);
            this.Guardado.Controls.Add(this.rut);
            this.Guardado.Controls.Add(this.label10);
            this.Guardado.Controls.Add(this.label9);
            this.Guardado.Controls.Add(this.label8);
            this.Guardado.Controls.Add(this.label7);
            this.Guardado.Controls.Add(this.label6);
            this.Guardado.Location = new System.Drawing.Point(261, 14);
            this.Guardado.Name = "Guardado";
            this.Guardado.Size = new System.Drawing.Size(264, 360);
            this.Guardado.TabIndex = 1;
            this.Guardado.TabStop = false;
            this.Guardado.Text = "Formulario";
            this.Guardado.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Rut";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Nombre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Apellido";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Direccion";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Ciudad";
            // 
            // rut
            // 
            this.rut.AutoSize = true;
            this.rut.Location = new System.Drawing.Point(81, 24);
            this.rut.Name = "rut";
            this.rut.Size = new System.Drawing.Size(41, 13);
            this.rut.TabIndex = 10;
            this.rut.Text = "label11";
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(81, 64);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(41, 13);
            this.nombre.TabIndex = 11;
            this.nombre.Text = "label12";
            // 
            // apellido
            // 
            this.apellido.AutoSize = true;
            this.apellido.Location = new System.Drawing.Point(81, 103);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(41, 13);
            this.apellido.TabIndex = 12;
            this.apellido.Text = "label13";
            // 
            // direccion
            // 
            this.direccion.AutoSize = true;
            this.direccion.Location = new System.Drawing.Point(81, 144);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(41, 13);
            this.direccion.TabIndex = 13;
            this.direccion.Text = "label14";
            // 
            // ciudad
            // 
            this.ciudad.AutoSize = true;
            this.ciudad.Location = new System.Drawing.Point(81, 183);
            this.ciudad.Name = "ciudad";
            this.ciudad.Size = new System.Drawing.Size(41, 13);
            this.ciudad.TabIndex = 14;
            this.ciudad.Text = "label15";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 450);
            this.Controls.Add(this.Guardado);
            this.Controls.Add(this.Formulario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Formulario.ResumeLayout(false);
            this.Formulario.PerformLayout();
            this.Guardado.ResumeLayout(false);
            this.Guardado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Formulario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combociudad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textdireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textnom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textapellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textrut;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.GroupBox Guardado;
        private System.Windows.Forms.Label ciudad;
        private System.Windows.Forms.Label direccion;
        private System.Windows.Forms.Label apellido;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label rut;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

