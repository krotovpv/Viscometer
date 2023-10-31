namespace ViscometerViewer
{
    partial class AuthorizationForm
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
            this.cbName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTxtPassword = new System.Windows.Forms.MaskedTextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.linkLblOffline = new System.Windows.Forms.LinkLabel();
            this.cbSub = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(40, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя:";
            // 
            // cbName
            // 
            this.cbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(123, 61);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(182, 24);
            this.cbName.TabIndex = 1;
            this.cbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(40, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль:";
            // 
            // maskedTxtPassword
            // 
            this.maskedTxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTxtPassword.Location = new System.Drawing.Point(123, 91);
            this.maskedTxtPassword.Name = "maskedTxtPassword";
            this.maskedTxtPassword.PasswordChar = '*';
            this.maskedTxtPassword.Size = new System.Drawing.Size(182, 22);
            this.maskedTxtPassword.TabIndex = 3;
            this.maskedTxtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTxtPassword_KeyPress);
            // 
            // btnEnter
            // 
            this.btnEnter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnter.Location = new System.Drawing.Point(269, 146);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 4;
            this.btnEnter.Text = "Вход";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // linkLblOffline
            // 
            this.linkLblOffline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLblOffline.AutoSize = true;
            this.linkLblOffline.Location = new System.Drawing.Point(12, 156);
            this.linkLblOffline.Name = "linkLblOffline";
            this.linkLblOffline.Size = new System.Drawing.Size(63, 13);
            this.linkLblOffline.TabIndex = 5;
            this.linkLblOffline.TabStop = true;
            this.linkLblOffline.Text = "Автономно";
            // 
            // cbSub
            // 
            this.cbSub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSub.FormattingEnabled = true;
            this.cbSub.Location = new System.Drawing.Point(251, 7);
            this.cbSub.Name = "cbSub";
            this.cbSub.Size = new System.Drawing.Size(99, 21);
            this.cbSub.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Подразделение:";
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 181);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbSub);
            this.Controls.Add(this.linkLblOffline);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.maskedTxtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuthorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.AuthorizationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTxtPassword;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.LinkLabel linkLblOffline;
        private System.Windows.Forms.ComboBox cbSub;
        private System.Windows.Forms.Label label3;
    }
}