namespace e_Analize
{
    partial class fisa_add
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
            this.button_save = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.textbox_rezultat = new System.Windows.Forms.TextBox();
            this.textbox_analiza = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textbox_nume2 = new System.Windows.Forms.TextBox();
            this.datetimepicker_data = new System.Windows.Forms.DateTimePicker();
            this.picturebox_poza = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textbox_medic = new System.Windows.Forms.TextBox();
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
            this.splitContainer1.Panel1MinSize = 250;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel4);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(584, 362);
            this.splitContainer1.SplitterDistance = 250;
            this.splitContainer1.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.datagridview_pacienti);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 294);
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
            this.datagridview_pacienti.Size = new System.Drawing.Size(250, 294);
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
            this.panel1.Size = new System.Drawing.Size(250, 68);
            this.panel1.TabIndex = 0;
            // 
            // textbox_prenume
            // 
            this.textbox_prenume.Location = new System.Drawing.Point(66, 38);
            this.textbox_prenume.Name = "textbox_prenume";
            this.textbox_prenume.Size = new System.Drawing.Size(100, 20);
            this.textbox_prenume.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Prenume:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nume:";
            // 
            // textbox_nume
            // 
            this.textbox_nume.Location = new System.Drawing.Point(66, 12);
            this.textbox_nume.Name = "textbox_nume";
            this.textbox_nume.Size = new System.Drawing.Size(100, 20);
            this.textbox_nume.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 25);
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
            this.panel4.Location = new System.Drawing.Point(0, 164);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(330, 198);
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
            this.datagridview_rezultate.Size = new System.Drawing.Size(330, 198);
            this.datagridview_rezultate.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textbox_medic);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.button_save);
            this.panel2.Controls.Add(this.button_add);
            this.panel2.Controls.Add(this.textbox_rezultat);
            this.panel2.Controls.Add(this.textbox_analiza);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textbox_nume2);
            this.panel2.Controls.Add(this.datetimepicker_data);
            this.panel2.Controls.Add(this.picturebox_poza);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 164);
            this.panel2.TabIndex = 0;
            // 
            // button_save
            // 
            this.button_save.Enabled = false;
            this.button_save.Location = new System.Drawing.Point(246, 133);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 8;
            this.button_save.Text = "Salveaza";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_add
            // 
            this.button_add.Enabled = false;
            this.button_add.Location = new System.Drawing.Point(157, 133);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 7;
            this.button_add.Text = "Adauga";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // textbox_rezultat
            // 
            this.textbox_rezultat.Enabled = false;
            this.textbox_rezultat.Location = new System.Drawing.Point(157, 107);
            this.textbox_rezultat.MaxLength = 9;
            this.textbox_rezultat.Name = "textbox_rezultat";
            this.textbox_rezultat.ShortcutsEnabled = false;
            this.textbox_rezultat.Size = new System.Drawing.Size(164, 20);
            this.textbox_rezultat.TabIndex = 6;
            this.textbox_rezultat.Text = "0";
            this.textbox_rezultat.Enter += new System.EventHandler(this.textbox_rezultat_Enter);
            this.textbox_rezultat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_rezultat_KeyPress);
            this.textbox_rezultat.Leave += new System.EventHandler(this.textbox_rezultat_Leave);
            // 
            // textbox_analiza
            // 
            this.textbox_analiza.Enabled = false;
            this.textbox_analiza.Location = new System.Drawing.Point(157, 81);
            this.textbox_analiza.MaxLength = 80;
            this.textbox_analiza.Name = "textbox_analiza";
            this.textbox_analiza.Size = new System.Drawing.Size(164, 20);
            this.textbox_analiza.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Rezultat: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Analiza: ";
            // 
            // textbox_nume2
            // 
            this.textbox_nume2.Location = new System.Drawing.Point(102, 55);
            this.textbox_nume2.Name = "textbox_nume2";
            this.textbox_nume2.ReadOnly = true;
            this.textbox_nume2.Size = new System.Drawing.Size(219, 20);
            this.textbox_nume2.TabIndex = 2;
            // 
            // datetimepicker_data
            // 
            this.datetimepicker_data.Location = new System.Drawing.Point(99, 3);
            this.datetimepicker_data.Name = "datetimepicker_data";
            this.datetimepicker_data.Size = new System.Drawing.Size(219, 20);
            this.datetimepicker_data.TabIndex = 1;
            // 
            // picturebox_poza
            // 
            this.picturebox_poza.Location = new System.Drawing.Point(3, 3);
            this.picturebox_poza.Name = "picturebox_poza";
            this.picturebox_poza.Size = new System.Drawing.Size(90, 120);
            this.picturebox_poza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturebox_poza.TabIndex = 0;
            this.picturebox_poza.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Alege Medic:";
            // 
            // textbox_medic
            // 
            this.textbox_medic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textbox_medic.Location = new System.Drawing.Point(174, 29);
            this.textbox_medic.Name = "textbox_medic";
            this.textbox_medic.ReadOnly = true;
            this.textbox_medic.Size = new System.Drawing.Size(144, 20);
            this.textbox_medic.TabIndex = 10;
            this.textbox_medic.Click += new System.EventHandler(this.textbox_medic_Click);
            // 
            // fisa_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "fisa_add";
            this.Text = "Fisa Noua";
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
        private System.Windows.Forms.TextBox textbox_prenume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textbox_nume;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView datagridview_rezultate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picturebox_poza;
        private System.Windows.Forms.DateTimePicker datetimepicker_data;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TextBox textbox_rezultat;
        private System.Windows.Forms.TextBox textbox_analiza;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textbox_nume2;
        private System.Windows.Forms.TextBox textbox_medic;
        private System.Windows.Forms.Label label5;

    }
}