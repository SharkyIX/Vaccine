using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Covid19VaccineRegistration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try

            {

                String str = "Data Source=.;Initial Catalog=VaccineRegistrations;Integrated Security=True";
                String qry = "insert into Registered(Id, Surname, Firstname, Gender, Province)" +
                    "Values('" + IdTb.Text + "','" + SurnameTb.Text +
                    "','" + FirstnameTb.Text + "','" + GenderCb.Text + "','" + ProvinceCb.Text + "')";
                SqlConnection con = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand(qry, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("The information has been stored! Thank you for registering to get vacinated against Covid-19! <3 ");
                con.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }
    }
}
