using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EncryptionApp.Properties;

namespace EncryptionApp
{
    public partial class passwordForm : Form
    {
        public passwordForm()
        {
            InitializeComponent();
            string key = "aaaaaaaabbbbbbbbccccccccdddddddd";
            string password = null;
            try
            {
                Globals.firstTime = 1;
                RegistryKey regKeyRead = Registry.CurrentUser.OpenSubKey("EncryptedPass");
                byte[] encPassByte = (byte[])regKeyRead.GetValue("pass");
                byte[] pass = EncryptionLib.Decrypt(key, encPassByte);
                password = Encoding.UTF8.GetString(pass);

            }
            catch (Exception)
            {
                
            }
            if (password == null)
            {
                Globals.firstTime = 0;
                string pass = "hero";
                RegistryKey regKey = Registry.CurrentUser.CreateSubKey("EncryptedPass");
                byte[] passBytes = Encoding.UTF8.GetBytes(pass);
                byte[] encPassword =EncryptionLib.Encrypt(key, passBytes);
                regKey.SetValue("pass", encPassword);
                //loginBtn.Image = EncryptionApp.Properties.Resources.icons8_invisible;

            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string key = "aaaaaaaabbbbbbbbccccccccdddddddd";
            string password = null;
            try
            {
                RegistryKey regKeyRead = Registry.CurrentUser.OpenSubKey("EncryptedPass");
                byte[] encPassByte = (byte[])regKeyRead.GetValue("pass");
                byte[] pass = EncryptionLib.Decrypt(key, encPassByte);
                password = Encoding.UTF8.GetString(pass);
              
            }
            catch (Exception)
            {
            }
            if (password == null)
            {
                string pass = "hero";
                RegistryKey regKey = Registry.CurrentUser.CreateSubKey("EncryptedPass");
                byte[] passBytes = Encoding.UTF8.GetBytes(pass);
                byte[] encPassword = EncryptionLib.Encrypt(key, passBytes);
                regKey.SetValue("pass", encPassword);

            }
            if (passwordTxt.Text== password)
            {
                this.Hide();
                Encryption_form form = new Encryption_form();
                form.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Password !!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void PasswordTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginBtn.PerformClick();
            }
        }

        public bool visible = false;
        private void BtnVisible_Click(object sender, EventArgs e)
        {
            if (!visible)
            {
                // show password text
                passwordTxt.UseSystemPasswordChar = false;
                btnVisible.Image = Resources.invisible_30px;
                visible = true;
            }
            else
            {
                // hide password text
                passwordTxt.UseSystemPasswordChar = true;
                btnVisible.Image = Resources.visible_30px;
                visible = false;
            }
        }
    }
}
