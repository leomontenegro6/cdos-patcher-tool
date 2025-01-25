namespace CDOSPatcher
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.checkboxEnableDawnDignity = new System.Windows.Forms.CheckBox();
            this.checkboxDisableMagicSeals = new System.Windows.Forms.CheckBox();
            this.checkboxEnableLuckSoulFixes = new System.Windows.Forms.CheckBox();
            this.buttonGenerateTranslatedRom = new System.Windows.Forms.Button();
            this.labelEnableDawnDignity = new System.Windows.Forms.Label();
            this.labelDisableMagicSeals = new System.Windows.Forms.Label();
            this.labelEnableLuckSoulFixes = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.buttonOpenRom = new System.Windows.Forms.Button();
            this.dialogOpenRom = new System.Windows.Forms.OpenFileDialog();
            this.textStatusIndicator = new System.Windows.Forms.TextBox();
            this.coverImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.coverImage)).BeginInit();
            this.SuspendLayout();
            // 
            // checkboxEnableDawnDignity
            // 
            this.checkboxEnableDawnDignity.AutoSize = true;
            this.checkboxEnableDawnDignity.Location = new System.Drawing.Point(302, 46);
            this.checkboxEnableDawnDignity.Margin = new System.Windows.Forms.Padding(2);
            this.checkboxEnableDawnDignity.Name = "checkboxEnableDawnDignity";
            this.checkboxEnableDawnDignity.Size = new System.Drawing.Size(169, 17);
            this.checkboxEnableDawnDignity.TabIndex = 1;
            this.checkboxEnableDawnDignity.Text = "Retratos do \"Dawn of Dignity\"";
            this.checkboxEnableDawnDignity.UseVisualStyleBackColor = true;
            this.checkboxEnableDawnDignity.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkboxDisableMagicSeals
            // 
            this.checkboxDisableMagicSeals.AutoSize = true;
            this.checkboxDisableMagicSeals.Location = new System.Drawing.Point(302, 107);
            this.checkboxDisableMagicSeals.Margin = new System.Windows.Forms.Padding(2);
            this.checkboxDisableMagicSeals.Name = "checkboxDisableMagicSeals";
            this.checkboxDisableMagicSeals.Size = new System.Drawing.Size(143, 17);
            this.checkboxDisableMagicSeals.TabIndex = 2;
            this.checkboxDisableMagicSeals.Text = "Desativar Selos Mágicos";
            this.checkboxDisableMagicSeals.UseVisualStyleBackColor = true;
            // 
            // checkboxEnableLuckSoulFixes
            // 
            this.checkboxEnableLuckSoulFixes.AutoSize = true;
            this.checkboxEnableLuckSoulFixes.Location = new System.Drawing.Point(302, 187);
            this.checkboxEnableLuckSoulFixes.Margin = new System.Windows.Forms.Padding(2);
            this.checkboxEnableLuckSoulFixes.Name = "checkboxEnableLuckSoulFixes";
            this.checkboxEnableLuckSoulFixes.Size = new System.Drawing.Size(254, 17);
            this.checkboxEnableLuckSoulFixes.TabIndex = 3;
            this.checkboxEnableLuckSoulFixes.Text = "Ativar fixes de sorte nula ao pegar almas e drops";
            this.checkboxEnableLuckSoulFixes.UseVisualStyleBackColor = true;
            // 
            // buttonGenerateTranslatedRom
            // 
            this.buttonGenerateTranslatedRom.Location = new System.Drawing.Point(379, 263);
            this.buttonGenerateTranslatedRom.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGenerateTranslatedRom.Name = "buttonGenerateTranslatedRom";
            this.buttonGenerateTranslatedRom.Size = new System.Drawing.Size(134, 25);
            this.buttonGenerateTranslatedRom.TabIndex = 4;
            this.buttonGenerateTranslatedRom.Text = "Gerar ROM Traduzida";
            this.buttonGenerateTranslatedRom.UseVisualStyleBackColor = true;
            this.buttonGenerateTranslatedRom.Click += new System.EventHandler(this.buttonGenerateTranslatedRom_Click);
            // 
            // labelEnableDawnDignity
            // 
            this.labelEnableDawnDignity.AutoSize = true;
            this.labelEnableDawnDignity.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnableDawnDignity.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelEnableDawnDignity.Location = new System.Drawing.Point(319, 65);
            this.labelEnableDawnDignity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEnableDawnDignity.Name = "labelEnableDawnDignity";
            this.labelEnableDawnDignity.Size = new System.Drawing.Size(204, 32);
            this.labelEnableDawnDignity.TabIndex = 5;
            this.labelEnableDawnDignity.Text = "Troca os avatares padrões de anime\r\npor avatares góticos no estilo da Ayami Kojim" +
    "a";
            this.labelEnableDawnDignity.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelDisableMagicSeals
            // 
            this.labelDisableMagicSeals.AutoSize = true;
            this.labelDisableMagicSeals.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisableMagicSeals.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelDisableMagicSeals.Location = new System.Drawing.Point(319, 127);
            this.labelDisableMagicSeals.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDisableMagicSeals.Name = "labelDisableMagicSeals";
            this.labelDisableMagicSeals.Size = new System.Drawing.Size(251, 48);
            this.labelDisableMagicSeals.TabIndex = 6;
            this.labelDisableMagicSeals.Text = "Permite derrotar bosses sem precisar selá-los. Ideal\r\npara jogadores sem touch-sc" +
    "reen, jogadores de\r\nportáteis chineses, ou só pra quem desgosta da mecânica.";
            this.labelDisableMagicSeals.Click += new System.EventHandler(this.label_disable_magic_seals_Click);
            // 
            // labelEnableLuckSoulFixes
            // 
            this.labelEnableLuckSoulFixes.AutoSize = true;
            this.labelEnableLuckSoulFixes.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnableLuckSoulFixes.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelEnableLuckSoulFixes.Location = new System.Drawing.Point(319, 206);
            this.labelEnableLuckSoulFixes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEnableLuckSoulFixes.Name = "labelEnableLuckSoulFixes";
            this.labelEnableLuckSoulFixes.Size = new System.Drawing.Size(242, 48);
            this.labelEnableLuckSoulFixes.TabIndex = 7;
            this.labelEnableLuckSoulFixes.Text = "Altera a lógica padrão de sorte, para fazer com que sorte\r\nelevada de fato faça d" +
    "iferença significativa ao pegar\r\nalmas de monstros.";
            this.labelEnableLuckSoulFixes.Click += new System.EventHandler(this.label_enable_luck_soul_fixes_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Enabled = false;
            this.maskedTextBox1.Location = new System.Drawing.Point(302, 10);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.ReadOnly = true;
            this.maskedTextBox1.Size = new System.Drawing.Size(199, 20);
            this.maskedTextBox1.TabIndex = 8;
            // 
            // buttonOpenRom
            // 
            this.buttonOpenRom.Location = new System.Drawing.Point(505, 8);
            this.buttonOpenRom.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpenRom.Name = "buttonOpenRom";
            this.buttonOpenRom.Size = new System.Drawing.Size(73, 22);
            this.buttonOpenRom.TabIndex = 9;
            this.buttonOpenRom.Text = "Abrir ROM";
            this.buttonOpenRom.UseVisualStyleBackColor = true;
            this.buttonOpenRom.Click += new System.EventHandler(this.button1_Click);
            // 
            // dialogOpenRom
            // 
            this.dialogOpenRom.Filter = "NDS Files (*.nds)|*.nds|All files (*.*)|*.*";
            this.dialogOpenRom.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // textStatusIndicator
            // 
            this.textStatusIndicator.Enabled = false;
            this.textStatusIndicator.Location = new System.Drawing.Point(4, 296);
            this.textStatusIndicator.Multiline = true;
            this.textStatusIndicator.Name = "textStatusIndicator";
            this.textStatusIndicator.ReadOnly = true;
            this.textStatusIndicator.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textStatusIndicator.Size = new System.Drawing.Size(574, 152);
            this.textStatusIndicator.TabIndex = 11;
            // 
            // coverImage
            // 
            this.coverImage.BackgroundImage = global::CDOSPatcher.Properties.Resources.cdos_cover;
            this.coverImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.coverImage.Location = new System.Drawing.Point(0, 0);
            this.coverImage.Margin = new System.Windows.Forms.Padding(0);
            this.coverImage.Name = "coverImage";
            this.coverImage.Size = new System.Drawing.Size(300, 284);
            this.coverImage.TabIndex = 0;
            this.coverImage.TabStop = false;
            this.coverImage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(584, 452);
            this.Controls.Add(this.textStatusIndicator);
            this.Controls.Add(this.buttonOpenRom);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.labelEnableLuckSoulFixes);
            this.Controls.Add(this.labelDisableMagicSeals);
            this.Controls.Add(this.labelEnableDawnDignity);
            this.Controls.Add(this.buttonGenerateTranslatedRom);
            this.Controls.Add(this.checkboxEnableLuckSoulFixes);
            this.Controls.Add(this.checkboxDisableMagicSeals);
            this.Controls.Add(this.checkboxEnableDawnDignity);
            this.Controls.Add(this.coverImage);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(604, 495);
            this.MinimumSize = new System.Drawing.Size(604, 495);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CDOS Patch Tool";
            ((System.ComponentModel.ISupportInitialize)(this.coverImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox coverImage;
        private System.Windows.Forms.CheckBox checkboxEnableDawnDignity;
        private System.Windows.Forms.CheckBox checkboxDisableMagicSeals;
        private System.Windows.Forms.CheckBox checkboxEnableLuckSoulFixes;
        private System.Windows.Forms.Button buttonGenerateTranslatedRom;
        private System.Windows.Forms.Label labelEnableDawnDignity;
        private System.Windows.Forms.Label labelDisableMagicSeals;
        private System.Windows.Forms.Label labelEnableLuckSoulFixes;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button buttonOpenRom;
        private System.Windows.Forms.OpenFileDialog dialogOpenRom;
        private System.Windows.Forms.TextBox textStatusIndicator;
    }
}

