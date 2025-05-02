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
    public partial class wachtwoord : Form
    {
        public wachtwoord()
        {
            InitializeComponent();
        }

        private void BevestigKnop_Click(object sender, EventArgs e)
        {
            if (CodeBox.Text == "admin")
            {
                this.DialogResult = DialogResult.OK; // geeft signaal aan Form1
                this.Close();
            }
            else
            {
                MessageBox.Show("Dit is geen geldige code");
            }
        }
    }
}
