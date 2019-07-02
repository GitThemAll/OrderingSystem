using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapeau_Restaurant
{
    public partial class DeviceManager : ChapeauForm
    {
        List<ChapeauForm> connectedScreens;
        // manages all connected devices (basicaly creates the forms as needed)
        public DeviceManager()
        {
            InitializeComponent();
            connectedScreens = new List<ChapeauForm>();
        }

        public void diplayScreens(ChapeauForm screen)
        {
            connectedScreens.Add(screen);
            LoginForm form = new LoginForm(screen);
            form.chapeauMonitor.login = form;
            form.Show();
        }

        private void WaiterForm_btn_Click(object sender, EventArgs e)
        {
            diplayScreens(new OrderForm(this));
        }

        private void ChefForm_btn_Click(object sender, EventArgs e)
        {
            diplayScreens(new OrderProcessingUI("Chef",this));
        }

        private void BarmanForm_btn_Click(object sender, EventArgs e)
        {
            diplayScreens(new OrderProcessingUI("Barman",this));
        }

        public void NotifyScreens()
        {
            foreach(ChapeauForm screen in connectedScreens)
            {
                screen.UpdateScreen();
            }
        }
    }
}
