using System;
using System.IO;
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
    public partial class admin_pacienti : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        int position=0;
        int total;
        string state = "view", imagepath, search_text = "";

        public admin_pacienti()
        {
            InitializeComponent();
        }

        private void admin_medici_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\e-Analize_data\DATABASE.MDF;Integrated Security=True;User Instance=True");
            cmd = new SqlCommand("", con);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            get_total();
            go_to_position();
        }

        void get_total()
        {
            cmd.CommandText = "SELECT COUNT(Id) FROM Pacienti WHERE Nume LIKE '%'+@Nume+'%' OR Prenume LIKE '%'+@Prenume+'%'";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@Nume", SqlDbType.NVarChar);
            cmd.Parameters.Add("@Prenume", SqlDbType.NVarChar);
            cmd.Parameters["@Nume"].Value = search_text;
            cmd.Parameters["@Prenume"].Value = search_text;
            ds.Tables.Clear();
            da.Fill(ds);
            total = (int)ds.Tables[0].Rows[0].ItemArray[0];
        }

        void go_to_position()
        {
            cmd.CommandText = "SELECT  * FROM Pacienti WHERE Nume LIKE '%'+@Nume+'%' OR Prenume LIKE '%'+@Prenume+'%' ORDER BY Id ASC OFFSET " + position + " ROWS FETCH NEXT 1 ROWS ONLY";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@Nume", SqlDbType.NVarChar);
            cmd.Parameters.Add("@Prenume", SqlDbType.NVarChar);
            cmd.Parameters["@Nume"].Value = search_text;
            cmd.Parameters["@Prenume"].Value = search_text;
            ds.Tables.Clear();
            da.Fill(ds);

            visual_textbox_nume.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            visual_textbox_prenume.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            visual_textbox_cnp.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
            visual_datetimepicker_datanasterii.Value = (DateTime)(ds.Tables[0].Rows[0].ItemArray[4]);
            if ((bool)(ds.Tables[0].Rows[0].ItemArray[5])) { visual_radiobutton_masculin.Select(); } else { visual_radiobutton_feminin.Select(); }
            visual_textbox_telefon.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
            visual_textbox_email.Text = ds.Tables[0].Rows[0].ItemArray[7].ToString();
            visual_textbox_adresa.Text = ds.Tables[0].Rows[0].ItemArray[8].ToString();
            visual_picturebox.ImageLocation = Application.StartupPath + "/e-Analize_data/Photo/Pacienti/" + ds.Tables[0].Rows[0].ItemArray[9].ToString();

            visual_label_position.Text = (position + 1).ToString() + "/" + total.ToString();
            DateTime today = DateTime.Today;
            DateTime bday = (DateTime)(ds.Tables[0].Rows[0].ItemArray[4]);
            int age = today.Year - bday.Year;
            if (today.Day < bday.Day) age--;
            visual_label_varsta.Text = age.ToString() + " ani";

            if (position == 0) visual_button_prev.Enabled = false;
            if (position == total - 1) visual_button_next.Enabled = false;
        }

        void change_state(string s)
        {
            if (s == "view")
            {
                visual_button_prev.Enabled = (position != 0) ? true : false;
                visual_button_next.Enabled = (position != total - 1) ? true : false;
                visual_button_add.Enabled = true;
                visual_button_cancel.Visible = false;
                textbox_search.Enabled = true;
                button_search.Enabled = true;

                visual_textbox_nume.ReadOnly = true;
                visual_textbox_prenume.ReadOnly = true;
                visual_textbox_cnp.ReadOnly = true;
                visual_textbox_telefon.ReadOnly = true;
                visual_textbox_email.ReadOnly = true;
                visual_textbox_adresa.ReadOnly = true;

            }
            if (s == "add")
            {
                visual_button_prev.Enabled = false;
                visual_button_next.Enabled = false;
                visual_button_add.Enabled = true;
                visual_button_cancel.Visible = true;
                visual_label_varsta.Text = "";
                visual_picturebox.Image = e_Analize.Properties.Resources.no_image;
                visual_label_position.Text = "";
                textbox_search.Enabled = false;
                button_search.Enabled = false;

                visual_textbox_nume.ReadOnly = false;
                visual_textbox_prenume.ReadOnly = false;
                visual_textbox_cnp.ReadOnly = false;
                visual_textbox_telefon.ReadOnly = false;
                visual_textbox_email.ReadOnly = false;
                visual_textbox_adresa.ReadOnly = false;

                visual_textbox_nume.Text = "";
                visual_textbox_prenume.Text = "";
                visual_textbox_cnp.Text = "";
                visual_datetimepicker_datanasterii.Value = DateTime.Parse("1940/12/31 00:00:00");
                visual_radiobutton_masculin.Select();
                visual_textbox_telefon.Text = "";
                visual_textbox_email.Text = "";
                visual_textbox_adresa.Text = "";

                imagepath = "";
            }
            state = s;
        }

        private void visual_button_next_Click(object sender, EventArgs e)
        {
            position++;
            go_to_position();
            visual_button_prev.Enabled = true;
            if (position == total - 1) visual_button_next.Enabled = false;
        }

        private void visual_button_prev_Click(object sender, EventArgs e)
        {
            position--;
            go_to_position();
            visual_button_next.Enabled = true;
            if (position == 0) visual_button_prev.Enabled = false;
        }

        private void visual_button_add_Click(object sender, EventArgs e)
        {
            if (state == "view") {
                change_state("add");
            } 
            else
            {
                con.Open();
                int id = int.Parse(ds.Tables[0].Rows[0].ItemArray[0].ToString());
                cmd.CommandText = "INSERT INTO dbo.Pacienti(Nume,Prenume,CNP,Data_Nasterii,Sex,Telefon,Email,Adresa,Image) Values(@Nume,@Prenume,@CNP,@Data_Nasterii,@Sex,@Telefon,@Email,@Adresa,@Image)";

                cmd.Parameters.Clear();
                cmd.Parameters.Add("@Nume", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Prenume", SqlDbType.NVarChar);
                cmd.Parameters.Add("@CNP", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Data_Nasterii", SqlDbType.DateTime);
                cmd.Parameters.Add("@Sex", SqlDbType.Bit);
                cmd.Parameters.Add("@Telefon", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Adresa", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Image", SqlDbType.NVarChar);

                cmd.Parameters["@Nume"].Value = visual_textbox_nume.Text;
                cmd.Parameters["@Prenume"].Value = visual_textbox_prenume.Text;
                cmd.Parameters["@CNP"].Value = visual_textbox_cnp.Text;
                cmd.Parameters["@Data_Nasterii"].Value = visual_datetimepicker_datanasterii.Value;
                cmd.Parameters["@Sex"].Value = visual_radiobutton_masculin.Focused;
                cmd.Parameters["@Telefon"].Value = visual_textbox_telefon.Text;
                cmd.Parameters["@Email"].Value = visual_textbox_email.Text;
                cmd.Parameters["@Adresa"].Value = visual_textbox_adresa.Text;
                TimeSpan t = (DateTime.UtcNow - new DateTime(1970, 1, 1));
                int timestamp = (int)t.TotalSeconds;
                if (imagepath != "") File.Copy(imagepath, Application.StartupPath + "/e-Analize_data/Photo/Pacienti/" + timestamp.ToString()+".jpg");
                cmd.Parameters["@Image"].Value = timestamp.ToString() + ".jpg";

                cmd.ExecuteNonQuery();
                con.Close();

                search_text = textbox_search.Text = "";
                get_total();
                position = total - 1;
                change_state("view");
                go_to_position();
            }
        }

        private void visual_button_cancel_Click(object sender, EventArgs e)
        {
            if (state == "add")
            {
                change_state("view");
                go_to_position();
            }
        }

        private void visual_picturebox_Click(object sender, EventArgs e)
        {
            if (state == "add")
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Imagini (*.jpg,*.jpeg,*.png,*.gif,*.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                ofd.Multiselect = false;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imagepath = ofd.FileName;
                    visual_picturebox.ImageLocation = ofd.FileName;
                }
            }
        }

        private void visual_picturebox_MouseEnter(object sender, EventArgs e)
        {
            if (state == "add") visual_picturebox.Cursor = Cursors.Hand;
            else visual_picturebox.Cursor = Cursors.Default;
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            search_text = textbox_search.Text;
            get_total();
            if (total != 0)
            {
                position = 0;
                visual_button_prev.Enabled = false;
                visual_button_next.Enabled = total > 1 ? true : false;
                go_to_position();
            }
            else {
                MessageBox.Show("Cautarea nu a returnat nici un rezultat!");
                search_text = "";
                get_total();
            }
        }

    }
}
