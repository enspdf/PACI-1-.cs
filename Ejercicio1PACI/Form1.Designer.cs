namespace Ejercicio1PACI
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbMaterias = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lbNotas = new System.Windows.Forms.ListBox();
            this.pbResultado = new System.Windows.Forms.PictureBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Materia:";
            // 
            // cbMaterias
            // 
            this.cbMaterias.FormattingEnabled = true;
            this.cbMaterias.Items.AddRange(new object[] {
            "Ingles",
            "Matematicas",
            "Quimica",
            "Programacion I"});
            this.cbMaterias.Location = new System.Drawing.Point(129, 20);
            this.cbMaterias.Name = "cbMaterias";
            this.cbMaterias.Size = new System.Drawing.Size(227, 21);
            this.cbMaterias.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nota:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(129, 58);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(134, 20);
            this.txtNota1.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(269, 56);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(87, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lbNotas
            // 
            this.lbNotas.FormattingEnabled = true;
            this.lbNotas.Location = new System.Drawing.Point(129, 97);
            this.lbNotas.Name = "lbNotas";
            this.lbNotas.Size = new System.Drawing.Size(227, 56);
            this.lbNotas.TabIndex = 5;
            // 
            // pbResultado
            // 
            this.pbResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbResultado.Location = new System.Drawing.Point(129, 167);
            this.pbResultado.Name = "pbResultado";
            this.pbResultado.Size = new System.Drawing.Size(227, 102);
            this.pbResultado.TabIndex = 6;
            this.pbResultado.TabStop = false;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(25, 167);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Notas:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 288);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.pbResultado);
            this.Controls.Add(this.lbNotas);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbMaterias);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calcular Notas";
            ((System.ComponentModel.ISupportInitialize)(this.pbResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMaterias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lbNotas;
        private System.Windows.Forms.PictureBox pbResultado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label3;
    }
}

