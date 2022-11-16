using Point_Sale.UI.Utils;
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
    public partial class ctrlLog : UserControl
    {
        public ctrlLog()
        {
            InitializeComponent();
        }

        private void ctrlLog_Load(object sender, EventArgs e)
        {
            this.lblNameSistemLog.Text = Auth.UserName ?? "Sin nombre";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            try
            {
                const string message = "Esta seguro de salir del sistema?";
                const string caption = "Form Closing";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Auth.setNull();
                    Application.Restart();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema");
            }
        }
    }
}
