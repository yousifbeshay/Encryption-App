namespace EncryptionApp
{
    partial class Encryption_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Encryption_form));
            this.browse_btn = new System.Windows.Forms.Button();
            this.encrypt_btn = new System.Windows.Forms.Button();
            this.path_txt = new System.Windows.Forms.TextBox();
            this.decrypt_btn = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // browse_btn
            // 
            this.browse_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browse_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browse_btn.Location = new System.Drawing.Point(888, 59);
            this.browse_btn.Name = "browse_btn";
            this.browse_btn.Size = new System.Drawing.Size(134, 38);
            this.browse_btn.TabIndex = 0;
            this.browse_btn.Text = "Browse File";
            this.browse_btn.UseVisualStyleBackColor = true;
            this.browse_btn.Click += new System.EventHandler(this.Browse_btn_Click);
            // 
            // encrypt_btn
            // 
            this.encrypt_btn.BackColor = System.Drawing.Color.ForestGreen;
            this.encrypt_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.encrypt_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.encrypt_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encrypt_btn.Image = ((System.Drawing.Image)(resources.GetObject("encrypt_btn.Image")));
            this.encrypt_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.encrypt_btn.Location = new System.Drawing.Point(161, 119);
            this.encrypt_btn.Name = "encrypt_btn";
            this.encrypt_btn.Size = new System.Drawing.Size(345, 60);
            this.encrypt_btn.TabIndex = 1;
            this.encrypt_btn.Text = "Encrypt";
            this.encrypt_btn.UseVisualStyleBackColor = false;
            this.encrypt_btn.Click += new System.EventHandler(this.Encrypt_btn_Click);
            // 
            // path_txt
            // 
            this.path_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.path_txt.Location = new System.Drawing.Point(161, 59);
            this.path_txt.Name = "path_txt";
            this.path_txt.Size = new System.Drawing.Size(707, 38);
            this.path_txt.TabIndex = 3;
            this.path_txt.TextChanged += new System.EventHandler(this.Path_txt_TextChanged);
            // 
            // decrypt_btn
            // 
            this.decrypt_btn.BackColor = System.Drawing.Color.Red;
            this.decrypt_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.decrypt_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.decrypt_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decrypt_btn.Image = ((System.Drawing.Image)(resources.GetObject("decrypt_btn.Image")));
            this.decrypt_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.decrypt_btn.Location = new System.Drawing.Point(523, 119);
            this.decrypt_btn.Name = "decrypt_btn";
            this.decrypt_btn.Size = new System.Drawing.Size(345, 60);
            this.decrypt_btn.TabIndex = 4;
            this.decrypt_btn.Text = "Decrypt";
            this.decrypt_btn.UseVisualStyleBackColor = false;
            this.decrypt_btn.Click += new System.EventHandler(this.Decrypt_btn_Click);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPath.Location = new System.Drawing.Point(12, 62);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(143, 32);
            this.lblPath.TabIndex = 5;
            this.lblPath.Text = "File Path :";
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Image = ((System.Drawing.Image)(resources.GetObject("clearBtn.Image")));
            this.clearBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clearBtn.Location = new System.Drawing.Point(925, 121);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(97, 60);
            this.clearBtn.TabIndex = 6;
            this.clearBtn.Text = "Clear Path";
            this.clearBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(14, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Made By Yousif Beshay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(954, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "V 1.2.0";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.Teal;
            this.btnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.Image = ((System.Drawing.Image)(resources.GetObject("btnChangePassword.Image")));
            this.btnChangePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChangePassword.Location = new System.Drawing.Point(161, 196);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(707, 60);
            this.btnChangePassword.TabIndex = 9;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.BtnChangePassword_Click);
            // 
            // Encryption_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 326);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.decrypt_btn);
            this.Controls.Add(this.path_txt);
            this.Controls.Add(this.encrypt_btn);
            this.Controls.Add(this.browse_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Encryption_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encryption App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Encryption_form_FormClosing);
            this.Load += new System.EventHandler(this.Encryption_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browse_btn;
        private System.Windows.Forms.Button encrypt_btn;
        private System.Windows.Forms.TextBox path_txt;
        private System.Windows.Forms.Button decrypt_btn;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChangePassword;
    }
}

