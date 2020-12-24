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
    public partial class Administration : Form
    {
        ErrMsg ErrMessage;
       // string cnnString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Banque.mdf;Integrated Security=True";
        static string cnnString = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;
       // SqlConnection cnnString = new SqlConnection(connectionString);
        public Tel_Internet adm;
        List<Panel> listpanel = new List<Panel>();
        int index;
        MsgAdm message;
        public int compte_id=19;
        int solde;
        public Administration()
        {
            InitializeComponent();
        }

        

        private void Administration_Load(object sender, EventArgs e)
        {
            listpanel.Add(panelTGR);
            listpanel.Add(panel2);
            listpanel[index].BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(157, 144, 162);
            button2.BackColor = Color.FromArgb(64, 54, 86);
            if (index < listpanel.Count - 1)
            {
                listpanel[++index].BringToFront();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(157, 144, 162);
            button4.BackColor = Color.FromArgb(64, 54, 86);
            if (index > 0)
            {
                listpanel[--index].BringToFront();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        public void verif_char(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
                e.Handled =false;
            else
            {
                if (char.IsLetter(e.KeyChar))
                    e.Handled= false;
                else
                    e.Handled =true;
            }

        }
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {

            if (textBox1.Text == "")
            {
                label4.Text = "Champ vide";
                label4.Visible = true;
            }
            else
                label4.Visible = false;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            verif_char(e);
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox2.Text == "")
            {
                label5.Text = "Champ vide";
                label5.Visible = true;
            }
            else
                label5.Visible = false;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            adm = new Tel_Internet();
            adm.verif_chiffre(e);
        }

        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox3.Text == "")
            {
                label6.Text = "Champ vide";
                label6.Visible = true;
            }
            else
                label6.Visible = false;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            adm = new Tel_Internet();
            adm.verif_chiffre(e);
        }

        private void button3_Click_1(object sender, EventArgs e) //valider le tgr
        {
            message = new MsgAdm();
            if (textBox1.Text == "" ||  textBox2.Text == "" || textBox3.Text == "")
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
                            cmd.Parameters.AddWithValue("@libelle", textBox1.Text);
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

                        try
                        {
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
                        catch(Exception ex)
                        {
                            Console.WriteLine("erreur d'update"+ex.Message); 
                        }

                       

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        MessageBox.Show(this, " l'insertion est echoue", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                //if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
               // {
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

                    message.facture = textBox1.Text;
                    message.libelle = textBox1.Text;
                    message.montant = textBox3.Text;
                    message.ShowDialog();
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
               // }
            }

        }

        private void textBox4_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox4.Text == "")
            {
                label10.Text = "Champ vide";
                label10.Visible = true;
            }
            else
                label10.Visible = false;
        }

        private void textBox5_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox5.Text == "")
            {
                label11.Text = "Champ vide";
                label11.Visible = true;
            }
            else
                label11.Visible = false;
        }

        private void textBox6_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox6.Text == "")
            {
                label4.Text = "Champ vide";
                label4.Visible = true;
            }
            else
                label4.Visible = false;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            verif_char(e);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            adm = new Tel_Internet();
            adm.verif_chiffre(e);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            adm = new Tel_Internet();
            adm.verif_chiffre(e);
        }

        private void button1_Click(object sender, EventArgs e) // valider la facture DGI
        {
            message = new MsgAdm();
            if (textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
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
                            cmd.Parameters.AddWithValue("@montant", textBox6.Text);
                            cmd.Parameters.AddWithValue("@libelle", textBox4.Text);
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
                            DataTable dta2 = new DataTable();
                            SqlDataAdapter dataadp2 = new SqlDataAdapter(cmd1.CommandText, cnn); ;
                            dataadp2.Fill(dta2);
                            foreach (DataRow dr2 in dta2.Rows)
                            {

                                dr2["montant"] = Convert.ToInt32(dr2["montant"]) - Convert.ToInt32(textBox6.Text);
                                solde = Convert.ToInt32(dr2["montant"]);
                            }

                            
                        }

                        try
                        {
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
                            Console.WriteLine("erreur d'update" + ex.Message);
                        }


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        MessageBox.Show(this, " l'insertion est echoue", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
              //  if (textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
                //{

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
                    message.facture = textBox4.Text;
                    message.libelle = textBox4.Text;
                    message.montant = textBox6.Text;
                    message.ShowDialog();
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                //}
            }
        }

        private void panel22_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuSeparator1_Load(object sender, EventArgs e)
        {

        }

        private void panelTGR_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelTGR_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void labelDGI_Click(object sender, EventArgs e)
        {

        }
    }
}
