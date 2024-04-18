namespace Viscometer
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
            this.ColIdOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDateOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNumOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNameTester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNameSub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTipForButton = new System.Windows.Forms.ToolTip(this.components);
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnChart = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(481, 373);
            this.dgvOrders.TabIndex = 0;
            this.dgvOrders.SelectionChanged += new System.EventHandler(this.dgvOrders_SelectionChanged);
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
            // btnView
            // 
            this.btnView.BackgroundImage = global::Viscometer.Properties.Resources.icons8_файл_64_view;
            this.btnView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnView.Location = new System.Drawing.Point(3, 3);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(44, 44);
            this.btnView.TabIndex = 11;
            this.toolTipForButton.SetToolTip(this.btnView, "Обновить");
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::Viscometer.Properties.Resources.добавить_64;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.Location = new System.Drawing.Point(53, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(44, 44);
            this.btnAdd.TabIndex = 1;
            this.toolTipForButton.SetToolTip(this.btnAdd, "Добавить");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnChart
            // 
            this.btnChart.BackgroundImage = global::Viscometer.Properties.Resources.icons8_сбалансировать_портфель_64;
            this.btnChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnChart.Location = new System.Drawing.Point(103, 3);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(44, 44);
            this.btnChart.TabIndex = 3;
            this.toolTipForButton.SetToolTip(this.btnChart, "Детальная информация");
            this.btnChart.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Viscometer.Properties.Resources.icons8_мусор_64;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(153, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 44);
            this.button2.TabIndex = 14;
            this.toolTipForButton.SetToolTip(this.button2, "Удалить");
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Viscometer.Properties.Resources.icons8_мусор_64;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Location = new System.Drawing.Point(303, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(44, 44);
            this.button3.TabIndex = 15;
            this.toolTipForButton.SetToolTip(this.button3, "Удалить");
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::Viscometer.Properties.Resources.icons8_сбалансировать_портфель_64;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Location = new System.Drawing.Point(203, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(44, 44);
            this.button4.TabIndex = 16;
            this.toolTipForButton.SetToolTip(this.button4, "Детальная информация");
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::Viscometer.Properties.Resources.icons8_закрыть_64__1_;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.Location = new System.Drawing.Point(153, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(44, 44);
            this.button5.TabIndex = 17;
            this.toolTipForButton.SetToolTip(this.button5, "Добавить");
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::Viscometer.Properties.Resources.icons8_файл_64__8_;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.Location = new System.Drawing.Point(103, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(44, 44);
            this.button6.TabIndex = 18;
            this.toolTipForButton.SetToolTip(this.button6, "Добавить");
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.BackgroundImage = global::Viscometer.Properties.Resources.icons8_файл_64_view;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button7.Location = new System.Drawing.Point(3, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(44, 44);
            this.button7.TabIndex = 19;
            this.toolTipForButton.SetToolTip(this.button7, "Обновить");
            this.button7.UseVisualStyleBackColor = true;
            // 
            // btnTest
            // 
            this.btnTest.BackgroundImage = global::Viscometer.Properties.Resources.icons8_выбор_64;
            this.btnTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTest.Location = new System.Drawing.Point(253, 3);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(44, 44);
            this.btnTest.TabIndex = 5;
            this.btnTest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTipForButton.SetToolTip(this.btnTest, "Испытание");
            this.btnTest.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Viscometer.Properties.Resources.добавить_64;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(53, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 44);
            this.button1.TabIndex = 13;
            this.toolTipForButton.SetToolTip(this.button1, "Добавить");
            this.button1.UseVisualStyleBackColor = true;
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
            this.splitContMain.Panel1.Controls.Add(this.btnView);
            this.splitContMain.Panel1.Controls.Add(this.label1);
            this.splitContMain.Panel1.Controls.Add(this.btnAdd);
            this.splitContMain.Panel1.Controls.Add(this.dateTimePicker1);
            this.splitContMain.Panel1.Controls.Add(this.btnChart);
            this.splitContMain.Panel1.Controls.Add(this.button2);
            // 
            // splitContMain.Panel2
            // 
            this.splitContMain.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContMain.Panel2.Controls.Add(this.button3);
            this.splitContMain.Panel2.Controls.Add(this.button4);
            this.splitContMain.Panel2.Controls.Add(this.button5);
            this.splitContMain.Panel2.Controls.Add(this.button6);
            this.splitContMain.Panel2.Controls.Add(this.button7);
            this.splitContMain.Panel2.Controls.Add(this.btnTest);
            this.splitContMain.Panel2.Controls.Add(this.dgvTests);
            this.splitContMain.Panel2.Controls.Add(this.button1);
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
            this.ColTesterStatus.DataPropertyName = "description";
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
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnChart;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.ToolTip toolTipForButton;
        private System.Windows.Forms.GroupBox grpBoxTester;
        private System.Windows.Forms.Label lblTester;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.SplitContainer splitContMain;
        private System.Windows.Forms.DataGridView dgvTests;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDateOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNumOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNameTester;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNameSub;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNumLoad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTesterStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNameParogramm;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCompaund;
    }
}

