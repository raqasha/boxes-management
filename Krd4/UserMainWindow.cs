using Krd4.Models;
using Krd4.Services;
using Krd4.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Krd4
{
    public partial class UserMainWindow : Form
    {
        IBoxService _boxService;

        public UserMainWindow(User user)
        {
            InitializeComponent();
            _boxService = new BoxXmlService();
            dataGridViewBoxStatus.DataSource = _boxService.GetByUserId(user);
        }

    }
}
