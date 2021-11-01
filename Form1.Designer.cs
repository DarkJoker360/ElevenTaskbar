namespace ElevenTaskbar
{
    partial class ElevenTaskbar
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.boxSixe = new System.Windows.Forms.ComboBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boxSixe
            // 
            this.boxSixe.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.boxSixe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxSixe.FormattingEnabled = true;
            this.boxSixe.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.boxSixe.Items.AddRange(new object[] {
            "Small",
            "Default",
            "Big"});
            this.boxSixe.Location = new System.Drawing.Point(125, 90);
            this.boxSixe.Name = "boxSixe";
            this.boxSixe.Size = new System.Drawing.Size(141, 21);
            this.boxSixe.TabIndex = 0;
            this.boxSixe.SelectedIndexChanged += new System.EventHandler(this.boxSixe_SelectedIndexChanged);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(162, 148);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 1;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // ElevenTaskbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 219);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.boxSixe);
            this.MaximizeBox = false;
            this.Name = "ElevenTaskbar";
            this.Text = "ElevenTaskbar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox boxSixe;
        private System.Windows.Forms.Button btnApply;
    }
}

