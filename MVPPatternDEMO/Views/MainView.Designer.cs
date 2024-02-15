namespace MVPPatternDEMO
{
    partial class MainView
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
            this.dgvEmployeeList = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvCopy = new System.Windows.Forms.DataGridView();
            this.ptbAge = new MVPPatternDEMO.CustomControls.PlaceholderTextBox();
            this.ptbSalary = new MVPPatternDEMO.CustomControls.PlaceholderTextBox();
            this.ptbLastName = new MVPPatternDEMO.CustomControls.PlaceholderTextBox();
            this.ptbOffice = new MVPPatternDEMO.CustomControls.PlaceholderTextBox();
            this.ptbMiddleName = new MVPPatternDEMO.CustomControls.PlaceholderTextBox();
            this.ptbPosition = new MVPPatternDEMO.CustomControls.PlaceholderTextBox();
            this.ptbFirstName = new MVPPatternDEMO.CustomControls.PlaceholderTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCopy)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployeeList
            // 
            this.dgvEmployeeList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvEmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeList.Location = new System.Drawing.Point(349, 12);
            this.dgvEmployeeList.Name = "dgvEmployeeList";
            this.dgvEmployeeList.Size = new System.Drawing.Size(439, 426);
            this.dgvEmployeeList.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ptbAge, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ptbSalary, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ptbLastName, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ptbOffice, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ptbMiddleName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ptbPosition, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ptbFirstName, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 58);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(331, 149);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Employee Details:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Location = new System.Drawing.Point(15, 256);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.RosyBrown;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(110, 256);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            // 
            // dgvCopy
            // 
            this.dgvCopy.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvCopy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCopy.Location = new System.Drawing.Point(819, 12);
            this.dgvCopy.Name = "dgvCopy";
            this.dgvCopy.Size = new System.Drawing.Size(439, 426);
            this.dgvCopy.TabIndex = 5;
            // 
            // ptbAge
            // 
            this.ptbAge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptbAge.ForeColor = System.Drawing.Color.Gray;
            this.ptbAge.Location = new System.Drawing.Point(3, 114);
            this.ptbAge.Name = "ptbAge";
            this.ptbAge.PlaceholderColor = System.Drawing.Color.Gray;
            this.ptbAge.PlaceholderText = "Age";
            this.ptbAge.Size = new System.Drawing.Size(159, 26);
            this.ptbAge.TabIndex = 6;
            this.ptbAge.Text = "Age";
            // 
            // ptbSalary
            // 
            this.ptbSalary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptbSalary.ForeColor = System.Drawing.Color.Gray;
            this.ptbSalary.Location = new System.Drawing.Point(168, 77);
            this.ptbSalary.Name = "ptbSalary";
            this.ptbSalary.PlaceholderColor = System.Drawing.Color.Gray;
            this.ptbSalary.PlaceholderText = "Salary";
            this.ptbSalary.Size = new System.Drawing.Size(160, 26);
            this.ptbSalary.TabIndex = 5;
            this.ptbSalary.Text = "Salary";
            // 
            // ptbLastName
            // 
            this.ptbLastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptbLastName.ForeColor = System.Drawing.Color.Gray;
            this.ptbLastName.Location = new System.Drawing.Point(3, 77);
            this.ptbLastName.Name = "ptbLastName";
            this.ptbLastName.PlaceholderColor = System.Drawing.Color.Gray;
            this.ptbLastName.PlaceholderText = "Last Name";
            this.ptbLastName.Size = new System.Drawing.Size(159, 26);
            this.ptbLastName.TabIndex = 4;
            this.ptbLastName.Text = "Last Name";
            // 
            // ptbOffice
            // 
            this.ptbOffice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbOffice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptbOffice.ForeColor = System.Drawing.Color.Gray;
            this.ptbOffice.Location = new System.Drawing.Point(168, 40);
            this.ptbOffice.Name = "ptbOffice";
            this.ptbOffice.PlaceholderColor = System.Drawing.Color.Gray;
            this.ptbOffice.PlaceholderText = "Office";
            this.ptbOffice.Size = new System.Drawing.Size(160, 26);
            this.ptbOffice.TabIndex = 3;
            this.ptbOffice.Text = "Office";
            // 
            // ptbMiddleName
            // 
            this.ptbMiddleName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptbMiddleName.ForeColor = System.Drawing.Color.Gray;
            this.ptbMiddleName.Location = new System.Drawing.Point(3, 40);
            this.ptbMiddleName.Name = "ptbMiddleName";
            this.ptbMiddleName.PlaceholderColor = System.Drawing.Color.Gray;
            this.ptbMiddleName.PlaceholderText = "Middle Name";
            this.ptbMiddleName.Size = new System.Drawing.Size(159, 26);
            this.ptbMiddleName.TabIndex = 2;
            this.ptbMiddleName.Text = "Middle Name";
            // 
            // ptbPosition
            // 
            this.ptbPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptbPosition.ForeColor = System.Drawing.Color.Gray;
            this.ptbPosition.Location = new System.Drawing.Point(168, 3);
            this.ptbPosition.Name = "ptbPosition";
            this.ptbPosition.PlaceholderColor = System.Drawing.Color.Gray;
            this.ptbPosition.PlaceholderText = "Position";
            this.ptbPosition.Size = new System.Drawing.Size(160, 26);
            this.ptbPosition.TabIndex = 1;
            this.ptbPosition.Text = "Position";
            // 
            // ptbFirstName
            // 
            this.ptbFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptbFirstName.ForeColor = System.Drawing.Color.Gray;
            this.ptbFirstName.Location = new System.Drawing.Point(3, 3);
            this.ptbFirstName.Name = "ptbFirstName";
            this.ptbFirstName.PlaceholderColor = System.Drawing.Color.Gray;
            this.ptbFirstName.PlaceholderText = "First Name";
            this.ptbFirstName.Size = new System.Drawing.Size(159, 26);
            this.ptbFirstName.TabIndex = 0;
            this.ptbFirstName.Text = "First Name";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1270, 450);
            this.Controls.Add(this.dgvCopy);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dgvEmployeeList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainView";
            this.Text = "MVP Demo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCopy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployeeList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CustomControls.PlaceholderTextBox ptbAge;
        private CustomControls.PlaceholderTextBox ptbSalary;
        private CustomControls.PlaceholderTextBox ptbLastName;
        private CustomControls.PlaceholderTextBox ptbOffice;
        private CustomControls.PlaceholderTextBox ptbMiddleName;
        private CustomControls.PlaceholderTextBox ptbPosition;
        private CustomControls.PlaceholderTextBox ptbFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvCopy;
    }
}

