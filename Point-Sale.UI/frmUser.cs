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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_Sale.UI
{
    public partial class frmUser : Form
    {
        private readonly UserService _userService = null;
        const int ZERO = 0;
        const string ACTION_TEXT = "Accion";
        const string DELETE_TEXT = "Desactivar";
        public int _Id { get; set; }
        public frmUser()
        {
            _userService = new UserService();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.dgvUsers.AutoGenerateColumns = false;
            this.dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.loadGrid();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text.Trim();
                string password = txtPassword.Text.Trim();
                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(password))
                {
                    return;
                }
                User user = new User()
                {
                    Id = this._Id,
                    UserName = name,
                    Password = password,
                    CreateAt = DateTime.UtcNow.ToString()
                };
                if (this._Id == ZERO)
                {
                    _userService.create(user);
                    MessageBox.Show("Usuario creado");
                }
                else
                {
                    _userService.update(user);
                    MessageBox.Show("Usuario actualizado");
                }
                this.clearFields();
                this.loadGrid();
                this._Id = ZERO;
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
                return;
            }
        }

        private void clearFields()
        {
            this.txtName.Clear();
            this.txtPassword.Clear();
        }

        private void loadGrid()
        {
            this.dgvUsers.Refresh();
            this.dgvUsers.DataSource = _userService.getAll();
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                User userSelected = (User)dgvUsers.Rows[e.RowIndex].DataBoundItem;
                string columnHeader = this.dgvUsers.SelectedCells[0].OwningColumn.HeaderText;
                if (columnHeader == ACTION_TEXT)
                {
                    string cellValue = this.dgvUsers.SelectedCells[0].Value.ToString();
                    if (cellValue == DELETE_TEXT)
                    {
                        string message = "Esta seguro de " + DELETE_TEXT + " el usuario " + userSelected.UserName + " ?";
                        const string caption = "Form Closing";
                        var result = MessageBox.Show(message, caption,
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

                        // If the no button was pressed ...
                        if (result == DialogResult.No)
                        {
                            return;
                        }

                        this._userService.delete(userSelected.Id);
                        MessageBox.Show("Usuario eliminado");
                        this.loadGrid();
                        return;
                    }

                } else {
                    this._Id = userSelected.Id;
                    this.txtName.Text = userSelected.UserName;
                    this.txtPassword.Text = userSelected.Password;
                    this.btnCancel.Visible = true;
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            this._Id = ZERO;
            this.clearFields();
            this.txtName.Focus();
            btn.Visible = false;
        }

    }
}
