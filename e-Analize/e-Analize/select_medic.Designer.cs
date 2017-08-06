namespace e_Analize
{
    partial class select_medic
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textbox_prenume = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textbox_nume = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.datagridview_medici = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_medici)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(254, 68);
            this.panel1.TabIndex = 1;
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
            // datagridview_medici
            // 
            this.datagridview_medici.AllowUserToAddRows = false;
            this.datagridview_medici.AllowUserToDeleteRows = false;
            this.datagridview_medici.AllowUserToResizeColumns = false;
            this.datagridview_medici.AllowUserToResizeRows = false;
            this.datagridview_medici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.datagridview_medici.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.datagridview_medici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview_medici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridview_medici.Location = new System.Drawing.Point(0, 68);
            this.datagridview_medici.MultiSelect = false;
            this.datagridview_medici.Name = "datagridview_medici";
            this.datagridview_medici.ReadOnly = true;
            this.datagridview_medici.RowHeadersVisible = false;
            this.datagridview_medici.Size = new System.Drawing.Size(254, 194);
            this.datagridview_medici.TabIndex = 2;
            this.datagridview_medici.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview_medici_CellContentClick);
            // 
            // select_medic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 262);
            this.ControlBox = false;
            this.Controls.Add(this.datagridview_medici);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(270, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(270, 300);
            this.Name = "select_medic";
            this.ShowIcon = false;
            this.Text = "Alege Medic";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_medici)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textbox_prenume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textbox_nume;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView datagridview_medici;
    }
}