namespace Otobüs
{
    partial class KayıtForm
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
            this.textBoxisim = new System.Windows.Forms.TextBox();
            this.textBoxsoyisim = new System.Windows.Forms.TextBox();
            this.maskedTextBoxtelefon = new System.Windows.Forms.MaskedTextBox();
            this.radioButtonBAY = new System.Windows.Forms.RadioButton();
            this.radioButton2BAYAN = new System.Windows.Forms.RadioButton();
            this.buttonKayıtOluştur = new System.Windows.Forms.Button();
            this.buttonKayıtİptal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxisim
            // 
            this.textBoxisim.Location = new System.Drawing.Point(120, 37);
            this.textBoxisim.Name = "textBoxisim";
            this.textBoxisim.Size = new System.Drawing.Size(234, 20);
            this.textBoxisim.TabIndex = 1;
            
            // 
            // textBoxsoyisim
            // 
            this.textBoxsoyisim.Location = new System.Drawing.Point(120, 99);
            this.textBoxsoyisim.Name = "textBoxsoyisim";
            this.textBoxsoyisim.Size = new System.Drawing.Size(234, 20);
            this.textBoxsoyisim.TabIndex = 1;
            // 
            // maskedTextBoxtelefon
            // 
            this.maskedTextBoxtelefon.Location = new System.Drawing.Point(121, 160);
            this.maskedTextBoxtelefon.Mask = "(999) 000-0000";
            this.maskedTextBoxtelefon.Name = "maskedTextBoxtelefon";
            this.maskedTextBoxtelefon.Size = new System.Drawing.Size(233, 20);
            this.maskedTextBoxtelefon.TabIndex = 3;
            // 
            // radioButtonBAY
            // 
            this.radioButtonBAY.AutoSize = true;
            this.radioButtonBAY.BackColor = System.Drawing.SystemColors.Control;
            this.radioButtonBAY.Checked = true;
            this.radioButtonBAY.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonBAY.ForeColor = System.Drawing.Color.Black;
            this.radioButtonBAY.Location = new System.Drawing.Point(152, 217);
            this.radioButtonBAY.Name = "radioButtonBAY";
            this.radioButtonBAY.Size = new System.Drawing.Size(60, 25);
            this.radioButtonBAY.TabIndex = 4;
            this.radioButtonBAY.TabStop = true;
            this.radioButtonBAY.Text = "BAY";
            this.radioButtonBAY.UseVisualStyleBackColor = false;
            // 
            // radioButton2BAYAN
            // 
            this.radioButton2BAYAN.AutoSize = true;
            this.radioButton2BAYAN.BackColor = System.Drawing.SystemColors.Control;
            this.radioButton2BAYAN.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton2BAYAN.ForeColor = System.Drawing.Color.Black;
            this.radioButton2BAYAN.Location = new System.Drawing.Point(258, 217);
            this.radioButton2BAYAN.Name = "radioButton2BAYAN";
            this.radioButton2BAYAN.Size = new System.Drawing.Size(83, 25);
            this.radioButton2BAYAN.TabIndex = 5;
            this.radioButton2BAYAN.Text = "BAYAN";
            this.radioButton2BAYAN.UseVisualStyleBackColor = false;
            // 
            // buttonKayıtOluştur
            // 
            this.buttonKayıtOluştur.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonKayıtOluştur.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKayıtOluştur.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonKayıtOluştur.Location = new System.Drawing.Point(120, 273);
            this.buttonKayıtOluştur.Name = "buttonKayıtOluştur";
            this.buttonKayıtOluştur.Size = new System.Drawing.Size(104, 39);
            this.buttonKayıtOluştur.TabIndex = 6;
            this.buttonKayıtOluştur.Text = "SATIŞ";
            this.buttonKayıtOluştur.UseVisualStyleBackColor = false;
            this.buttonKayıtOluştur.Click += new System.EventHandler(this.buttonKayıtOluştur_Click);
            // 
            // buttonKayıtİptal
            // 
            this.buttonKayıtİptal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonKayıtİptal.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKayıtİptal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonKayıtİptal.Location = new System.Drawing.Point(249, 273);
            this.buttonKayıtİptal.Name = "buttonKayıtİptal";
            this.buttonKayıtİptal.Size = new System.Drawing.Size(105, 39);
            this.buttonKayıtİptal.TabIndex = 7;
            this.buttonKayıtİptal.Text = "İPTAL ET";
            this.buttonKayıtİptal.UseVisualStyleBackColor = false;
            this.buttonKayıtİptal.Click += new System.EventHandler(this.buttonKayıtİptal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(213, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "İSİM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(195, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "TELEFON";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(195, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "SOYİSİM";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // KayıtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(460, 324);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKayıtİptal);
            this.Controls.Add(this.buttonKayıtOluştur);
            this.Controls.Add(this.radioButton2BAYAN);
            this.Controls.Add(this.radioButtonBAY);
            this.Controls.Add(this.maskedTextBoxtelefon);
            this.Controls.Add(this.textBoxsoyisim);
            this.Controls.Add(this.textBoxisim);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KayıtForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt Bilgi Ekranı";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonKayıtOluştur;
        private System.Windows.Forms.Button buttonKayıtİptal;
        public System.Windows.Forms.TextBox textBoxisim;
        public System.Windows.Forms.TextBox textBoxsoyisim;
        public System.Windows.Forms.MaskedTextBox maskedTextBoxtelefon;
        public System.Windows.Forms.RadioButton radioButtonBAY;
        public System.Windows.Forms.RadioButton radioButton2BAYAN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}