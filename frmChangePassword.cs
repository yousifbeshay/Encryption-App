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
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            string key = "aaaaaaaabbbbbbbbccccccccdddddddd";

            // Check is the Confimed password match the new Password
            if (txtNewPassword.Text!=txtConfirmNewPassword.Text)
            {
                MessageBox.Show("The new Password doesn't match the confirmation Password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string currentPass = null;
            try
            {
                // Reading the password from the computer's local Registry
                RegistryKey regKeyRead = Registry.CurrentUser.OpenSubKey("EncryptedPass");
                byte[] encPassByte = (byte[])regKeyRead.GetValue("pass");
                byte[] pass = EncryptionLib.Decrypt(key, encPassByte);
                currentPass = Encoding.UTF8.GetString(pass);
            }
            catch (Exception)
            {
            }
            if (currentPass == null)
            {
                /* the password is set to "hero" if there isn't a saved password ( will only happens if Someone deletes 
                the registry value while the app is still running */
                string pass = "hero"; // default password
                RegistryKey regKey = Registry.CurrentUser.CreateSubKey("EncryptedPass");
                byte[] passBytess = Encoding.UTF8.GetBytes(pass);
                byte[] encPasswordd = EncryptionLib.Encrypt(key, passBytess);
                regKey.SetValue("pass", encPasswordd);
            }
            // Check if the user knows the old password in order to change it.
            if (currentPass != txtOldPassword.Text)
            {
                MessageBox.Show($"Old Password is incorrect !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Saving the New Password to the Registry
            string password = txtNewPassword.Text;
            RegistryKey regKeyWrite = Registry.CurrentUser.CreateSubKey("EncryptedPass");
            byte[] passBytes = Encoding.UTF8.GetBytes(password);
            byte[] encPassword = EncryptionLib.Encrypt(key, passBytes);
            regKeyWrite.SetValue("pass", encPassword);
            MessageBox.Show($"Password was changed Successfully ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Close();
        }
        public bool visible = false;
        public bool visible2 = false;
        public bool visible3 = false;
        private void BtnVisibleOld_Click(object sender, EventArgs e)
        {
            if (!visible)
            {
                // show password text
                txtOldPassword.UseSystemPasswordChar = false;
                btnVisibleOld.Image = Resources.visible_30px;
                visible = true;
            }
            else
            {
                // hide password text
                txtOldPassword.UseSystemPasswordChar = true;
                btnVisibleOld.Image = Resources.invisible_30px;

                visible = false;
            }
        }

        private void BtnVisibleNew_Click(object sender, EventArgs e)
        {
            if (!visible2)
            {
                // show password text
                txtNewPassword.UseSystemPasswordChar = false;
                btnVisibleNew.Image = Resources.visible_30px;
                visible2 = true;
            }
            else
            {
                // hide password text
                txtNewPassword.UseSystemPasswordChar = true;
                btnVisibleNew.Image = Resources.invisible_30px;
                visible2 = false;
            }
        }

        private void BtnVisibleConfirm_Click(object sender, EventArgs e)
        {
            if (!visible3)
            {
                // show password text
                txtConfirmNewPassword.UseSystemPasswordChar = false;
                btnVisibleConfirm.Image = Resources.visible_30px;
                visible3 = true;
            }
            else
            {
                // hide password text
                txtConfirmNewPassword.UseSystemPasswordChar = true;
                btnVisibleConfirm.Image = Resources.invisible_30px;

                visible3 = false;
            }
        }
    }
}
