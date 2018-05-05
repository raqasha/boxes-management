using Krd4.Enums;
using Krd4.Models;
using Krd4.Services;
using Krd4.Services.Interfaces;
using System;
using System.Windows.Forms;

namespace Krd4
{
    public partial class AdminMainWindow : Form
    {
        IUserService _userService;

        public AdminMainWindow(User user)
        {
            InitializeComponent();
            _userService = new UserXmlService();
            comboBoxTypeOfUser.DataSource = Enum.GetValues(typeof(RoleEnum));
            RefreshDataGridView();
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            var user = new User();
            user.Login = textBoxLogin.Text;
            user.Password = textBoxPassword.Text;
            Enum.TryParse(comboBoxTypeOfUser.Text, out RoleEnum role);
            user.TypeOfUser = role;
            _userService.Add(user);
            RefreshDataGridView();
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            var data = dataGridViewAllUsers.CurrentRow.Cells[3].Value.ToString();
            int id = Int32.Parse(data);
            _userService.Delete(id);
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            dataGridViewAllUsers.DataSource = _userService.GetAll();
        }

    }
}
