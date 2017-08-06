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

namespace e_Analize
{
    public partial class db_tables : Form
    {
        string con_string = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\DATABASE.MDF;Integrated Security=True;User Instance=True";
        SqlConnection con;
        public db_tables()
        {
            InitializeComponent();
            con = new SqlConnection(con_string);
            con.Open();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cmd_text = "SELECT * FROM " + comboBox1.Text;
            SqlDataAdapter adpt = new SqlDataAdapter(cmd_text,con);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            adpt.Fill(ds);
            dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            con.Close();
        }
    }
}
