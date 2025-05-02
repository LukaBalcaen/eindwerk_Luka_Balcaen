using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eindwerk_Luka_Balcaen
{
    public partial class InfoVenster : Form
    {
        public InfoVenster()
        {
            InitializeComponent();
        }

        private void SecurityBox_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 30; i++)
            {
                InfoTabel.Rows.Add("ik", i);

            }
                
           
        }

        private void VerwijderKnop_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in InfoTabel.SelectedRows)
                {
                    InfoTabel.Rows.RemoveAt(row.Index);
                }
            }
            catch
            {
                MessageBox.Show("Selecteer een rij om te verwijderen.");
            }
        }

        private void Toevoegen_Click(object sender, EventArgs e)
        {
            wachtwoord wachtwoord = new wachtwoord();
            wachtwoord.ShowDialog(); // wacht tot form sluit

            if (wachtwoord.DialogResult == DialogResult.OK)
            {
                if (EigenaarBox.Text != "")
                {
                    InfoTabel.Rows.Add("ik", EigenaarBox.Text);
                    EigenaarBox.Text = "";
                    EigenaarBox.BackColor = Color.White;
                }
                else
                {
                    MessageBox.Show("Voeg eerst een naam voor de eigenaar");
                    EigenaarBox.BackColor = Color.Red;
                }
            }
        }

        private void Clearknop_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Ben je zeker dat je de volledig tabel wil verwijderen", "Bevestiging", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                InfoTabel.Rows.Clear();
            }
            
            
        }
    }
}
