
namespace Parcial1.Vista
{
    partial class FrmMenu
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id_empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empl_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empl_apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empl_DUI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empl_direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empl_tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empl_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empl_cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_empleado,
            this.Empl_nombre,
            this.Empl_apellido,
            this.Empl_DUI,
            this.Empl_direccion,
            this.Empl_tel,
            this.Empl_email,
            this.Empl_cargo});
            this.dataGridView1.Location = new System.Drawing.Point(52, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(845, 353);
            this.dataGridView1.TabIndex = 0;
            // 
            // Id_empleado
            // 
            this.Id_empleado.HeaderText = "Id_empleado";
            this.Id_empleado.Name = "Id_empleado";
            // 
            // Empl_nombre
            // 
            this.Empl_nombre.HeaderText = "Empl_nombre";
            this.Empl_nombre.Name = "Empl_nombre";
            // 
            // Empl_apellido
            // 
            this.Empl_apellido.HeaderText = "Empl_apellido";
            this.Empl_apellido.Name = "Empl_apellido";
            // 
            // Empl_DUI
            // 
            this.Empl_DUI.HeaderText = "Empl_DUI";
            this.Empl_DUI.Name = "Empl_DUI";
            // 
            // Empl_direccion
            // 
            this.Empl_direccion.HeaderText = "Empl_direccion";
            this.Empl_direccion.Name = "Empl_direccion";
            // 
            // Empl_tel
            // 
            this.Empl_tel.HeaderText = "Empl_tel";
            this.Empl_tel.Name = "Empl_tel";
            // 
            // Empl_email
            // 
            this.Empl_email.HeaderText = "Empl_email";
            this.Empl_email.Name = "Empl_email";
            // 
            // Empl_cargo
            // 
            this.Empl_cargo.HeaderText = "Empl_cargo";
            this.Empl_cargo.Name = "Empl_cargo";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empl_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empl_apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empl_DUI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empl_direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empl_tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empl_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empl_cargo;
    }
}