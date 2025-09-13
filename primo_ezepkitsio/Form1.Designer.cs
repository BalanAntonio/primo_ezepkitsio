namespace primo_ezepkitsio
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_aggiungi = new System.Windows.Forms.Button();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_prezzo = new System.Windows.Forms.Label();
            this.txt_prezzo = new System.Windows.Forms.TextBox();
            this.lbl_quantita = new System.Windows.Forms.Label();
            this.txt_quantita = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_aggiungi
            // 
            this.btn_aggiungi.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_aggiungi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aggiungi.Location = new System.Drawing.Point(12, 198);
            this.btn_aggiungi.Name = "btn_aggiungi";
            this.btn_aggiungi.Size = new System.Drawing.Size(252, 38);
            this.btn_aggiungi.TabIndex = 0;
            this.btn_aggiungi.Text = "Aggiungi P.";
            this.btn_aggiungi.UseVisualStyleBackColor = false;
            this.btn_aggiungi.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_nome
            // 
            this.txt_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_nome.Location = new System.Drawing.Point(12, 47);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(252, 20);
            this.txt_nome.TabIndex = 1;
            // 
            // lbl_nome
            // 
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(12, 21);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(252, 23);
            this.lbl_nome.TabIndex = 2;
            this.lbl_nome.Text = "Nome";
            this.lbl_nome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_prezzo
            // 
            this.lbl_prezzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prezzo.Location = new System.Drawing.Point(12, 76);
            this.lbl_prezzo.Name = "lbl_prezzo";
            this.lbl_prezzo.Size = new System.Drawing.Size(252, 23);
            this.lbl_prezzo.TabIndex = 4;
            this.lbl_prezzo.Text = "Prezzo";
            this.lbl_prezzo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_prezzo
            // 
            this.txt_prezzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_prezzo.Location = new System.Drawing.Point(12, 102);
            this.txt_prezzo.Name = "txt_prezzo";
            this.txt_prezzo.Size = new System.Drawing.Size(252, 20);
            this.txt_prezzo.TabIndex = 3;
            // 
            // lbl_quantita
            // 
            this.lbl_quantita.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantita.Location = new System.Drawing.Point(12, 135);
            this.lbl_quantita.Name = "lbl_quantita";
            this.lbl_quantita.Size = new System.Drawing.Size(252, 23);
            this.lbl_quantita.TabIndex = 6;
            this.lbl_quantita.Text = "Quantità";
            this.lbl_quantita.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_quantita
            // 
            this.txt_quantita.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_quantita.Location = new System.Drawing.Point(12, 161);
            this.txt_quantita.Name = "txt_quantita";
            this.txt_quantita.Size = new System.Drawing.Size(252, 20);
            this.txt_quantita.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 248);
            this.Controls.Add(this.lbl_quantita);
            this.Controls.Add(this.txt_quantita);
            this.Controls.Add(this.lbl_prezzo);
            this.Controls.Add(this.txt_prezzo);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.btn_aggiungi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_aggiungi;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_prezzo;
        private System.Windows.Forms.TextBox txt_prezzo;
        private System.Windows.Forms.Label lbl_quantita;
        private System.Windows.Forms.TextBox txt_quantita;
    }
}

