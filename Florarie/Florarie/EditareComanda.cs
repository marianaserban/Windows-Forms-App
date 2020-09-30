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
    public partial class EditareComanda : Form
    {
        Livrare _instance;
        public EditareComanda(Livrare oLivare)
        {
            InitializeComponent();
            _instance = oLivare;
        }
        private void EditareComanda_Load(object sender, EventArgs e)
        {
            tbDenumire.Text = _instance.comanda.floare.Denumire;
            cbTip.Text = _instance.comanda.floare.Tip.ToString();
            tbPret.Text = _instance.comanda.floare.Pret.ToString();
            tbCantitate.Text = _instance.comanda.Cantitate.ToString();
            cbModalitate.Text = _instance.comanda.Modalitate;
            dtpLivrare.Value = _instance.DataLivrare;
            tbAdresa.Text = _instance.Adresa;
            tbNume.Text = _instance.client.Nume;
            tbPrenume.Text = _instance.client.Prenume;
            tbTelefon.Text = _instance.client.Telefon.ToString();
        }
        private void btnConfirma_Click(object sender, EventArgs e)
        {
            try
            {
                _instance.comanda.floare.Denumire = tbDenumire.Text;
                Enum.TryParse(cbTip.Text, out TipFloare tip);
                _instance.comanda.floare.Tip = tip;
                int.TryParse(tbPret.Text, out int pret);
                _instance.comanda.floare.Pret = pret;
                int.TryParse(tbCantitate.Text, out int cantitate);
                _instance.comanda.Cantitate = cantitate;
                _instance.comanda.Modalitate = cbModalitate.Text;
                DateTime data = dtpLivrare.Value;
                _instance.DataLivrare = data;
                _instance.Adresa = tbAdresa.Text;
                _instance.client.Nume = tbNume.Text;
                _instance.client.Prenume = tbPrenume.Text;
                int.TryParse(tbTelefon.Text, out int telefon);
                _instance.client.Telefon = telefon;
            }
            catch (CustomExceptionCantitate ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Close();
        }

        private void btnAnuleaza_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
