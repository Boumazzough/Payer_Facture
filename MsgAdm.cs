using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet
{

    public partial class MsgAdm : Form
    {
        public string facture;
        public string compte;
        public string libelle;
        public string montant;
        public MsgAdm()
        {
            InitializeComponent();
        }

        private void MsgAdm_Load(object sender, EventArgs e)
        {
            label1.Text = "Facture: "+facture ;
            label2.Text = "Libellé: "+libelle;
            label3.Text = "№ de Compte: " + compte;
            label4.Text = "Montant payer: " + montant + " DHs";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
