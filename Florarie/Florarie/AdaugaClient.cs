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
    public partial class AdaugaClient : Form
    {
        List<Client> lista = new List<Client>();
        public AdaugaClient()
        {
            InitializeComponent();
        }

        #region OPERATII CRUD
        //create
        private void bntAdauga_Click(object sender, EventArgs e)
        {
          bool isValid = true;
            if (tbNume.Text == "" || tbPrenume.Text == "" || tbTelefon.Text == "") isValid = false;
            if (isValid == true)
            {
                String nume = tbNume.Text;
                String prenume = tbPrenume.Text;
                String valoareNrTel = tbTelefon.Text;
                int.TryParse(valoareNrTel, out int nrTel);
                Client unClient = new Client(nume, prenume, nrTel);

                lista.Add(unClient);
                populeazaListView();
                curataCampuri();

                MessageBox.Show("Ati adaugat un client!", "Succes",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Completati toate campurile!", "Eroare",
                   MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
          
        }
        //read
        private void populeazaListView()
        {
            lvClienti.Items.Clear();

            foreach (Client each in lista)
            {
                ListViewItem item = new ListViewItem(new String[] { 
                     each.Nume, each.Prenume, each.Telefon.ToString()});
                lvClienti.Items.Add(item);
            }
        }
        //update
        private void btnEditeaza_Click(object sender, EventArgs e)
        {
            if (lvClienti.SelectedItems.Count != 0)
            {
                Client unClient = lista.ElementAt(lvClienti.SelectedIndices[0]);
                EditeazaClient editare = new EditeazaClient(unClient);
                editare.ShowDialog();

                populeazaListView();
            }
        }
        //delete
        private void btnSterge_Click(object sender, EventArgs e)
        {
            if (lvClienti.SelectedItems.Count != 0)
            {
                if (MessageBox.Show("Doresti sa stergi clientul?", "Sterge clientul",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    lista.RemoveAt(lvClienti.SelectedIndices[0]);
                    populeazaListView();
                }
            }
        }

        #endregion

        #region VALIDAREA DATELOR
        private void tbNume_Validating(object sender, CancelEventArgs e)
        {

            String nume = tbNume.Text;
            if (String.IsNullOrEmpty(nume) || string.IsNullOrWhiteSpace(nume))
            {
                epNume.SetError((Control)sender, "Indroduceti numele!");
                e.Cancel = true;
            }
        }

        private void tbNume_Validated(object sender, EventArgs e)
        {
            epNume.Clear();

        }
        private void tbPrenume_Validating(object sender, CancelEventArgs e)
        {
            String prenume = tbPrenume.Text;
            if (String.IsNullOrEmpty(prenume) || string.IsNullOrWhiteSpace(prenume))
            {
                epNume.SetError((Control)sender, "Indroduceti prenumele!");
                e.Cancel = true;
            }
        }

        private void tbPrenume_Validated(object sender, EventArgs e)
        {
            epPrenume.Clear();

        }
        private void tbTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Numarul de telefon trebuie sa contina doar cifre!");
            }
        }

        private void tbTelefon_Leave(object sender, EventArgs e)
        {

            if ((tbTelefon.Text.Length != 10))
            {
                MessageBox.Show("Numarul de telefon trebuie sa aiba 10 cifre!");
                tbTelefon.Focus();
            }
        }

        #endregion

        private void curataCampuri()
        {
           
            tbNume.Clear();
            tbPrenume.Clear();
            tbTelefon.Clear();
        }

        private void btnCurata_Click(object sender, EventArgs e)
        {
            curataCampuri();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
