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
    public partial class grafic : Form
    {
        int pacient_id;
        string pacient_nume, analiza;
        public grafic(int pacient_id, string pacient_nume, string analiza)
        {
            InitializeComponent();
            this.pacient_id = pacient_id;
            this.pacient_nume = pacient_nume;
            this.analiza = analiza;
            this.Text = pacient_nume + " - " + analiza;
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\e-Analize_data\Database.mdf;Integrated Security=True;User Instance=True");
            SqlCommand cmd=new SqlCommand("SELECT Fise.Data,Rezultate.Rezultat FROM Fise JOIN Pacienti ON Fise.Pacient=Pacienti.Id JOIN Rezultate ON Fise.Id=Rezultate.Fisa WHERE Pacienti.Id=@pacient_id AND Rezultate.Analiza LIKE @Analiza ORDER BY Fise.Data", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.Add("@Analiza", SqlDbType.NVarChar);
            cmd.Parameters.Add("@pacient_id", SqlDbType.Int);
            cmd.Parameters["@Analiza"].Value = analiza;
            cmd.Parameters["@pacient_id"].Value = pacient_id;
            DataSet ds = new DataSet();
            da.Fill(ds);
            int i2 = ds.Tables[0].Rows.Count;
            for (int i = 0; i < i2; i++)
            {
                DateTime dt = (DateTime)ds.Tables[0].Rows[i].ItemArray[0];
                double d = double.Parse(ds.Tables[0].Rows[i].ItemArray[1].ToString());
                chart_valori.Series[0].Points.AddXY(dt, d);
                chart_valori.Series[0].Points[i].Color = Color.Red;
            }
        }
    }
}
