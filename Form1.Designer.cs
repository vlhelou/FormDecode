namespace DecodForm
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
            origem = new TextBox();
            Destino = new TextBox();
            Transforma = new Button();
            SuspendLayout();
            // 
            // origem
            // 
            origem.Location = new Point(0, 0);
            origem.Multiline = true;
            origem.Name = "origem";
            origem.Size = new Size(356, 411);
            origem.TabIndex = 0;
            // 
            // Destino
            // 
            Destino.Location = new Point(411, 0);
            Destino.Multiline = true;
            Destino.Name = "Destino";
            Destino.Size = new Size(356, 411);
            Destino.TabIndex = 1;
            // 
            // Transforma
            // 
            Transforma.Location = new Point(358, 180);
            Transforma.Name = "Transforma";
            Transforma.Size = new Size(47, 23);
            Transforma.TabIndex = 2;
            Transforma.Text = ">>";
            Transforma.UseVisualStyleBackColor = true;
            Transforma.Click += Transforma_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Transforma);
            Controls.Add(Destino);
            Controls.Add(origem);
            Name = "Form1";
            Text = "Decode";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox origem;
        private TextBox Destino;
        private Button Transforma;
    }
}