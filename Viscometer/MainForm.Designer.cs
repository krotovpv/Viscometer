﻿namespace Viscometer
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.toolTipForButton = new System.Windows.Forms.ToolTip(this.components);
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btnViewOrder = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btnChartOrder = new System.Windows.Forms.Button();
            this.btnDelOrder = new System.Windows.Forms.Button();
            this.btnDelTest = new System.Windows.Forms.Button();
            this.btnChartTest = new System.Windows.Forms.Button();
            this.btnRejectTest = new System.Windows.Forms.Button();
            this.btnReceiptTest = new System.Windows.Forms.Button();
            this.btnViewTest = new System.Windows.Forms.Button();
            this.btnStartTest = new System.Windows.Forms.Button();
            this.btnAddTest = new System.Windows.Forms.Button();
            this.grpBoxTester = new System.Windows.Forms.GroupBox();
            this.lblTester = new System.Windows.Forms.Label();
            this.splitContMain = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dgvTests = new System.Windows.Forms.DataGridView();
            this.ColIdTest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNumLoad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTesterStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNameParogramm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCompaund = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ColIdOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDateOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNumOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNameTester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNameSub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.grpBoxTester.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContMain)).BeginInit();
            this.splitContMain.Panel1.SuspendLayout();
            this.splitContMain.Panel2.SuspendLayout();
            this.splitContMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrders.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIdOrder,
            this.ColDateOrder,
            this.ColNumOrder,
            this.ColNameTester,
            this.ColNameSub});
            this.dgvOrders.Location = new System.Drawing.Point(1, 53);
            this.dgvOrders.MultiSelect = false;
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(481, 373);
            this.dgvOrders.TabIndex = 0;
            this.dgvOrders.SelectionChanged += new System.EventHandler(this.dgvOrders_SelectionChanged);
            // 
            // button10
            // 
            this.button10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button10.BackgroundImage = global::Viscometer.Properties.Resources.icons8_adobe_file_64;
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button10.Location = new System.Drawing.Point(907, 12);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(44, 44);
            this.button10.TabIndex = 15;
            this.toolTipForButton.SetToolTip(this.button10, "Поиск");
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.BackgroundImage = global::Viscometer.Properties.Resources.icons8_архив_64__1_;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button9.Location = new System.Drawing.Point(857, 12);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(44, 44);
            this.button9.TabIndex = 14;
            this.toolTipForButton.SetToolTip(this.button9, "Поиск");
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.BackgroundImage = global::Viscometer.Properties.Resources.icons8_архив_64;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button8.Location = new System.Drawing.Point(807, 12);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(44, 44);
            this.button8.TabIndex = 13;
            this.toolTipForButton.SetToolTip(this.button8, "Поиск");
            this.button8.UseVisualStyleBackColor = true;
            // 
            // btnViewOrder
            // 
            this.btnViewOrder.BackgroundImage = global::Viscometer.Properties.Resources.icons8_файл_64_view;
            this.btnViewOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnViewOrder.Location = new System.Drawing.Point(3, 3);
            this.btnViewOrder.Name = "btnViewOrder";
            this.btnViewOrder.Size = new System.Drawing.Size(44, 44);
            this.btnViewOrder.TabIndex = 11;
            this.toolTipForButton.SetToolTip(this.btnViewOrder, "Обновить");
            this.btnViewOrder.UseVisualStyleBackColor = true;
            this.btnViewOrder.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.BackgroundImage = global::Viscometer.Properties.Resources.добавить_64;
            this.btnAddOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddOrder.Location = new System.Drawing.Point(53, 3);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(44, 44);
            this.btnAddOrder.TabIndex = 1;
            this.toolTipForButton.SetToolTip(this.btnAddOrder, "Добавить заказ");
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnChartOrder
            // 
            this.btnChartOrder.BackgroundImage = global::Viscometer.Properties.Resources.icons8_сбалансировать_портфель_64;
            this.btnChartOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnChartOrder.Location = new System.Drawing.Point(103, 3);
            this.btnChartOrder.Name = "btnChartOrder";
            this.btnChartOrder.Size = new System.Drawing.Size(44, 44);
            this.btnChartOrder.TabIndex = 3;
            this.toolTipForButton.SetToolTip(this.btnChartOrder, "Детальная информация");
            this.btnChartOrder.UseVisualStyleBackColor = true;
            // 
            // btnDelOrder
            // 
            this.btnDelOrder.BackgroundImage = global::Viscometer.Properties.Resources.icons8_мусор_64;
            this.btnDelOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelOrder.Location = new System.Drawing.Point(153, 3);
            this.btnDelOrder.Name = "btnDelOrder";
            this.btnDelOrder.Size = new System.Drawing.Size(44, 44);
            this.btnDelOrder.TabIndex = 14;
            this.toolTipForButton.SetToolTip(this.btnDelOrder, "Удалить");
            this.btnDelOrder.UseVisualStyleBackColor = true;
            // 
            // btnDelTest
            // 
            this.btnDelTest.BackgroundImage = global::Viscometer.Properties.Resources.icons8_мусор_64;
            this.btnDelTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelTest.Location = new System.Drawing.Point(253, 3);
            this.btnDelTest.Name = "btnDelTest";
            this.btnDelTest.Size = new System.Drawing.Size(44, 44);
            this.btnDelTest.TabIndex = 15;
            this.toolTipForButton.SetToolTip(this.btnDelTest, "Удалить испытание");
            this.btnDelTest.UseVisualStyleBackColor = true;
            // 
            // btnChartTest
            // 
            this.btnChartTest.BackgroundImage = global::Viscometer.Properties.Resources.icons8_сбалансировать_портфель_64;
            this.btnChartTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnChartTest.Location = new System.Drawing.Point(203, 3);
            this.btnChartTest.Name = "btnChartTest";
            this.btnChartTest.Size = new System.Drawing.Size(44, 44);
            this.btnChartTest.TabIndex = 16;
            this.toolTipForButton.SetToolTip(this.btnChartTest, "Детальная информация");
            this.btnChartTest.UseVisualStyleBackColor = true;
            // 
            // btnRejectTest
            // 
            this.btnRejectTest.BackgroundImage = global::Viscometer.Properties.Resources.icons8_закрыть_64__1_;
            this.btnRejectTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRejectTest.Location = new System.Drawing.Point(153, 3);
            this.btnRejectTest.Name = "btnRejectTest";
            this.btnRejectTest.Size = new System.Drawing.Size(44, 44);
            this.btnRejectTest.TabIndex = 17;
            this.toolTipForButton.SetToolTip(this.btnRejectTest, "Забраковать результат");
            this.btnRejectTest.UseVisualStyleBackColor = true;
            // 
            // btnReceiptTest
            // 
            this.btnReceiptTest.BackgroundImage = global::Viscometer.Properties.Resources.icons8_файл_64__8_;
            this.btnReceiptTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReceiptTest.Location = new System.Drawing.Point(103, 3);
            this.btnReceiptTest.Name = "btnReceiptTest";
            this.btnReceiptTest.Size = new System.Drawing.Size(44, 44);
            this.btnReceiptTest.TabIndex = 18;
            this.toolTipForButton.SetToolTip(this.btnReceiptTest, "Подтвердить результат");
            this.btnReceiptTest.UseVisualStyleBackColor = true;
            // 
            // btnViewTest
            // 
            this.btnViewTest.BackgroundImage = global::Viscometer.Properties.Resources.icons8_файл_64_view;
            this.btnViewTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnViewTest.Location = new System.Drawing.Point(3, 3);
            this.btnViewTest.Name = "btnViewTest";
            this.btnViewTest.Size = new System.Drawing.Size(44, 44);
            this.btnViewTest.TabIndex = 19;
            this.toolTipForButton.SetToolTip(this.btnViewTest, "Обновить");
            this.btnViewTest.UseVisualStyleBackColor = true;
            // 
            // btnStartTest
            // 
            this.btnStartTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStartTest.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartTest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStartTest.Location = new System.Drawing.Point(387, 3);
            this.btnStartTest.Name = "btnStartTest";
            this.btnStartTest.Size = new System.Drawing.Size(83, 44);
            this.btnStartTest.TabIndex = 5;
            this.btnStartTest.Text = "ТЕСТ";
            this.btnStartTest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTipForButton.SetToolTip(this.btnStartTest, "Испытание");
            this.btnStartTest.UseVisualStyleBackColor = true;
            this.btnStartTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnAddTest
            // 
            this.btnAddTest.BackgroundImage = global::Viscometer.Properties.Resources.добавить_64;
            this.btnAddTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddTest.Location = new System.Drawing.Point(53, 3);
            this.btnAddTest.Name = "btnAddTest";
            this.btnAddTest.Size = new System.Drawing.Size(44, 44);
            this.btnAddTest.TabIndex = 20;
            this.toolTipForButton.SetToolTip(this.btnAddTest, "Добавить испытание");
            this.btnAddTest.UseVisualStyleBackColor = true;
            this.btnAddTest.Click += new System.EventHandler(this.btnAddTest_Click);
            // 
            // grpBoxTester
            // 
            this.grpBoxTester.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxTester.Controls.Add(this.lblTester);
            this.grpBoxTester.Location = new System.Drawing.Point(621, 12);
            this.grpBoxTester.Name = "grpBoxTester";
            this.grpBoxTester.Size = new System.Drawing.Size(180, 44);
            this.grpBoxTester.TabIndex = 10;
            this.grpBoxTester.TabStop = false;
            this.grpBoxTester.Text = "Подразделение";
            // 
            // lblTester
            // 
            this.lblTester.AutoSize = true;
            this.lblTester.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTester.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTester.Location = new System.Drawing.Point(3, 16);
            this.lblTester.Name = "lblTester";
            this.lblTester.Size = new System.Drawing.Size(106, 15);
            this.lblTester.TabIndex = 0;
            this.lblTester.Text = "Имя испытателя";
            // 
            // splitContMain
            // 
            this.splitContMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContMain.Location = new System.Drawing.Point(0, 62);
            this.splitContMain.Name = "splitContMain";
            // 
            // splitContMain.Panel1
            // 
            this.splitContMain.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContMain.Panel1.Controls.Add(this.label2);
            this.splitContMain.Panel1.Controls.Add(this.dgvOrders);
            this.splitContMain.Panel1.Controls.Add(this.dateTimePicker2);
            this.splitContMain.Panel1.Controls.Add(this.btnViewOrder);
            this.splitContMain.Panel1.Controls.Add(this.label1);
            this.splitContMain.Panel1.Controls.Add(this.btnAddOrder);
            this.splitContMain.Panel1.Controls.Add(this.dateTimePicker1);
            this.splitContMain.Panel1.Controls.Add(this.btnChartOrder);
            this.splitContMain.Panel1.Controls.Add(this.btnDelOrder);
            // 
            // splitContMain.Panel2
            // 
            this.splitContMain.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContMain.Panel2.Controls.Add(this.btnAddTest);
            this.splitContMain.Panel2.Controls.Add(this.btnDelTest);
            this.splitContMain.Panel2.Controls.Add(this.btnChartTest);
            this.splitContMain.Panel2.Controls.Add(this.btnRejectTest);
            this.splitContMain.Panel2.Controls.Add(this.btnReceiptTest);
            this.splitContMain.Panel2.Controls.Add(this.btnViewTest);
            this.splitContMain.Panel2.Controls.Add(this.btnStartTest);
            this.splitContMain.Panel2.Controls.Add(this.dgvTests);
            this.splitContMain.Size = new System.Drawing.Size(963, 427);
            this.splitContMain.SplitterDistance = 483;
            this.splitContMain.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "По";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker2.Location = new System.Drawing.Point(334, 28);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(146, 20);
            this.dateTimePicker2.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "С";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Location = new System.Drawing.Point(334, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(146, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // dgvTests
            // 
            this.dgvTests.AllowUserToAddRows = false;
            this.dgvTests.AllowUserToDeleteRows = false;
            this.dgvTests.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTests.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIdTest,
            this.ColNumLoad,
            this.ColTesterStatus,
            this.ColNameParogramm,
            this.ColCompaund});
            this.dgvTests.Location = new System.Drawing.Point(1, 53);
            this.dgvTests.MultiSelect = false;
            this.dgvTests.Name = "dgvTests";
            this.dgvTests.ReadOnly = true;
            this.dgvTests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTests.Size = new System.Drawing.Size(474, 373);
            this.dgvTests.TabIndex = 0;
            // 
            // ColIdTest
            // 
            this.ColIdTest.DataPropertyName = "idTest";
            this.ColIdTest.HeaderText = "Id";
            this.ColIdTest.Name = "ColIdTest";
            this.ColIdTest.ReadOnly = true;
            this.ColIdTest.Visible = false;
            // 
            // ColNumLoad
            // 
            this.ColNumLoad.DataPropertyName = "numLoad";
            this.ColNumLoad.HeaderText = "Номер";
            this.ColNumLoad.Name = "ColNumLoad";
            this.ColNumLoad.ReadOnly = true;
            this.ColNumLoad.Width = 50;
            // 
            // ColTesterStatus
            // 
            this.ColTesterStatus.DataPropertyName = "short_description";
            this.ColTesterStatus.HeaderText = "Статус";
            this.ColTesterStatus.Name = "ColTesterStatus";
            this.ColTesterStatus.ReadOnly = true;
            this.ColTesterStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColNameParogramm
            // 
            this.ColNameParogramm.DataPropertyName = "name";
            this.ColNameParogramm.HeaderText = "Программа испытания";
            this.ColNameParogramm.Name = "ColNameParogramm";
            this.ColNameParogramm.ReadOnly = true;
            this.ColNameParogramm.Width = 150;
            // 
            // ColCompaund
            // 
            this.ColCompaund.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColCompaund.DataPropertyName = "nameCompound";
            this.ColCompaund.HeaderText = "Компаунд";
            this.ColCompaund.Name = "ColCompaund";
            this.ColCompaund.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Viscometer.Properties.Resources.Belshina_logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // ColIdOrder
            // 
            this.ColIdOrder.DataPropertyName = "idOrder";
            this.ColIdOrder.HeaderText = "Id";
            this.ColIdOrder.Name = "ColIdOrder";
            this.ColIdOrder.ReadOnly = true;
            this.ColIdOrder.Visible = false;
            // 
            // ColDateOrder
            // 
            this.ColDateOrder.DataPropertyName = "dateOrder";
            this.ColDateOrder.HeaderText = "Дата";
            this.ColDateOrder.Name = "ColDateOrder";
            this.ColDateOrder.ReadOnly = true;
            // 
            // ColNumOrder
            // 
            this.ColNumOrder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColNumOrder.DataPropertyName = "numOrder";
            this.ColNumOrder.HeaderText = "Номер заказа";
            this.ColNumOrder.Name = "ColNumOrder";
            this.ColNumOrder.ReadOnly = true;
            // 
            // ColNameTester
            // 
            this.ColNameTester.DataPropertyName = "nameTester";
            this.ColNameTester.HeaderText = "Испытатель";
            this.ColNameTester.Name = "ColNameTester";
            this.ColNameTester.ReadOnly = true;
            // 
            // ColNameSub
            // 
            this.ColNameSub.DataPropertyName = "nameSubdiv";
            this.ColNameSub.HeaderText = "Подразделение";
            this.ColNameSub.Name = "ColNameSub";
            this.ColNameSub.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(963, 489);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.grpBoxTester);
            this.Controls.Add(this.splitContMain);
            this.Name = "MainForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.grpBoxTester.ResumeLayout(false);
            this.grpBoxTester.PerformLayout();
            this.splitContMain.Panel1.ResumeLayout(false);
            this.splitContMain.Panel1.PerformLayout();
            this.splitContMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContMain)).EndInit();
            this.splitContMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnChartOrder;
        private System.Windows.Forms.Button btnStartTest;
        private System.Windows.Forms.ToolTip toolTipForButton;
        private System.Windows.Forms.GroupBox grpBoxTester;
        private System.Windows.Forms.Label lblTester;
        private System.Windows.Forms.Button btnViewOrder;
        private System.Windows.Forms.SplitContainer splitContMain;
        private System.Windows.Forms.DataGridView dgvTests;
        private System.Windows.Forms.Button btnDelOrder;
        private System.Windows.Forms.Button btnDelTest;
        private System.Windows.Forms.Button btnChartTest;
        private System.Windows.Forms.Button btnRejectTest;
        private System.Windows.Forms.Button btnReceiptTest;
        private System.Windows.Forms.Button btnViewTest;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAddTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNumLoad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTesterStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNameParogramm;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCompaund;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDateOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNumOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNameTester;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNameSub;
    }
}

