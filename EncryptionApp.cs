using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EncryptionApp
{
    public partial class Encryption_form : Form
    {
        public Encryption_form()
        {
            InitializeComponent();
        }
        string filePath = "";

        byte[] encryptedFile = null;
        byte[] fileToEncrypt = null;

        byte[] decryptedFile = null;
        byte[] fileToDecrypt = null;

        string password = "aaaaaaaabbbbbbbbccccccccdddddddd";

        private void Browse_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog()==DialogResult.OK)
            {
                path_txt.Text = ofd.FileName;
                filePath= ofd.FileName;
            }

        }

        private void Encrypt_btn_Click(object sender, EventArgs e)
        {
            try
            {
                fileToEncrypt = File.ReadAllBytes(filePath);
                encryptedFile = EncryptionLib.Encrypt(password, fileToEncrypt);
            }
            catch (Exception)
            {

                MessageBox.Show("Invalid Path. Please make sure that you have chosen a file !!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (encryptedFile!= null)
            {
                File.WriteAllBytes(filePath, encryptedFile);
                MessageBox.Show("The file has been Encrypted Successfully","Info",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                

            }
            else
            {
                MessageBox.Show("Encryption Failed !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Decrypt_btn_Click(object sender, EventArgs e)
        {
            try
            {
                fileToDecrypt = File.ReadAllBytes(filePath);
                decryptedFile = EncryptionLib.Decrypt(password, fileToDecrypt);
            }
            catch (Exception)
            {

                MessageBox.Show("Invalid Path. Please make sure that you have chosen a file !!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            

            if (decryptedFile!= null)
            {
                File.WriteAllBytes(filePath, decryptedFile);
                MessageBox.Show("The file has been Decrypted Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                //MessageBox.Show("Decryption Failed !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            path_txt.Text = "";
        }

        private void Encryption_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Path_txt_TextChanged(object sender, EventArgs e)
        {
            filePath = path_txt.Text;
        }

        private void Encryption_form_Load(object sender, EventArgs e)
        {

        }

        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword();
            frm.ShowDialog();
        }
    }
}
