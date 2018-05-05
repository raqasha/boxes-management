namespace Krd4
{
    partial class UserMainWindow
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
            this.dataGridViewBoxStatus = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBoxStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBoxStatus
            // 
            this.dataGridViewBoxStatus.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewBoxStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBoxStatus.Location = new System.Drawing.Point(54, 90);
            this.dataGridViewBoxStatus.Name = "dataGridViewBoxStatus";
            this.dataGridViewBoxStatus.Size = new System.Drawing.Size(428, 264);
            this.dataGridViewBoxStatus.TabIndex = 0;
            // 
            // UserMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 377);
            this.Controls.Add(this.dataGridViewBoxStatus);
            this.Name = "UserMainWindow";
            this.Text = "UserMainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBoxStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBoxStatus;
    }
}