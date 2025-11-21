namespace brainbook
{
    partial class galeria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(galeria));
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            Registrar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("SF Automaton", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(315, 37);
            label2.Name = "label2";
            label2.Size = new Size(181, 40);
            label2.TabIndex = 18;
            label2.Text = "mi galeria";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(112, 81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(277, 133);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Location = new Point(415, 80);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(277, 133);
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // Registrar
            // 
            Registrar.BackColor = SystemColors.ControlText;
            Registrar.Font = new Font("SF Automaton", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Registrar.ForeColor = SystemColors.ButtonHighlight;
            Registrar.Location = new Point(315, 402);
            Registrar.Name = "Registrar";
            Registrar.Size = new Size(154, 36);
            Registrar.TabIndex = 21;
            Registrar.Text = "inicio";
            Registrar.UseVisualStyleBackColor = false;
            Registrar.Click += Registrar_Click;
            // 
            // galeria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(Registrar);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Name = "galeria";
            Text = "galeria";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        public PictureBox pictureBox1;
        public PictureBox pictureBox2;
        private Button Registrar;
    }
}