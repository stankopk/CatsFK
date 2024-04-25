using CatsFK.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatsFK.View
{
    public partial class MainView : Form
    {
        MainController controller = new MainController();
        public MainView()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var account = txtAccount.Text;
            var password = txtPassword.Text;
            var login = controller.Login(account,password);
            if(login)
            {
                CatsView c = new CatsView();
                c.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password!");
            }
        }
    }
}
