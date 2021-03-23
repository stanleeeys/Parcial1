
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
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.txtEmpl_nombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDui = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 194);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(847, 212);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.Location = new System.Drawing.Point(58, 60);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txtIdEmpleado.TabIndex = 1;
            // 
            // txtEmpl_nombre
            // 
            this.txtEmpl_nombre.Location = new System.Drawing.Point(58, 137);
            this.txtEmpl_nombre.Name = "txtEmpl_nombre";
            this.txtEmpl_nombre.Size = new System.Drawing.Size(100, 20);
            this.txtEmpl_nombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(236, 60);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // txtDui
            // 
            this.txtDui.Location = new System.Drawing.Point(236, 137);
            this.txtDui.Name = "txtDui";
            this.txtDui.Size = new System.Drawing.Size(100, 20);
            this.txtDui.TabIndex = 4;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(426, 60);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 5;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(426, 137);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(100, 20);
            this.txtTel.TabIndex = 6;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(580, 60);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(100, 20);
            this.txtemail.TabIndex = 7;
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(580, 137);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(100, 20);
            this.txtCargo.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Id_empleado";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Empl_nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Empl_apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Empl_DUI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(423, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Empl_direccion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(423, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Empl_tel";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(577, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Empl_email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(577, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Empl_cargo";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 614);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtDui);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtEmpl_nombre);
            this.Controls.Add(this.txtIdEmpleado);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox txtIdEmpleado;
        private System.Windows.Forms.TextBox txtEmpl_nombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDui;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}