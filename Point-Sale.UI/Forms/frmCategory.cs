using Point_Sale.DataAccess.Models;
using Point_Sale.DataAccess.Repository;
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
    public partial class frmCategory : Form
    {
        private readonly CategoryService _categoryService = null;
        const int ZERO = 0;
        const string ACTION_TEXT = "Accion";
        const string DELETE_TEXT = "Desactivar";
        public int _Id { get; set; }
        public frmCategory()
        {
            _categoryService = new CategoryService();
            InitializeComponent();
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            this.dgvCategory.AutoGenerateColumns = false;
            this.dgvCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.loadGrid();
        }

        private void loadGrid()
        {
            this.dgvCategory.Refresh();
            this.dgvCategory.DataSource = _categoryService.getAll();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string name = this.txtName.Text.Trim();
                string password = this.txtDescription.Text.Trim();
                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(password))
                {
                    return;
                }
                Category category = new Category()
                {
                    Id = this._Id,
                    CategoryName = name,
                    Description = password,
                    CreateAt = DateTime.UtcNow.ToString()
                };
                if (this._Id == ZERO)
                {
                    _categoryService.create(category);
                    MessageBox.Show("Categoria creada");
                }
                else
                {
                    _categoryService.update(category);
                    MessageBox.Show("Categoria actualizado");
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
            this.txtDescription.Clear();
        }
    }
}
