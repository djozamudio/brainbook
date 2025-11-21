namespace brainbook
{
    partial class Iniciosesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Iniciosesion));
            label2 = new Label();
            label1 = new Label();
            contraseña = new TextBox();
            Nombre = new TextBox();
            Sesion = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("SF Automaton", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(334, 202);
            label2.Name = "label2";
            label2.Size = new Size(140, 26);
            label2.TabIndex = 10;
            label2.Text = "Contraseña";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("SF Automaton", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(295, 116);
            label1.Name = "label1";
            label1.Size = new Size(215, 26);
            label1.TabIndex = 9;
            label1.Text = "Nombre de Usuario";
            // 
            // contraseña
            // 
            contraseña.Location = new Point(306, 231);
            contraseña.Name = "contraseña";
            contraseña.Size = new Size(192, 27);
            contraseña.TabIndex = 8;
            // 
            // Nombre
            // 
            Nombre.Location = new Point(306, 143);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(192, 27);
            Nombre.TabIndex = 7;
            // 
            // Sesion
            // 
            Sesion.BackColor = Color.Turquoise;
            Sesion.Font = new Font("SF Automaton", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Sesion.ForeColor = SystemColors.ButtonHighlight;
            Sesion.Location = new Point(315, 324);
            Sesion.Name = "Sesion";
            Sesion.Size = new Size(183, 36);
            Sesion.TabIndex = 12;
            Sesion.Text = "Iniciar sesión";
            Sesion.UseVisualStyleBackColor = false;
            Sesion.Click += Sesion_Click;
            // 
            // Iniciosesion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(Sesion);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(contraseña);
            Controls.Add(Nombre);
            DoubleBuffered = true;
            Name = "Iniciosesion";
            Text = "Iniciosesion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox contraseña;
        private TextBox Nombre;
        private Button Sesion;
    }
}