namespace Viscometer
{
    partial class UCViscometerButton
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lblPortName = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picBoxDel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDel)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(0, 1);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Имя";
            // 
            // lblPortName
            // 
            this.lblPortName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPortName.AutoSize = true;
            this.lblPortName.Location = new System.Drawing.Point(0, 76);
            this.lblPortName.Name = "lblPortName";
            this.lblPortName.Size = new System.Drawing.Size(89, 13);
            this.lblPortName.TabIndex = 2;
            this.lblPortName.Text = "Название порта";
            // 
            // lblNumber
            // 
            this.lblNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(0, 89);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(117, 13);
            this.lblNumber.TabIndex = 3;
            this.lblNumber.Text = "Номер вискозиметра";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Viscometer.Properties.Resources.icons8_industry_48;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // picBoxDel
            // 
            this.picBoxDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picBoxDel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxDel.Image = global::Viscometer.Properties.Resources.удалить_навсегда_16;
            this.picBoxDel.Location = new System.Drawing.Point(46, -1);
            this.picBoxDel.Name = "picBoxDel";
            this.picBoxDel.Size = new System.Drawing.Size(17, 17);
            this.picBoxDel.TabIndex = 5;
            this.picBoxDel.TabStop = false;
            this.picBoxDel.Click += new System.EventHandler(this.picBoxDel_Click);
            // 
            // UCViscometerButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.picBoxDel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblPortName);
            this.Controls.Add(this.lblName);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Name = "UCViscometerButton";
            this.Size = new System.Drawing.Size(63, 104);
            this.Load += new System.EventHandler(this.UCViscometerButton_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPortName;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picBoxDel;
    }
}
