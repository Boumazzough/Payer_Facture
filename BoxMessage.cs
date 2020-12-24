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
    public partial class BoxMessage : Form
    {
        public String Message;
        public bool clicked = false;
        public BoxMessage(String Message)
        {
            this.Message = Message;
            InitializeComponent();
        }

        private void Ok_button_Click(object sender, EventArgs e)
        {
            clicked = true;
            this.Hide();
        }

        private void BoxMessage_Load(object sender, EventArgs e)
        {
            msgField.Text = this.Message;
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            clicked = true;
            this.Hide();
        }

        private void msgField_Click(object sender, EventArgs e)
        {

        }
    }
}
