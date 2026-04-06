using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gsbRapports
{
    public partial class Menu : Form
    {
        public Menu()
        {
            this.InitializeComponent();
        }

        // Cas d'utilisation : Gestion des médicaments (Ajouter/Modifier/Supprimer)
        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // On crée une instance du formulaire de gestion
            FormGestionMedicaments fenetreGestion = new FormGestionMedicaments();
            // .ShowDialog() bloque le menu tant que la fenêtre n'est pas fermée
            fenetreGestion.ShowDialog();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Pour fermer proprement l'application
        }

        private void Menu_Load(object sender, EventArgs e)
        {
        }

        private void listeOffertsMenuItem_Click(object sender, EventArgs e)
        {
            FormMedicamentsOfferts fenetreDons = new FormMedicamentsOfferts();
            fenetreDons.ShowDialog();
        }
    }
}