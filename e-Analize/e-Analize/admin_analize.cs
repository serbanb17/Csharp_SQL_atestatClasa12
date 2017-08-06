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
using System.IO;
using System.Diagnostics;

namespace e_Analize
{
    public partial class admin_analize : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        string nume2write = null, prenume2write = null, cnp2write = null, date2wrie = null, numecentru = "Nume Centru de Analize";
        int pacient_id;
        Form mdi_main;

        void write_file(string filename)
        {
            StreamWriter sw = new StreamWriter(filename);
            int page_width, max_analiza = 7, max_cifra = 8, i2, i3;
            for (int i = 0; i < datagridview_rezultate.Rows.Count; i++)
            {
                if (max_analiza < datagridview_rezultate.Rows[i].Cells[0].Value.ToString().Length) max_analiza = datagridview_rezultate.Rows[i].Cells[0].Value.ToString().Length;
                if (max_cifra < datagridview_rezultate.Rows[i].Cells[1].Value.ToString().Length) max_cifra = datagridview_rezultate.Rows[i].Cells[1].Value.ToString().Length;
            }
            page_width = Math.Max(date2wrie.Length + numecentru.Length + 1, Math.Max(nume2write.Length + 9, Math.Max(prenume2write.Length + 9, Math.Max(22, max_analiza + max_cifra + 3))));

            i2 = page_width - date2wrie.Length - numecentru.Length;
            sw.Write(date2wrie);
            for (int i = 0; i < i2; i++) sw.Write(" ");
            sw.WriteLine(numecentru);
            sw.WriteLine(string.Empty);

            sw.WriteLine("Nume:    " + nume2write);
            sw.WriteLine("Prenume: " + prenume2write);
            sw.WriteLine("CNP:     " + cnp2write);
            sw.WriteLine(string.Empty);

            i2 = page_width - (3 + max_cifra + 7); sw.Write("|Analiza"); for (int i = 0; i < i2; i++) sw.Write(" ");
            i2 = max_cifra - 8; sw.Write("|Rezultat"); for (int i = 0; i < i2; i++) sw.Write(" "); sw.WriteLine("|");

            i2 = page_width - 2;
            sw.Write("+"); for (int i = 0; i < i2; i++) sw.Write("-"); sw.Write("+"); sw.WriteLine(string.Empty);

            for (int r = 0; r < datagridview_rezultate.Rows.Count; r++)
            {
                string current_analize = datagridview_rezultate.Rows[r].Cells[0].Value.ToString();
                string current_rezultat = datagridview_rezultate.Rows[r].Cells[1].Value.ToString();
                sw.Write("|");
                sw.Write(current_analize);
                i3 = page_width - (3 + max_cifra + current_analize.Length);
                for (int i = 0; i <i3; i++) sw.Write(" ");
                sw.Write("|");
                for (int i = current_rezultat.Length; i < max_cifra; i++) sw.Write(" ");
                sw.Write(current_rezultat);
                sw.WriteLine("|");
                sw.Write("+"); for (int i = 0; i < i2; i++) sw.Write("-"); sw.Write("+"); sw.WriteLine(string.Empty);
            }

            sw.Close();
        }

        public admin_analize(Form mdi_main)
        {
            InitializeComponent();
            this.mdi_main = mdi_main;
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
            cmd.CommandText = "SELECT Fise.Id,Pacienti.Image,Fise.Data,CONCAT(Medici.Nume,' ',Medici.Prenume) AS Medic,CONCAT(Pacienti.Nume,' ',Pacienti.Prenume) AS Pacient,Pacienti.CNP,Pacienti.Nume,Pacienti.Prenume,Pacienti.Id FROM (Pacienti JOIN Fise ON Pacienti.Id=Fise.Pacient) JOIN Medici ON Fise.Medic=Medici.Id Where Pacienti.Nume LIKE '%' + @nume + '%' AND Pacienti.Prenume LIKE '%' + @prenume + '%'";
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
            datagridview_pacienti.Columns[6].Visible = false;
            datagridview_pacienti.Columns[7].Visible = false;
            datagridview_pacienti.Columns[8].Visible = false;
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
            int id = (int)datagridview_pacienti.Rows[e.RowIndex].Cells[0].Value;
            pacient_id = (int)datagridview_pacienti.Rows[e.RowIndex].Cells[8].Value;
            cmd.CommandText = "SELECT Analiza,Rezultat FROM Rezultate WHERE Fisa=@id";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@id", SqlDbType.Int);
            cmd.Parameters["@id"].Value = id;
            ds.Tables.Clear();
            da.Fill(ds);
            datagridview_rezultate.DataSource = ds.Tables[0];
            picturebox_poza.ImageLocation = "e-Analize_data/photo/pacienti/" + datagridview_pacienti.Rows[e.RowIndex].Cells[1].Value.ToString();
            textbox_nume2.Text = datagridview_pacienti.Rows[e.RowIndex].Cells[4].Value.ToString();
            datagridview_pacienti.Rows[e.RowIndex].Selected = true;
            nume2write = datagridview_pacienti.Rows[e.RowIndex].Cells[6].Value.ToString();
            prenume2write = datagridview_pacienti.Rows[e.RowIndex].Cells[7].Value.ToString();
            cnp2write = datagridview_pacienti.Rows[e.RowIndex].Cells[5].Value.ToString();
            date2wrie = ((DateTime)(datagridview_pacienti.Rows[e.RowIndex].Cells[2].Value)).ToShortDateString();
            button_save.Enabled = true;
            button_print.Enabled = true;
        }

        private void datagridview_rezultate_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            if (e.Cell.Selected)
            {
                datagridview_rezultate.Rows[e.Cell.RowIndex].Selected = true;
            }
        }

        private void textbox_numecentru_TextChanged(object sender, EventArgs e)
        {
            numecentru = textbox_numecentru.Text;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "All Files (*.*)|*.*|Text File (*.txt)|*.txt";
            sfd.FilterIndex = 2;
            sfd.CheckFileExists = false;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string filename = sfd.FileName;
                write_file(filename);
                Process.Start(filename);
            }

        }

        private void button_print_Click(object sender, EventArgs e)
        {
            string temp_path = System.IO.Path.GetTempPath() + textbox_nume2.Text + "_rezultate_analize.txt";
            write_file(temp_path);
            PrintDialog pd = new PrintDialog();
            if (pd.ShowDialog() == DialogResult.OK)
            {
                ProcessStartInfo info = new ProcessStartInfo(temp_path);
                info.Verb = "PrintTo";
                info.Arguments = "\"" + pd.PrinterSettings.PrinterName + "\"";
                info.CreateNoWindow = true;
                info.WindowStyle = ProcessWindowStyle.Hidden;
                Process.Start(info);
            }
        }

        private void datagridview_rezultate_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            grafic form_grafic = new grafic(pacient_id, textbox_nume2.Text, datagridview_rezultate.Rows[e.RowIndex].Cells[0].Value.ToString());
            form_grafic.MdiParent = mdi_main;
            form_grafic.Show();
        }

    }
}
