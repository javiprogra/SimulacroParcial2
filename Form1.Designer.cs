namespace SimulacroParcial2
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
            buttonInscripcion = new Button();
            SuspendLayout();
            // 
            // buttonInscripcion
            // 
            buttonInscripcion.Location = new Point(33, 45);
            buttonInscripcion.Name = "buttonInscripcion";
            buttonInscripcion.Size = new Size(106, 69);
            buttonInscripcion.TabIndex = 0;
            buttonInscripcion.Text = "Ingresar Inscripcion";
            buttonInscripcion.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonInscripcion);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Control de inscripcion";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonInscripcion;
    }
}
