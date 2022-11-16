using Point_Sale.Data.Models;
using Point_Sale.UI.Utils;
using PointSale.DataAccess.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_Sale.UI.Forms
{
    public partial class frmLogin : Form
    {
        private readonly UserService _userService = null;
        public frmLogin()
        {
            _userService = new UserService();
            InitializeComponent();
        }
        async Task<string> LongRunning()
        {
            await Task.Delay(10000);
            return "Listo";
        }
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            //string userName = this.txtName.Text.Trim();
            //var data = await this.login2Async(userName);
            //Console.WriteLine(data.UserName);
            //Task.Run(async () => {

            //    string msg = await this.LongRunning();
            //    Console.WriteLine(msg);
            //});

            //Task.Run(() => {
            //    this.login();
            //    return Task.CompletedTask;
            //});

           await this.loginAsync();
        }

        private async Task loginAsync()
        {
            try
            {
                string userName = this.txtName.Text.Trim();
                string password = this.txtPassword.Text.Trim();
                if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
                {
                    this.txtName.Focus();
                    return;
                }
               
                var user = await this.login2Async(userName);

                if (user == null || !user.Password.Equals(password))
                {
                    MessageBox.Show("Credenciales invalidas! ");
                    return;
                }
                MessageBox.Show("Bienvenido! " + user.UserName);
                Auth.setAuth(user);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Hubo un problema! " +  ex.Message );
            }
        }

        public async Task<User> login2Async(string userName)
        {
            var result = await Task.Run(() => _userService.getByName(userName));
            return result;
        }

        public Task<User> loginAsync(string userName)
        {
            var result = _userService.getByName(userName);
            return Task.FromResult(result);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
           
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtName.Text.Trim()) &&
                !string.IsNullOrEmpty(this.txtPassword.Text.Trim()) &&
                e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtName.Text.Trim()) &&
               !string.IsNullOrEmpty(this.txtPassword.Text.Trim()) &&
               e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}
