using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_Sale.UI.Forms
{
    public class FormBase: Form
    {
        public FormBase()
        {
            this.WindowState = FormWindowState.Maximized;
        }



        public void ShowMessageSuccess(string message)
        {
            MessageBox.Show(message);
        }
    }
}
