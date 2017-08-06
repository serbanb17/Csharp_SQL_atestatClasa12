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
    public partial class db_setup : Form
    {
        string con_string = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\DATABASE.MDF;Integrated Security=True;User Instance=True";
        SqlConnection con;
        public db_setup()
        {
            InitializeComponent();
            con = new SqlConnection(con_string);
            con.Open();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            string cmd_text= "";
            cmd_text = "DELETE FROM Rezultate";
            cmd = new SqlCommand(cmd_text, con);
            cmd.ExecuteNonQuery();
            cmd_text = "DBCC CHECKIDENT('Rezultate', RESEED, -1);";
            cmd = new SqlCommand(cmd_text, con);
            cmd.ExecuteNonQuery();

            Console_TextBox.Text += "Data Cleared\r\n";
            Console_TextBox.SelectionStart = Console_TextBox.Text.Length;
            Console_TextBox.ScrollToCaret();
        }

        void fill_rezultate()
        {
            SqlCommand cmd;
            string cmd_text;
            Random rand = new Random();
            string[] analize = new string[22];
            analize[0] = "colesterol";
            analize[1] = "ficat";
            analize[2] = "pancreas";
            analize[3] = "tensiune";
            analize[4] = "leucocite";
            analize[5] = "hematite ";
            analize[6] = "hemoglobina  ";
            analize[7] = "hematocrite  ";
            analize[8] = "Viteza de sedimentare (VS) ";
            analize[9] = "glicemia ";
            analize[10] = "Trigliceride ";
            analize[11] = "TSH ";
            analize[12] = "lalacocite ";
            analize[13] = "andrenalina";
            analize[14] = "apa";
            analize[15] = "sare";
            analize[16] = "carbon";
            analize[17] = "calciu";
            analize[18] = "fier ";
            analize[19] = "globule rosii";
            analize[20] = "globule albe";
            for (int i = 0; i < 600; i++)
            {
                for (int j = 0; j < 21; j++)
                {
                    cmd_text = "INSERT INTO dbo.Rezultate(Fisa,Analiza,Rezultat) Values(@Fisa,@Analiza,@Rezultat)";
                    cmd = new SqlCommand(cmd_text, con);

                    cmd.Parameters.Add("@Fisa", SqlDbType.Int);
                    cmd.Parameters.Add("@Analiza", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@Rezultat", SqlDbType.Decimal);

                    cmd.Parameters["@Fisa"].Value = i;
                    cmd.Parameters["@Analiza"].Value = analize[j];
                    cmd.Parameters["@Rezultat"].Value = rand.Next(10, 99999999) / 1000;

                    cmd.ExecuteNonQuery();
                }
            }


        }

        void fill_analize()
        {
            SqlCommand cmd;
            string cmd_text;
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                cmd_text = "INSERT INTO dbo.Analize(Analiza) Values(@Analiza)";
                cmd = new SqlCommand(cmd_text, con);
                
                cmd.Parameters.Add("@Analiza", SqlDbType.NVarChar);

                cmd.Parameters["@Analiza"].Value = "Organ"+i;

                cmd.ExecuteNonQuery();
            }

        }

        void fill_fise()
        {
            SqlCommand cmd;
            string cmd_text;
            Random rand = new Random();
            for (int i = 0; i < 600; i++)
            {
                cmd_text = "INSERT INTO dbo.Fise(Data,Medic,Pacient) Values(@Data,@Medic,@Pacient)";
                cmd = new SqlCommand(cmd_text, con);
                DateTime data = new DateTime(rand.Next(2005, 2014), rand.Next(1, 12), rand.Next(1, 28), 0, 0, 0);
                
                cmd.Parameters.Add("@Data", SqlDbType.DateTime);
                cmd.Parameters.Add("@Medic", SqlDbType.Int);
                cmd.Parameters.Add("@Pacient", SqlDbType.Int);

                cmd.Parameters["@Data"].Value = data;
                cmd.Parameters["@Medic"].Value = rand.Next(0,5);
                cmd.Parameters["@Pacient"].Value = rand.Next(0,13);

                cmd.ExecuteNonQuery();
            }

        }

        void fill_medici()
        {
            SqlCommand cmd;
            string cmd_text;
            string[] nume = new string[5], prenume = new string[5];
            Random rand = new Random();
            bool b;
            prenume[0] = "George";
            nume[0] = "Popescu";
            prenume[1] = "Grigore";
            nume[1] = "Varga";
            prenume[2] = "Violeta";
            nume[2] = "Rosu";
            prenume[3] = "Mihaela";
            nume[3] = "Croatu";
            prenume[4] = "Ionela";
            nume[4] = "Soare";
            for (int i = 0; i < 5; i++)
            {
                b = rand.Next(2) == 1;
                cmd_text = "INSERT INTO dbo.Medici(Nume,Prenume,CNP,Data_Nasterii,Data_Angajarii" + (b ? ",Data_Plecarii" : "") + ",Sex,Telefon,Email,Adresa,Image) Values(@Nume,@Prenume,@CNP,@Data_Nasterii,@Data_Angajarii" + (b ? ",@Data_Plecarii" : "") + ",@Sex,@Telefon,@Email,@Adresa,@Image)";
                cmd = new SqlCommand(cmd_text, con);
                DateTime dn = new DateTime(rand.Next(1960, 1980), rand.Next(1, 12), rand.Next(1, 28), 0, 0, 0);
                DateTime da = new DateTime(rand.Next(1990, 2005), rand.Next(1, 12), rand.Next(1, 28), 0, 0, 0);
                DateTime dp = new DateTime();
                if (b) dp = new DateTime(rand.Next(2005, 2014), rand.Next(1, 12), rand.Next(1, 28), 0, 0, 0);

                cmd.Parameters.Add("@Nume", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Prenume", SqlDbType.NVarChar);
                cmd.Parameters.Add("@CNP", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Data_Nasterii", SqlDbType.DateTime);
                cmd.Parameters.Add("@Data_Angajarii", SqlDbType.DateTime);
                if (b) cmd.Parameters.Add("@Data_Plecarii", SqlDbType.DateTime);
                cmd.Parameters.Add("@Sex", SqlDbType.Bit);
                cmd.Parameters.Add("@Telefon", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Adresa", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Image", SqlDbType.NVarChar);

                cmd.Parameters["@Nume"].Value = nume[i];
                cmd.Parameters["@Prenume"].Value = prenume[i];
                cmd.Parameters["@CNP"].Value = "xxxxxxxxxxxxx";
                cmd.Parameters["@Data_Nasterii"].Value = dn;
                cmd.Parameters["@Data_Angajarii"].Value = da;
                if (b) cmd.Parameters["@Data_Plecarii"].Value = dp;
                cmd.Parameters["@Sex"].Value = i < 3 ? true : false;
                cmd.Parameters["@Telefon"].Value = "0759654251";
                cmd.Parameters["@Email"].Value = nume[i] + prenume[i] + "@e-Analize.ro"; ;
                cmd.Parameters["@Adresa"].Value = "Str Stefen cel Mare nr 102 Sector 5 Bucuresti";
                cmd.Parameters["@Image"].Value = i.ToString() + ".jpg";

                cmd.ExecuteNonQuery();
            }

        }

        void fill_pacienti()
        {
            SqlCommand cmd;
            string cmd_text;
            string[] nume = new string[13], prenume = new string[13];
            Random rand = new Random();
            prenume[0] = "Georgel";
            nume[0] = "Popescul";
            prenume[1] = "Grigorel";
            nume[1] = "Vargal";
            prenume[2] = "Violetal";
            nume[2] = "Rosul";
            prenume[3] = "Mihaelal";
            nume[3] = "Croatul";
            prenume[4] = "Ionelal";
            nume[4] = "Soarel";
            prenume[5] = "Georgem";
            nume[5] = "Popescum";
            prenume[6] = "Grigorem";
            nume[6] = "Vargam";
            prenume[7] = "Violetam";
            nume[7] = "Rosum";
            prenume[8] = "Mihaelam";
            nume[8] = "Croatum";
            prenume[9] = "Ionelam";
            nume[9] = "Soarem"; 
            prenume[10] = "Georget";
            nume[10] = "Popescut";
            prenume[11] = "Grigoret";
            nume[11] = "Vargat";
            prenume[12] = "Violetat";
            nume[12] = "Rosut";
            for (int i = 0; i < 13; i++)
            {
                cmd_text = "INSERT INTO dbo.Pacienti(Nume,Prenume,CNP,Data_Nasterii,Sex,Telefon,Email,Adresa,Image) Values(@Nume,@Prenume,@CNP,@Data_Nasterii,@Sex,@Telefon,@Email,@Adresa,@Image)";
                cmd = new SqlCommand(cmd_text, con);
                DateTime dn = new DateTime(rand.Next(1960, 1980), rand.Next(1, 12), rand.Next(1, 28), 0, 0, 0);
                
                cmd.Parameters.Add("@Nume", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Prenume", SqlDbType.NVarChar);
                cmd.Parameters.Add("@CNP", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Data_Nasterii", SqlDbType.DateTime);
                cmd.Parameters.Add("@Sex", SqlDbType.Bit);
                cmd.Parameters.Add("@Telefon", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Adresa", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Image", SqlDbType.NVarChar);

                cmd.Parameters["@Nume"].Value = nume[i];
                cmd.Parameters["@Prenume"].Value = prenume[i];
                cmd.Parameters["@CNP"].Value = "xxxxxxxxxxxxx";
                cmd.Parameters["@Data_Nasterii"].Value = dn;
                cmd.Parameters["@Sex"].Value = i < 7 ? true : false;
                cmd.Parameters["@Telefon"].Value = "0759654251";
                cmd.Parameters["@Email"].Value = nume[i] + prenume[i] + "@e-Analize.ro"; ;
                cmd.Parameters["@Adresa"].Value = "Str Stefen cel Mare nr 102 Sector 5 Bucuresti";
                cmd.Parameters["@Image"].Value = i.ToString() + ".jpg";

                cmd.ExecuteNonQuery();
            }

        }


        private void button2_Click(object sender, EventArgs e)
        {
            //fill_analize();
            fill_rezultate();
            //fill_fise();
            //fill_medici();
            //fill_pacienti();
            Console_TextBox.Text += "Success\r\n";
            Console_TextBox.SelectionStart = Console_TextBox.Text.Length;
            Console_TextBox.ScrollToCaret();
        }

        private void db_setup_FormClosed(object sender, FormClosedEventArgs e)
        {
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            db_tables viewtable = new db_tables();
            viewtable.Show();
        }
    }
}
