namespace Florarie
{
    partial class EditeazaClient
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
            this.gbClient = new System.Windows.Forms.GroupBox();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.lbTelefon = new System.Windows.Forms.Label();
            this.tbPrenume = new System.Windows.Forms.TextBox();
            this.lbPrenume = new System.Windows.Forms.Label();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.lbNume = new System.Windows.Forms.Label();
            this.btnAnuleaza = new System.Windows.Forms.Button();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gbClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbClient
            // 
            this.gbClient.Controls.Add(this.tbTelefon);
            this.gbClient.Controls.Add(this.lbTelefon);
            this.gbClient.Controls.Add(this.tbPrenume);
            this.gbClient.Controls.Add(this.lbPrenume);
            this.gbClient.Controls.Add(this.tbNume);
            this.gbClient.Controls.Add(this.lbNume);
            this.gbClient.Location = new System.Drawing.Point(12, 12);
            this.gbClient.Name = "gbClient";
            this.gbClient.Size = new System.Drawing.Size(267, 204);
            this.gbClient.TabIndex = 18;
            this.gbClient.TabStop = false;
            this.gbClient.Text = "Editeaza client";
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(30, 134);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(207, 20);
            this.tbTelefon.TabIndex = 16;
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
            // btnAnuleaza
            // 
            this.btnAnuleaza.Location = new System.Drawing.Point(150, 235);
            this.btnAnuleaza.Name = "btnAnuleaza";
            this.btnAnuleaza.Size = new System.Drawing.Size(99, 40);
            this.btnAnuleaza.TabIndex = 21;
            this.btnAnuleaza.Text = "Anuleaza";
            this.btnAnuleaza.UseVisualStyleBackColor = true;
            this.btnAnuleaza.Click += new System.EventHandler(this.btnAnuleaza_Click);
            // 
            // btnConfirma
            // 
            this.btnConfirma.Location = new System.Drawing.Point(45, 235);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(88, 40);
            this.btnConfirma.TabIndex = 20;
            this.btnConfirma.Text = "Confirma";
            this.btnConfirma.UseVisualStyleBackColor = true;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 19;
            // 
            // EditeazaClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 298);
            this.Controls.Add(this.btnAnuleaza);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "EditeazaClient";
            this.Text = "Editeaza client";
            this.Load += new System.EventHandler(this.EditeazaClient_Load);
            this.gbClient.ResumeLayout(false);
            this.gbClient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbClient;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.Label lbTelefon;
        private System.Windows.Forms.TextBox tbPrenume;
        private System.Windows.Forms.Label lbPrenume;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.Label lbNume;
        private System.Windows.Forms.Button btnAnuleaza;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.Label label2;
    }
}