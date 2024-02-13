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
            this.placeholderTextBox7 = new MVPPatternDEMO.CustomControls.PlaceholderTextBox();
            this.placeholderTextBox6 = new MVPPatternDEMO.CustomControls.PlaceholderTextBox();
            this.placeholderTextBox5 = new MVPPatternDEMO.CustomControls.PlaceholderTextBox();
            this.placeholderTextBox4 = new MVPPatternDEMO.CustomControls.PlaceholderTextBox();
            this.placeholderTextBox3 = new MVPPatternDEMO.CustomControls.PlaceholderTextBox();
            this.placeholderTextBox2 = new MVPPatternDEMO.CustomControls.PlaceholderTextBox();
            this.placeholderTextBox1 = new MVPPatternDEMO.CustomControls.PlaceholderTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.tableLayoutPanel1.Controls.Add(this.placeholderTextBox7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.placeholderTextBox6, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.placeholderTextBox5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.placeholderTextBox4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.placeholderTextBox3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.placeholderTextBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.placeholderTextBox1, 0, 0);
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
            // placeholderTextBox7
            // 
            this.placeholderTextBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.placeholderTextBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeholderTextBox7.ForeColor = System.Drawing.Color.Gray;
            this.placeholderTextBox7.Location = new System.Drawing.Point(3, 114);
            this.placeholderTextBox7.Name = "placeholderTextBox7";
            this.placeholderTextBox7.PlaceholderColor = System.Drawing.Color.Gray;
            this.placeholderTextBox7.PlaceholderText = "Age";
            this.placeholderTextBox7.Size = new System.Drawing.Size(159, 26);
            this.placeholderTextBox7.TabIndex = 6;
            this.placeholderTextBox7.Text = "Age";
            // 
            // placeholderTextBox6
            // 
            this.placeholderTextBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.placeholderTextBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeholderTextBox6.ForeColor = System.Drawing.Color.Gray;
            this.placeholderTextBox6.Location = new System.Drawing.Point(168, 77);
            this.placeholderTextBox6.Name = "placeholderTextBox6";
            this.placeholderTextBox6.PlaceholderColor = System.Drawing.Color.Gray;
            this.placeholderTextBox6.PlaceholderText = "Salary";
            this.placeholderTextBox6.Size = new System.Drawing.Size(160, 26);
            this.placeholderTextBox6.TabIndex = 5;
            this.placeholderTextBox6.Text = "Salary";
            // 
            // placeholderTextBox5
            // 
            this.placeholderTextBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.placeholderTextBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeholderTextBox5.ForeColor = System.Drawing.Color.Gray;
            this.placeholderTextBox5.Location = new System.Drawing.Point(3, 77);
            this.placeholderTextBox5.Name = "placeholderTextBox5";
            this.placeholderTextBox5.PlaceholderColor = System.Drawing.Color.Gray;
            this.placeholderTextBox5.PlaceholderText = "Last Name";
            this.placeholderTextBox5.Size = new System.Drawing.Size(159, 26);
            this.placeholderTextBox5.TabIndex = 4;
            this.placeholderTextBox5.Text = "Last Name";
            // 
            // placeholderTextBox4
            // 
            this.placeholderTextBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.placeholderTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeholderTextBox4.ForeColor = System.Drawing.Color.Gray;
            this.placeholderTextBox4.Location = new System.Drawing.Point(168, 40);
            this.placeholderTextBox4.Name = "placeholderTextBox4";
            this.placeholderTextBox4.PlaceholderColor = System.Drawing.Color.Gray;
            this.placeholderTextBox4.PlaceholderText = "Office";
            this.placeholderTextBox4.Size = new System.Drawing.Size(160, 26);
            this.placeholderTextBox4.TabIndex = 3;
            this.placeholderTextBox4.Text = "Office";
            // 
            // placeholderTextBox3
            // 
            this.placeholderTextBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.placeholderTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeholderTextBox3.ForeColor = System.Drawing.Color.Gray;
            this.placeholderTextBox3.Location = new System.Drawing.Point(3, 40);
            this.placeholderTextBox3.Name = "placeholderTextBox3";
            this.placeholderTextBox3.PlaceholderColor = System.Drawing.Color.Gray;
            this.placeholderTextBox3.PlaceholderText = "Middle Name";
            this.placeholderTextBox3.Size = new System.Drawing.Size(159, 26);
            this.placeholderTextBox3.TabIndex = 2;
            this.placeholderTextBox3.Text = "Middle Name";
            // 
            // placeholderTextBox2
            // 
            this.placeholderTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.placeholderTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeholderTextBox2.ForeColor = System.Drawing.Color.Gray;
            this.placeholderTextBox2.Location = new System.Drawing.Point(168, 3);
            this.placeholderTextBox2.Name = "placeholderTextBox2";
            this.placeholderTextBox2.PlaceholderColor = System.Drawing.Color.Gray;
            this.placeholderTextBox2.PlaceholderText = "Position";
            this.placeholderTextBox2.Size = new System.Drawing.Size(160, 26);
            this.placeholderTextBox2.TabIndex = 1;
            this.placeholderTextBox2.Text = "Position";
            // 
            // placeholderTextBox1
            // 
            this.placeholderTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.placeholderTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeholderTextBox1.ForeColor = System.Drawing.Color.Gray;
            this.placeholderTextBox1.Location = new System.Drawing.Point(3, 3);
            this.placeholderTextBox1.Name = "placeholderTextBox1";
            this.placeholderTextBox1.PlaceholderColor = System.Drawing.Color.Gray;
            this.placeholderTextBox1.PlaceholderText = "First Name";
            this.placeholderTextBox1.Size = new System.Drawing.Size(159, 26);
            this.placeholderTextBox1.TabIndex = 0;
            this.placeholderTextBox1.Text = "First Name";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(15, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RosyBrown;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(110, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(265, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dgvEmployeeList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainView";
            this.Text = "MVP Demo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployeeList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CustomControls.PlaceholderTextBox placeholderTextBox7;
        private CustomControls.PlaceholderTextBox placeholderTextBox6;
        private CustomControls.PlaceholderTextBox placeholderTextBox5;
        private CustomControls.PlaceholderTextBox placeholderTextBox4;
        private CustomControls.PlaceholderTextBox placeholderTextBox3;
        private CustomControls.PlaceholderTextBox placeholderTextBox2;
        private CustomControls.PlaceholderTextBox placeholderTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

