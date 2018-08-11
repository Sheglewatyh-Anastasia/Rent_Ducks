namespace RentOfDucks
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tbPg_Orders = new System.Windows.Forms.TabPage();
            this.dGV_Orders = new System.Windows.Forms.DataGridView();
            this.tbPg_Ducks = new System.Windows.Forms.TabPage();
            this.dGV_Ducks = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tbPg_Orders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Orders)).BeginInit();
            this.tbPg_Ducks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Ducks)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tbPg_Orders);
            this.tabControl.Controls.Add(this.tbPg_Ducks);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(679, 243);
            this.tabControl.TabIndex = 0;
            // 
            // tbPg_Orders
            // 
            this.tbPg_Orders.Controls.Add(this.dGV_Orders);
            this.tbPg_Orders.Location = new System.Drawing.Point(4, 22);
            this.tbPg_Orders.Name = "tbPg_Orders";
            this.tbPg_Orders.Padding = new System.Windows.Forms.Padding(3);
            this.tbPg_Orders.Size = new System.Drawing.Size(671, 217);
            this.tbPg_Orders.TabIndex = 1;
            this.tbPg_Orders.Text = "Заказы";
            this.tbPg_Orders.UseVisualStyleBackColor = true;
            // 
            // dGV_Orders
            // 
            this.dGV_Orders.AllowUserToAddRows = false;
            this.dGV_Orders.AllowUserToDeleteRows = false;
            this.dGV_Orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Orders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGV_Orders.Location = new System.Drawing.Point(3, 3);
            this.dGV_Orders.Name = "dGV_Orders";
            this.dGV_Orders.ReadOnly = true;
            this.dGV_Orders.Size = new System.Drawing.Size(665, 211);
            this.dGV_Orders.TabIndex = 0;
            // 
            // tbPg_Ducks
            // 
            this.tbPg_Ducks.Controls.Add(this.dGV_Ducks);
            this.tbPg_Ducks.Location = new System.Drawing.Point(4, 22);
            this.tbPg_Ducks.Name = "tbPg_Ducks";
            this.tbPg_Ducks.Padding = new System.Windows.Forms.Padding(3);
            this.tbPg_Ducks.Size = new System.Drawing.Size(671, 217);
            this.tbPg_Ducks.TabIndex = 0;
            this.tbPg_Ducks.Text = "Уточки";
            this.tbPg_Ducks.UseVisualStyleBackColor = true;
            // 
            // dGV_Ducks
            // 
            this.dGV_Ducks.AllowUserToAddRows = false;
            this.dGV_Ducks.AllowUserToDeleteRows = false;
            this.dGV_Ducks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Ducks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGV_Ducks.Location = new System.Drawing.Point(3, 3);
            this.dGV_Ducks.Name = "dGV_Ducks";
            this.dGV_Ducks.ReadOnly = true;
            this.dGV_Ducks.Size = new System.Drawing.Size(665, 211);
            this.dGV_Ducks.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tabControl);
            this.panel1.Location = new System.Drawing.Point(0, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 243);
            this.panel1.TabIndex = 1;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Image = global::RentOfDucks.Properties.Resources.del_l;
            this.btn_Delete.Location = new System.Drawing.Point(108, 22);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(42, 42);
            this.btn_Delete.TabIndex = 4;
            this.toolTip.SetToolTip(this.btn_Delete, "Удалить");
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Image = global::RentOfDucks.Properties.Resources.edit_l;
            this.btn_Edit.Location = new System.Drawing.Point(60, 22);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(42, 42);
            this.btn_Edit.TabIndex = 3;
            this.toolTip.SetToolTip(this.btn_Edit, "Редактировать");
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Image = global::RentOfDucks.Properties.Resources.add_l;
            this.btn_Add.Location = new System.Drawing.Point(12, 22);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(42, 42);
            this.btn_Add.TabIndex = 2;
            this.toolTip.SetToolTip(this.btn_Add, "Добавить");
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 330);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(378, 272);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказ уточек";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tbPg_Orders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Orders)).EndInit();
            this.tbPg_Ducks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Ducks)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tbPg_Ducks;
        private System.Windows.Forms.TabPage tbPg_Orders;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dGV_Ducks;
        private System.Windows.Forms.DataGridView dGV_Orders;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.ToolTip toolTip;
    }
}