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
    public partial class CatsView : Form
    {
        CatsController controller = new CatsController();
        public CatsView()
        {
            InitializeComponent();
        }

        private void CatsView_Load(object sender, EventArgs e)
        {
            var id = GlobalInfo.Id;
            dgvCats.DataSource = controller.GetAllCatsById(id);
        }
    }
}
