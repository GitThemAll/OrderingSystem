using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauModel;

namespace Chapeau_Restaurant
{
    public partial class ChapeauForm : Form
    {
        public User currentUser;

        public ChapeauForm()
        {
            InitializeComponent();
            currentUser = new User();
            currentUser.jobType = "Waiter";
        }
    }
}
