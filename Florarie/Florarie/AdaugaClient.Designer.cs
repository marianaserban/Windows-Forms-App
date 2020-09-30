namespace Florarie
{
    partial class AdaugaClient
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
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.lbTelefon = new System.Windows.Forms.Label();
            this.tbPrenume = new System.Windows.Forms.TextBox();
            this.lbPrenume = new System.Windows.Forms.Label();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.lbNume = new System.Windows.Forms.Label();
            this.gbClient = new System.Windows.Forms.GroupBox();
            this.bntAdauga = new System.Windows.Forms.Button();
            this.btnCurata = new System.Windows.Forms.Button();
            this.lvClienti = new System.Windows.Forms.ListView();
            this.nume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prenume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.telefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbLista = new System.Windows.Forms.Label();
            this.btnSterge = new System.Windows.Forms.Button();
            this.btnEditeaza = new System.Windows.Forms.Button();
            this.epNume = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPrenume = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuClient = new System.Windows.Forms.MenuStrip();
            this.back = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.gbClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epNume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPrenume)).BeginInit();
            this.menuClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(30, 134);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(207, 20);
            this.tbTelefon.TabIndex = 16;
            this.tbTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTelefon_KeyPress);
            this.tbTelefon.Leave += new System.EventHandler(this.tbTelefon_Leave);
            // 
            // lbTelefon
            // 
            this.lbTelefon.AutoSize = true;
            this.lbTelefon.Location = new System.Drawing.Point(30, 117);
            this.lbTelefon.Name = "lbTelefon";
            this.lbTelefon.Size = new System.Drawing.Size(71, 13);
            this.lbTelefon.TabIndex = 15;
            this.lbTelefon.Text = "Telefon client";
            // 
            // tbPrenume
            // 
            this.tbPrenume.Location = new System.Drawing.Point(30, 86);
            this.tbPrenume.Name = "tbPrenume";
            this.tbPrenume.Size = new System.Drawing.Size(207, 20);
            this.tbPrenume.TabIndex = 14;
            this.tbPrenume.Validating += new System.ComponentModel.CancelEventHandler(this.tbPrenume_Validating);
            this.tbPrenume.Validated += new System.EventHandler(this.tbPrenume_Validated);
            // 
            // lbPrenume
            // 
            this.lbPrenume.AutoSize = true;
            this.lbPrenume.Location = new System.Drawing.Point(30, 70);
            this.lbPrenume.Name = "lbPrenume";
            this.lbPrenume.Size = new System.Drawing.Size(77, 13);
            this.lbPrenume.TabIndex = 13;
            this.lbPrenume.Text = "Prenume client";
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(30, 47);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(207, 20);
            this.tbNume.TabIndex = 12;
            this.tbNume.Validating += new System.ComponentModel.CancelEventHandler(this.tbNume_Validating);
            this.tbNume.Validated += new System.EventHandler(this.tbNume_Validated);
            // 
            // lbNume
            // 
            this.lbNume.AutoSize = true;
            this.lbNume.Location = new System.Drawing.Point(27, 31);
            this.lbNume.Name = "lbNume";
            this.lbNume.Size = new System.Drawing.Size(63, 13);
            this.lbNume.TabIndex = 11;
            this.lbNume.Text = "Nume client";
            // 
            // gbClient
            // 
            this.gbClient.Controls.Add(this.tbTelefon);
            this.gbClient.Controls.Add(this.lbTelefon);
            this.gbClient.Controls.Add(this.tbPrenume);
            this.gbClient.Controls.Add(this.lbPrenume);
            this.gbClient.Controls.Add(this.tbNume);
            this.gbClient.Controls.Add(this.lbNume);
            this.gbClient.Location = new System.Drawing.Point(12, 28);
            this.gbClient.Name = "gbClient";
            this.gbClient.Size = new System.Drawing.Size(267, 204);
            this.gbClient.TabIndex = 17;
            this.gbClient.TabStop = false;
            this.gbClient.Text = "Adauga un client ";
            // 
            // bntAdauga
            // 
            this.bntAdauga.Location = new System.Drawing.Point(25, 243);
            this.bntAdauga.Name = "bntAdauga";
            this.bntAdauga.Size = new System.Drawing.Size(119, 39);
            this.bntAdauga.TabIndex = 18;
            this.bntAdauga.Text = "Adauga client";
            this.bntAdauga.UseVisualStyleBackColor = true;
            this.bntAdauga.Click += new System.EventHandler(this.bntAdauga_Click);
            // 
            // btnCurata
            // 
            this.btnCurata.Location = new System.Drawing.Point(150, 243);
            this.btnCurata.Name = "btnCurata";
            this.btnCurata.Size = new System.Drawing.Size(119, 39);
            this.btnCurata.TabIndex = 19;
            this.btnCurata.Text = "Curata formular";
            this.btnCurata.UseVisualStyleBackColor = true;
            this.btnCurata.Click += new System.EventHandler(this.btnCurata_Click);
            // 
            // lvClienti
            // 
            this.lvClienti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nume,
            this.prenume,
            this.telefon});
            this.lvClienti.FullRowSelect = true;
            this.lvClienti.Location = new System.Drawing.Point(292, 46);
            this.lvClienti.Name = "lvClienti";
            this.lvClienti.Size = new System.Drawing.Size(450, 173);
            this.lvClienti.TabIndex = 20;
            this.lvClienti.UseCompatibleStateImageBehavior = false;
            this.lvClienti.View = System.Windows.Forms.View.Details;
            // 
            // nume
            // 
            this.nume.Text = "Nume";
            this.nume.Width = 145;
            // 
            // prenume
            // 
            this.prenume.Text = "Prenume";
            this.prenume.Width = 146;
            // 
            // telefon
            // 
            this.telefon.Text = "Nr. telefon";
            this.telefon.Width = 109;
            // 
            // lbLista
            // 
            this.lbLista.AutoSize = true;
            this.lbLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLista.Location = new System.Drawing.Point(472, 22);
            this.lbLista.Name = "lbLista";
            this.lbLista.Size = new System.Drawing.Size(87, 20);
            this.lbLista.TabIndex = 21;
            this.lbLista.Text = "Lista clienti";
            // 
            // btnSterge
            // 
            this.btnSterge.Location = new System.Drawing.Point(623, 243);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(119, 39);
            this.btnSterge.TabIndex = 23;
            this.btnSterge.Text = "Sterge client";
            this.btnSterge.UseVisualStyleBackColor = true;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // btnEditeaza
            // 
            this.btnEditeaza.Location = new System.Drawing.Point(498, 243);
            this.btnEditeaza.Name = "btnEditeaza";
            this.btnEditeaza.Size = new System.Drawing.Size(119, 39);
            this.btnEditeaza.TabIndex = 22;
            this.btnEditeaza.Text = "Editeaza client";
            this.btnEditeaza.UseVisualStyleBackColor = true;
            this.btnEditeaza.Click += new System.EventHandler(this.btnEditeaza_Click);
            // 
            // epNume
            // 
            this.epNume.ContainerControl = this;
            // 
            // epPrenume
            // 
            this.epPrenume.ContainerControl = this;
            // 
            // menuClient
            // 
            this.menuClient.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuClient.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.back});
            this.menuClient.Location = new System.Drawing.Point(0, 0);
            this.menuClient.Name = "menuClient";
            this.menuClient.Size = new System.Drawing.Size(758, 24);
            this.menuClient.TabIndex = 24;
            this.menuClient.Text = "menuStrip1";
            // 
            // back
            // 
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(62, 20);
            this.back.Text = "Go back";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(284, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(3, 280);
            this.label1.TabIndex = 25;
            // 
            // AdaugaClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 309);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnEditeaza);
            this.Controls.Add(this.lbLista);
            this.Controls.Add(this.lvClienti);
            this.Controls.Add(this.btnCurata);
            this.Controls.Add(this.bntAdauga);
            this.Controls.Add(this.gbClient);
            this.Controls.Add(this.menuClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuClient;
            this.Name = "AdaugaClient";
            this.Text = "Adaugare client";
            this.gbClient.ResumeLayout(false);
            this.gbClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epNume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPrenume)).EndInit();
            this.menuClient.ResumeLayout(false);
            this.menuClient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.Label lbTelefon;
        private System.Windows.Forms.TextBox tbPrenume;
        private System.Windows.Forms.Label lbPrenume;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.Label lbNume;
        private System.Windows.Forms.GroupBox gbClient;
        private System.Windows.Forms.Button bntAdauga;
        private System.Windows.Forms.Button btnCurata;
        private System.Windows.Forms.ListView lvClienti;
        private System.Windows.Forms.Label lbLista;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.Button btnEditeaza;
        private System.Windows.Forms.ErrorProvider epNume;
        private System.Windows.Forms.ErrorProvider epPrenume;
        private System.Windows.Forms.ColumnHeader nume;
        private System.Windows.Forms.ColumnHeader prenume;
        private System.Windows.Forms.ColumnHeader telefon;
        private System.Windows.Forms.MenuStrip menuClient;
        private System.Windows.Forms.ToolStripMenuItem back;
        private System.Windows.Forms.Label label1;
    }
}