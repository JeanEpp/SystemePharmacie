using Pharmacie.InterfaceUtilisateur;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystèmePharmacie.Pharmacie
{
    public partial class EcranPrincipale : Form
    {
        public EcranPrincipale()
        {
            InitializeComponent();
        }

        private void ajouterMédecinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjoutMédecin view = new AjoutMédecin();
            view.Show();
            view.Focus();
        }
        private void consulterMédecinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RechercherMédecin view = new RechercherMédecin();
            view.Show();
            view.Focus();
        }

        private void ajouterMédicamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjoutMédicamment view = new AjoutMédicamment();
            view.Show();
            view.Focus();
        }

        private void consulterMédicamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RechercherMédicamment view = new RechercherMédicamment();
            view.Show();
            view.Focus();
        }

        private void ajouterPatientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjoutPatient view = new AjoutPatient();
            view.Show();
            view.Focus();
        }

        private void consulterPatientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RechercherPatient view = new RechercherPatient();
            view.Show();
            view.Focus();
        }

        private void ajouterPharmaciesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjoutPharmacie view = new AjoutPharmacie();
            view.Show();
            view.Focus();
        }

        private void consulterPharmaciesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RechercherPharmacie view = new RechercherPharmacie();
            view.Show();
            view.Focus();
        }

        private void ajouterPharmaciensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjoutPharmacien view = new AjoutPharmacien();
            view.Show();
            view.Focus();
        }

        private void consulterPharmaciensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RechercherPharmacien view = new RechercherPharmacien();
            view.Show();
            view.Focus();
        }

        private void ajouterPrescriptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjoutPréscription view = new AjoutPréscription();
            view.Show();
            view.Focus();
        }

        private void consulterPrescriptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RechercherPrescription view = new RechercherPrescription();
            view.Show();
            view.Focus();
        }

        private void renouvellementInterneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Renouvellement view = new Renouvellement();
            view.Show();
            view.Focus();
        }
    }
}
