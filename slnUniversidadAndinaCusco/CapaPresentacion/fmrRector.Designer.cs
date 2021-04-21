
namespace CapaPresentacion
{
    partial class fmrRector
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
            this.btnLeer = new System.Windows.Forms.Button();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtLugarNacimiento = new System.Windows.Forms.TextBox();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.btnSupervisar = new System.Windows.Forms.Button();
            this.btnAdministar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnControlar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(448, 58);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 0;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(267, 58);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(100, 22);
            this.txtNombres.TabIndex = 1;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(267, 87);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(100, 22);
            this.txtApellidos.TabIndex = 2;
            // 
            // txtLugarNacimiento
            // 
            this.txtLugarNacimiento.Location = new System.Drawing.Point(267, 116);
            this.txtLugarNacimiento.Name = "txtLugarNacimiento";
            this.txtLugarNacimiento.Size = new System.Drawing.Size(100, 22);
            this.txtLugarNacimiento.TabIndex = 3;
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(448, 116);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(75, 23);
            this.btnEscribir.TabIndex = 4;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // btnSupervisar
            // 
            this.btnSupervisar.Location = new System.Drawing.Point(200, 229);
            this.btnSupervisar.Name = "btnSupervisar";
            this.btnSupervisar.Size = new System.Drawing.Size(97, 23);
            this.btnSupervisar.TabIndex = 5;
            this.btnSupervisar.Text = "Supervisar";
            this.btnSupervisar.UseVisualStyleBackColor = true;
            this.btnSupervisar.Click += new System.EventHandler(this.btnSupervisar_Click);
            // 
            // btnAdministar
            // 
            this.btnAdministar.Location = new System.Drawing.Point(397, 229);
            this.btnAdministar.Name = "btnAdministar";
            this.btnAdministar.Size = new System.Drawing.Size(91, 23);
            this.btnAdministar.TabIndex = 6;
            this.btnAdministar.Text = "Administrar";
            this.btnAdministar.UseVisualStyleBackColor = true;
            this.btnAdministar.Click += new System.EventHandler(this.btnAdministar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "LugarNacimiento";
            // 
            // btnControlar
            // 
            this.btnControlar.Location = new System.Drawing.Point(566, 229);
            this.btnControlar.Name = "btnControlar";
            this.btnControlar.Size = new System.Drawing.Size(75, 23);
            this.btnControlar.TabIndex = 10;
            this.btnControlar.Text = "Controlar";
            this.btnControlar.UseVisualStyleBackColor = true;
            this.btnControlar.Click += new System.EventHandler(this.btnControlar_Click);
            // 
            // fmrRector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnControlar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdministar);
            this.Controls.Add(this.btnSupervisar);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.txtLugarNacimiento);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.btnLeer);
            this.Name = "fmrRector";
            this.Text = "Rector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtLugarNacimiento;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.Button btnSupervisar;
        private System.Windows.Forms.Button btnAdministar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnControlar;
    }
}