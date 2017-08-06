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
    public partial class select_medic : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        public int medic_id = -1;
        public string medic_nume;

        public select_medic()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\e-Analize_data\Database.mdf;Integrated Security=True;User Instance=True");
            cmd = new SqlCommand("", con);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nume, prenume;
            nume = textbox_nume.Text;
            prenume = textbox_prenume.Text;
            cmd.CommandText = "SELECT Id,CONCAT(Nume,' ',Prenume) AS Nume FROM Medici Where Nume LIKE '%' + @nume + '%' AND Prenume LIKE '%' + @prenume + '%'";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@nume", SqlDbType.NVarChar);
            cmd.Parameters.Add("@prenume", SqlDbType.NVarChar);
            cmd.Parameters["@nume"].Value = nume;
            cmd.Parameters["@prenume"].Value = prenume;
            ds.Tables.Clear();
            da.Fill(ds);
            datagridview_medici.DataSource = ds.Tables[0];
            datagridview_medici.Columns[0].Visible = false;
        }

        private void datagridview_medici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            medic_id = int.Parse(datagridview_medici.Rows[e.RowIndex].Cells[0].Value.ToString());
            medic_nume = datagridview_medici.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.Close();
        }
    }
}
