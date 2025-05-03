namespace eindwerk_Luka_Balcaen
{
    partial class InfoVenster
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
            this.components = new System.ComponentModel.Container();
            this.InfoTabel = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.EigenaarBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Toevoegen = new System.Windows.Forms.Label();
            this.VerwijderKnop = new System.Windows.Forms.Label();
            this.Clearknop = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.COMLijst = new System.Windows.Forms.ComboBox();
            this.Poort = new System.IO.Ports.SerialPort(this.components);
            this.BevistigKNop = new System.Windows.Forms.Label();
            this.OpenKnop = new System.Windows.Forms.Label();
            this.SluitKnop = new System.Windows.Forms.Label();
            this.KaartID = new System.Windows.Forms.Label();
            this.IDBOX = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.InfoTabel)).BeginInit();
            this.SuspendLayout();
            // 
            // InfoTabel
            // 
            this.InfoTabel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InfoTabel.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.InfoTabel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InfoTabel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.InfoTabel.EnableHeadersVisualStyles = false;
            this.InfoTabel.Location = new System.Drawing.Point(277, 12);
            this.InfoTabel.Name = "InfoTabel";
            this.InfoTabel.RowHeadersVisible = false;
            this.InfoTabel.RowHeadersWidth = 51;
            this.InfoTabel.RowTemplate.Height = 24;
            this.InfoTabel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InfoTabel.Size = new System.Drawing.Size(369, 385);
            this.InfoTabel.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Badge";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Eigenaar ";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Badge ";
            // 
            // EigenaarBox
            // 
            this.EigenaarBox.Location = new System.Drawing.Point(86, 54);
            this.EigenaarBox.Name = "EigenaarBox";
            this.EigenaarBox.Size = new System.Drawing.Size(169, 22);
            this.EigenaarBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Eigenaar:";
            // 
            // Toevoegen
            // 
            this.Toevoegen.AutoSize = true;
            this.Toevoegen.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Toevoegen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Toevoegen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Toevoegen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Toevoegen.Location = new System.Drawing.Point(91, 131);
            this.Toevoegen.Name = "Toevoegen";
            this.Toevoegen.Size = new System.Drawing.Size(123, 27);
            this.Toevoegen.TabIndex = 7;
            this.Toevoegen.Text = "Toevoegen";
            this.Toevoegen.Click += new System.EventHandler(this.Toevoegen_Click);
            // 
            // VerwijderKnop
            // 
            this.VerwijderKnop.AutoSize = true;
            this.VerwijderKnop.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.VerwijderKnop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.VerwijderKnop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VerwijderKnop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerwijderKnop.Location = new System.Drawing.Point(91, 175);
            this.VerwijderKnop.Name = "VerwijderKnop";
            this.VerwijderKnop.Size = new System.Drawing.Size(128, 27);
            this.VerwijderKnop.TabIndex = 8;
            this.VerwijderKnop.Text = "Verwijderen";
            this.VerwijderKnop.Click += new System.EventHandler(this.VerwijderKnop_Click);
            // 
            // Clearknop
            // 
            this.Clearknop.AutoSize = true;
            this.Clearknop.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Clearknop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Clearknop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clearknop.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clearknop.Location = new System.Drawing.Point(225, 379);
            this.Clearknop.Name = "Clearknop";
            this.Clearknop.Size = new System.Drawing.Size(46, 18);
            this.Clearknop.TabIndex = 9;
            this.Clearknop.Text = "Clear";
            this.Clearknop.Click += new System.EventHandler(this.Clearknop_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "COM Selecteren";
            // 
            // COMLijst
            // 
            this.COMLijst.FormattingEnabled = true;
            this.COMLijst.Location = new System.Drawing.Point(98, 258);
            this.COMLijst.Name = "COMLijst";
            this.COMLijst.Size = new System.Drawing.Size(121, 24);
            this.COMLijst.TabIndex = 11;
            // 
            // Poort
            // 
            this.Poort.PortName = " ";
            this.Poort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.OntvangData);
            // 
            // BevistigKNop
            // 
            this.BevistigKNop.AutoSize = true;
            this.BevistigKNop.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BevistigKNop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BevistigKNop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BevistigKNop.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BevistigKNop.Location = new System.Drawing.Point(-2, 261);
            this.BevistigKNop.Name = "BevistigKNop";
            this.BevistigKNop.Size = new System.Drawing.Size(87, 18);
            this.BevistigKNop.TabIndex = 13;
            this.BevistigKNop.Text = "Bevestigen";
            this.BevistigKNop.Click += new System.EventHandler(this.BevestigKnop_Click);
            // 
            // OpenKnop
            // 
            this.OpenKnop.AutoSize = true;
            this.OpenKnop.BackColor = System.Drawing.Color.Chartreuse;
            this.OpenKnop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OpenKnop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenKnop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenKnop.Location = new System.Drawing.Point(120, 285);
            this.OpenKnop.Name = "OpenKnop";
            this.OpenKnop.Size = new System.Drawing.Size(55, 22);
            this.OpenKnop.TabIndex = 14;
            this.OpenKnop.Text = "Open";
            this.OpenKnop.Click += new System.EventHandler(this.OpenKnop_Click);
            // 
            // SluitKnop
            // 
            this.SluitKnop.AutoSize = true;
            this.SluitKnop.BackColor = System.Drawing.Color.Red;
            this.SluitKnop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SluitKnop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SluitKnop.Enabled = false;
            this.SluitKnop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SluitKnop.Location = new System.Drawing.Point(120, 285);
            this.SluitKnop.Name = "SluitKnop";
            this.SluitKnop.Size = new System.Drawing.Size(69, 22);
            this.SluitKnop.TabIndex = 15;
            this.SluitKnop.Text = "Sluiten";
            this.SluitKnop.Visible = false;
            this.SluitKnop.Click += new System.EventHandler(this.SluitKnop_Click);
            // 
            // KaartID
            // 
            this.KaartID.AutoSize = true;
            this.KaartID.Location = new System.Drawing.Point(13, 91);
            this.KaartID.Name = "KaartID";
            this.KaartID.Size = new System.Drawing.Size(67, 16);
            this.KaartID.TabIndex = 16;
            this.KaartID.Text = "Badge ID:";
            // 
            // IDBOX
            // 
            this.IDBOX.Location = new System.Drawing.Point(86, 88);
            this.IDBOX.Name = "IDBOX";
            this.IDBOX.Size = new System.Drawing.Size(169, 22);
            this.IDBOX.TabIndex = 17;
            // 
            // InfoVenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 417);
            this.Controls.Add(this.IDBOX);
            this.Controls.Add(this.KaartID);
            this.Controls.Add(this.SluitKnop);
            this.Controls.Add(this.OpenKnop);
            this.Controls.Add(this.BevistigKNop);
            this.Controls.Add(this.COMLijst);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Clearknop);
            this.Controls.Add(this.VerwijderKnop);
            this.Controls.Add(this.Toevoegen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EigenaarBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InfoTabel);
            this.Name = "InfoVenster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Info scherm";
            this.Load += new System.EventHandler(this.SecurityBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InfoTabel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView InfoTabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EigenaarBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Toevoegen;
        private System.Windows.Forms.Label VerwijderKnop;
        private System.Windows.Forms.Label Clearknop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox COMLijst;
        private System.IO.Ports.SerialPort Poort;
        private System.Windows.Forms.Label BevistigKNop;
        private System.Windows.Forms.Label OpenKnop;
        private System.Windows.Forms.Label SluitKnop;
        private System.Windows.Forms.Label KaartID;
        private System.Windows.Forms.TextBox IDBOX;
    }
}

