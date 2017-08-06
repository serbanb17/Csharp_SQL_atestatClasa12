namespace e_Analize
{
    partial class admin_analize
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.datagridview_pacienti = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textbox_prenume = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textbox_nume = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.datagridview_rezultate = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_print = new System.Windows.Forms.Button();
            this.textbox_numecentru = new System.Windows.Forms.TextBox();
            this.button_save = new System.Windows.Forms.Button();
            this.textbox_nume2 = new System.Windows.Forms.TextBox();
            this.picturebox_poza = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_pacienti)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_rezultate)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_poza)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1MinSize = 400;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel4);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(684, 462);
            this.splitContainer1.SplitterDistance = 400;
            this.splitContainer1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.datagridview_pacienti);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 429);
            this.panel3.TabIndex = 1;
            // 
            // datagridview_pacienti
            // 
            this.datagridview_pacienti.AllowUserToAddRows = false;
            this.datagridview_pacienti.AllowUserToDeleteRows = false;
            this.datagridview_pacienti.AllowUserToResizeColumns = false;
            this.datagridview_pacienti.AllowUserToResizeRows = false;
            this.datagridview_pacienti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.datagridview_pacienti.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.datagridview_pacienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview_pacienti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridview_pacienti.Location = new System.Drawing.Point(0, 0);
            this.datagridview_pacienti.MultiSelect = false;
            this.datagridview_pacienti.Name = "datagridview_pacienti";
            this.datagridview_pacienti.ReadOnly = true;
            this.datagridview_pacienti.RowHeadersVisible = false;
            this.datagridview_pacienti.Size = new System.Drawing.Size(400, 429);
            this.datagridview_pacienti.TabIndex = 1;
            this.datagridview_pacienti.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview_pacienti_CellDoubleClick);
            this.datagridview_pacienti.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.datagridview_pacienti_CellStateChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textbox_prenume);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textbox_nume);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 33);
            this.panel1.TabIndex = 0;
            // 
            // textbox_prenume
            // 
            this.textbox_prenume.Location = new System.Drawing.Point(220, 6);
            this.textbox_prenume.Name = "textbox_prenume";
            this.textbox_prenume.Size = new System.Drawing.Size(100, 20);
            this.textbox_prenume.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Prenume:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nume:";
            // 
            // textbox_nume
            // 
            this.textbox_nume.Location = new System.Drawing.Point(56, 6);
            this.textbox_nume.Name = "textbox_nume";
            this.textbox_nume.Size = new System.Drawing.Size(100, 20);
            this.textbox_nume.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(322, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cauta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.datagridview_rezultate);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 133);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(280, 329);
            this.panel4.TabIndex = 1;
            // 
            // datagridview_rezultate
            // 
            this.datagridview_rezultate.AllowUserToAddRows = false;
            this.datagridview_rezultate.AllowUserToDeleteRows = false;
            this.datagridview_rezultate.AllowUserToResizeColumns = false;
            this.datagridview_rezultate.AllowUserToResizeRows = false;
            this.datagridview_rezultate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.datagridview_rezultate.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.datagridview_rezultate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview_rezultate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridview_rezultate.Location = new System.Drawing.Point(0, 0);
            this.datagridview_rezultate.Name = "datagridview_rezultate";
            this.datagridview_rezultate.ReadOnly = true;
            this.datagridview_rezultate.RowHeadersVisible = false;
            this.datagridview_rezultate.Size = new System.Drawing.Size(280, 329);
            this.datagridview_rezultate.TabIndex = 2;
            this.datagridview_rezultate.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview_rezultate_CellDoubleClick);
            this.datagridview_rezultate.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.datagridview_rezultate_CellStateChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button_print);
            this.panel2.Controls.Add(this.textbox_numecentru);
            this.panel2.Controls.Add(this.button_save);
            this.panel2.Controls.Add(this.textbox_nume2);
            this.panel2.Controls.Add(this.picturebox_poza);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 133);
            this.panel2.TabIndex = 0;
            // 
            // button_print
            // 
            this.button_print.Enabled = false;
            this.button_print.Location = new System.Drawing.Point(180, 58);
            this.button_print.Name = "button_print";
            this.button_print.Size = new System.Drawing.Size(75, 23);
            this.button_print.TabIndex = 4;
            this.button_print.Text = "Printare...";
            this.button_print.UseVisualStyleBackColor = true;
            this.button_print.Click += new System.EventHandler(this.button_print_Click);
            // 
            // textbox_numecentru
            // 
            this.textbox_numecentru.Location = new System.Drawing.Point(99, 6);
            this.textbox_numecentru.MaxLength = 80;
            this.textbox_numecentru.Name = "textbox_numecentru";
            this.textbox_numecentru.Size = new System.Drawing.Size(169, 20);
            this.textbox_numecentru.TabIndex = 3;
            this.textbox_numecentru.Text = "Nume Centru de Analize";
            this.textbox_numecentru.TextChanged += new System.EventHandler(this.textbox_numecentru_TextChanged);
            // 
            // button_save
            // 
            this.button_save.Enabled = false;
            this.button_save.Location = new System.Drawing.Point(99, 58);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 2;
            this.button_save.Text = "Salvare...";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // textbox_nume2
            // 
            this.textbox_nume2.Location = new System.Drawing.Point(99, 32);
            this.textbox_nume2.Name = "textbox_nume2";
            this.textbox_nume2.ReadOnly = true;
            this.textbox_nume2.Size = new System.Drawing.Size(169, 20);
            this.textbox_nume2.TabIndex = 1;
            // 
            // picturebox_poza
            // 
            this.picturebox_poza.Location = new System.Drawing.Point(3, 6);
            this.picturebox_poza.Name = "picturebox_poza";
            this.picturebox_poza.Size = new System.Drawing.Size(90, 120);
            this.picturebox_poza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturebox_poza.TabIndex = 0;
            this.picturebox_poza.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dublu-Click pentru grafic";
            // 
            // admin_analize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.splitContainer1);
            this.Name = "admin_analize";
            this.Text = "Gestionare Analize";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_pacienti)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_rezultate)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_poza)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView datagridview_pacienti;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView datagridview_rezultate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textbox_prenume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textbox_nume;
        private System.Windows.Forms.TextBox textbox_nume2;
        private System.Windows.Forms.PictureBox picturebox_poza;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.TextBox textbox_numecentru;
        private System.Windows.Forms.Button button_print;
        private System.Windows.Forms.Label label3;

    }
}