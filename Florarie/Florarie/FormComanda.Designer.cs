namespace Florarie
{
    partial class FormComanda
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
            this.gbComanda = new System.Windows.Forms.GroupBox();
            this.cbModalitate = new System.Windows.Forms.ComboBox();
            this.tbCantitate = new System.Windows.Forms.TextBox();
            this.lbModalitate = new System.Windows.Forms.Label();
            this.lbCantitate = new System.Windows.Forms.Label();
            this.tbPret = new System.Windows.Forms.TextBox();
            this.lbPret = new System.Windows.Forms.Label();
            this.cbTip = new System.Windows.Forms.ComboBox();
            this.lbTip = new System.Windows.Forms.Label();
            this.tbDenumire = new System.Windows.Forms.TextBox();
            this.lbDenumire = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbLivrare = new System.Windows.Forms.GroupBox();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.lbTelefon = new System.Windows.Forms.Label();
            this.tbPrenume = new System.Windows.Forms.TextBox();
            this.lbPrenume = new System.Windows.Forms.Label();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.lbNume = new System.Windows.Forms.Label();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.lbAdresa = new System.Windows.Forms.Label();
            this.dtpLivrare = new System.Windows.Forms.DateTimePicker();
            this.lbData = new System.Windows.Forms.Label();
            this.lvComenzi = new System.Windows.Forms.ListView();
            this.denumire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pret = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cantitate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.modalitate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prenume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.telefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbDetalii = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnCurata = new System.Windows.Forms.Button();
            this.btnEditeaza = new System.Windows.Forms.Button();
            this.epDenumire = new System.Windows.Forms.ErrorProvider(this.components);
            this.epTip = new System.Windows.Forms.ErrorProvider(this.components);
            this.epData = new System.Windows.Forms.ErrorProvider(this.components);
            this.epAdresa = new System.Windows.Forms.ErrorProvider(this.components);
            this.epNume = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPrenume = new System.Windows.Forms.ErrorProvider(this.components);
            this.epModalitate = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSterge = new System.Windows.Forms.Button();
            this.Meniu = new System.Windows.Forms.MenuStrip();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.MyName = new System.Windows.Forms.ToolStripMenuItem();
            this.AdaugaClient = new System.Windows.Forms.ToolStripMenuItem();
            this.gbComanda.SuspendLayout();
            this.gbLivrare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epDenumire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAdresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPrenume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epModalitate)).BeginInit();
            this.Meniu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbComanda
            // 
            this.gbComanda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbComanda.Controls.Add(this.cbModalitate);
            this.gbComanda.Controls.Add(this.tbCantitate);
            this.gbComanda.Controls.Add(this.lbModalitate);
            this.gbComanda.Controls.Add(this.lbCantitate);
            this.gbComanda.Controls.Add(this.tbPret);
            this.gbComanda.Controls.Add(this.lbPret);
            this.gbComanda.Controls.Add(this.cbTip);
            this.gbComanda.Controls.Add(this.lbTip);
            this.gbComanda.Controls.Add(this.tbDenumire);
            this.gbComanda.Controls.Add(this.lbDenumire);
            this.gbComanda.Location = new System.Drawing.Point(12, 29);
            this.gbComanda.Name = "gbComanda";
            this.gbComanda.Size = new System.Drawing.Size(187, 241);
            this.gbComanda.TabIndex = 0;
            this.gbComanda.TabStop = false;
            this.gbComanda.Text = "Detalii comanda";
            // 
            // cbModalitate
            // 
            this.cbModalitate.FormattingEnabled = true;
            this.cbModalitate.Items.AddRange(new object[] {
            "Cash",
            "Card"});
            this.cbModalitate.Location = new System.Drawing.Point(9, 205);
            this.cbModalitate.Name = "cbModalitate";
            this.cbModalitate.Size = new System.Drawing.Size(158, 21);
            this.cbModalitate.TabIndex = 9;
            this.cbModalitate.Validated += new System.EventHandler(this.cbModalitate_Validated);
            // 
            // tbCantitate
            // 
            this.tbCantitate.Location = new System.Drawing.Point(9, 158);
            this.tbCantitate.Name = "tbCantitate";
            this.tbCantitate.Size = new System.Drawing.Size(158, 20);
            this.tbCantitate.TabIndex = 8;
            this.tbCantitate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCantitate_KeyPress);
            // 
            // lbModalitate
            // 
            this.lbModalitate.AutoSize = true;
            this.lbModalitate.Location = new System.Drawing.Point(11, 189);
            this.lbModalitate.Name = "lbModalitate";
            this.lbModalitate.Size = new System.Drawing.Size(56, 13);
            this.lbModalitate.TabIndex = 7;
            this.lbModalitate.Text = "Modalitate";
            // 
            // lbCantitate
            // 
            this.lbCantitate.AutoSize = true;
            this.lbCantitate.Location = new System.Drawing.Point(9, 142);
            this.lbCantitate.Name = "lbCantitate";
            this.lbCantitate.Size = new System.Drawing.Size(49, 13);
            this.lbCantitate.TabIndex = 6;
            this.lbCantitate.Text = "Cantitate";
            // 
            // tbPret
            // 
            this.tbPret.Location = new System.Drawing.Point(9, 119);
            this.tbPret.Name = "tbPret";
            this.tbPret.Size = new System.Drawing.Size(158, 20);
            this.tbPret.TabIndex = 5;
            this.tbPret.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPret_KeyPress);
            // 
            // lbPret
            // 
            this.lbPret.AutoSize = true;
            this.lbPret.Location = new System.Drawing.Point(9, 103);
            this.lbPret.Name = "lbPret";
            this.lbPret.Size = new System.Drawing.Size(26, 13);
            this.lbPret.TabIndex = 4;
            this.lbPret.Text = "Pret";
            // 
            // cbTip
            // 
            this.cbTip.FormattingEnabled = true;
            this.cbTip.Items.AddRange(new object[] {
            "Trandafir",
            "Lalea",
            "Zambila",
            "Crin",
            "Garoafa",
            "Orhidee"});
            this.cbTip.Location = new System.Drawing.Point(9, 79);
            this.cbTip.Name = "cbTip";
            this.cbTip.Size = new System.Drawing.Size(158, 21);
            this.cbTip.TabIndex = 3;
            this.cbTip.Validated += new System.EventHandler(this.cbTip_Validated);
            // 
            // lbTip
            // 
            this.lbTip.AutoSize = true;
            this.lbTip.Location = new System.Drawing.Point(9, 63);
            this.lbTip.Name = "lbTip";
            this.lbTip.Size = new System.Drawing.Size(51, 13);
            this.lbTip.TabIndex = 2;
            this.lbTip.Text = "Tip floare";
            // 
            // tbDenumire
            // 
            this.tbDenumire.Location = new System.Drawing.Point(9, 40);
            this.tbDenumire.Name = "tbDenumire";
            this.tbDenumire.Size = new System.Drawing.Size(158, 20);
            this.tbDenumire.TabIndex = 1;
            this.tbDenumire.Validating += new System.ComponentModel.CancelEventHandler(this.tbDenumire_Validating);
            this.tbDenumire.Validated += new System.EventHandler(this.tbDenumire_Validated);
            // 
            // lbDenumire
            // 
            this.lbDenumire.AutoSize = true;
            this.lbDenumire.Location = new System.Drawing.Point(6, 24);
            this.lbDenumire.Name = "lbDenumire";
            this.lbDenumire.Size = new System.Drawing.Size(87, 13);
            this.lbDenumire.TabIndex = 0;
            this.lbDenumire.Text = "Denumire produs";
            // 
            // gbLivrare
            // 
            this.gbLivrare.Controls.Add(this.tbTelefon);
            this.gbLivrare.Controls.Add(this.lbTelefon);
            this.gbLivrare.Controls.Add(this.tbPrenume);
            this.gbLivrare.Controls.Add(this.lbPrenume);
            this.gbLivrare.Controls.Add(this.tbNume);
            this.gbLivrare.Controls.Add(this.lbNume);
            this.gbLivrare.Controls.Add(this.tbAdresa);
            this.gbLivrare.Controls.Add(this.lbAdresa);
            this.gbLivrare.Controls.Add(this.dtpLivrare);
            this.gbLivrare.Controls.Add(this.lbData);
            this.gbLivrare.Location = new System.Drawing.Point(210, 29);
            this.gbLivrare.Name = "gbLivrare";
            this.gbLivrare.Size = new System.Drawing.Size(217, 240);
            this.gbLivrare.TabIndex = 1;
            this.gbLivrare.TabStop = false;
            this.gbLivrare.Text = "Detalii livrare";
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(6, 206);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(180, 20);
            this.tbTelefon.TabIndex = 10;
            this.tbTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTelefon_KeyPress);
            this.tbTelefon.Leave += new System.EventHandler(this.tbTelefon_Leave);
            // 
            // lbTelefon
            // 
            this.lbTelefon.AutoSize = true;
            this.lbTelefon.Location = new System.Drawing.Point(6, 189);
            this.lbTelefon.Name = "lbTelefon";
            this.lbTelefon.Size = new System.Drawing.Size(71, 13);
            this.lbTelefon.TabIndex = 9;
            this.lbTelefon.Text = "Telefon client";
            // 
            // tbPrenume
            // 
            this.tbPrenume.Location = new System.Drawing.Point(6, 158);
            this.tbPrenume.Name = "tbPrenume";
            this.tbPrenume.Size = new System.Drawing.Size(180, 20);
            this.tbPrenume.TabIndex = 8;
            this.tbPrenume.Validating += new System.ComponentModel.CancelEventHandler(this.tbPrenume_Validating);
            this.tbPrenume.Validated += new System.EventHandler(this.tbPrenume_Validated);
            // 
            // lbPrenume
            // 
            this.lbPrenume.AutoSize = true;
            this.lbPrenume.Location = new System.Drawing.Point(6, 142);
            this.lbPrenume.Name = "lbPrenume";
            this.lbPrenume.Size = new System.Drawing.Size(77, 13);
            this.lbPrenume.TabIndex = 7;
            this.lbPrenume.Text = "Prenume client";
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(6, 119);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(180, 20);
            this.tbNume.TabIndex = 6;
            this.tbNume.Validating += new System.ComponentModel.CancelEventHandler(this.tbNume_Validating);
            this.tbNume.Validated += new System.EventHandler(this.tbNume_Validated);
            // 
            // lbNume
            // 
            this.lbNume.AutoSize = true;
            this.lbNume.Location = new System.Drawing.Point(3, 103);
            this.lbNume.Name = "lbNume";
            this.lbNume.Size = new System.Drawing.Size(63, 13);
            this.lbNume.TabIndex = 5;
            this.lbNume.Text = "Nume client";
            // 
            // tbAdresa
            // 
            this.tbAdresa.Location = new System.Drawing.Point(6, 79);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(180, 20);
            this.tbAdresa.TabIndex = 4;
            this.tbAdresa.Validating += new System.ComponentModel.CancelEventHandler(this.tbAdresa_Validating);
            this.tbAdresa.Validated += new System.EventHandler(this.tbAdresa_Validated);
            // 
            // lbAdresa
            // 
            this.lbAdresa.AutoSize = true;
            this.lbAdresa.Location = new System.Drawing.Point(6, 63);
            this.lbAdresa.Name = "lbAdresa";
            this.lbAdresa.Size = new System.Drawing.Size(40, 13);
            this.lbAdresa.TabIndex = 3;
            this.lbAdresa.Text = "Adresa";
            // 
            // dtpLivrare
            // 
            this.dtpLivrare.Location = new System.Drawing.Point(6, 37);
            this.dtpLivrare.Name = "dtpLivrare";
            this.dtpLivrare.Size = new System.Drawing.Size(180, 20);
            this.dtpLivrare.TabIndex = 2;
            this.dtpLivrare.Validating += new System.ComponentModel.CancelEventHandler(this.dtpLivrare_Validating);
            this.dtpLivrare.Validated += new System.EventHandler(this.dtpLivrare_Validated);
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Location = new System.Drawing.Point(6, 21);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(61, 13);
            this.lbData.TabIndex = 1;
            this.lbData.Text = "Data livrare";
            // 
            // lvComenzi
            // 
            this.lvComenzi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.denumire,
            this.tip,
            this.pret,
            this.cantitate,
            this.modalitate,
            this.data,
            this.adresa,
            this.nume,
            this.prenume,
            this.telefon});
            this.lvComenzi.FullRowSelect = true;
            this.lvComenzi.Location = new System.Drawing.Point(12, 302);
            this.lvComenzi.Name = "lvComenzi";
            this.lvComenzi.Size = new System.Drawing.Size(715, 99);
            this.lvComenzi.TabIndex = 2;
            this.lvComenzi.UseCompatibleStateImageBehavior = false;
            this.lvComenzi.View = System.Windows.Forms.View.Details;
            // 
            // denumire
            // 
            this.denumire.Text = "Denumire produs";
            this.denumire.Width = 95;
            // 
            // tip
            // 
            this.tip.Text = "Tip floare";
            // 
            // pret
            // 
            this.pret.Text = "Pret";
            // 
            // cantitate
            // 
            this.cantitate.Text = "Cantitate";
            // 
            // modalitate
            // 
            this.modalitate.Text = "Modalitate";
            this.modalitate.Width = 68;
            // 
            // data
            // 
            this.data.Text = "Data livrare";
            this.data.Width = 70;
            // 
            // adresa
            // 
            this.adresa.Text = "Adresa";
            // 
            // nume
            // 
            this.nume.Text = "Nume client";
            this.nume.Width = 79;
            // 
            // prenume
            // 
            this.prenume.Text = "Prenume Client";
            this.prenume.Width = 84;
            // 
            // telefon
            // 
            this.telefon.Text = "Telefon";
            this.telefon.Width = 70;
            // 
            // lbDetalii
            // 
            this.lbDetalii.AutoSize = true;
            this.lbDetalii.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetalii.Location = new System.Drawing.Point(327, 271);
            this.lbDetalii.Name = "lbDetalii";
            this.lbDetalii.Size = new System.Drawing.Size(109, 20);
            this.lbDetalii.TabIndex = 3;
            this.lbDetalii.Text = "Lista Comenzi";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(738, 2);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 5;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(521, 96);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(119, 46);
            this.btnAdauga.TabIndex = 6;
            this.btnAdauga.Text = "Adauga Comanda";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnCurata
            // 
            this.btnCurata.Location = new System.Drawing.Point(521, 158);
            this.btnCurata.Name = "btnCurata";
            this.btnCurata.Size = new System.Drawing.Size(119, 46);
            this.btnCurata.TabIndex = 7;
            this.btnCurata.Text = "Curata formular";
            this.btnCurata.UseVisualStyleBackColor = true;
            this.btnCurata.Click += new System.EventHandler(this.btnCurata_Click);
            // 
            // btnEditeaza
            // 
            this.btnEditeaza.Location = new System.Drawing.Point(219, 407);
            this.btnEditeaza.Name = "btnEditeaza";
            this.btnEditeaza.Size = new System.Drawing.Size(141, 31);
            this.btnEditeaza.TabIndex = 8;
            this.btnEditeaza.Text = "Editeaza comanda";
            this.btnEditeaza.UseVisualStyleBackColor = true;
            this.btnEditeaza.Click += new System.EventHandler(this.btnEditeaza_Click);
            // 
            // epDenumire
            // 
            this.epDenumire.ContainerControl = this;
            // 
            // epTip
            // 
            this.epTip.ContainerControl = this;
            // 
            // epData
            // 
            this.epData.ContainerControl = this;
            // 
            // epAdresa
            // 
            this.epAdresa.ContainerControl = this;
            // 
            // epNume
            // 
            this.epNume.ContainerControl = this;
            // 
            // epPrenume
            // 
            this.epPrenume.ContainerControl = this;
            // 
            // epModalitate
            // 
            this.epModalitate.ContainerControl = this;
            // 
            // btnSterge
            // 
            this.btnSterge.Location = new System.Drawing.Point(375, 407);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(141, 31);
            this.btnSterge.TabIndex = 12;
            this.btnSterge.Text = "Sterge comanda";
            this.btnSterge.UseVisualStyleBackColor = true;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // Meniu
            // 
            this.Meniu.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Meniu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Exit,
            this.MyName,
            this.AdaugaClient});
            this.Meniu.Location = new System.Drawing.Point(0, 0);
            this.Meniu.Name = "Meniu";
            this.Meniu.Size = new System.Drawing.Size(736, 24);
            this.Meniu.TabIndex = 13;
            this.Meniu.Text = "Meniu";
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(37, 20);
            this.Exit.Text = "Exit";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MyName
            // 
            this.MyName.Name = "MyName";
            this.MyName.Size = new System.Drawing.Size(55, 20);
            this.MyName.Text = "Despre";
            this.MyName.Click += new System.EventHandler(this.MyName_Click);
            // 
            // AdaugaClient
            // 
            this.AdaugaClient.Name = "AdaugaClient";
            this.AdaugaClient.Size = new System.Drawing.Size(109, 20);
            this.AdaugaClient.Text = "Adauga un client";
            this.AdaugaClient.Click += new System.EventHandler(this.AdaugaClient_Click);
            // 
            // FormComanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 444);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnEditeaza);
            this.Controls.Add(this.btnCurata);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbDetalii);
            this.Controls.Add(this.lvComenzi);
            this.Controls.Add(this.gbLivrare);
            this.Controls.Add(this.gbComanda);
            this.Controls.Add(this.Meniu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormComanda";
            this.Text = "Formular Comanda";
            this.gbComanda.ResumeLayout(false);
            this.gbComanda.PerformLayout();
            this.gbLivrare.ResumeLayout(false);
            this.gbLivrare.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epDenumire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAdresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPrenume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epModalitate)).EndInit();
            this.Meniu.ResumeLayout(false);
            this.Meniu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbComanda;
        private System.Windows.Forms.Label lbDenumire;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cbModalitate;
        private System.Windows.Forms.TextBox tbCantitate;
        private System.Windows.Forms.Label lbModalitate;
        private System.Windows.Forms.Label lbCantitate;
        private System.Windows.Forms.TextBox tbPret;
        private System.Windows.Forms.Label lbPret;
        private System.Windows.Forms.ComboBox cbTip;
        private System.Windows.Forms.Label lbTip;
        private System.Windows.Forms.TextBox tbDenumire;
        private System.Windows.Forms.GroupBox gbLivrare;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.Label lbTelefon;
        private System.Windows.Forms.TextBox tbPrenume;
        private System.Windows.Forms.Label lbPrenume;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.Label lbNume;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.Label lbAdresa;
        private System.Windows.Forms.DateTimePicker dtpLivrare;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.ListView lvComenzi;
        private System.Windows.Forms.ColumnHeader denumire;
        private System.Windows.Forms.ColumnHeader tip;
        private System.Windows.Forms.ColumnHeader pret;
        private System.Windows.Forms.ColumnHeader cantitate;
        private System.Windows.Forms.ColumnHeader modalitate;
        private System.Windows.Forms.ColumnHeader data;
        private System.Windows.Forms.ColumnHeader adresa;
        private System.Windows.Forms.ColumnHeader nume;
        private System.Windows.Forms.ColumnHeader prenume;
        private System.Windows.Forms.ColumnHeader telefon;
        private System.Windows.Forms.Label lbDetalii;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnCurata;
        private System.Windows.Forms.Button btnEditeaza;
        private System.Windows.Forms.ErrorProvider epDenumire;
        private System.Windows.Forms.ErrorProvider epTip;
        private System.Windows.Forms.ErrorProvider epData;
        private System.Windows.Forms.ErrorProvider epAdresa;
        private System.Windows.Forms.ErrorProvider epNume;
        private System.Windows.Forms.ErrorProvider epPrenume;
        private System.Windows.Forms.ErrorProvider epModalitate;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.MenuStrip Meniu;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ToolStripMenuItem MyName;
        private System.Windows.Forms.ToolStripMenuItem AdaugaClient;
    }
}

