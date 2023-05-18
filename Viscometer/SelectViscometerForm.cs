using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Viscometer
{
    public partial class SelectViscometerForm : Form
    {
        public string SelectPortName { get; set; } = String.Empty;
        public SelectViscometerForm()
        {
            InitializeComponent();
        }

        private void SelectViscometerForm_Load(object sender, EventArgs e)
        {
            LoadViscometer();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ShowAddViscometerForm();
        }

        private void ShowAddViscometerForm(AddViscometerForm addForm = null)
        {
            if (addForm == null) addForm = new AddViscometerForm();

            if (addForm.ShowDialog() == DialogResult.OK)
            {
                if (!addForm.Viscometer.PortName.StartsWith("COM") || addForm.Viscometer.PortName.Length < 3)
                {
                    MessageBox.Show("Не верно указан COM порт");
                    ShowAddViscometerForm(addForm);
                }
                else
                {
                    //проверяем существует ли выбраный порт
                    bool portExist = false;
                    foreach (var item in addForm.PortNames)
                    {
                        if (item == addForm.Viscometer.PortName)
                        {
                            portExist = true; break;
                        }
                    }

                    bool portCopy = false;
                    //проверяем есть ли данный COM порт в уже добавленых
                    foreach (var item in SaveSettings.Viscometers)
                    {
                        if (item.PortName == addForm.Viscometer.PortName)
                        {
                            portCopy = true; break;
                        }
                    }

                    //если указанный порт уже добавлен
                    if (portCopy)
                    {
                        MessageBox.Show(addForm.Viscometer.PortName + " - порт уже сохранен. Если желаете его изменить то следует удалить и создать новый.");
                        ShowAddViscometerForm(addForm);
                        return;
                    }

                    //если данный порт не существует уточняем у пользователя уверен ли он в добавлении
                    if (!portExist)
                    {
                        if (MessageBox.Show("Вы уверены, что желаете добавить COM порт которого нет на данном устройстве?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        {
                            ShowAddViscometerForm(addForm);
                            return;
                        }
                    }

                    //добавляем COM порт
                    SaveSettings.Viscometers.Add(addForm.Viscometer);
                    SaveSettings.Save();
                    flowLayoutPanelMain.Controls.Add(new UCViscometerButton(addForm.Viscometer));
                }
            }
        }

        private void LoadViscometer()
        {
            foreach (Viscometer item in SaveSettings.Viscometers)
                flowLayoutPanelMain.Controls.Add(new UCViscometerButton(item));
        }
    }
}
