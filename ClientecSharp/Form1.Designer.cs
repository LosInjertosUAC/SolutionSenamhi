
namespace ClientecSharp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnConsultaxCiudad = new System.Windows.Forms.Button();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.dgvReporte = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(97, 119);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(156, 23);
            this.btnConsulta.TabIndex = 0;
            this.btnConsulta.Text = "Consultar Temperaturas";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnConsultaxCiudad
            // 
            this.btnConsultaxCiudad.Location = new System.Drawing.Point(303, 119);
            this.btnConsultaxCiudad.Name = "btnConsultaxCiudad";
            this.btnConsultaxCiudad.Size = new System.Drawing.Size(151, 23);
            this.btnConsultaxCiudad.TabIndex = 1;
            this.btnConsultaxCiudad.Text = "Consulta por Ciudad";
            this.btnConsultaxCiudad.UseVisualStyleBackColor = true;
            this.btnConsultaxCiudad.Click += new System.EventHandler(this.btnConsultaxCiudad_Click);
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(97, 71);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(214, 20);
            this.txtCiudad.TabIndex = 2;
            // 
            // dgvReporte
            // 
            this.dgvReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporte.Location = new System.Drawing.Point(97, 177);
            this.dgvReporte.Name = "dgvReporte";
            this.dgvReporte.Size = new System.Drawing.Size(240, 150);
            this.dgvReporte.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvReporte);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.btnConsultaxCiudad);
            this.Controls.Add(this.btnConsulta);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnConsultaxCiudad;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.DataGridView dgvReporte;
    }
}

