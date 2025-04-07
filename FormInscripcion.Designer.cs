namespace SimulacroParcial2
{
    partial class FormInscripcion
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
            label1 = new Label();
            label2 = new Label();
            comboBoxAlumno = new ComboBox();
            comboBoxTaller = new ComboBox();
            buttonGuardar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(133, 94);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Alumno:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 151);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 1;
            label2.Text = "Taller:";
            // 
            // comboBoxAlumno
            // 
            comboBoxAlumno.FormattingEnabled = true;
            comboBoxAlumno.Location = new Point(220, 94);
            comboBoxAlumno.Name = "comboBoxAlumno";
            comboBoxAlumno.Size = new Size(182, 28);
            comboBoxAlumno.TabIndex = 2;
            // 
            // comboBoxTaller
            // 
            comboBoxTaller.FormattingEnabled = true;
            comboBoxTaller.Location = new Point(220, 143);
            comboBoxTaller.Name = "comboBoxTaller";
            comboBoxTaller.Size = new Size(182, 28);
            comboBoxTaller.TabIndex = 3;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(343, 223);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(129, 56);
            buttonGuardar.TabIndex = 4;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // FormInscripcion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 364);
            Controls.Add(buttonGuardar);
            Controls.Add(comboBoxTaller);
            Controls.Add(comboBoxAlumno);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormInscripcion";
            Text = "FormInscripcion";
            Load += FormInscripcion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBoxAlumno;
        private ComboBox comboBoxTaller;
        private Button buttonGuardar;
    }
}