namespace brainbook
{
    partial class perfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(perfil));
            GUARDAR = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Apellidos = new TextBox();
            Nombres = new TextBox();
            label4 = new Label();
            Genero = new ComboBox();
            pais = new ComboBox();
            label5 = new Label();
            Talento = new ComboBox();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            Cumpleaños = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // GUARDAR
            // 
            GUARDAR.BackColor = Color.DarkCyan;
            GUARDAR.Font = new Font("SF Automaton", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            GUARDAR.ForeColor = SystemColors.ButtonHighlight;
            GUARDAR.Location = new Point(564, 256);
            GUARDAR.Name = "GUARDAR";
            GUARDAR.Size = new Size(205, 55);
            GUARDAR.TabIndex = 21;
            GUARDAR.Text = "GUARDAR";
            GUARDAR.UseVisualStyleBackColor = false;
            GUARDAR.Click += GUARDAR_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("SF Automaton", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(67, 242);
            label3.Name = "label3";
            label3.Size = new Size(142, 26);
            label3.TabIndex = 18;
            label3.Text = "cUMPLEAÑOS";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("SF Automaton", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(329, 20);
            label2.Name = "label2";
            label2.Size = new Size(116, 26);
            label2.TabIndex = 17;
            label2.Text = "APELLIDOS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("SF Automaton", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(63, 20);
            label1.Name = "label1";
            label1.Size = new Size(107, 26);
            label1.TabIndex = 16;
            label1.Text = "Nombres";
            // 
            // Apellidos
            // 
            Apellidos.BackColor = Color.LemonChiffon;
            Apellidos.Location = new Point(290, 49);
            Apellidos.Name = "Apellidos";
            Apellidos.Size = new Size(192, 27);
            Apellidos.TabIndex = 12;
            // 
            // Nombres
            // 
            Nombres.BackColor = Color.LemonChiffon;
            Nombres.Location = new Point(26, 49);
            Nombres.Name = "Nombres";
            Nombres.Size = new Size(192, 27);
            Nombres.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("SF Automaton", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(72, 121);
            label4.Name = "label4";
            label4.Size = new Size(88, 26);
            label4.TabIndex = 24;
            label4.Text = "GENERO";
            // 
            // Genero
            // 
            Genero.BackColor = Color.LemonChiffon;
            Genero.FormattingEnabled = true;
            Genero.Items.AddRange(new object[] { "Masculino", "Femenino" });
            Genero.Location = new Point(23, 159);
            Genero.Name = "Genero";
            Genero.Size = new Size(195, 28);
            Genero.TabIndex = 25;
            // 
            // pais
            // 
            pais.BackColor = Color.Cornsilk;
            pais.FormattingEnabled = true;
            pais.Items.AddRange(new object[] { " \"Afganistán\",", "        \"Albania\",", "        \"Alemania\",", "        \"Andorra\",", "        \"Angola\",", "        \"Antigua y Barbuda\",", "        \"Arabia Saudita\",", "        \"Argelia\",", "        \"Argentina\",", "        \"Armenia\",", "        \"Australia\",", "        \"Austria\",", "        \"Azerbaiyán\",", "        \"Bahamas\",", "        \"Bangladés\",", "        \"Barbados\",", "        \"Baréin\",", "        \"Bélgica\",", "        \"Belice\",", "        \"Benín\",", "        \"Bielorrusia\",", "        \"Birmania\",", "        \"Bolivia\",", "        \"Bosnia y Herzegovina\",", "        \"Botsuana\",", "        \"Brasil\",", "        \"Brunéi\",", "        \"Bulgaria\",", "        \"Burkina Faso\",", "        \"Burundi\",", "        \"Bután\",", "        \"Cabo Verde\",", "        \"Camboya\",", "        \"Camerún\",", "        \"Canadá\",", "        \"Catar\",", "        \"Chad\",", "        \"Chile\",", "        \"China\",", "        \"Chipre\",", "        \"Colombia\",", "        \"Comoras\",", "        \"Corea del Norte\",", "        \"Corea del Sur\",", "        \"Costa de Marfil\",", "        \"Costa Rica\",", "        \"Croacia\",", "        \"Cuba\",", "        \"Dinamarca\",", "        \"Dominica\",", "        \"Ecuador\",", "        \"Egipto\",", "        \"El Salvador\",", "        \"Emiratos Árabes Unidos\",", "        \"Eritrea\",", "        \"Eslovaquia\",", "        \"Eslovenia\",", "        \"España\",", "        \"Estados Unidos\",", "        \"Estonia\",", "        \"Etiopía\",", "        \"Filipinas\",", "        \"Finlandia\",", "        \"Fiyi\",", "        \"Francia\",", "        \"Gabón\",", "        \"Gambia\",", "        \"Georgia\",", "        \"Ghana\",", "        \"Granada\",", "        \"Grecia\",", "        \"Guatemala\",", "        \"Guyana\",", "        \"Guinea\",", "        \"Guinea-Bisáu\",", "        \"Guinea Ecuatorial\",", "        \"Haití\",", "        \"Honduras\",", "        \"Hungría\",", "        \"India\",", "        \"Indonesia\",", "        \"Irak\",", "        \"Irán\",", "        \"Irlanda\",", "        \"Islandia\",", "        \"Islas Marshall\",", "        \"Islas Salomón\",", "        \"Israel\",", "        \"Italia\",", "        \"Jamaica\",", "        \"Japón\",", "        \"Jordania\",", "        \"Kazajistán\",", "        \"Kenia\",", "        \"Kirguistán\",", "        \"Kiribati\",", "        \"Kuwait\",", "        \"Laos\",", "        \"Lesoto\",", "        \"Letonia\",", "        \"Líbano\",", "        \"Liberia\",", "        \"Libia\",", "        \"Liechtenstein\",", "        \"Lituania\",", "        \"Luxemburgo\",", "        \"Madagascar\",", "        \"Malasia\",", "        \"Malaui\",", "        \"Maldivas\",", "        \"Malí\",", "        \"Malta\",", "        \"Marruecos\",", "        \"Mauricio\",", "        \"Mauritania\",", "        \"México\",", "        \"Micronesia\",", "        \"Moldavia\",", "        \"Mónaco\",", "        \"Mongolia\",", "        \"Montenegro\",", "        \"Mozambique\",", "        \"Namibia\",", "        \"Nauru\",", "        \"Nepal\",", "        \"Nicaragua\",", "        \"Níger\",", "        \"Nigeria\",", "        \"Noruega\",", "        \"Nueva Zelanda\",", "        \"Omán\",", "        \"Países Bajos\",", "        \"Pakistán\",", "        \"Palaos\",", "        \"Palestina\",", "        \"Panamá\",", "        \"Papúa Nueva Guinea\",", "        \"Paraguay\",", "        \"Perú\",", "        \"Polonia\",", "        \"Portugal\",", "        \"Reino Unido\",", "        \"República Centroafricana\",", "        \"República Checa\",", "        \"República del Congo\",", "        \"República Democrática del Congo\",", "        \"República Dominicana\",", "        \"República Sudafricana\",", "        \"Ruanda\",", "        \"Rumania\",", "        \"Rusia\",", "        \"Samoa\",", "        \"San Cristóbal y Nieves\",", "        \"San Marino\",", "        \"San Vicente y las Granadinas\",", "        \"Santa Lucía\",", "        \"Santo Tomé y Príncipe\",", "        \"Senegal\",", "        \"Serbia\",", "        \"Seychelles\",", "        \"Sierra Leona\",", "        \"Singapur\",", "        \"Siria\",", "        \"Somalia\",", "        \"Sri Lanka\",", "        \"Suazilandia\",", "        \"Sudán\",", "        \"Sudán del Sur\",", "        \"Suecia\",", "        \"Suiza\",", "        \"Surinam\"," });
            pais.Location = new Point(290, 159);
            pais.Name = "pais";
            pais.Size = new Size(195, 28);
            pais.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("SF Automaton", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(360, 121);
            label5.Name = "label5";
            label5.Size = new Size(56, 26);
            label5.TabIndex = 26;
            label5.Text = "Pais";
            // 
            // Talento
            // 
            Talento.BackColor = SystemColors.Info;
            Talento.FormattingEnabled = true;
            Talento.Items.AddRange(new object[] { "Musico", "Artístista", "Deportista", "Literario", "Matemático", "Culinario", "Lingüístico", "Tecnológico", "Científico" });
            Talento.Location = new Point(290, 273);
            Talento.Name = "Talento";
            Talento.Size = new Size(195, 28);
            Talento.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("SF Automaton", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(344, 235);
            label6.Name = "label6";
            label6.Size = new Size(99, 26);
            label6.TabIndex = 28;
            label6.Text = "talento";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(255, 255, 128);
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(564, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(196, 135);
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSkyBlue;
            button1.Font = new Font("SF Automaton", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(564, 161);
            button1.Name = "button1";
            button1.Size = new Size(196, 36);
            button1.TabIndex = 31;
            button1.Text = "Cargar foto";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Cumpleaños
            // 
            Cumpleaños.CalendarMonthBackground = SystemColors.Info;
            Cumpleaños.Location = new Point(12, 271);
            Cumpleaños.Name = "Cumpleaños";
            Cumpleaños.Size = new Size(228, 27);
            Cumpleaños.TabIndex = 32;
            // 
            // perfil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(Cumpleaños);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(Talento);
            Controls.Add(label6);
            Controls.Add(pais);
            Controls.Add(label5);
            Controls.Add(Genero);
            Controls.Add(label4);
            Controls.Add(GUARDAR);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Apellidos);
            Controls.Add(Nombres);
            DoubleBuffered = true;
            Name = "perfil";
            Text = "perfil";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button GUARDAR;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox Apellidos;
        private TextBox Nombres;
        private Label label4;
        private ComboBox Genero;
        private ComboBox pais;
        private Label label5;
        private ComboBox Talento;
        private Label label6;
        private PictureBox pictureBox1;
        private Button button1;
        private DateTimePicker Cumpleaños;
    }
}