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
    public partial class FormGestionMedicaments : Form
    {
        // 1. Déclarations (les noms à utiliser sont adpFamille et adpMedicament)
        private gsbrapports2016DataSet monDataSet = new gsbrapports2016DataSet();
        private gsbRapports.gsbrapports2016DataSetTableAdapters.familleTableAdapter adpFamille = new gsbRapports.gsbrapports2016DataSetTableAdapters.familleTableAdapter();
        private gsbRapports.gsbrapports2016DataSetTableAdapters.medicamentTableAdapter adpMedicament = new gsbRapports.gsbrapports2016DataSetTableAdapters.medicamentTableAdapter();
        public FormGestionMedicaments()
        {
            InitializeComponent();
        }

        private void FormGestionMedicaments_Load(object sender, EventArgs e)
        {
            // Utilisez les noms déclarés juste au-dessus (adpFamille au lieu de familleTableAdapter)
            this.adpFamille.Fill(this.monDataSet.famille);

            /// On lie la ComboBox à la table de mon instance 'monDataSet'
            cbxFamilles.DataSource = this.monDataSet.famille;
            cbxFamilles.DisplayMember = "libelle";
            cbxFamilles.ValueMember = "id";

            // Optionnel : ne rien sélectionner par défaut pour forcer le choix
            cbxFamilles.SelectedIndex = -1;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbxFamilles_SelectedIndexChanged(object sender, EventArgs e)
        {
            // On vérifie qu'une famille est bien sélectionnée
            if (cbxFamilles.SelectedValue != null)
            {
                // On récupère l'ID de la famille (ValueMember)
                string idFamille = cbxFamilles.SelectedValue.ToString();

                try
                {
                    // On remplit la table avec les médicaments filtrés
                    // Note : si vous n'avez pas encore créé FillByFamille, utilisez Fill pour tester
                    this.adpMedicament.Fill(this.monDataSet.medicament);

                    // On lie le DataGridView aux données
                    dgvMedicaments.DataSource = this.monDataSet.medicament;

                    // Pour filtrer visuellement sans nouvelle requête SQL immédiate :
                    (dgvMedicaments.DataSource as DataTable).DefaultView.RowFilter = "idFamille = '" + idFamille + "'";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur de filtrage : " + ex.Message);
                }
            }
        }

        private void dgvMedicaments_SelectionChanged(object sender, EventArgs e)
        {
            // On vérifie qu'une ligne est bien sélectionnée
            if (dgvMedicaments.CurrentRow != null)
            {
                // On récupère l'objet "Ligne" correspondant au médicament sélectionné
                // DataBoundItem nous donne accès à la ligne du DataSet
                DataRowView currentSdr = (DataRowView)dgvMedicaments.CurrentRow.DataBoundItem;
                gsbrapports2016DataSet.medicamentRow ligne = (gsbrapports2016DataSet.medicamentRow)currentSdr.Row;

                // On remplit les TextBox avec les colonnes de la base de données
                txtNom.Text = ligne.nomCommercial;
                txtComposition.Text = ligne.composition;
                txtEffets.Text = ligne.effets;
                //txtContreIndication.Text = ligne.contreIndication;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvMedicaments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        

        private void btnModifier_Click(object sender, EventArgs e)
        {
            // 1. On vérifie qu'une ligne est bien sélectionnée dans la grille [cite: 10]
            if (dgvMedicaments.CurrentRow != null)
            {
                // 2. On récupère la ligne de données liée 
                DataRowView drv = (DataRowView)dgvMedicaments.CurrentRow.DataBoundItem;
                var ligne = (gsbrapports2016DataSet.medicamentRow)drv.Row;

                // 3. On met à jour l'objet avec le contenu actuel des TextBox [cite: 11, 29]
                ligne.nomCommercial = txtNom.Text;
                ligne.composition = txtComposition.Text; // Ajouté
                ligne.effets = txtEffets.Text; // Ajoutez le 's' pour correspondre au nom du contrôle  // Ajouté
                                               // ligne.contreIndication = txtContreIndication.Text; // À ajouter quand j'aurais plus la flemme
                                               // Sécurité : On ne prend que les 100 premiers caractères pour éviter le crash
                if (txtEffets.Text.Length > 100)
                {
                    ligne.effets = txtEffets.Text.Substring(0, 100);
                }
                else
                {
                    ligne.effets = txtEffets.Text;
                }

                try
                {
                    this.adpMedicament.Update(this.monDataSet.medicament);
                    MessageBox.Show("Modifications enregistrées !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur SQL : " + ex.Message); // Scénario alternatif 5.1.2.1
                }
            }
        }

        //Bouton ajouter famille
        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Ouvrir le formulaire en mode "Dialogue" (bloque la fenêtre principale)
            FormAjoutFamille f = new FormAjoutFamille();
            f.ShowDialog();

            // 2. IMPORTANT : Recharger la liste des familles pour voir la nouvelle !
            this.adpFamille.Fill(this.monDataSet.famille);

        }
    }
}
