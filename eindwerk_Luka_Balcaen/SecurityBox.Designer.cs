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
            this.InfoTabel = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.EigenaarBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Toevoegen = new System.Windows.Forms.Label();
            this.VerwijderKnop = new System.Windows.Forms.Label();
            this.Clearknop = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Toevoegen.Location = new System.Drawing.Point(91, 90);
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
            this.VerwijderKnop.Location = new System.Drawing.Point(91, 141);
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
            // InfoVenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 417);
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
    }
}

