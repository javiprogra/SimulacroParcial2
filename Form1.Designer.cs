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
            dataGridViewReporte = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReporte).BeginInit();
            SuspendLayout();
            // 
            // buttonInscripcion
            // 
            buttonInscripcion.Location = new Point(260, 280);
            buttonInscripcion.Name = "buttonInscripcion";
            buttonInscripcion.Size = new Size(106, 69);
            buttonInscripcion.TabIndex = 0;
            buttonInscripcion.Text = "Ingresar Inscripcion";
            buttonInscripcion.UseVisualStyleBackColor = true;
            buttonInscripcion.Click += buttonInscripcion_Click;
            // 
            // dataGridViewReporte
            // 
            dataGridViewReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReporte.Location = new Point(99, 86);
            dataGridViewReporte.Name = "dataGridViewReporte";
            dataGridViewReporte.RowHeadersWidth = 51;
            dataGridViewReporte.Size = new Size(433, 188);
            dataGridViewReporte.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(203, 43);
            label1.Name = "label1";
            label1.Size = new Size(253, 31);
            label1.TabIndex = 2;
            label1.Text = "Inscripciones actuales:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(dataGridViewReporte);
            Controls.Add(buttonInscripcion);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Control de inscripcion";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewReporte).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonInscripcion;
        private DataGridView dataGridViewReporte;
        private Label label1;
    }
}
