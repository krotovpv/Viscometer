namespace ViscometerViewer
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.toolTipForButton = new System.Windows.Forms.ToolTip(this.components);
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnChart = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBoxTester = new System.Windows.Forms.GroupBox();
            this.lblTester = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpBoxTester.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(953, 434);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSearch.Location = new System.Drawing.Point(60, 62);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(891, 20);
            this.txtSearch.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackgroundImage = global::ViscometerViewer.Properties.Resources.icons8_find_64;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.Location = new System.Drawing.Point(857, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(44, 44);
            this.btnSearch.TabIndex = 6;
            this.toolTipForButton.SetToolTip(this.btnSearch, "Поиск");
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnTest
            // 
            this.btnTest.BackgroundImage = global::ViscometerViewer.Properties.Resources.icons8_выбор_64;
            this.btnTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTest.Location = new System.Drawing.Point(62, 12);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(44, 44);
            this.btnTest.TabIndex = 5;
            this.btnTest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTipForButton.SetToolTip(this.btnTest, "Испытание");
            this.btnTest.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::ViscometerViewer.Properties.Resources.icons8_документ_64__1_;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrint.Location = new System.Drawing.Point(162, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(44, 44);
            this.btnPrint.TabIndex = 4;
            this.toolTipForButton.SetToolTip(this.btnPrint, "Отчет");
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnChart
            // 
            this.btnChart.BackgroundImage = global::ViscometerViewer.Properties.Resources.icons8_сбалансировать_портфель_64;
            this.btnChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnChart.Location = new System.Drawing.Point(112, 12);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(44, 44);
            this.btnChart.TabIndex = 3;
            this.toolTipForButton.SetToolTip(this.btnChart, "Детальная информация");
            this.btnChart.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackgroundImage = global::ViscometerViewer.Properties.Resources.icons8_мусор_64;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.Location = new System.Drawing.Point(907, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(44, 44);
            this.btnDelete.TabIndex = 2;
            this.toolTipForButton.SetToolTip(this.btnDelete, "Удалить");
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::ViscometerViewer.Properties.Resources.icons8_добавить_64;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.Location = new System.Drawing.Point(12, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(44, 44);
            this.btnAdd.TabIndex = 1;
            this.toolTipForButton.SetToolTip(this.btnAdd, "Добавить");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Поиск:";
            // 
            // grpBoxTester
            // 
            this.grpBoxTester.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxTester.Controls.Add(this.lblTester);
            this.grpBoxTester.Location = new System.Drawing.Point(671, 12);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 526);
            this.Controls.Add(this.grpBoxTester);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnChart);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainForm";
            this.Text = "Вискозиметр";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpBoxTester.ResumeLayout(false);
            this.grpBoxTester.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChart;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ToolTip toolTipForButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBoxTester;
        private System.Windows.Forms.Label lblTester;
    }
}

