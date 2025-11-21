namespace brainbook
{
    partial class comunidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(comunidad));
            AMIGOS = new Button();
            GALERIA = new Button();
            COMUNIDADES = new Button();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // AMIGOS
            // 
            AMIGOS.BackColor = Color.Gold;
            AMIGOS.Font = new Font("SF Automaton", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            AMIGOS.ForeColor = SystemColors.ButtonHighlight;
            AMIGOS.Location = new Point(511, 204);
            AMIGOS.Name = "AMIGOS";
            AMIGOS.Size = new Size(189, 57);
            AMIGOS.TabIndex = 28;
            AMIGOS.Text = "bateria";
            AMIGOS.UseVisualStyleBackColor = false;
            // 
            // GALERIA
            // 
            GALERIA.BackColor = Color.DarkOrange;
            GALERIA.Font = new Font("SF Automaton", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            GALERIA.ForeColor = SystemColors.ButtonHighlight;
            GALERIA.Location = new Point(122, 204);
            GALERIA.Name = "GALERIA";
            GALERIA.Size = new Size(189, 57);
            GALERIA.TabIndex = 27;
            GALERIA.Text = "guitarra";
            GALERIA.UseVisualStyleBackColor = false;
            GALERIA.Click += GALERIA_Click;
            // 
            // COMUNIDADES
            // 
            COMUNIDADES.BackColor = Color.SpringGreen;
            COMUNIDADES.Font = new Font("SF Automaton", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            COMUNIDADES.ForeColor = SystemColors.ButtonHighlight;
            COMUNIDADES.Location = new Point(303, 204);
            COMUNIDADES.Name = "COMUNIDADES";
            COMUNIDADES.Size = new Size(215, 57);
            COMUNIDADES.TabIndex = 26;
            COMUNIDADES.Text = "piano";
            COMUNIDADES.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("SF Automaton", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(149, 204);
            label1.Name = "label1";
            label1.Size = new Size(0, 26);
            label1.TabIndex = 25;
            // 
            // button1
            // 
            button1.BackColor = Color.Blue;
            button1.Font = new Font("SF Automaton", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(303, 381);
            button1.Name = "button1";
            button1.Size = new Size(215, 57);
            button1.TabIndex = 29;
            button1.Text = "guardar";
            button1.UseVisualStyleBackColor = false;
            // 
            // comunidad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(AMIGOS);
            Controls.Add(GALERIA);
            Controls.Add(COMUNIDADES);
            Controls.Add(label1);
            Name = "comunidad";
            Text = "comunidad";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AMIGOS;
        private Button GALERIA;
        private Button COMUNIDADES;
        private Label label1;
        private Button button1;
    }
}