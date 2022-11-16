using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_Sale.UI.Forms
{
    public partial class frmMenu : FormBase
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void lblUsuariosCatalog_Click(object sender, EventArgs e)
        {
            frmUser form = new frmUser();
            form.TopLevel = false;
            form.AutoScroll = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.WindowState = FormWindowState.Maximized;
            panelMenu.Controls.Add(form);
            form.Show();
        }
    }
}
