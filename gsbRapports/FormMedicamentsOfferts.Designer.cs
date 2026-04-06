namespace gsbRapports
{
    partial class FormMedicamentsOfferts
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
            this.cbxFamilles = new System.Windows.Forms.ComboBox();
            this.dgvOfferts = new System.Windows.Forms.DataGridView();
            this.btnExportXML = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOfferts)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxFamilles
            // 
            this.cbxFamilles.FormattingEnabled = true;
            this.cbxFamilles.Location = new System.Drawing.Point(193, 57);
            this.cbxFamilles.Name = "cbxFamilles";
            this.cbxFamilles.Size = new System.Drawing.Size(368, 24);
            this.cbxFamilles.TabIndex = 0;
            this.cbxFamilles.SelectedIndexChanged += new System.EventHandler(this.cbxFamilles_SelectedIndexChanged);
            // 
            // dgvOfferts
            // 
            this.dgvOfferts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOfferts.Location = new System.Drawing.Point(117, 103);
            this.dgvOfferts.Name = "dgvOfferts";
            this.dgvOfferts.RowHeadersWidth = 51;
            this.dgvOfferts.RowTemplate.Height = 24;
            this.dgvOfferts.Size = new System.Drawing.Size(544, 216);
            this.dgvOfferts.TabIndex = 1;
            // 
            // btnExportXML
            // 
            this.btnExportXML.Location = new System.Drawing.Point(273, 357);
            this.btnExportXML.Name = "btnExportXML";
            this.btnExportXML.Size = new System.Drawing.Size(191, 31);
            this.btnExportXML.TabIndex = 3;
            this.btnExportXML.Text = "Exporter en XML";
            this.btnExportXML.UseVisualStyleBackColor = true;
            this.btnExportXML.Click += new System.EventHandler(this.btnExportXML_Click);
            // 
            // FormMedicamentsOfferts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExportXML);
            this.Controls.Add(this.dgvOfferts);
            this.Controls.Add(this.cbxFamilles);
            this.Name = "FormMedicamentsOfferts";
            this.Text = "FormMedicamentsOfferts";
            this.Load += new System.EventHandler(this.FormMedicamentsOfferts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOfferts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxFamilles;
        private System.Windows.Forms.DataGridView dgvOfferts;
        private System.Windows.Forms.Button btnExportXML;
    }
}