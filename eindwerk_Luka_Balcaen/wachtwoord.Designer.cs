namespace eindwerk_Luka_Balcaen
{
    partial class wachtwoord
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
            this.label1 = new System.Windows.Forms.Label();
            this.CodeBox = new System.Windows.Forms.TextBox();
            this.BevestigKnop = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Heeft de admin code ";
            // 
            // CodeBox
            // 
            this.CodeBox.Location = new System.Drawing.Point(86, 58);
            this.CodeBox.Name = "CodeBox";
            this.CodeBox.Size = new System.Drawing.Size(194, 22);
            this.CodeBox.TabIndex = 2;
            // 
            // BevestigKnop
            // 
            this.BevestigKnop.AutoSize = true;
            this.BevestigKnop.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BevestigKnop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BevestigKnop.Location = new System.Drawing.Point(145, 83);
            this.BevestigKnop.Name = "BevestigKnop";
            this.BevestigKnop.Size = new System.Drawing.Size(76, 18);
            this.BevestigKnop.TabIndex = 3;
            this.BevestigKnop.Text = "bevestigen";
            this.BevestigKnop.Click += new System.EventHandler(this.BevestigKnop_Click);
            // 
            // wachtwoord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 139);
            this.Controls.Add(this.BevestigKnop);
            this.Controls.Add(this.CodeBox);
            this.Controls.Add(this.label1);
            this.Name = "wachtwoord";
            this.Text = "Wachtwoord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CodeBox;
        private System.Windows.Forms.Label BevestigKnop;
    }
}