using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Analize
{
    public partial class main : Form
    {
        bool form_admin_medici_opened = false, form_admin_pacienti_opened = false, form_admin_analize_opened = false, form_fisa_add_opened = false;

        public main()
        {
            InitializeComponent();
        }

        private void mediciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!form_admin_medici_opened)
            {
                admin_medici form_admin_medici = new admin_medici();
                form_admin_medici.MdiParent = this;
                form_admin_medici.FormClosed += form_admin_medici_FormClosed;
                form_admin_medici.Show();
                form_admin_medici_opened = true;
            }
        }

        void form_admin_medici_FormClosed(object sender, FormClosedEventArgs e)
        {
            form_admin_medici_opened = false;
        }

        private void pacientiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!form_admin_pacienti_opened)
            {
                admin_pacienti form_admin_pacienti = new admin_pacienti();
                form_admin_pacienti.MdiParent = this;
                form_admin_pacienti.FormClosed += form_admin_pacienti_FormClosed;
                form_admin_pacienti.Show();
                form_admin_pacienti_opened = true;
            }
        }

        void form_admin_pacienti_FormClosed(object sender, FormClosedEventArgs e)
        {
            form_admin_pacienti_opened = false;
        }

        private void fisaNouaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!form_fisa_add_opened)
            {
                fisa_add form_fisa_add = new fisa_add();
                form_fisa_add.MdiParent = this;
                form_fisa_add.FormClosed += form_fisa_add_FormClosed;
                form_fisa_add.Show();
                form_fisa_add_opened = true;
            }
        }

        void form_fisa_add_FormClosed(object sender, FormClosedEventArgs e)
        {
            form_fisa_add_opened = false;
        }

        private void vizualizareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!form_admin_analize_opened)
            {
                admin_analize form_admin_analize = new admin_analize(this);
                form_admin_analize.MdiParent = this;
                form_admin_analize.FormClosed += form_admin_analize_FormClosed;
                form_admin_analize.Show();
                form_admin_analize_opened = true;
            }
        }

        void form_admin_analize_FormClosed(object sender, FormClosedEventArgs e)
        {
            form_admin_analize_opened = false;
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void arrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
