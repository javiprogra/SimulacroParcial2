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
            buttonOrdenarAZ = new Button();
            button1 = new Button();
            label2 = new Label();
            buttonUpdate = new Button();
            label3 = new Label();
            labelAlumnos = new Label();
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
            // buttonOrdenarAZ
            // 
            buttonOrdenarAZ.Location = new Point(558, 115);
            buttonOrdenarAZ.Name = "buttonOrdenarAZ";
            buttonOrdenarAZ.Size = new Size(77, 56);
            buttonOrdenarAZ.TabIndex = 3;
            buttonOrdenarAZ.Text = "Z - A";
            buttonOrdenarAZ.UseVisualStyleBackColor = true;
            buttonOrdenarAZ.Click += buttonOrdenarAZ_Click;
            // 
            // button1
            // 
            button1.Location = new Point(558, 177);
            button1.Name = "button1";
            button1.Size = new Size(77, 56);
            button1.TabIndex = 4;
            button1.Text = "A - Z";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(558, 86);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 5;
            label2.Text = "Ordenar";
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(372, 280);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(106, 69);
            buttonUpdate.TabIndex = 6;
            buttonUpdate.Text = "Actualizar";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 376);
            label3.Name = "label3";
            label3.Size = new Size(211, 20);
            label3.TabIndex = 7;
            label3.Text = "Cantidad de alumnos inscritos:";
            // 
            // labelAlumnos
            // 
            labelAlumnos.AutoSize = true;
            labelAlumnos.Location = new Point(229, 376);
            labelAlumnos.Name = "labelAlumnos";
            labelAlumnos.Size = new Size(50, 20);
            labelAlumnos.TabIndex = 8;
            labelAlumnos.Text = "label4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelAlumnos);
            Controls.Add(label3);
            Controls.Add(buttonUpdate);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(buttonOrdenarAZ);
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
        private Button buttonOrdenarAZ;
        private Button button1;
        private Label label2;
        private Button buttonUpdate;
        private Label label3;
        private Label labelAlumnos;
    }
}
