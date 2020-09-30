using Florarie.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Florarie
{
    public partial class EditeazaClient : Form
    {
        Client _instance;
        public EditeazaClient(Client unCLient)
        {
            InitializeComponent();
            _instance = unCLient;
        }
        private void EditeazaClient_Load(object sender, EventArgs e)
        {
            tbNume.Text = _instance.Nume;
            tbPrenume.Text = _instance.Prenume;
            tbTelefon.Text = _instance.Telefon.ToString();
        }
        private void btnConfirma_Click(object sender, EventArgs e)
        {
            _instance.Nume = tbNume.Text;
            _instance.Prenume = tbPrenume.Text;
            int.TryParse(tbTelefon.Text, out int telefon);
            _instance.Telefon = telefon;
            this.Close();
        }

        private void btnAnuleaza_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
