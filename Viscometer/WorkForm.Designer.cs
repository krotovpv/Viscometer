namespace Viscometer
{
    partial class WorkForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblResault = new System.Windows.Forms.Label();
            this.lblCompound = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblLoad = new System.Windows.Forms.Label();
            this.lblOrder = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblRelax = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.lblPreheat = new System.Windows.Forms.Label();
            this.lblTestTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chartValue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTemperature = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperature)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.chartValue, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chartTemperature, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1019, 636);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblStartTime);
            this.panel1.Controls.Add(this.lblType);
            this.panel1.Controls.Add(this.lblResault);
            this.panel1.Controls.Add(this.lblCompound);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblNum);
            this.panel1.Controls.Add(this.lblLoad);
            this.panel1.Controls.Add(this.lblOrder);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtData);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblRelax);
            this.panel1.Controls.Add(this.lblTemperature);
            this.panel1.Controls.Add(this.lblPreheat);
            this.panel1.Controls.Add(this.lblTestTime);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(772, 3);
            this.panel1.Name = "panel1";
            this.tableLayoutPanel1.SetRowSpan(this.panel1, 2);
            this.panel1.Size = new System.Drawing.Size(244, 630);
            this.panel1.TabIndex = 0;
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStartTime.Location = new System.Drawing.Point(45, 29);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(14, 20);
            this.lblStartTime.TabIndex = 31;
            this.lblStartTime.Text = "-";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(4, 272);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(29, 13);
            this.lblType.TabIndex = 30;
            this.lblType.Text = "Тип:";
            // 
            // lblResault
            // 
            this.lblResault.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResault.BackColor = System.Drawing.Color.White;
            this.lblResault.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResault.Location = new System.Drawing.Point(0, 581);
            this.lblResault.Name = "lblResault";
            this.lblResault.Size = new System.Drawing.Size(244, 49);
            this.lblResault.TabIndex = 29;
            this.lblResault.Text = "-";
            this.lblResault.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCompound
            // 
            this.lblCompound.AutoSize = true;
            this.lblCompound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCompound.Location = new System.Drawing.Point(76, 49);
            this.lblCompound.Name = "lblCompound";
            this.lblCompound.Size = new System.Drawing.Size(14, 20);
            this.lblCompound.TabIndex = 28;
            this.lblCompound.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Номер заправки:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Номер заказа:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.SkyBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 558);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Результат";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(3, 249);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(44, 13);
            this.lblNum.TabIndex = 16;
            this.lblNum.Text = "Номер:";
            // 
            // lblLoad
            // 
            this.lblLoad.AutoSize = true;
            this.lblLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLoad.Location = new System.Drawing.Point(104, 93);
            this.lblLoad.Name = "lblLoad";
            this.lblLoad.Size = new System.Drawing.Size(14, 20);
            this.lblLoad.TabIndex = 14;
            this.lblLoad.Text = "-";
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOrder.Location = new System.Drawing.Point(90, 73);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(14, 20);
            this.lblOrder.TabIndex = 13;
            this.lblOrder.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Рез. смесь:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Дата:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.SkyBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Испытание";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtData
            // 
            this.txtData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtData.Location = new System.Drawing.Point(0, 318);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtData.Size = new System.Drawing.Size(244, 240);
            this.txtData.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BackColor = System.Drawing.Color.SkyBlue;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(0, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(244, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Текущие данные";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRelax
            // 
            this.lblRelax.AutoSize = true;
            this.lblRelax.Location = new System.Drawing.Point(3, 226);
            this.lblRelax.Name = "lblRelax";
            this.lblRelax.Size = new System.Drawing.Size(106, 13);
            this.lblRelax.TabIndex = 5;
            this.lblRelax.Text = "Время релаксации:";
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Location = new System.Drawing.Point(3, 204);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(77, 13);
            this.lblTemperature.TabIndex = 4;
            this.lblTemperature.Text = "Температура:";
            // 
            // lblPreheat
            // 
            this.lblPreheat.AutoSize = true;
            this.lblPreheat.Location = new System.Drawing.Point(3, 182);
            this.lblPreheat.Name = "lblPreheat";
            this.lblPreheat.Size = new System.Drawing.Size(93, 13);
            this.lblPreheat.TabIndex = 2;
            this.lblPreheat.Text = "Время прогрева:";
            // 
            // lblTestTime
            // 
            this.lblTestTime.AutoSize = true;
            this.lblTestTime.Location = new System.Drawing.Point(3, 160);
            this.lblTestTime.Name = "lblTestTime";
            this.lblTestTime.Size = new System.Drawing.Size(101, 13);
            this.lblTestTime.TabIndex = 1;
            this.lblTestTime.Text = "Время испытания:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.SkyBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Параметры испытания";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chartValue
            // 
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea3.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea3.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.AxisY.IsStartedFromZero = false;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea3.AxisY.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea3.Name = "ChartArea1";
            this.chartValue.ChartAreas.Add(chartArea3);
            this.chartValue.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chartValue.Legends.Add(legend3);
            this.chartValue.Location = new System.Drawing.Point(3, 3);
            this.chartValue.Name = "chartValue";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.Blue;
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            this.chartValue.Series.Add(series4);
            this.chartValue.Size = new System.Drawing.Size(763, 312);
            this.chartValue.TabIndex = 1;
            this.chartValue.Text = "chart1";
            // 
            // chartTemperature
            // 
            chartArea4.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea4.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea4.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea4.AxisY.IsStartedFromZero = false;
            chartArea4.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea4.AxisY.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea4.Name = "ChartArea1";
            this.chartTemperature.ChartAreas.Add(chartArea4);
            this.chartTemperature.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.chartTemperature.Legends.Add(legend4);
            this.chartTemperature.Location = new System.Drawing.Point(3, 321);
            this.chartTemperature.Name = "chartTemperature";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Color = System.Drawing.Color.Red;
            series5.IsVisibleInLegend = false;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            series5.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series6.IsVisibleInLegend = false;
            series6.Legend = "Legend1";
            series6.Name = "Series2";
            series6.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            this.chartTemperature.Series.Add(series5);
            this.chartTemperature.Series.Add(series6);
            this.chartTemperature.Size = new System.Drawing.Size(763, 312);
            this.chartTemperature.TabIndex = 2;
            this.chartTemperature.Text = "chart2";
            // 
            // WorkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 639);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "WorkForm";
            this.Text = "Испытание";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WorkForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperature)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTestTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartValue;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblRelax;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.Label lblPreheat;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTemperature;
        private System.Windows.Forms.Label lblLoad;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCompound;
        private System.Windows.Forms.Label lblResault;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblStartTime;
    }
}

