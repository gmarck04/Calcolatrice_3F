namespace esercizio_form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bottone1btn = new System.Windows.Forms.Button();
            this.numero1Txt = new System.Windows.Forms.TextBox();
            this.numero2Txt = new System.Windows.Forms.TextBox();
            this.risultatoTxt = new System.Windows.Forms.TextBox();
            this.risMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cancellaMemoriaStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bottone2btn = new System.Windows.Forms.Button();
            this.testoTB = new System.Windows.Forms.TextBox();
            this.maiuscoleBtn = new System.Windows.Forms.Button();
            this.ControlloFontBtn = new System.Windows.Forms.Button();
            this.risMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // bottone1btn
            // 
            this.bottone1btn.ForeColor = System.Drawing.Color.Coral;
            this.bottone1btn.Location = new System.Drawing.Point(148, 167);
            this.bottone1btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bottone1btn.Name = "bottone1btn";
            this.bottone1btn.Size = new System.Drawing.Size(112, 34);
            this.bottone1btn.TabIndex = 0;
            this.bottone1btn.Text = "+";
            this.bottone1btn.UseVisualStyleBackColor = true;
            this.bottone1btn.Click += new System.EventHandler(this.bottone1btn_Click);
            // 
            // numero1Txt
            // 
            this.numero1Txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.numero1Txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.numero1Txt.Location = new System.Drawing.Point(13, 171);
            this.numero1Txt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numero1Txt.Name = "numero1Txt";
            this.numero1Txt.Size = new System.Drawing.Size(127, 26);
            this.numero1Txt.TabIndex = 1;
            this.numero1Txt.TextChanged += new System.EventHandler(this.testo1Txt_TextChanged);
            // 
            // numero2Txt
            // 
            this.numero2Txt.Location = new System.Drawing.Point(268, 171);
            this.numero2Txt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numero2Txt.Name = "numero2Txt";
            this.numero2Txt.Size = new System.Drawing.Size(135, 26);
            this.numero2Txt.TabIndex = 2;
            this.numero2Txt.TextChanged += new System.EventHandler(this.testo2Txt_TextChanged);
            // 
            // risultatoTxt
            // 
            this.risultatoTxt.ContextMenuStrip = this.risMenuStrip;
            this.risultatoTxt.Enabled = false;
            this.risultatoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.risultatoTxt.Location = new System.Drawing.Point(531, 171);
            this.risultatoTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.risultatoTxt.Name = "risultatoTxt";
            this.risultatoTxt.Size = new System.Drawing.Size(112, 26);
            this.risultatoTxt.TabIndex = 3;
            this.risultatoTxt.TextChanged += new System.EventHandler(this.testo3Txt_TextChanged);
            // 
            // risMenuStrip
            // 
            this.risMenuStrip.BackColor = System.Drawing.Color.Honeydew;
            this.risMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.risMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancellaMemoriaStripMenuItem});
            this.risMenuStrip.Name = "risMenuStrip";
            this.risMenuStrip.Size = new System.Drawing.Size(225, 34);
            // 
            // cancellaMemoriaStripMenuItem
            // 
            this.cancellaMemoriaStripMenuItem.BackColor = System.Drawing.Color.GreenYellow;
            this.cancellaMemoriaStripMenuItem.Name = "cancellaMemoriaStripMenuItem";
            this.cancellaMemoriaStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.cancellaMemoriaStripMenuItem.Text = "Cancella memoria";
            // 
            // bottone2btn
            // 
            this.bottone2btn.ForeColor = System.Drawing.Color.Coral;
            this.bottone2btn.Location = new System.Drawing.Point(411, 167);
            this.bottone2btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bottone2btn.Name = "bottone2btn";
            this.bottone2btn.Size = new System.Drawing.Size(112, 34);
            this.bottone2btn.TabIndex = 4;
            this.bottone2btn.Text = "=";
            this.bottone2btn.UseVisualStyleBackColor = true;
            this.bottone2btn.Click += new System.EventHandler(this.bottone2btn_Click);
            // 
            // testoTB
            // 
            this.testoTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testoTB.Location = new System.Drawing.Point(13, 52);
            this.testoTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.testoTB.Multiline = true;
            this.testoTB.Name = "testoTB";
            this.testoTB.Size = new System.Drawing.Size(472, 105);
            this.testoTB.TabIndex = 8;
            this.testoTB.Text = "Calcolatrice\r\n\r\nSommatrice";
            this.testoTB.TextChanged += new System.EventHandler(this.testoTB_TextChanged);
            // 
            // maiuscoleBtn
            // 
            this.maiuscoleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maiuscoleBtn.ForeColor = System.Drawing.Color.Coral;
            this.maiuscoleBtn.Location = new System.Drawing.Point(493, 52);
            this.maiuscoleBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.maiuscoleBtn.Name = "maiuscoleBtn";
            this.maiuscoleBtn.Size = new System.Drawing.Size(150, 34);
            this.maiuscoleBtn.TabIndex = 7;
            this.maiuscoleBtn.Text = "MAIUSCOLE";
            this.maiuscoleBtn.UseVisualStyleBackColor = true;
            this.maiuscoleBtn.Click += new System.EventHandler(this.maiuscoleBtn_Click);
            // 
            // ControlloFontBtn
            // 
            this.ControlloFontBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ControlloFontBtn.ForeColor = System.Drawing.Color.Coral;
            this.ControlloFontBtn.Location = new System.Drawing.Point(531, 256);
            this.ControlloFontBtn.Name = "ControlloFontBtn";
            this.ControlloFontBtn.Size = new System.Drawing.Size(112, 74);
            this.ControlloFontBtn.TabIndex = 9;
            this.ControlloFontBtn.Text = "Controllo grassetto";
            this.ControlloFontBtn.UseVisualStyleBackColor = true;
            this.ControlloFontBtn.Click += new System.EventHandler(this.ControlloFontBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(666, 342);
            this.Controls.Add(this.ControlloFontBtn);
            this.Controls.Add(this.testoTB);
            this.Controls.Add(this.maiuscoleBtn);
            this.Controls.Add(this.bottone2btn);
            this.Controls.Add(this.risultatoTxt);
            this.Controls.Add(this.numero2Txt);
            this.Controls.Add(this.numero1Txt);
            this.Controls.Add(this.bottone1btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calcolatrice";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.risMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bottone1btn;
        private System.Windows.Forms.TextBox numero1Txt;
        private System.Windows.Forms.TextBox numero2Txt;
        private System.Windows.Forms.TextBox risultatoTxt;
        private System.Windows.Forms.Button bottone2btn;
        private System.Windows.Forms.TextBox testoTB;
        private System.Windows.Forms.Button maiuscoleBtn;
        private System.Windows.Forms.ContextMenuStrip risMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem cancellaMemoriaStripMenuItem;
        private System.Windows.Forms.Button ControlloFontBtn;
    }
}

