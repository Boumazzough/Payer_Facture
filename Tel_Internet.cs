using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using System.Text.RegularExpressions;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Projet
{
    public partial class Tel_Internet : Form
    {
      
        MsgTel message;
        ErrMsg ErrMessage;
        //string cnnString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Banque.mdf;Integrated Security=True";
        static string cnnString = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;
        List<Panel> listPanel=new List<Panel>();
        int index;
        public int compte_id=19;
        int solde;
        String r;
        int passe;
        public Tel_Internet()
        {
            InitializeComponent();
        }

        private void Tel_Internet_Load(object sender, EventArgs e)
        {
            listPanel.Add(panel1);
            listPanel.Add(panel2);
            listPanel[index].BringToFront();
            comboBox1.Text = comboBox1.Items[0].ToString();
        }

        public void verif_chiffre(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
                e.Handled = false;
            else
            {
                if (char.IsControl(e.KeyChar))
                    e.Handled = false;
                else
                    e.Handled = true;
            }
            
        }
        private void textBoxPhone_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBoxPhone.Text.StartsWith("0"))
            {
                labelTel.Text = " il faut pas commencer par '0'";
                labelTel.Visible = true;
            }
            else
            {
                if (textBoxPhone.TextLength != 9)
                {
                    labelTel.Text = "le numéro doit être composé de 9 chiffres";
                    labelTel.Visible = true;
                }
                else {
                    if (textBoxPhone.Text == "")
                    {
                        labelTel.Text = "Champ vide";
                        labelTel.Visible = true;
                    }
                    else
                        labelTel.Visible = false;
                }
               
            }
        }

        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            verif_chiffre(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            verif_chiffre(e);
        }

        private void textBoxMontant_KeyPress(object sender, KeyPressEventArgs e)
        {
            verif_chiffre(e);
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            
                if (textBox1.TextLength != 4)
                {
                    labelCode.Text = "le code doit être composé de 4 chiffres";
                    labelCode.Visible = true;
                }
                else
                {
                    if (textBox1.Text == "")
                    {
                    labelCode.Text = "Champ vide";
                    labelCode.Visible = true;
                    }
                    else
                    labelCode.Visible = false;
                }

        }

        private void textBoxMontant_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBoxMontant.Text == "")
            {
                labelMontant.Text = "Champ vide";
                labelMontant.Visible = true;
            }
            else
                labelMontant.Visible = false;
        }

     
        private void button1_Click(object sender, EventArgs e) // valider la facture
        {
            if (textBoxPhone.Text == "" || textBox1.Text =="" || textBoxMontant.Text == "" )
            {
                ErrMessage = new ErrMsg();
                ErrMessage.Errmsg = "Veuillez remplir le(s) champ(s) vide(s)";
                ErrMessage.ShowDialog();
               
            }
            else
            {
                if(textBox1.Text.Length == 4)
                {
                    int p = twilio_fct();
                    if (p == 1)
                    {
                        // button
                        if (index < listPanel.Count - 1)
                        {
                            listPanel[++index].BringToFront();
                        }
                    }
                }
                
            }   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                listPanel[--index].BringToFront();
            }
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox2.TextLength != 6)
            {
                labelCode1.Text = "le code doit être composé de 6 chiffres";
                labelCode1.Visible = true;
            }
            else
            {
                if (textBox2.Text == "")
                {
                    labelCode1.Text = "Champ vide";
                    labelCode1.Visible = true;
                }
                else
                    labelCode1.Visible = false;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            verif_chiffre(e);
        }

       

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Cursor = Cursors.Hand;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            pictureBox1.Cursor = Cursors.Default;
        }

        private void button2_Click(object sender, EventArgs e) // valider le code de verification
        {

            message = new MsgTel();
            using (SqlConnection con1 = new SqlConnection(cnnString))
            {
                con1.Open();


                SqlCommand cmd1 = con1.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "select compte_num from [compte] where id = '" + compte_id + "'";
                cmd1.ExecuteNonQuery();
                DataTable dta1 = new DataTable();
                SqlDataAdapter dataadp1 = new SqlDataAdapter(cmd1.CommandText, con1); ;
                dataadp1.Fill(dta1);
                foreach (DataRow dr1 in dta1.Rows)
                {
                    message.compte = dr1["compte_num"].ToString();
                }
            }
            message.facture = comboBox1.Text;
            message.tele = "+212"+textBoxPhone.Text;
            message.montant = textBoxMontant.Text;
            if (r == textBox2.Text)
            {
                DateTime date = DateTime.Now;
                string format = "yyyy-MM-dd";
                using (SqlConnection cnn = new SqlConnection(cnnString))
                {
                    //OPen the connection
                    cnn.Open();

                    try
                    {
                        //Replaced Parameters with Value
                        string sql = "insert into [operation](operation_type,montant,libelle,operation_date,compte_id) values(@type,@montant,@libelle,@date,@compte)";

                        using (SqlCommand cmd = new SqlCommand(sql, cnn))
                        {
                            //Pass values to Parameters
                            cmd.Parameters.AddWithValue("@type", "Facture");
                            cmd.Parameters.AddWithValue("@montant", textBoxMontant.Text);
                            cmd.Parameters.AddWithValue("@libelle", "Facture " + comboBox1.Text);
                            cmd.Parameters.AddWithValue("@date", date.ToString(format));
                            cmd.Parameters.AddWithValue("@compte", compte_id);

                            //set command type
                            cmd.CommandType = CommandType.Text;
                            //Execute the INSERT statement
                            cmd.ExecuteNonQuery();
                            
                        }
                        using (SqlCommand cmd1 = new SqlCommand(sql, cnn))
                        {
                            cmd1.CommandType = CommandType.Text;
                            cmd1.CommandText = "select montant from [compte] where id = '" + compte_id + "'";
                            cmd1.ExecuteNonQuery();
                            DataTable dta1 = new DataTable();
                            SqlDataAdapter dataadp1 = new SqlDataAdapter(cmd1.CommandText, cnn); ;
                            dataadp1.Fill(dta1);
                            foreach (DataRow dr1 in dta1.Rows)
                            {
                                Console.WriteLine("d1" + dr1["montant"]);
                                dr1["montant"] = Convert.ToInt32(dr1["montant"]) - Convert.ToInt32(textBoxMontant.Text);
                                solde = Convert.ToInt32(dr1["montant"]);
                                Console.WriteLine("d2" + dr1["montant"]);
                            }
                        }
                        Console.WriteLine(solde);
                        string sql2 = "UPDATE [compte] SET montant =@montant WHERE id =@compte";
                        using (SqlCommand cmd2 = new SqlCommand(sql2, cnn))
                        {
                            cmd2.Parameters.AddWithValue("@montant", solde);
                            cmd2.Parameters.AddWithValue("@compte", compte_id);
                            //set command type
                            cmd2.CommandType = CommandType.Text;
                            //Execute the INSERT statement
                            cmd2.ExecuteNonQuery();
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        MessageBox.Show(this, " l'insertion est echoue", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                message.ShowDialog();
                textBox2.Text = "";
                textBoxPhone.Text = "";
                textBoxMontant.Text = "";
                textBox1.Text = "";
            }
            else
            {
                ErrMessage = new ErrMsg();
                ErrMessage.Errmsg = "Veuillez saisir un code valide";
                ErrMessage.ShowDialog();
            }
            
        }

        public int twilio_fct()
        {
            try
            {
                if (textBox1.Text != "" && textBoxMontant.Text != "")
                {
                    /// generate random number 6D
                    Random generator = new Random();
                    r = generator.Next(100000, 999999).ToString("D6");
                    // account sid and auth tocken
                    const string accountSid = "ACc4333e701e8c0c003f6c0d1015d884d7";
                    const string authToken = "a5d22c7fd3ecdc5a8b74556a110650c0";
                    TwilioClient.Init(accountSid, authToken);
                    var to = new PhoneNumber("+212" + textBoxPhone.Text);

                    var message = MessageResource.Create(
                        to,
                        from: new PhoneNumber("+12034635768"),
                        body: "Your verification code is:  " + r
                        );
                    Console.WriteLine(message.Sid);
                    passe = 1;
                }
               
            }
            catch (Exception ex)
            {
                passe = 0;
                ErrMessage = new ErrMsg();
                ErrMessage.Errmsg = "Veuillez saisir un numéro de téléphone valide";
                ErrMessage.ShowDialog();
            }
            return passe;
        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            twilio_fct();
        }
    }
}
