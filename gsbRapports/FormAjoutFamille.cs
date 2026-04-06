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
    public partial class FormAjoutFamille : Form
    {
        public FormAjoutFamille()
        {
            InitializeComponent();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (txtIdFamille.Text != "" && txtLibelle.Text != "")
            {
                try
                {
                    // Utilisation du TableAdapter famille
                    var adpFamille = new gsbRapports.gsbrapports2016DataSetTableAdapters.familleTableAdapter();
                    adpFamille.Insert(txtIdFamille.Text, txtLibelle.Text);

                    MessageBox.Show("Nouvelle famille enregistrée !");
                    this.Close(); // On ferme la fenêtre après validation
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : L'ID existe peut-être déjà. " + ex.Message);
                }
            }
        }
    }
}
