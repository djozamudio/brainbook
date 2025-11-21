namespace brainbook
{
    partial class registro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registro));
            Nombre = new TextBox();
            contraseña = new TextBox();
            Correo = new TextBox();
            numero = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Registrar = new Button();
            SuspendLayout();
            // 
            // Nombre
            // 
            Nombre.Location = new Point(308, 36);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(192, 27);
            Nombre.TabIndex = 0;
            // 
            // contraseña
            // 
            contraseña.Location = new Point(307, 104);
            contraseña.Name = "contraseña";
            contraseña.Size = new Size(192, 27);
            contraseña.TabIndex = 1;
            // 
            // Correo
            // 
            Correo.Location = new Point(308, 239);
            Correo.Name = "Correo";
            Correo.Size = new Size(192, 27);
            Correo.TabIndex = 2;
            // 
            // numero
            // 
            numero.Location = new Point(308, 300);
            numero.Name = "numero";
            numero.Size = new Size(192, 27);
            numero.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(282, 171);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("SF Automaton", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(297, 9);
            label1.Name = "label1";
            label1.Size = new Size(215, 26);
            label1.TabIndex = 5;
            label1.Text = "Nombre de Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("SF Automaton", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(335, 75);
            label2.Name = "label2";
            label2.Size = new Size(140, 26);
            label2.TabIndex = 6;
            label2.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("SF Automaton", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(291, 142);
            label3.Name = "label3";
            label3.Size = new Size(229, 26);
            label3.TabIndex = 7;
            label3.Text = "Fecha de nacimiento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("SF Automaton", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(297, 210);
            label4.Name = "label4";
            label4.Size = new Size(225, 26);
            label4.TabIndex = 8;
            label4.Text = "Correo electronico";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("SF Automaton", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(358, 271);
            label5.Name = "label5";
            label5.Size = new Size(94, 26);
            label5.TabIndex = 9;
            label5.Text = "Numero";
            // 
            // Registrar
            // 
            Registrar.BackColor = Color.LightSkyBlue;
            Registrar.Font = new Font("SF Automaton", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Registrar.ForeColor = SystemColors.ButtonHighlight;
            Registrar.Location = new Point(335, 362);
            Registrar.Name = "Registrar";
            Registrar.Size = new Size(154, 36);
            Registrar.TabIndex = 10;
            Registrar.Text = "Registrar";
            Registrar.UseVisualStyleBackColor = false;
            Registrar.Click += Registrar_Click;
            // 
            // registro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(Registrar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(numero);
            Controls.Add(Correo);
            Controls.Add(contraseña);
            Controls.Add(Nombre);
            DoubleBuffered = true;
            Name = "registro";
            Text = "registro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Nombre;
        private TextBox contraseña;
        private TextBox Correo;
        private TextBox numero;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button Registrar;
    }
}