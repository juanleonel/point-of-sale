namespace Point_Sale.UI.Forms
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTopMenu = new System.Windows.Forms.Panel();
            this.lblUsuariosCatalog = new System.Windows.Forms.Label();
            this.lblCategoryCatalog = new System.Windows.Forms.Label();
            this.lblProductosCatalog = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.pnlTopMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopMenu
            // 
            this.pnlTopMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlTopMenu.Controls.Add(this.lblUsuariosCatalog);
            this.pnlTopMenu.Controls.Add(this.lblCategoryCatalog);
            this.pnlTopMenu.Controls.Add(this.lblProductosCatalog);
            this.pnlTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlTopMenu.Name = "pnlTopMenu";
            this.pnlTopMenu.Size = new System.Drawing.Size(1504, 64);
            this.pnlTopMenu.TabIndex = 0;
            // 
            // lblUsuariosCatalog
            // 
            this.lblUsuariosCatalog.AutoSize = true;
            this.lblUsuariosCatalog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUsuariosCatalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuariosCatalog.Location = new System.Drawing.Point(12, 18);
            this.lblUsuariosCatalog.Name = "lblUsuariosCatalog";
            this.lblUsuariosCatalog.Size = new System.Drawing.Size(108, 29);
            this.lblUsuariosCatalog.TabIndex = 3;
            this.lblUsuariosCatalog.Text = "Usuarios";
            this.lblUsuariosCatalog.Click += new System.EventHandler(this.lblUsuariosCatalog_Click);
            // 
            // lblCategoryCatalog
            // 
            this.lblCategoryCatalog.AutoSize = true;
            this.lblCategoryCatalog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCategoryCatalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryCatalog.Location = new System.Drawing.Point(140, 18);
            this.lblCategoryCatalog.Name = "lblCategoryCatalog";
            this.lblCategoryCatalog.Size = new System.Drawing.Size(130, 29);
            this.lblCategoryCatalog.TabIndex = 1;
            this.lblCategoryCatalog.Text = "Categorias";
            // 
            // lblProductosCatalog
            // 
            this.lblProductosCatalog.AutoSize = true;
            this.lblProductosCatalog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblProductosCatalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductosCatalog.Location = new System.Drawing.Point(294, 18);
            this.lblProductosCatalog.Name = "lblProductosCatalog";
            this.lblProductosCatalog.Size = new System.Drawing.Size(122, 29);
            this.lblProductosCatalog.TabIndex = 0;
            this.lblProductosCatalog.Text = "Productos";
            // 
            // panelMenu
            // 
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(0, 64);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1504, 574);
            this.panelMenu.TabIndex = 1;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1504, 638);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.pnlTopMenu);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.pnlTopMenu.ResumeLayout(false);
            this.pnlTopMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopMenu;
        private System.Windows.Forms.Label lblProductosCatalog;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label lblCategoryCatalog;
        private System.Windows.Forms.Label lblUsuariosCatalog;
    }
}