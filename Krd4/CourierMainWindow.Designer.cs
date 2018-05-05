namespace Krd4
{
    partial class CourierMainWindow
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
            this.dataGridViewAllBoxes = new System.Windows.Forms.DataGridView();
            this.buttonAddBox = new System.Windows.Forms.Button();
            this.buttonDeleteBox = new System.Windows.Forms.Button();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.textBoxUserId = new System.Windows.Forms.TextBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllBoxes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAllBoxes
            // 
            this.dataGridViewAllBoxes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewAllBoxes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllBoxes.Location = new System.Drawing.Point(53, 87);
            this.dataGridViewAllBoxes.Name = "dataGridViewAllBoxes";
            this.dataGridViewAllBoxes.Size = new System.Drawing.Size(428, 264);
            this.dataGridViewAllBoxes.TabIndex = 1;
            // 
            // buttonAddBox
            // 
            this.buttonAddBox.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonAddBox.FlatAppearance.BorderSize = 0;
            this.buttonAddBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddBox.Location = new System.Drawing.Point(393, 5);
            this.buttonAddBox.Name = "buttonAddBox";
            this.buttonAddBox.Size = new System.Drawing.Size(129, 35);
            this.buttonAddBox.TabIndex = 6;
            this.buttonAddBox.Text = "Dodaj paczkę";
            this.buttonAddBox.UseVisualStyleBackColor = false;
            this.buttonAddBox.Click += new System.EventHandler(this.buttonAddBox_Click);
            // 
            // buttonDeleteBox
            // 
            this.buttonDeleteBox.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonDeleteBox.FlatAppearance.BorderSize = 0;
            this.buttonDeleteBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDeleteBox.Location = new System.Drawing.Point(393, 46);
            this.buttonDeleteBox.Name = "buttonDeleteBox";
            this.buttonDeleteBox.Size = new System.Drawing.Size(129, 35);
            this.buttonDeleteBox.TabIndex = 7;
            this.buttonDeleteBox.Text = "Usuń paczkę";
            this.buttonDeleteBox.UseVisualStyleBackColor = false;
            this.buttonDeleteBox.Click += new System.EventHandler(this.buttonDeleteBox_Click);
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNumber.Location = new System.Drawing.Point(12, 12);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(118, 21);
            this.textBoxNumber.TabIndex = 9;
            this.textBoxNumber.Text = "Wpisz numer paczki";
            // 
            // textBoxUserId
            // 
            this.textBoxUserId.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxUserId.Location = new System.Drawing.Point(281, 12);
            this.textBoxUserId.Name = "textBoxUserId";
            this.textBoxUserId.Size = new System.Drawing.Size(105, 21);
            this.textBoxUserId.TabIndex = 10;
            this.textBoxUserId.Text = "Wpisz id klienta";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(145, 12);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(121, 23);
            this.comboBoxStatus.TabIndex = 11;
            this.comboBoxStatus.Text = "Wybierz status";
            // 
            // CourierMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 377);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.textBoxUserId);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.buttonDeleteBox);
            this.Controls.Add(this.buttonAddBox);
            this.Controls.Add(this.dataGridViewAllBoxes);
            this.Name = "CourierMainWindow";
            this.Text = "CourierMainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllBoxes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAllBoxes;
        private System.Windows.Forms.Button buttonAddBox;
        private System.Windows.Forms.Button buttonDeleteBox;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.TextBox textBoxUserId;
        private System.Windows.Forms.ComboBox comboBoxStatus;
    }
}