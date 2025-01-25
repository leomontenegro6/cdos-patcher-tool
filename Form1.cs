using System;
using System.ComponentModel;
using System.Net;
using System.Windows.Forms;
using DarkModeForms;

namespace CDOSPatcher
{
    public partial class Form1 : Form
    {
        private DarkModeCS dm = null;

        public Form1()
        {
            InitializeComponent();
            dm = new DarkModeCS(this)
            {
                //[Optional] Choose your preferred color mode here:
                ColorMode = DarkModeCS.DisplayMode.SystemDefault
            };
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label_disable_magic_seals_Click(object sender, EventArgs e)
        {

        }

        private void label_enable_luck_soul_fixes_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dialogOpenRom.ShowDialog() == DialogResult.OK) {
                maskedTextBox1.Text = dialogOpenRom.FileName;
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void buttonGenerateTranslatedRom_Click(object sender, EventArgs e)
        {
            // Checando se a ROM foi fornecida.
            if (dialogOpenRom.FileName == "")
            {
                Messenger.MessageBox("ROM não fornecida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            textStatusIndicator.Text = "";

            // Checando se a ROM fornecida é válida.
            string checksumHex = Utils.CalculateFileCrc32(dialogOpenRom.FileName);
            textStatusIndicator.Text += "Validando checksum da rom fornecida... ";
            if (checksumHex != "135737f6")
            {
                textStatusIndicator.Text += "Inválido!\r\n";
                Messenger.MessageBox("Checksum inválido!\nVocê precisa passar a rom americana do Dawn of Sorrow, de crc32 135737f6.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            textStatusIndicator.Text += "OK.\r\n";

            // Iniciando processo de patching.
            textStatusIndicator.Text += "Aplicando patch xdelta da tradução original... ";
            Utils.ApplyTranslationPatch(dialogOpenRom.FileName);
            textStatusIndicator.Text += "OK.\r\n";

            if (checkboxEnableDawnDignity.Checked || checkboxDisableMagicSeals.Checked || checkboxEnableLuckSoulFixes.Checked)
            {
                if (checkboxEnableDawnDignity.Checked)
                {
                    textStatusIndicator.Text += "Aplicando patch armips de retratos do Dawn of Dignity... ";
                    Utils.ApplyDawnDignityPortraits();
                    textStatusIndicator.Text += "OK.\r\n";
                }

                if (checkboxDisableMagicSeals.Checked)
                {
                    textStatusIndicator.Text += "Aplicando patch IPS para desativar Selos Mágicos... ";
                    Utils.ApplyPatchDisableMagicSeals();
                    textStatusIndicator.Text += "OK.\r\n";
                }

                if (checkboxEnableLuckSoulFixes.Checked)
                {
                    textStatusIndicator.Text += "Aplicando patch IPS para ativar os fixes de sorte nula... ";
                    Utils.ApplyPatchEnableLuckSoulFixes();
                    textStatusIndicator.Text += "OK.\r\n";
                }
            }

            Messenger.MessageBox("ROM(s) traduzida(s) gerada(s) com sucesso.\nVerifique na pasta 'Nova_Rom'.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textStatusIndicator_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
