using Krd4.Models;
using Krd4.Services;
using Krd4.Services.Interfaces;
using System;
using System.Windows.Forms;

namespace Krd4
{
    public partial class LoginForm : Form
    {
        //interfejs jest typem
        //podkreślenie dla zmiennej prywatnej w klasie
        IUserService _userService;

        public LoginForm()
        {
            InitializeComponent();
            _userService = new UserXmlService();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text; 
            string password = textBoxPassword.Text;
            User user = _userService.Login(login, password);

            if (user != null)
            {
                MainWindow mainWindow = new MainWindow(user);
                mainWindow.Show();
                MessageBox.Show("Successful login", "", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Incorect login or password!", "", MessageBoxButtons.OK);
            }
        }
    }
}
