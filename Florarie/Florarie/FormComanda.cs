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
    public partial class FormComanda : Form
    {
        List<Livrare> lista = new List<Livrare>();
        public FormComanda()
        {
            InitializeComponent();
        }

        #region VALIDAREA DATELOR

        //denumire
        private void tbDenumire_Validating(object sender, CancelEventArgs e)
        {
            String denumire = tbDenumire.Text;
            if (String.IsNullOrEmpty(denumire) || string.IsNullOrWhiteSpace(denumire))
 
            {
                epDenumire.SetError((Control)sender, "Completati denumirea!");
                e.Cancel = true;
            }
        }

        private void tbDenumire_Validated(object sender, EventArgs e)
        {
            epDenumire.Clear();
        }


        //Tip 
        private void cbTip_Validated(object sender, EventArgs e)
        {
            epTip.Clear();
        }

        //pret
        private void tbPret_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Pretul trebuie sa fie o valoare numerica!");
            }
        }

        //cantitate
        private void tbCantitate_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Cantitatea trebuie sa fie o valoare numerica!");
            }
        }

        //modalitate
        private void cbModalitate_Validated(object sender, EventArgs e)
        {
            epModalitate.Clear();
        }


        //data
        private void dtpLivrare_Validating(object sender, CancelEventArgs e)
        {
            DateTime data = dtpLivrare.Value;
            DateTime data_curenta = DateTime.Now;
            if (DateTime.Compare(data_curenta, data) > 0)
            {
                epData.SetError(dtpLivrare, "Data livare invalida!");
                e.Cancel = true;
            }
        }

        private void dtpLivrare_Validated(object sender, EventArgs e)
        {
            epData.Clear();
        }


        //adresa
        private void tbAdresa_Validating(object sender, CancelEventArgs e)
        {
            String adresa = tbAdresa.Text;
            if (String.IsNullOrEmpty(adresa) || string.IsNullOrWhiteSpace(adresa))
            {
                epAdresa.SetError((Control)sender, "Indroduceti adresa");
                e.Cancel = true;
            }
        }

        private void tbAdresa_Validated(object sender, EventArgs e)
        {
            epAdresa.Clear();
        }


        //nume
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

        //prenume
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

        //telefon
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

        #region OPERATII CRUD 
        //create
        private void btnAdauga_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            if (cbTip.SelectedIndex == -1)
            {
                epTip.SetError(cbTip, "Alegeti un tip de floare!");
                isValid = false;
                
            }
            else if (cbModalitate.SelectedIndex == -1)
            {
                epModalitate.SetError(cbModalitate, "Alegeti o modalitate de plata!");
                isValid = false;
             

            }
            else if (tbPret.Text == "" || tbCantitate.Text == ""
                || tbAdresa.Text == "" || tbNume.Text == "" || tbPrenume.Text == "" || tbTelefon.Text == "") isValid = false;
            if(isValid==true)
            {
                try
                {
                    //denumire
                    String denumire = tbDenumire.Text;

                    //tip floare
                    String valoareTip = cbTip.Text;
                    Enum.TryParse(valoareTip, out TipFloare tip);

                    //pret
                    String valoarePret = tbPret.Text;
                    int.TryParse(valoarePret, out int pret);

                    //cantitate
                    String valoareCantitate = tbCantitate.Text;
                    int.TryParse(valoareCantitate, out int cantitate);

                    //modalitate
                    String modalitate = cbModalitate.Text;

                    DateTime data = dtpLivrare.Value;
                    String adresa = tbAdresa.Text;
                    String nume = tbNume.Text;
                    String prenume = tbPrenume.Text;
                    String valoareNrTel = tbTelefon.Text;
                    int.TryParse(valoareNrTel, out int nrTel);


                    Floare ofloare = new Floare(denumire, tip, pret);
                    Comanda oComanda = new Comanda(ofloare, modalitate, cantitate);
                    Client unClient = new Client(nume, prenume, nrTel);
                    Livrare oLivrare = new Livrare(data, adresa, unClient, oComanda);

                    lista.Add(oLivrare);
                    populeazaListView();
                    curataCampuri();

                    MessageBox.Show("Ati adaugat o comanda!", "Succes",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (CustomExceptionCantitate ex)
                {
                    MessageBox.Show(ex.Message);
                }
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
            lvComenzi.Items.Clear();

            foreach (Livrare each in lista)
            {
                ListViewItem item = new ListViewItem(new String[] { each.comanda.floare.Denumire,
                    each.comanda.floare.Tip.ToString(), each.comanda.floare.Pret.ToString(),
                each.comanda.Cantitate.ToString(), each.comanda.Modalitate, each.DataLivrare.ToString(),
                each.Adresa, each.client.Nume, each.client.Prenume, each.client.Telefon.ToString()});
                lvComenzi.Items.Add(item);
            }
        }

        //update
        private void btnEditeaza_Click(object sender, EventArgs e)
        {
            if (lvComenzi.SelectedItems.Count != 0)
            {
                Livrare oLivrare = lista.ElementAt(lvComenzi.SelectedIndices[0]);
                EditareComanda editare = new EditareComanda(oLivrare);
                editare.ShowDialog();

                populeazaListView();
            }
        }

        //delete
        private void btnSterge_Click(object sender, EventArgs e)
        {
            if (lvComenzi.SelectedItems.Count != 0)
            {
                if (MessageBox.Show("Doresti sa stergi comanda?", "Sterge comanda",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    lista.RemoveAt(lvComenzi.SelectedIndices[0]);
                    populeazaListView();
                }
            }
        }
        #endregion

        #region BUTOANE MENIU
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MyName_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mariana Serban");
        }
        private void AdaugaClient_Click(object sender, EventArgs e)
        {
            AdaugaClient adauga = new AdaugaClient();
            adauga.ShowDialog();
        }
        #endregion
        private void curataCampuri()
        {
            tbDenumire.Clear();
            cbTip.SelectedIndex = -1;
            tbPret.Clear();
            tbCantitate.Clear();
            cbModalitate.SelectedIndex = -1;
            dtpLivrare.Value = DateTime.Now;
            tbAdresa.Clear();
            tbNume.Clear();
            tbPrenume.Clear();
            tbTelefon.Clear();
        }

        private void btnCurata_Click(object sender, EventArgs e)
        {
            curataCampuri();
        }
    }
}
