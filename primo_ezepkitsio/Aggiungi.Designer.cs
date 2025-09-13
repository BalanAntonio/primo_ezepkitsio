namespace primo_ezepkitsio
{
    partial class Aggiungi
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
            this.lbl_filtra = new System.Windows.Forms.Label();
            this.btn_filtra = new System.Windows.Forms.Button();
            this.txt_filtro = new System.Windows.Forms.TextBox();
            this.btn_visualizza = new System.Windows.Forms.Button();
            this.btn_aggiungi1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_filtra
            // 
            this.lbl_filtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Bold);
            this.lbl_filtra.Location = new System.Drawing.Point(121, 11);
            this.lbl_filtra.Name = "lbl_filtra";
            this.lbl_filtra.Size = new System.Drawing.Size(143, 18);
            this.lbl_filtra.TabIndex = 14;
            this.lbl_filtra.Text = "Filtra per prezzo";
            this.lbl_filtra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_filtra
            // 
            this.btn_filtra.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_filtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_filtra.Location = new System.Drawing.Point(131, 61);
            this.btn_filtra.Name = "btn_filtra";
            this.btn_filtra.Size = new System.Drawing.Size(123, 24);
            this.btn_filtra.TabIndex = 13;
            this.btn_filtra.Text = "Filtra";
            this.btn_filtra.UseVisualStyleBackColor = false;
            this.btn_filtra.Click += new System.EventHandler(this.btn_filtra_Click);
            // 
            // txt_filtro
            // 
            this.txt_filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_filtro.Location = new System.Drawing.Point(131, 32);
            this.txt_filtro.Name = "txt_filtro";
            this.txt_filtro.Size = new System.Drawing.Size(123, 22);
            this.txt_filtro.TabIndex = 12;
            // 
            // btn_visualizza
            // 
            this.btn_visualizza.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_visualizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_visualizza.Location = new System.Drawing.Point(12, 52);
            this.btn_visualizza.Name = "btn_visualizza";
            this.btn_visualizza.Size = new System.Drawing.Size(103, 34);
            this.btn_visualizza.TabIndex = 11;
            this.btn_visualizza.Text = "Visualizza";
            this.btn_visualizza.UseVisualStyleBackColor = false;
            this.btn_visualizza.Click += new System.EventHandler(this.btn_visualizza_Click);
            // 
            // btn_aggiungi1
            // 
            this.btn_aggiungi1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_aggiungi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aggiungi1.Location = new System.Drawing.Point(12, 12);
            this.btn_aggiungi1.Name = "btn_aggiungi1";
            this.btn_aggiungi1.Size = new System.Drawing.Size(103, 34);
            this.btn_aggiungi1.TabIndex = 15;
            this.btn_aggiungi1.Text = "Aggiungi P.";
            this.btn_aggiungi1.UseVisualStyleBackColor = false;
            this.btn_aggiungi1.Click += new System.EventHandler(this.btn_aggiungi1_Click);
            // 
            // Aggiungi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 99);
            this.Controls.Add(this.btn_aggiungi1);
            this.Controls.Add(this.lbl_filtra);
            this.Controls.Add(this.btn_filtra);
            this.Controls.Add(this.txt_filtro);
            this.Controls.Add(this.btn_visualizza);
            this.Name = "Aggiungi";
            this.Text = "Aggiungi";
            this.Load += new System.EventHandler(this.Aggiungi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_filtra;
        private System.Windows.Forms.Button btn_filtra;
        private System.Windows.Forms.TextBox txt_filtro;
        private System.Windows.Forms.Button btn_visualizza;
        private System.Windows.Forms.Button btn_aggiungi1;
    }
}