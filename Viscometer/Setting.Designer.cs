namespace Viscometer
{
    partial class Setting
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDbName = new System.Windows.Forms.TextBox();
            this.btnSaveDbName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя сервера базы данных:";
            // 
            // txtDbName
            // 
            this.txtDbName.Location = new System.Drawing.Point(164, 21);
            this.txtDbName.Name = "txtDbName";
            this.txtDbName.Size = new System.Drawing.Size(185, 20);
            this.txtDbName.TabIndex = 1;
            // 
            // btnSaveDbName
            // 
            this.btnSaveDbName.Location = new System.Drawing.Point(355, 19);
            this.btnSaveDbName.Name = "btnSaveDbName";
            this.btnSaveDbName.Size = new System.Drawing.Size(75, 23);
            this.btnSaveDbName.TabIndex = 2;
            this.btnSaveDbName.Text = "Применить";
            this.btnSaveDbName.UseVisualStyleBackColor = true;
            this.btnSaveDbName.Click += new System.EventHandler(this.btnSaveDbName_Click);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 135);
            this.Controls.Add(this.btnSaveDbName);
            this.Controls.Add(this.txtDbName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Setting";
            this.Text = "Настройки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDbName;
        private System.Windows.Forms.Button btnSaveDbName;
    }
}