using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gsbRapports
{
    public partial class FormMedicamentsOfferts : Form
    {
        private gsbrapports2016DataSet monDataSet = new gsbrapports2016DataSet();
        private gsbRapports.gsbrapports2016DataSetTableAdapters.familleTableAdapter adpFamille = new gsbRapports.gsbrapports2016DataSetTableAdapters.familleTableAdapter();
        private gsbRapports.gsbrapports2016DataSetTableAdapters.medicamentTableAdapter adpMedicament = new gsbRapports.gsbrapports2016DataSetTableAdapters.medicamentTableAdapter();
        // -----------------------------
        public FormMedicamentsOfferts()
        {
            InitializeComponent();
        }

        private void FormMedicamentsOfferts_Load(object sender, EventArgs e)
        {
            // Remplir le DataSet avec les familles
            this.adpFamille.Fill(this.monDataSet.famille);

            cbxFamilles.DataSource = this.monDataSet.famille;
            cbxFamilles.DisplayMember = "libelle";
            cbxFamilles.ValueMember = "id";
            cbxFamilles.SelectedIndex = -1;
        }

        private void cbxFamilles_SelectedIndexChanged(object sender, EventArgs e)
        {
            // On vérifie que SelectedValue est bien un string (l'ID de la famille)
            if (cbxFamilles.SelectedValue != null && cbxFamilles.SelectedValue is string)
            {
                // On vérifie que SelectedValue est bien un string (l'ID de la famille)
                if (cbxFamilles.SelectedValue != null && cbxFamilles.SelectedValue is string)
                {
                    string idFamille = cbxFamilles.SelectedValue.ToString();

                    try
                    {
                        // 1. On charge les données fraîches depuis SQL Server
                        this.adpMedicament.Fill(this.monDataSet.medicament);

                        // 2. On crée la vue filtrée et triée
                        DataView dv = new DataView(this.monDataSet.medicament);
                        dv.RowFilter = "idFamille = '" + idFamille + "' AND totalOffert > 0";
                        dv.Sort = "totalOffert DESC";

                        // 3. On lie les données à la grille
                        dgvOfferts.DataSource = dv;

                        // --- DEBUT DE LA PARTIE "JOLIE" (UI) ---

                        // Masquer les colonnes techniques dont la secrétaire n'a pas besoin
                        if (dgvOfferts.Columns.Contains("idFamille")) dgvOfferts.Columns["idFamille"].Visible = false;
                        if (dgvOfferts.Columns.Contains("id")) dgvOfferts.Columns["id"].Visible = false;
                        if (dgvOfferts.Columns.Contains("contreIndications")) dgvOfferts.Columns["contreIndications"].Visible = false;

                        // Renommer les entêtes pour que ce soit lisible
                        dgvOfferts.Columns["nomCommercial"].HeaderText = "Médicament";
                        dgvOfferts.Columns["composition"].HeaderText = "Composition";
                        dgvOfferts.Columns["effets"].HeaderText = "Effets thérapeutiques";
                        dgvOfferts.Columns["totalOffert"].HeaderText = "Quantité Totale Offerte";

                        // Améliorer l'affichage (Lignes alternées pour la lecture)
                        dgvOfferts.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
                        dgvOfferts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                        // --- FIN DE LA PARTIE "JOLIE" ---
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur d'affichage : " + ex.Message);
                    }
                }
            }
        }

        private void btnExportXML_Click(object sender, EventArgs e)
        {
            // 1. On vérifie qu'il y a des données à exporter
            if (dgvOfferts.Rows.Count > 0)
            {
                // 2. Configuration de la boîte de dialogue de sauvegarde
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Fichier XML (*.xml)|*.xml";
                saveFileDialog.Title = "Exporter les médicaments offerts";
                saveFileDialog.FileName = "Export_Medicaments_Offerts.xml";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // 3. Création d'une DataTable temporaire pour ne stocker que ce qui est filtré
                        // On clone la structure de la table médicaments
                        DataTable dtExport = ((DataView)dgvOfferts.DataSource).ToTable();

                        // On donne un nom à la table (important pour la racine du XML)
                        dtExport.TableName = "MedicamentOffert";

                        // 4. Écriture du fichier XML
                        dtExport.WriteXml(saveFileDialog.FileName, XmlWriteMode.WriteSchema);

                        MessageBox.Show("Exportation réussie dans : " + saveFileDialog.FileName,
                                        "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur lors de l'exportation : " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Aucune donnée à exporter.");
            }
        }
    }
}
