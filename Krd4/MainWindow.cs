using Krd4.Enums;
using Krd4.Models;
using System;
using System.Windows.Forms;

namespace Krd4
{
    public partial class MainWindow : Form
    {
        public User user;

        public MainWindow(User user)
        {
            InitializeComponent();
            this.user = user;
            HideButtons();
        }

        private void buttonUserManagement_Click(object sender, EventArgs e)
        {
            AdminMainWindow adminMainWindow = new AdminMainWindow(user);
            adminMainWindow.Show();
        }

        private void buttonBoxManagement_Click(object sender, EventArgs e)
        {
            CourierMainWindow courierMainWindow = new CourierMainWindow(user);
            courierMainWindow.Show();

        }

        private void buttonCheckStatus_Click(object sender, EventArgs e)
        {
            UserMainWindow userMainWindow = new UserMainWindow(user);
            userMainWindow.Show();
        }

        private void HideButtons()
        {
            if (user.TypeOfUser == RoleEnum.Admin)
            {
                buttonBoxManagement.Hide();
                buttonCheckStatus.Hide();
            }
            else if (user.TypeOfUser == RoleEnum.Courier)
            {
                buttonUserManagement.Hide();
                buttonCheckStatus.Hide();
            }
            else
            {
                buttonBoxManagement.Hide();
                buttonUserManagement.Hide();
            }
        }
    }
}
