namespace Krd4
{
    partial class MainWindow
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
            this.buttonUserManagement = new System.Windows.Forms.Button();
            this.buttonBoxManagement = new System.Windows.Forms.Button();
            this.buttonCheckStatus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonUserManagement
            // 
            this.buttonUserManagement.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonUserManagement.FlatAppearance.BorderSize = 0;
            this.buttonUserManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUserManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUserManagement.Location = new System.Drawing.Point(55, 131);
            this.buttonUserManagement.Name = "buttonUserManagement";
            this.buttonUserManagement.Size = new System.Drawing.Size(193, 35);
            this.buttonUserManagement.TabIndex = 10;
            this.buttonUserManagement.Text = "Zarządzaj użytkownikami";
            this.buttonUserManagement.UseVisualStyleBackColor = false;
            this.buttonUserManagement.Click += new System.EventHandler(this.buttonUserManagement_Click);
            // 
            // buttonBoxManagement
            // 
            this.buttonBoxManagement.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonBoxManagement.FlatAppearance.BorderSize = 0;
            this.buttonBoxManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBoxManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBoxManagement.Location = new System.Drawing.Point(55, 188);
            this.buttonBoxManagement.Name = "buttonBoxManagement";
            this.buttonBoxManagement.Size = new System.Drawing.Size(193, 35);
            this.buttonBoxManagement.TabIndex = 11;
            this.buttonBoxManagement.Text = "Zarządzaj paczkami";
            this.buttonBoxManagement.UseVisualStyleBackColor = false;
            this.buttonBoxManagement.Click += new System.EventHandler(this.buttonBoxManagement_Click);
            // 
            // buttonCheckStatus
            // 
            this.buttonCheckStatus.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonCheckStatus.FlatAppearance.BorderSize = 0;
            this.buttonCheckStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheckStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCheckStatus.Location = new System.Drawing.Point(55, 73);
            this.buttonCheckStatus.Name = "buttonCheckStatus";
            this.buttonCheckStatus.Size = new System.Drawing.Size(193, 35);
            this.buttonCheckStatus.TabIndex = 12;
            this.buttonCheckStatus.Text = "Sprawdź status mojej paczki";
            this.buttonCheckStatus.UseVisualStyleBackColor = false;
            this.buttonCheckStatus.Click += new System.EventHandler(this.buttonCheckStatus_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 422);
            this.Controls.Add(this.buttonCheckStatus);
            this.Controls.Add(this.buttonBoxManagement);
            this.Controls.Add(this.buttonUserManagement);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonUserManagement;
        private System.Windows.Forms.Button buttonBoxManagement;
        private System.Windows.Forms.Button buttonCheckStatus;
    }
}