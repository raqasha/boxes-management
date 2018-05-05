namespace Krd4
{
    partial class AdminMainWindow
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
            this.comboBoxTypeOfUser = new System.Windows.Forms.ComboBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.dataGridViewAllUsers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxTypeOfUser
            // 
            this.comboBoxTypeOfUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxTypeOfUser.FormattingEnabled = true;
            this.comboBoxTypeOfUser.Location = new System.Drawing.Point(266, 12);
            this.comboBoxTypeOfUser.Name = "comboBoxTypeOfUser";
            this.comboBoxTypeOfUser.Size = new System.Drawing.Size(121, 23);
            this.comboBoxTypeOfUser.TabIndex = 17;
            this.comboBoxTypeOfUser.Text = "Wybierz uprawnienia";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPassword.Location = new System.Drawing.Point(146, 12);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(105, 21);
            this.textBoxPassword.TabIndex = 16;
            this.textBoxPassword.Text = "Wpisz hasło";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxLogin.Location = new System.Drawing.Point(12, 12);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(118, 21);
            this.textBoxLogin.TabIndex = 15;
            this.textBoxLogin.Text = "Wpisz login";
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonDeleteUser.FlatAppearance.BorderSize = 0;
            this.buttonDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDeleteUser.Location = new System.Drawing.Point(393, 46);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(129, 35);
            this.buttonDeleteUser.TabIndex = 14;
            this.buttonDeleteUser.Text = "Usuń użytkownika";
            this.buttonDeleteUser.UseVisualStyleBackColor = false;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonAddUser.FlatAppearance.BorderSize = 0;
            this.buttonAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddUser.Location = new System.Drawing.Point(393, 5);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(129, 35);
            this.buttonAddUser.TabIndex = 13;
            this.buttonAddUser.Text = "Dodaj użytkownika";
            this.buttonAddUser.UseVisualStyleBackColor = false;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // dataGridViewAllUsers
            // 
            this.dataGridViewAllUsers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewAllUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllUsers.Location = new System.Drawing.Point(53, 87);
            this.dataGridViewAllUsers.Name = "dataGridViewAllUsers";
            this.dataGridViewAllUsers.Size = new System.Drawing.Size(428, 264);
            this.dataGridViewAllUsers.TabIndex = 12;
            // 
            // AdminMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 377);
            this.Controls.Add(this.comboBoxTypeOfUser);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.buttonDeleteUser);
            this.Controls.Add(this.buttonAddUser);
            this.Controls.Add(this.dataGridViewAllUsers);
            this.Name = "AdminMainWindow";
            this.Text = "AdminMainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTypeOfUser;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.DataGridView dataGridViewAllUsers;
    }
}