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
    public partial class MsgEE : Form
    {
        public string facture;
        public string compte;
        public string agence;
        public string service;
        public string montant;
        public MsgEE()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MsgEE_Load(object sender, EventArgs e)
        {
            label1.Text = facture + " Facture";
            label2.Text ="№ de Compte:"+compte;
            label3.Text ="Agence: " + agence;
            label4.Text ="service: " + service;
            label5.Text ="Montant payer: " + montant + " DHs";
        }
    }
}
