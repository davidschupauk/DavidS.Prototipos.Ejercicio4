namespace DavidS.Prototipos.Ejercicio4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listView1 = new ListView();
            dniColumna = new ColumnHeader();
            nombreColumna = new ColumnHeader();
            apellidoColumna = new ColumnHeader();
            groupBox1 = new GroupBox();
            label3 = new Label();
            nombreTextBox = new TextBox();
            label2 = new Label();
            apellidoTextBox = new TextBox();
            label1 = new Label();
            dniTextBox = new TextBox();
            agregarBoton = new Button();
            eliminarSeleccionada = new Button();
            modificarBoton = new Button();
            label4 = new Label();
            label5 = new Label();
            codPaisTextBox = new TextBox();
            label6 = new Label();
            codAreaTextBox = new TextBox();
            label7 = new Label();
            numeroTextBox = new TextBox();
            aceptarBoton = new Button();
            cancelarBoton = new Button();
            tipoComboBox = new ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { dniColumna, nombreColumna, apellidoColumna });
            listView1.Location = new Point(38, 19);
            listView1.Name = "listView1";
            listView1.Size = new Size(730, 147);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // dniColumna
            // 
            dniColumna.Text = "DNI";
            // 
            // nombreColumna
            // 
            nombreColumna.DisplayIndex = 2;
            nombreColumna.Text = "Nombre";
            // 
            // apellidoColumna
            // 
            apellidoColumna.DisplayIndex = 1;
            apellidoColumna.Text = "Apellido";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tipoComboBox);
            groupBox1.Controls.Add(cancelarBoton);
            groupBox1.Controls.Add(aceptarBoton);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(numeroTextBox);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(codAreaTextBox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(codPaisTextBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(nombreTextBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(apellidoTextBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dniTextBox);
            groupBox1.Location = new Point(38, 220);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(730, 224);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(231, 29);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 5;
            label3.Text = "Apellido";
            // 
            // nombreTextBox
            // 
            nombreTextBox.Location = new Point(472, 52);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(241, 27);
            nombreTextBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(472, 29);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 3;
            label2.Text = "Nombre";
            // 
            // apellidoTextBox
            // 
            apellidoTextBox.Location = new Point(230, 52);
            apellidoTextBox.Name = "apellidoTextBox";
            apellidoTextBox.Size = new Size(217, 27);
            apellidoTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 29);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 1;
            label1.Text = "Documento";
            // 
            // dniTextBox
            // 
            dniTextBox.Location = new Point(19, 52);
            dniTextBox.Name = "dniTextBox";
            dniTextBox.Size = new Size(189, 27);
            dniTextBox.TabIndex = 0;
            // 
            // agregarBoton
            // 
            agregarBoton.Location = new Point(674, 185);
            agregarBoton.Name = "agregarBoton";
            agregarBoton.Size = new Size(94, 29);
            agregarBoton.TabIndex = 2;
            agregarBoton.Text = "Nueva";
            agregarBoton.UseVisualStyleBackColor = true;
            // 
            // eliminarSeleccionada
            // 
            eliminarSeleccionada.Location = new Point(474, 185);
            eliminarSeleccionada.Name = "eliminarSeleccionada";
            eliminarSeleccionada.Size = new Size(176, 29);
            eliminarSeleccionada.TabIndex = 3;
            eliminarSeleccionada.Text = "Borrar seleccionada";
            eliminarSeleccionada.UseVisualStyleBackColor = true;
            // 
            // modificarBoton
            // 
            modificarBoton.Location = new Point(279, 185);
            modificarBoton.Name = "modificarBoton";
            modificarBoton.Size = new Size(176, 29);
            modificarBoton.TabIndex = 4;
            modificarBoton.Text = "Modificar seleccionada";
            modificarBoton.UseVisualStyleBackColor = true;
            modificarBoton.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 91);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 7;
            label4.Text = "Tipo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(176, 91);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 9;
            label5.Text = "Cod. Pais";
            // 
            // codPaisTextBox
            // 
            codPaisTextBox.Location = new Point(176, 116);
            codPaisTextBox.Name = "codPaisTextBox";
            codPaisTextBox.Size = new Size(125, 27);
            codPaisTextBox.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(307, 91);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 11;
            label6.Text = "Cod. Area";
            // 
            // codAreaTextBox
            // 
            codAreaTextBox.Location = new Point(307, 116);
            codAreaTextBox.Name = "codAreaTextBox";
            codAreaTextBox.Size = new Size(125, 27);
            codAreaTextBox.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(438, 91);
            label7.Name = "label7";
            label7.Size = new Size(63, 20);
            label7.TabIndex = 13;
            label7.Text = "Numero";
            // 
            // numeroTextBox
            // 
            numeroTextBox.Location = new Point(438, 116);
            numeroTextBox.Name = "numeroTextBox";
            numeroTextBox.Size = new Size(236, 27);
            numeroTextBox.TabIndex = 12;
            // 
            // aceptarBoton
            // 
            aceptarBoton.Location = new Point(509, 187);
            aceptarBoton.Name = "aceptarBoton";
            aceptarBoton.Size = new Size(94, 29);
            aceptarBoton.TabIndex = 14;
            aceptarBoton.Text = "Aceptar";
            aceptarBoton.UseVisualStyleBackColor = true;
            // 
            // cancelarBoton
            // 
            cancelarBoton.Location = new Point(619, 187);
            cancelarBoton.Name = "cancelarBoton";
            cancelarBoton.Size = new Size(94, 29);
            cancelarBoton.TabIndex = 15;
            cancelarBoton.Text = "Cancelar";
            cancelarBoton.UseVisualStyleBackColor = true;
            // 
            // tipoComboBox
            // 
            tipoComboBox.FormattingEnabled = true;
            tipoComboBox.Location = new Point(19, 115);
            tipoComboBox.Name = "tipoComboBox";
            tipoComboBox.Size = new Size(151, 28);
            tipoComboBox.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(modificarBoton);
            Controls.Add(eliminarSeleccionada);
            Controls.Add(agregarBoton);
            Controls.Add(groupBox1);
            Controls.Add(listView1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader dniColumna;
        private ColumnHeader nombreColumna;
        private ColumnHeader apellidoColumna;
        private GroupBox groupBox1;
        private Button agregarBoton;
        private Button eliminarSeleccionada;
        private Button modificarBoton;
        private Label label3;
        private TextBox nombreTextBox;
        private Label label2;
        private TextBox apellidoTextBox;
        private Label label1;
        private TextBox dniTextBox;
        private Button cancelarBoton;
        private Button aceptarBoton;
        private Label label7;
        private TextBox numeroTextBox;
        private Label label6;
        private TextBox codAreaTextBox;
        private Label label5;
        private TextBox codPaisTextBox;
        private Label label4;
        private ComboBox tipoComboBox;
    }
}
