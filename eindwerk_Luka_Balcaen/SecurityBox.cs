using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Luka Balcaen
// eindeindwerk: een beveiligde doos makenen.

namespace eindwerk_Luka_Balcaen
{
    public partial class InfoVenster : Form
    {
        public InfoVenster()
        {
            InitializeComponent();
        }
        List<string> toegelaten = new List<string>();

        private void SecurityBox_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();

            foreach (string port in ports)
            {
                COMLijst.Items.Add(port);
            }

            if (ports.Length > 0)
            {
                COMLijst.SelectedIndex = 0;
            }

        }

        private void VerwijderKnop_Click(object sender, EventArgs e)
        {
            wachtwoord wachtwoord = new wachtwoord(); 
            wachtwoord.ShowDialog(); // wacht tot form sluit
            if (wachtwoord.DialogResult == DialogResult.OK)// hier gaan we kijken op de resultaat juist is.
            {
                try
                {
                    foreach (DataGridViewRow row in InfoTabel.SelectedRows)// verwijder geselecteerde rij
                    {
                        InfoTabel.Rows.RemoveAt(row.Index);
                    }
                }
                catch
                {
                    MessageBox.Show("Selecteer een rij om te verwijderen.");
                }
            }
        }

        private void Toevoegen_Click(object sender, EventArgs e)
        {
            wachtwoord wachtwoord = new wachtwoord();
            wachtwoord.ShowDialog(); // wacht tot form sluit

            if (wachtwoord.DialogResult == DialogResult.OK) // hier kijken we als de wachtwoord juist is.
            {
                if (EigenaarBox.Text != "" && IDBOX.Text !="")
                {
                    InfoTabel.Rows.Add(IDBOX.Text, EigenaarBox.Text); 
                    toegelaten.Add(IDBOX.Text+"\r");// we voegen \r toe de data gemakkelijker te vinden in waneer we hem zoeken via de arduino
                    EigenaarBox.Text = ""; // hier werd de textbox leeggemaakt
                    EigenaarBox.BackColor = Color.White; 
                    IDBOX.Text = "";
                }
                else
                {
                    MessageBox.Show("Je moet alle parameters invullen"); 
                    if(EigenaarBox.Text == "")
                    {
                        EigenaarBox.BackColor = Color.Red;
                    }
                    if(IDBOX.Text == "")
                    {
                        IDBOX.BackColor = Color.Red;
                    }
                    if (EigenaarBox.Text != "" )
                    {
                        EigenaarBox.BackColor = Color.White;
                       
                    }
                    if (IDBOX.Text != "")
                    {
                        IDBOX.BackColor = Color.White;

                    }
                }
            }
        }

        private void Clearknop_Click(object sender, EventArgs e)
        {
            wachtwoord wachtwoord = new wachtwoord();
            wachtwoord.ShowDialog(); // wacht tot form sluit
            DialogResult dialogResult = MessageBox.Show("Ben je zeker dat je de volledig tabel wil verwijderen", "Bevestiging", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (wachtwoord.DialogResult == DialogResult.OK) 
                {
                    InfoTabel.Rows.Clear();
                }
            }
        }

        private void OntvangData(object sender, SerialDataReceivedEventArgs e)
        {

            try
            {
                string data = Poort.ReadLine();

                if (data != null && data != "" ) 
                {
                    DataBewerk(data); 
                }
            }
            catch (Exception)
            {
                
            }

        }
        private void DataBewerk(string data)
        {

                if (toegelaten.Contains(data))// als de id kaart is in dat tabel 
                {
                    Poort.Write("0"); // dan return je 0 
                }
                else
                {
                    Poort.Write("1"); // anders return 1
                }
            
        }
        

        private void SluitKnop_Click(object sender, EventArgs e)
        {
            Poort.Close();
            OpenKnop.Enabled = true;
            SluitKnop.Enabled = false;
            OpenKnop.Visible = true;
            SluitKnop.Visible = false;
        }

        private void OpenKnop_Click(object sender, EventArgs e)
        {
            if (Poort.PortName!= " ")
            {
                try
                {
                    Poort.Open();
                    OpenKnop.Enabled = false;
                    SluitKnop.Enabled = true;
                    OpenKnop.Visible = false;
                    SluitKnop.Visible = true;
                }
                catch
                {
                    MessageBox.Show("De poort is al in gebruik of niet beschikbaar");
                    COMLijst.BackColor = Color.Red;
                }
            }
            else
            {
                MessageBox.Show("Selecteer een COM poort");
                COMLijst.BackColor = Color.Red;
                return;
            }

        }

        private void COMLijst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (COMLijst.Text == "")
            {
                MessageBox.Show("Selecteer een COM poort");
                COMLijst.BackColor = Color.Red;
                return;
            }
            else
            {
                COMLijst.BackColor = Color.White;
                Poort.PortName = COMLijst.Text;
            }
        }

        
    }
}
