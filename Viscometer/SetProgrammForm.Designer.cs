namespace Viscometer
{
    partial class SetProgrammForm
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
            this.components = new System.ComponentModel.Container();
            this.radioBtnViscosity = new System.Windows.Forms.RadioButton();
            this.radioBtnScorch = new System.Windows.Forms.RadioButton();
            this.groupBoxRotor = new System.Windows.Forms.GroupBox();
            this.radioBtnRotorS = new System.Windows.Forms.RadioButton();
            this.radioBtnRotorL = new System.Windows.Forms.RadioButton();
            this.nudTemperature = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpPreheat = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpTimeTest = new System.Windows.Forms.DateTimePicker();
            this.lblDecay = new System.Windows.Forms.Label();
            this.dtpDecay = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblLinkTestType = new System.Windows.Forms.Label();
            this.lblLinkRotorSize = new System.Windows.Forms.Label();
            this.lblLinkTempTest = new System.Windows.Forms.Label();
            this.lblLinkPreheatTime = new System.Windows.Forms.Label();
            this.lblLinkSetTime = new System.Windows.Forms.Label();
            this.lblLinkDecay = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblLinkPrintPreheat = new System.Windows.Forms.Label();
            this.groupBoxRotor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTemperature)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioBtnViscosity
            // 
            this.radioBtnViscosity.AutoSize = true;
            this.radioBtnViscosity.Checked = true;
            this.radioBtnViscosity.Location = new System.Drawing.Point(6, 19);
            this.radioBtnViscosity.Name = "radioBtnViscosity";
            this.radioBtnViscosity.Size = new System.Drawing.Size(123, 17);
            this.radioBtnViscosity.TabIndex = 2;
            this.radioBtnViscosity.TabStop = true;
            this.radioBtnViscosity.Text = "Вязкость (Viscosity)";
            this.radioBtnViscosity.UseVisualStyleBackColor = true;
            this.radioBtnViscosity.CheckedChanged += new System.EventHandler(this.radioBtnViscosity_Scorch_CheckedChanged);
            // 
            // radioBtnScorch
            // 
            this.radioBtnScorch.AutoSize = true;
            this.radioBtnScorch.Location = new System.Drawing.Point(135, 19);
            this.radioBtnScorch.Name = "radioBtnScorch";
            this.radioBtnScorch.Size = new System.Drawing.Size(159, 17);
            this.radioBtnScorch.TabIndex = 3;
            this.radioBtnScorch.Text = "Подвулканизация (Scorch)";
            this.radioBtnScorch.UseVisualStyleBackColor = true;
            this.radioBtnScorch.CheckedChanged += new System.EventHandler(this.radioBtnViscosity_Scorch_CheckedChanged);
            // 
            // groupBoxRotor
            // 
            this.groupBoxRotor.Controls.Add(this.radioBtnRotorS);
            this.groupBoxRotor.Controls.Add(this.radioBtnRotorL);
            this.groupBoxRotor.Location = new System.Drawing.Point(12, 64);
            this.groupBoxRotor.Name = "groupBoxRotor";
            this.groupBoxRotor.Size = new System.Drawing.Size(296, 46);
            this.groupBoxRotor.TabIndex = 4;
            this.groupBoxRotor.TabStop = false;
            this.groupBoxRotor.Text = "Ротор";
            // 
            // radioBtnRotorS
            // 
            this.radioBtnRotorS.AutoSize = true;
            this.radioBtnRotorS.Location = new System.Drawing.Point(97, 19);
            this.radioBtnRotorS.Name = "radioBtnRotorS";
            this.radioBtnRotorS.Size = new System.Drawing.Size(75, 17);
            this.radioBtnRotorS.TabIndex = 1;
            this.radioBtnRotorS.Text = "S (малый)";
            this.radioBtnRotorS.UseVisualStyleBackColor = true;
            // 
            // radioBtnRotorL
            // 
            this.radioBtnRotorL.AutoSize = true;
            this.radioBtnRotorL.Checked = true;
            this.radioBtnRotorL.Location = new System.Drawing.Point(6, 19);
            this.radioBtnRotorL.Name = "radioBtnRotorL";
            this.radioBtnRotorL.Size = new System.Drawing.Size(84, 17);
            this.radioBtnRotorL.TabIndex = 0;
            this.radioBtnRotorL.TabStop = true;
            this.radioBtnRotorL.Text = "L (большой)";
            this.radioBtnRotorL.UseVisualStyleBackColor = true;
            // 
            // nudTemperature
            // 
            this.nudTemperature.DecimalPlaces = 1;
            this.nudTemperature.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudTemperature.Location = new System.Drawing.Point(250, 116);
            this.nudTemperature.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudTemperature.Name = "nudTemperature";
            this.nudTemperature.Size = new System.Drawing.Size(58, 20);
            this.nudTemperature.TabIndex = 5;
            this.nudTemperature.Value = new decimal(new int[] {
            1000,
            0,
            0,
            65536});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Температура испытания:";
            // 
            // dtpPreheat
            // 
            this.dtpPreheat.CustomFormat = "mm:ss";
            this.dtpPreheat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPreheat.Location = new System.Drawing.Point(250, 142);
            this.dtpPreheat.Name = "dtpPreheat";
            this.dtpPreheat.ShowUpDown = true;
            this.dtpPreheat.Size = new System.Drawing.Size(58, 20);
            this.dtpPreheat.TabIndex = 7;
            this.dtpPreheat.Value = new System.DateTime(2024, 7, 22, 0, 1, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Время для прогрева образца (mm:ss):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Время испытания (mm:ss):";
            // 
            // dtpTimeTest
            // 
            this.dtpTimeTest.CustomFormat = "mm:ss";
            this.dtpTimeTest.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTimeTest.Location = new System.Drawing.Point(250, 168);
            this.dtpTimeTest.Name = "dtpTimeTest";
            this.dtpTimeTest.ShowUpDown = true;
            this.dtpTimeTest.Size = new System.Drawing.Size(58, 20);
            this.dtpTimeTest.TabIndex = 10;
            this.dtpTimeTest.Value = new System.DateTime(2024, 7, 22, 0, 4, 0, 0);
            // 
            // lblDecay
            // 
            this.lblDecay.AutoSize = true;
            this.lblDecay.Location = new System.Drawing.Point(12, 201);
            this.lblDecay.Name = "lblDecay";
            this.lblDecay.Size = new System.Drawing.Size(109, 13);
            this.lblDecay.TabIndex = 11;
            this.lblDecay.Text = "Релоксация (mm:ss):";
            // 
            // dtpDecay
            // 
            this.dtpDecay.CustomFormat = "mm:ss";
            this.dtpDecay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDecay.Location = new System.Drawing.Point(250, 194);
            this.dtpDecay.Name = "dtpDecay";
            this.dtpDecay.ShowUpDown = true;
            this.dtpDecay.Size = new System.Drawing.Size(58, 20);
            this.dtpDecay.TabIndex = 12;
            this.dtpDecay.Value = new System.DateTime(2024, 7, 22, 0, 0, 0, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtnViscosity);
            this.groupBox1.Controls.Add(this.radioBtnScorch);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 46);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Испытание";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(12, 225);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(296, 28);
            this.btnOk.TabIndex = 14;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblLinkTestType
            // 
            this.lblLinkTestType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLinkTestType.BackColor = System.Drawing.Color.LightGray;
            this.lblLinkTestType.Location = new System.Drawing.Point(319, 186);
            this.lblLinkTestType.Name = "lblLinkTestType";
            this.lblLinkTestType.Size = new System.Drawing.Size(11, 38);
            this.lblLinkTestType.TabIndex = 15;
            this.toolTip1.SetToolTip(this.lblLinkTestType, "Результат запроса типа испытания");
            // 
            // lblLinkRotorSize
            // 
            this.lblLinkRotorSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLinkRotorSize.BackColor = System.Drawing.Color.LightGray;
            this.lblLinkRotorSize.Location = new System.Drawing.Point(319, 149);
            this.lblLinkRotorSize.Name = "lblLinkRotorSize";
            this.lblLinkRotorSize.Size = new System.Drawing.Size(11, 36);
            this.lblLinkRotorSize.TabIndex = 16;
            this.toolTip1.SetToolTip(this.lblLinkRotorSize, "Результат запроса размера ротора");
            // 
            // lblLinkTempTest
            // 
            this.lblLinkTempTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLinkTempTest.BackColor = System.Drawing.Color.LightGray;
            this.lblLinkTempTest.Location = new System.Drawing.Point(319, 37);
            this.lblLinkTempTest.Name = "lblLinkTempTest";
            this.lblLinkTempTest.Size = new System.Drawing.Size(11, 35);
            this.lblLinkTempTest.TabIndex = 17;
            this.toolTip1.SetToolTip(this.lblLinkTempTest, "Результат запроса температуры испытания");
            // 
            // lblLinkPreheatTime
            // 
            this.lblLinkPreheatTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLinkPreheatTime.BackColor = System.Drawing.Color.LightGray;
            this.lblLinkPreheatTime.Location = new System.Drawing.Point(319, 73);
            this.lblLinkPreheatTime.Name = "lblLinkPreheatTime";
            this.lblLinkPreheatTime.Size = new System.Drawing.Size(11, 35);
            this.lblLinkPreheatTime.TabIndex = 18;
            this.toolTip1.SetToolTip(this.lblLinkPreheatTime, "Результат испытания предварительного нагрева перед испытанием");
            // 
            // lblLinkSetTime
            // 
            this.lblLinkSetTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLinkSetTime.BackColor = System.Drawing.Color.LightGray;
            this.lblLinkSetTime.Location = new System.Drawing.Point(319, 1);
            this.lblLinkSetTime.Name = "lblLinkSetTime";
            this.lblLinkSetTime.Size = new System.Drawing.Size(11, 35);
            this.lblLinkSetTime.TabIndex = 19;
            this.toolTip1.SetToolTip(this.lblLinkSetTime, "Результат запроса времени испытания");
            // 
            // lblLinkDecay
            // 
            this.lblLinkDecay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLinkDecay.BackColor = System.Drawing.Color.LightGray;
            this.lblLinkDecay.Location = new System.Drawing.Point(319, 110);
            this.lblLinkDecay.Name = "lblLinkDecay";
            this.lblLinkDecay.Size = new System.Drawing.Size(11, 38);
            this.lblLinkDecay.TabIndex = 20;
            this.toolTip1.SetToolTip(this.lblLinkDecay, "Результат запроса длительности релоксации");
            // 
            // lblLinkPrintPreheat
            // 
            this.lblLinkPrintPreheat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLinkPrintPreheat.BackColor = System.Drawing.Color.LightGray;
            this.lblLinkPrintPreheat.Location = new System.Drawing.Point(319, 225);
            this.lblLinkPrintPreheat.Name = "lblLinkPrintPreheat";
            this.lblLinkPrintPreheat.Size = new System.Drawing.Size(11, 38);
            this.lblLinkPrintPreheat.TabIndex = 21;
            this.toolTip1.SetToolTip(this.lblLinkPrintPreheat, "Результат запроса типа испытания");
            // 
            // SetProgrammForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 265);
            this.Controls.Add(this.lblLinkPrintPreheat);
            this.Controls.Add(this.lblLinkDecay);
            this.Controls.Add(this.lblLinkSetTime);
            this.Controls.Add(this.lblLinkTestType);
            this.Controls.Add(this.lblLinkPreheatTime);
            this.Controls.Add(this.lblLinkTempTest);
            this.Controls.Add(this.lblLinkRotorSize);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpDecay);
            this.Controls.Add(this.lblDecay);
            this.Controls.Add(this.dtpTimeTest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpPreheat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudTemperature);
            this.Controls.Add(this.groupBoxRotor);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetProgrammForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Программа испытания";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SetProgrammForm_FormClosing);
            this.Load += new System.EventHandler(this.SetProgrammForm_Load);
            this.groupBoxRotor.ResumeLayout(false);
            this.groupBoxRotor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTemperature)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioBtnViscosity;
        private System.Windows.Forms.RadioButton radioBtnScorch;
        private System.Windows.Forms.GroupBox groupBoxRotor;
        private System.Windows.Forms.RadioButton radioBtnRotorS;
        private System.Windows.Forms.RadioButton radioBtnRotorL;
        private System.Windows.Forms.NumericUpDown nudTemperature;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpPreheat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpTimeTest;
        private System.Windows.Forms.Label lblDecay;
        private System.Windows.Forms.DateTimePicker dtpDecay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblLinkTestType;
        private System.Windows.Forms.Label lblLinkRotorSize;
        private System.Windows.Forms.Label lblLinkTempTest;
        private System.Windows.Forms.Label lblLinkPreheatTime;
        private System.Windows.Forms.Label lblLinkSetTime;
        private System.Windows.Forms.Label lblLinkDecay;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblLinkPrintPreheat;
    }
}