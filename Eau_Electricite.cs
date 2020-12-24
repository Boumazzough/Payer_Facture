using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Projet
{
    public partial class Eau_Electricite : Form
    {
        MsgEE message;
        ErrMsg ErrMessage;
        //string cnnString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Banque.mdf;Integrated Security=True";
        static string cnnString = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;
        public Tel_Internet telInt;
        public int compte_id=19;
        int solde;
        public Eau_Electricite()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // valider
        {
            
            message = new MsgEE();
            if (textBox2.Text == "" || textBox3.Text == "" )
            {
                ErrMessage = new ErrMsg();
                ErrMessage.Errmsg = "Veuillez remplir le(s) champ(s) vide(s)";
                ErrMessage.ShowDialog();

            }
            else
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
                            cmd.Parameters.AddWithValue("@montant", textBox3.Text);
                            cmd.Parameters.AddWithValue("@libelle", "Facture d'" + comboBox2.Text);
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
                               
                                dr1["montant"] = Convert.ToInt32(dr1["montant"]) - Convert.ToInt32(textBox3.Text);
                                solde = Convert.ToInt32(dr1["montant"]);
                            }
                        }

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
                    message.agence = comboBox1.Text;
                    message.service = comboBox2.Text;
                    message.montant = textBox3.Text;
                    message.ShowDialog();
                    comboBox1.Text = "Lydec";
                    comboBox2.Text = "Eau";
                    textBox2.Text = "";
                    textBox3.Text = "";
               
            }
           

        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            
                    if (textBox2.Text == "")
                    {
                        label4.Text = "Champ vide";
                        label4.Visible = true;
                    }
                    else
                        label4.Visible = false;
       
        }

        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox3.Text == "")
            {
                label5.Text = "Champ vide";
                label5.Visible = true;
            }
            else
                label5.Visible = false;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            telInt = new Tel_Internet();
            telInt.verif_chiffre(e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            telInt = new Tel_Internet();
            telInt.verif_chiffre(e);
        }

        private void Eau_Electricite_Load(object sender, EventArgs e)
        {
            comboBox1.Text = comboBox1.Items[0].ToString();
            comboBox2.Text = comboBox2.Items[0].ToString();
        }
    }
}
