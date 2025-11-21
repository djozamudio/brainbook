namespace brainbook
{
    partial class inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inicio));
            Registrar = new Button();
            Sesion = new Button();
            SuspendLayout();
            // 
            // Registrar
            // 
            Registrar.BackColor = SystemColors.ActiveCaption;
            Registrar.Font = new Font("SF Automaton", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Registrar.ForeColor = SystemColors.ButtonHighlight;
            Registrar.Location = new Point(40, 31);
            Registrar.Name = "Registrar";
            Registrar.Size = new Size(154, 36);
            Registrar.TabIndex = 0;
            Registrar.Text = "Registrar";
            Registrar.UseVisualStyleBackColor = false;
            Registrar.Click += Registrar_Click;
            // 
            // Sesion
            // 
            Sesion.BackColor = SystemColors.ActiveCaption;
            Sesion.Font = new Font("SF Automaton", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Sesion.ForeColor = SystemColors.ButtonHighlight;
            Sesion.Location = new Point(590, 31);
            Sesion.Name = "Sesion";
            Sesion.Size = new Size(183, 36);
            Sesion.TabIndex = 1;
            Sesion.Text = "Iniciar sesión";
            Sesion.UseVisualStyleBackColor = false;
            Sesion.Click += Sesion_Click;
            // 
            // inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(Sesion);
            Controls.Add(Registrar);
            Name = "inicio";
            Text = "inicio";
            ResumeLayout(false);
        }

        #endregion

        private Button Registrar;
        private Button Sesion;
    }
}