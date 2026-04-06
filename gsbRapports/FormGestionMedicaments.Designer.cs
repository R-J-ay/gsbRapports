namespace gsbRapports
{
    partial class FormGestionMedicaments
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
            this.components = new System.ComponentModel.Container();
            this.cbxFamilles = new System.Windows.Forms.ComboBox();
            this.dgvMedicaments = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomCommercialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFamilleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.effetsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contreIndicationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicamentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gsbrapports2016DataSet = new gsbRapports.gsbrapports2016DataSet();
            this.medicamentTableAdapter = new gsbRapports.gsbrapports2016DataSetTableAdapters.medicamentTableAdapter();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtComposition = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Button();
            this.txtEffets = new System.Windows.Forms.TextBox();
            this.btnPlusFamille = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicaments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gsbrapports2016DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxFamilles
            // 
            this.cbxFamilles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFamilles.FormattingEnabled = true;
            this.cbxFamilles.Location = new System.Drawing.Point(288, 22);
            this.cbxFamilles.Name = "cbxFamilles";
            this.cbxFamilles.Size = new System.Drawing.Size(218, 24);
            this.cbxFamilles.TabIndex = 0;
            this.cbxFamilles.SelectedIndexChanged += new System.EventHandler(this.cbxFamilles_SelectedIndexChanged);
            // 
            // dgvMedicaments
            // 
            this.dgvMedicaments.AllowUserToOrderColumns = true;
            this.dgvMedicaments.AutoGenerateColumns = false;
            this.dgvMedicaments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicaments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomCommercialDataGridViewTextBoxColumn,
            this.idFamilleDataGridViewTextBoxColumn,
            this.compositionDataGridViewTextBoxColumn,
            this.effetsDataGridViewTextBoxColumn,
            this.contreIndicationsDataGridViewTextBoxColumn});
            this.dgvMedicaments.DataSource = this.medicamentBindingSource;
            this.dgvMedicaments.Location = new System.Drawing.Point(94, 192);
            this.dgvMedicaments.Name = "dgvMedicaments";
            this.dgvMedicaments.RowHeadersWidth = 51;
            this.dgvMedicaments.RowTemplate.Height = 24;
            this.dgvMedicaments.Size = new System.Drawing.Size(584, 163);
            this.dgvMedicaments.TabIndex = 1;
            this.dgvMedicaments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedicaments_CellContentClick);
            this.dgvMedicaments.SelectionChanged += new System.EventHandler(this.dgvMedicaments_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomCommercialDataGridViewTextBoxColumn
            // 
            this.nomCommercialDataGridViewTextBoxColumn.DataPropertyName = "nomCommercial";
            this.nomCommercialDataGridViewTextBoxColumn.HeaderText = "nomCommercial";
            this.nomCommercialDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomCommercialDataGridViewTextBoxColumn.Name = "nomCommercialDataGridViewTextBoxColumn";
            this.nomCommercialDataGridViewTextBoxColumn.Width = 125;
            // 
            // idFamilleDataGridViewTextBoxColumn
            // 
            this.idFamilleDataGridViewTextBoxColumn.DataPropertyName = "idFamille";
            this.idFamilleDataGridViewTextBoxColumn.HeaderText = "idFamille";
            this.idFamilleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idFamilleDataGridViewTextBoxColumn.Name = "idFamilleDataGridViewTextBoxColumn";
            this.idFamilleDataGridViewTextBoxColumn.Width = 125;
            // 
            // compositionDataGridViewTextBoxColumn
            // 
            this.compositionDataGridViewTextBoxColumn.DataPropertyName = "composition";
            this.compositionDataGridViewTextBoxColumn.HeaderText = "composition";
            this.compositionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.compositionDataGridViewTextBoxColumn.Name = "compositionDataGridViewTextBoxColumn";
            this.compositionDataGridViewTextBoxColumn.Width = 125;
            // 
            // effetsDataGridViewTextBoxColumn
            // 
            this.effetsDataGridViewTextBoxColumn.DataPropertyName = "effets";
            this.effetsDataGridViewTextBoxColumn.HeaderText = "effets";
            this.effetsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.effetsDataGridViewTextBoxColumn.Name = "effetsDataGridViewTextBoxColumn";
            this.effetsDataGridViewTextBoxColumn.Width = 125;
            // 
            // contreIndicationsDataGridViewTextBoxColumn
            // 
            this.contreIndicationsDataGridViewTextBoxColumn.DataPropertyName = "contreIndications";
            this.contreIndicationsDataGridViewTextBoxColumn.HeaderText = "contreIndications";
            this.contreIndicationsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contreIndicationsDataGridViewTextBoxColumn.Name = "contreIndicationsDataGridViewTextBoxColumn";
            this.contreIndicationsDataGridViewTextBoxColumn.Width = 125;
            // 
            // medicamentBindingSource
            // 
            this.medicamentBindingSource.DataMember = "medicament";
            this.medicamentBindingSource.DataSource = this.gsbrapports2016DataSet;
            // 
            // gsbrapports2016DataSet
            // 
            this.gsbrapports2016DataSet.DataSetName = "gsbrapports2016DataSet";
            this.gsbrapports2016DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicamentTableAdapter
            // 
            this.medicamentTableAdapter.ClearBeforeFill = true;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(220, 86);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(152, 22);
            this.txtNom.TabIndex = 3;
            this.txtNom.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nom";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Famille";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtComposition
            // 
            this.txtComposition.Location = new System.Drawing.Point(421, 86);
            this.txtComposition.Name = "txtComposition";
            this.txtComposition.Size = new System.Drawing.Size(170, 22);
            this.txtComposition.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(468, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Composition";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(376, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Effet";
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(199, 393);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(98, 26);
            this.btnModifier.TabIndex = 11;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // txtEffets
            // 
            this.txtEffets.Location = new System.Drawing.Point(94, 155);
            this.txtEffets.MaxLength = 100;
            this.txtEffets.Name = "txtEffets";
            this.txtEffets.Size = new System.Drawing.Size(602, 22);
            this.txtEffets.TabIndex = 12;
            // 
            // btnPlusFamille
            // 
            this.btnPlusFamille.Location = new System.Drawing.Point(514, 15);
            this.btnPlusFamille.Name = "btnPlusFamille";
            this.btnPlusFamille.Size = new System.Drawing.Size(36, 37);
            this.btnPlusFamille.TabIndex = 13;
            this.btnPlusFamille.Text = "+";
            this.btnPlusFamille.UseVisualStyleBackColor = true;
            this.btnPlusFamille.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(462, 393);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(167, 32);
            this.btnAjouter.TabIndex = 14;
            this.btnAjouter.Text = "Ajouter Médicaments";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // FormGestionMedicaments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnPlusFamille);
            this.Controls.Add(this.txtEffets);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtComposition);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.dgvMedicaments);
            this.Controls.Add(this.cbxFamilles);
            this.Name = "FormGestionMedicaments";
            this.Text = "FormGestionMedicaments";
            this.Load += new System.EventHandler(this.FormGestionMedicaments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicaments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gsbrapports2016DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxFamilles;
        private System.Windows.Forms.DataGridView dgvMedicaments;
        private gsbrapports2016DataSet gsbrapports2016DataSet;
        private System.Windows.Forms.BindingSource medicamentBindingSource;
        private gsbrapports2016DataSetTableAdapters.medicamentTableAdapter medicamentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCommercialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFamilleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn effetsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contreIndicationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtComposition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.TextBox txtEffets;
        private System.Windows.Forms.Button btnPlusFamille;
        private System.Windows.Forms.Button btnAjouter;
    }
}