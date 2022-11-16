namespace Point_Sale.UI.Forms
{
    partial class ctrlLog
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblNameSistemLog = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnLogout.BackColor = System.Drawing.Color.IndianRed;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(181, -1);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 39);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Salir";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblNameSistemLog
            // 
            this.lblNameSistemLog.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNameSistemLog.AutoSize = true;
            this.lblNameSistemLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameSistemLog.Location = new System.Drawing.Point(3, 7);
            this.lblNameSistemLog.Name = "lblNameSistemLog";
            this.lblNameSistemLog.Size = new System.Drawing.Size(97, 22);
            this.lblNameSistemLog.TabIndex = 7;
            this.lblNameSistemLog.Text = "Log Name ";
            // 
            // ctrlLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblNameSistemLog);
            this.Name = "ctrlLog";
            this.Size = new System.Drawing.Size(261, 36);
            this.Load += new System.EventHandler(this.ctrlLog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblNameSistemLog;
    }
}
