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
    public partial class fisa_add : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        select_medic form_select_medic;
        int pacient_id = 0, medic_id = -1, c_int = 0, c_dec = 0;
        bool on_decimals = false;

        public fisa_add()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\e-Analize_data\Database.mdf;Integrated Security=True;User Instance=True");
            cmd = new SqlCommand("", con);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            form_select_medic = new select_medic();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nume, prenume;
            nume = textbox_nume.Text;
            prenume = textbox_prenume.Text;
            cmd.CommandText = "SELECT Id,Image,CONCAT(Nume,' ',Prenume) AS Nume,CNP FROM Pacienti Where Pacienti.Nume LIKE '%' + @nume + '%' AND Pacienti.Prenume LIKE '%' + @prenume + '%'";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@nume", SqlDbType.NVarChar);
            cmd.Parameters.Add("@prenume", SqlDbType.NVarChar);
            cmd.Parameters["@nume"].Value = nume;
            cmd.Parameters["@prenume"].Value = prenume;
            ds.Tables.Clear();
            da.Fill(ds);
            datagridview_pacienti.DataSource = ds.Tables[0];
            datagridview_pacienti.Columns[0].Visible = false;
            datagridview_pacienti.Columns[1].Visible = false;
        }

        private void datagridview_pacienti_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            if (e.Cell.Selected)
            {
                datagridview_pacienti.Rows[e.Cell.RowIndex].Selected = true;
            }
        }

        private void datagridview_pacienti_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            pacient_id = (int)datagridview_pacienti.Rows[e.RowIndex].Cells[0].Value;
            picturebox_poza.ImageLocation = "e-Analize_data/photo/pacienti/" + datagridview_pacienti.Rows[e.RowIndex].Cells[1].Value.ToString();
            textbox_nume2.Text = datagridview_pacienti.Rows[e.RowIndex].Cells[2].Value.ToString();
            textbox_analiza.Enabled = true;
            textbox_rezultat.Enabled = true;
            button_add.Enabled = true;
            button_save.Enabled = true;
            datagridview_rezultate.Columns.Clear();
            datagridview_rezultate.Columns.Add("Analiza", "Analiza");
            datagridview_rezultate.Columns.Add("Rezultat", "Rezultat");
        }

        private void textbox_medic_Click(object sender, EventArgs e)
        {
            form_select_medic.ShowDialog();
            if (form_select_medic.medic_id != -1)
            {
                medic_id = form_select_medic.medic_id;
                textbox_medic.Text = form_select_medic.medic_nume;
            }
        }

        private void textbox_rezultat_Enter(object sender, EventArgs e)
        {
            textbox_rezultat.Text = "";
            textbox_rezultat.MaxLength = 8;
        }

        private void textbox_rezultat_Leave(object sender, EventArgs e)
        {
            if (textbox_rezultat.Text == "") textbox_rezultat.Text = "0";
            textbox_rezultat.MaxLength = 9;
            textbox_rezultat.Text = (double.Parse(textbox_rezultat.Text) / 1000).ToString();
        }

        private void textbox_rezultat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (textbox_analiza.Text != "")
            {
                datagridview_rezultate.Rows.Add(1);
                datagridview_rezultate.Rows[datagridview_rezultate.Rows.Count - 1].Cells[0].Value = textbox_analiza.Text;
                datagridview_rezultate.Rows[datagridview_rezultate.Rows.Count - 1].Cells[1].Value = textbox_rezultat.Text;
            }
            else MessageBox.Show("Introdu analiza!");
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (datagridview_rezultate.Rows.Count > 0 && medic_id!=-1)
            {
                cmd.CommandText = "INSERT INTO Fise(Data,Medic,Pacient) Values(@Data,@Medic,@Pacient)";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@Data", SqlDbType.DateTime);
                cmd.Parameters.Add("@Medic", SqlDbType.Int);
                cmd.Parameters.Add("@Pacient", SqlDbType.Int);
                cmd.Parameters["@Data"].Value = datetimepicker_data.Value;
                cmd.Parameters["@Medic"].Value = medic_id;
                cmd.Parameters["@Pacient"].Value = pacient_id;
                con.Open();
                cmd.ExecuteNonQuery();

                cmd.CommandText = "SELECT Id FROM Fise ORDER BY Id DESC OFFSET 0 ROWS FETCH NEXT 1 ROWS ONLY";
                ds.Tables.Clear();
                da.Fill(ds);

                cmd.CommandText = "INSERT INTO Rezultate(Fisa,Analiza,Rezultat) Values(@Fisa,@Analiza,@Rezultat)";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@Fisa", SqlDbType.Int);
                cmd.Parameters.Add("@Analiza", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Rezultat", SqlDbType.Decimal);
                cmd.Parameters["@Fisa"].Value = int.Parse(ds.Tables[0].Rows[0].ItemArray[0].ToString());
                for (int i = 0; i < datagridview_rezultate.Rows.Count; i++)
                {
                    cmd.Parameters["@Analiza"].Value = datagridview_rezultate.Rows[i].Cells[0].Value.ToString();
                    cmd.Parameters["@Rezultat"].Value = decimal.Parse(datagridview_rezultate.Rows[i].Cells[1].Value.ToString());
                    cmd.ExecuteNonQuery();
                }
                con.Close();
                MessageBox.Show("Fisa a fost adaugata!");
            }
            if (datagridview_rezultate.Rows.Count == 0) MessageBox.Show("Adauga cel putin o analiza!");
            if (medic_id == -1) MessageBox.Show("Alege un medic!");
        }
    }
}
