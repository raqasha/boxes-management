using Krd4.Enums;
using Krd4.Models;
using Krd4.Services;
using Krd4.Services.Interfaces;
using System;
using System.Windows.Forms;

namespace Krd4
{
    public partial class CourierMainWindow : Form
    {
        IBoxService _boxService;

        public CourierMainWindow(User user)
        {
            InitializeComponent();
            _boxService = new BoxXmlService();
            RefreshDataGridView();
            comboBoxStatus.DataSource = Enum.GetValues(typeof(StatusEnum));

        }

        private void buttonAddBox_Click(object sender, EventArgs e)
        {
            var box = new Box();
            box.Number = Int32.Parse(textBoxNumber.Text);
            Enum.TryParse(comboBoxStatus.Text, out StatusEnum status);
            box.Status = status;
            box.UserId = Int32.Parse(textBoxUserId.Text);

            _boxService.Add(box);
            RefreshDataGridView();
        }

        private void buttonDeleteBox_Click(object sender, EventArgs e)
        {
            var data = dataGridViewAllBoxes.CurrentRow.Cells[3].Value.ToString();
            int id = Int32.Parse(data);
            _boxService.Delete(id);
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            dataGridViewAllBoxes.DataSource = _boxService.GetAll();
        }
    }
}
