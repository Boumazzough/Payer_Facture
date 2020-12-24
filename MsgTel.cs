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
    public partial class MsgTel : Form
    {
        public string facture;
        public string compte;
        public string tele;
        public string montant;
        public MsgTel()
        {
            InitializeComponent();
        }

        private void MessageBox_Load(object sender, EventArgs e)
        {
            label1.Text = facture+" Facture";
            label2.Text = "№ de Compte:"+compte;
            label3.Text = "№ de Téléphone: "+tele;
            label4.Text = "Montant payer: "+montant+" DHs";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
