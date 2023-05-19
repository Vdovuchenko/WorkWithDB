namespace WorkWithDB_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            btnAddServiceStation = new Button();
            txtName = new TextBox();
            txtAddress = new TextBox();
            txtPhoneNumber = new TextBox();
            txtWorkHours = new TextBox();
            panel1 = new Panel();
            lblErrorMessageServiceStation = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnUpdate = new Button();
            btnDelete = new Button();
            lblTableName = new Label();
            tabControl1 = new TabControl();
            Service_station = new TabPage();
            Employee = new TabPage();
            panel2 = new Panel();
            lblErrorMessageEmployee = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtEmployeeServiceStation_id = new TextBox();
            txtEmployeeWorkHours = new TextBox();
            txtEmployeeSalary = new TextBox();
            txtEmployeePosition = new TextBox();
            txtEmployeeName = new TextBox();
            btnEmployeeUpdate = new Button();
            btnEmployeeDelete = new Button();
            btnEmployeeAdd = new Button();
            dataGridView2 = new DataGridView();
            Invoice = new TabPage();
            lblErrorMessageInvoice = new Label();
            label10 = new Label();
            label11 = new Label();
            txtInvoiceAmount = new TextBox();
            txtInvoiceDate = new TextBox();
            btnInvoiceAdd = new Button();
            btnInvoiceDelete = new Button();
            btnInvoiceUpdate = new Button();
            dataGridView3 = new DataGridView();
            Motorist = new TabPage();
            lblErrorMessageMotorist = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            txtMotoristDrivingLicenseNumber = new TextBox();
            txtMotoristAddress = new TextBox();
            txtMotoristPhoneNumber = new TextBox();
            txtMotoristName = new TextBox();
            btnMotoristAdd = new Button();
            btnMotoristDelete = new Button();
            btnMotoristUpdate = new Button();
            dataGridView4 = new DataGridView();
            Service = new TabPage();
            lblErrorMessageService = new Label();
            label17 = new Label();
            label16 = new Label();
            txtServicePrice = new TextBox();
            txtServiceName = new TextBox();
            btnServiceAdd = new Button();
            btnServiceDelete = new Button();
            btnServiceUpdate = new Button();
            dataGridView5 = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            Service_station.SuspendLayout();
            Employee.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            Invoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            Motorist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            Service.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(762, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(93, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.ActiveCaption;
            dataGridView1.Location = new Point(82, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(661, 203);
            dataGridView1.TabIndex = 2;
            // 
            // btnAddServiceStation
            // 
            btnAddServiceStation.Anchor = AnchorStyles.Bottom;
            btnAddServiceStation.Location = new Point(605, 244);
            btnAddServiceStation.Name = "btnAddServiceStation";
            btnAddServiceStation.Size = new Size(73, 24);
            btnAddServiceStation.TabIndex = 7;
            btnAddServiceStation.Text = "Add";
            btnAddServiceStation.UseVisualStyleBackColor = true;
            btnAddServiceStation.Click += btnAddServiceStation_Click;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Bottom;
            txtName.Location = new Point(195, 245);
            txtName.Name = "txtName";
            txtName.Size = new Size(98, 23);
            txtName.TabIndex = 8;
            // 
            // txtAddress
            // 
            txtAddress.Anchor = AnchorStyles.Bottom;
            txtAddress.Location = new Point(297, 245);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(98, 23);
            txtAddress.TabIndex = 9;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Anchor = AnchorStyles.Bottom;
            txtPhoneNumber.Location = new Point(399, 245);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(98, 23);
            txtPhoneNumber.TabIndex = 10;
            // 
            // txtWorkHours
            // 
            txtWorkHours.Anchor = AnchorStyles.Bottom;
            txtWorkHours.Location = new Point(501, 245);
            txtWorkHours.Name = "txtWorkHours";
            txtWorkHours.Size = new Size(98, 23);
            txtWorkHours.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(lblErrorMessageServiceStation);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(txtPhoneNumber);
            panel1.Controls.Add(btnAddServiceStation);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(txtWorkHours);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(748, 273);
            panel1.TabIndex = 13;
            // 
            // lblErrorMessageServiceStation
            // 
            lblErrorMessageServiceStation.Anchor = AnchorStyles.Bottom;
            lblErrorMessageServiceStation.AutoSize = true;
            lblErrorMessageServiceStation.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorMessageServiceStation.Location = new Point(82, 200);
            lblErrorMessageServiceStation.Name = "lblErrorMessageServiceStation";
            lblErrorMessageServiceStation.Size = new Size(73, 25);
            lblErrorMessageServiceStation.TabIndex = 14;
            lblErrorMessageServiceStation.Text = "label18";
            lblErrorMessageServiceStation.Visible = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Location = new Point(517, 227);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 17;
            label4.Text = "Work hours";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Location = new Point(409, 227);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 16;
            label3.Text = "Phone number";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Location = new Point(322, 227);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 15;
            label2.Text = "Address";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Location = new Point(224, 227);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 14;
            label1.Text = "Name";
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Bottom;
            btnUpdate.Location = new Point(82, 244);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(61, 24);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom;
            btnDelete.Location = new Point(141, 244);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(50, 24);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblTableName
            // 
            lblTableName.AutoSize = true;
            lblTableName.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTableName.Location = new Point(73, 339);
            lblTableName.Name = "lblTableName";
            lblTableName.Size = new Size(59, 22);
            lblTableName.TabIndex = 14;
            lblTableName.Text = "label1";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Service_station);
            tabControl1.Controls.Add(Employee);
            tabControl1.Controls.Add(Invoice);
            tabControl1.Controls.Add(Motorist);
            tabControl1.Controls.Add(Service);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 24);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(762, 307);
            tabControl1.TabIndex = 15;
            // 
            // Service_station
            // 
            Service_station.BackColor = SystemColors.ActiveCaption;
            Service_station.Controls.Add(panel1);
            Service_station.Location = new Point(4, 24);
            Service_station.Name = "Service_station";
            Service_station.Padding = new Padding(3);
            Service_station.Size = new Size(754, 279);
            Service_station.TabIndex = 0;
            Service_station.Text = "Service station";
            // 
            // Employee
            // 
            Employee.BackColor = SystemColors.ActiveCaption;
            Employee.Controls.Add(panel2);
            Employee.Location = new Point(4, 24);
            Employee.Name = "Employee";
            Employee.Padding = new Padding(3);
            Employee.Size = new Size(754, 279);
            Employee.TabIndex = 1;
            Employee.Text = "Employee";
            // 
            // panel2
            // 
            panel2.Controls.Add(lblErrorMessageEmployee);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txtEmployeeServiceStation_id);
            panel2.Controls.Add(txtEmployeeWorkHours);
            panel2.Controls.Add(txtEmployeeSalary);
            panel2.Controls.Add(txtEmployeePosition);
            panel2.Controls.Add(txtEmployeeName);
            panel2.Controls.Add(btnEmployeeUpdate);
            panel2.Controls.Add(btnEmployeeDelete);
            panel2.Controls.Add(btnEmployeeAdd);
            panel2.Controls.Add(dataGridView2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(748, 273);
            panel2.TabIndex = 0;
            // 
            // lblErrorMessageEmployee
            // 
            lblErrorMessageEmployee.Anchor = AnchorStyles.Bottom;
            lblErrorMessageEmployee.AutoSize = true;
            lblErrorMessageEmployee.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorMessageEmployee.Location = new Point(138, 202);
            lblErrorMessageEmployee.Name = "lblErrorMessageEmployee";
            lblErrorMessageEmployee.Size = new Size(73, 25);
            lblErrorMessageEmployee.TabIndex = 1;
            lblErrorMessageEmployee.Text = "label18";
            lblErrorMessageEmployee.Visible = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.Location = new Point(168, 228);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 1;
            label5.Text = "Name";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom;
            label6.AutoSize = true;
            label6.Location = new Point(268, 227);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 2;
            label6.Text = "Position";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom;
            label7.AutoSize = true;
            label7.Location = new Point(380, 227);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 3;
            label7.Text = "Salary";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom;
            label8.AutoSize = true;
            label8.Location = new Point(474, 227);
            label8.Name = "label8";
            label8.Size = new Size(68, 15);
            label8.TabIndex = 4;
            label8.Text = "Work hours";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom;
            label9.AutoSize = true;
            label9.Location = new Point(565, 227);
            label9.Name = "label9";
            label9.Size = new Size(97, 15);
            label9.TabIndex = 5;
            label9.Text = "Service Station Id";
            // 
            // txtEmployeeServiceStation_id
            // 
            txtEmployeeServiceStation_id.Anchor = AnchorStyles.Bottom;
            txtEmployeeServiceStation_id.Location = new Point(562, 245);
            txtEmployeeServiceStation_id.Name = "txtEmployeeServiceStation_id";
            txtEmployeeServiceStation_id.Size = new Size(100, 23);
            txtEmployeeServiceStation_id.TabIndex = 21;
            // 
            // txtEmployeeWorkHours
            // 
            txtEmployeeWorkHours.Anchor = AnchorStyles.Bottom;
            txtEmployeeWorkHours.Location = new Point(456, 245);
            txtEmployeeWorkHours.Name = "txtEmployeeWorkHours";
            txtEmployeeWorkHours.Size = new Size(100, 23);
            txtEmployeeWorkHours.TabIndex = 20;
            // 
            // txtEmployeeSalary
            // 
            txtEmployeeSalary.Anchor = AnchorStyles.Bottom;
            txtEmployeeSalary.Location = new Point(350, 245);
            txtEmployeeSalary.Name = "txtEmployeeSalary";
            txtEmployeeSalary.Size = new Size(100, 23);
            txtEmployeeSalary.TabIndex = 19;
            // 
            // txtEmployeePosition
            // 
            txtEmployeePosition.Anchor = AnchorStyles.Bottom;
            txtEmployeePosition.Location = new Point(244, 245);
            txtEmployeePosition.Name = "txtEmployeePosition";
            txtEmployeePosition.Size = new Size(100, 23);
            txtEmployeePosition.TabIndex = 18;
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Anchor = AnchorStyles.Bottom;
            txtEmployeeName.Location = new Point(138, 245);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(100, 23);
            txtEmployeeName.TabIndex = 17;
            // 
            // btnEmployeeUpdate
            // 
            btnEmployeeUpdate.Anchor = AnchorStyles.Bottom;
            btnEmployeeUpdate.Location = new Point(3, 245);
            btnEmployeeUpdate.Name = "btnEmployeeUpdate";
            btnEmployeeUpdate.Size = new Size(59, 23);
            btnEmployeeUpdate.TabIndex = 1;
            btnEmployeeUpdate.Text = "Update";
            btnEmployeeUpdate.UseVisualStyleBackColor = true;
            btnEmployeeUpdate.Click += btnEmployeeUpdate_Click;
            // 
            // btnEmployeeDelete
            // 
            btnEmployeeDelete.Anchor = AnchorStyles.Bottom;
            btnEmployeeDelete.Location = new Point(61, 245);
            btnEmployeeDelete.Name = "btnEmployeeDelete";
            btnEmployeeDelete.Size = new Size(58, 25);
            btnEmployeeDelete.TabIndex = 2;
            btnEmployeeDelete.Text = "Delete";
            btnEmployeeDelete.UseVisualStyleBackColor = true;
            btnEmployeeDelete.Click += btnEmployeeDelete_Click;
            // 
            // btnEmployeeAdd
            // 
            btnEmployeeAdd.Anchor = AnchorStyles.Bottom;
            btnEmployeeAdd.Location = new Point(668, 245);
            btnEmployeeAdd.Name = "btnEmployeeAdd";
            btnEmployeeAdd.Size = new Size(75, 23);
            btnEmployeeAdd.TabIndex = 3;
            btnEmployeeAdd.Text = "Add";
            btnEmployeeAdd.UseVisualStyleBackColor = true;
            btnEmployeeAdd.Click += btnEmployeeAdd_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dataGridView2.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(61, 3);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(682, 196);
            dataGridView2.TabIndex = 16;
            // 
            // Invoice
            // 
            Invoice.BackColor = SystemColors.ActiveCaption;
            Invoice.Controls.Add(lblErrorMessageInvoice);
            Invoice.Controls.Add(label10);
            Invoice.Controls.Add(label11);
            Invoice.Controls.Add(txtInvoiceAmount);
            Invoice.Controls.Add(txtInvoiceDate);
            Invoice.Controls.Add(btnInvoiceAdd);
            Invoice.Controls.Add(btnInvoiceDelete);
            Invoice.Controls.Add(btnInvoiceUpdate);
            Invoice.Controls.Add(dataGridView3);
            Invoice.Location = new Point(4, 24);
            Invoice.Name = "Invoice";
            Invoice.Size = new Size(754, 279);
            Invoice.TabIndex = 2;
            Invoice.Text = "Invoice";
            // 
            // lblErrorMessageInvoice
            // 
            lblErrorMessageInvoice.Anchor = AnchorStyles.Bottom;
            lblErrorMessageInvoice.AutoSize = true;
            lblErrorMessageInvoice.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorMessageInvoice.Location = new Point(165, 202);
            lblErrorMessageInvoice.Name = "lblErrorMessageInvoice";
            lblErrorMessageInvoice.Size = new Size(73, 25);
            lblErrorMessageInvoice.TabIndex = 18;
            lblErrorMessageInvoice.Text = "label18";
            lblErrorMessageInvoice.Visible = false;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom;
            label10.AutoSize = true;
            label10.Location = new Point(496, 230);
            label10.Name = "label10";
            label10.Size = new Size(31, 15);
            label10.TabIndex = 16;
            label10.Text = "Date";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Bottom;
            label11.AutoSize = true;
            label11.Location = new Point(592, 230);
            label11.Name = "label11";
            label11.Size = new Size(51, 15);
            label11.TabIndex = 17;
            label11.Text = "Amount";
            // 
            // txtInvoiceAmount
            // 
            txtInvoiceAmount.Anchor = AnchorStyles.Bottom;
            txtInvoiceAmount.Location = new Point(565, 248);
            txtInvoiceAmount.Name = "txtInvoiceAmount";
            txtInvoiceAmount.Size = new Size(100, 23);
            txtInvoiceAmount.TabIndex = 5;
            // 
            // txtInvoiceDate
            // 
            txtInvoiceDate.Anchor = AnchorStyles.Bottom;
            txtInvoiceDate.Location = new Point(459, 248);
            txtInvoiceDate.Name = "txtInvoiceDate";
            txtInvoiceDate.Size = new Size(100, 23);
            txtInvoiceDate.TabIndex = 4;
            // 
            // btnInvoiceAdd
            // 
            btnInvoiceAdd.Anchor = AnchorStyles.Bottom;
            btnInvoiceAdd.Location = new Point(671, 248);
            btnInvoiceAdd.Name = "btnInvoiceAdd";
            btnInvoiceAdd.Size = new Size(75, 23);
            btnInvoiceAdd.TabIndex = 3;
            btnInvoiceAdd.Text = "Add";
            btnInvoiceAdd.UseVisualStyleBackColor = true;
            btnInvoiceAdd.Click += btnInvoiceAdd_Click;
            // 
            // btnInvoiceDelete
            // 
            btnInvoiceDelete.Anchor = AnchorStyles.Bottom;
            btnInvoiceDelete.Location = new Point(82, 248);
            btnInvoiceDelete.Name = "btnInvoiceDelete";
            btnInvoiceDelete.Size = new Size(75, 23);
            btnInvoiceDelete.TabIndex = 2;
            btnInvoiceDelete.Text = "Delete";
            btnInvoiceDelete.UseVisualStyleBackColor = true;
            btnInvoiceDelete.Click += btnInvoiceDelete_Click;
            // 
            // btnInvoiceUpdate
            // 
            btnInvoiceUpdate.Anchor = AnchorStyles.Bottom;
            btnInvoiceUpdate.Location = new Point(3, 248);
            btnInvoiceUpdate.Name = "btnInvoiceUpdate";
            btnInvoiceUpdate.Size = new Size(75, 23);
            btnInvoiceUpdate.TabIndex = 1;
            btnInvoiceUpdate.Text = "Update";
            btnInvoiceUpdate.UseVisualStyleBackColor = true;
            btnInvoiceUpdate.Click += btnInvoiceUpdate_Click;
            // 
            // dataGridView3
            // 
            dataGridView3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dataGridView3.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView3.BorderStyle = BorderStyle.None;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(147, 3);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new Size(599, 196);
            dataGridView3.TabIndex = 0;
            // 
            // Motorist
            // 
            Motorist.BackColor = SystemColors.ActiveCaption;
            Motorist.Controls.Add(lblErrorMessageMotorist);
            Motorist.Controls.Add(label12);
            Motorist.Controls.Add(label13);
            Motorist.Controls.Add(label14);
            Motorist.Controls.Add(label15);
            Motorist.Controls.Add(txtMotoristDrivingLicenseNumber);
            Motorist.Controls.Add(txtMotoristAddress);
            Motorist.Controls.Add(txtMotoristPhoneNumber);
            Motorist.Controls.Add(txtMotoristName);
            Motorist.Controls.Add(btnMotoristAdd);
            Motorist.Controls.Add(btnMotoristDelete);
            Motorist.Controls.Add(btnMotoristUpdate);
            Motorist.Controls.Add(dataGridView4);
            Motorist.Location = new Point(4, 24);
            Motorist.Name = "Motorist";
            Motorist.Size = new Size(754, 279);
            Motorist.TabIndex = 3;
            Motorist.Text = "Motorist";
            // 
            // lblErrorMessageMotorist
            // 
            lblErrorMessageMotorist.Anchor = AnchorStyles.Bottom;
            lblErrorMessageMotorist.AutoSize = true;
            lblErrorMessageMotorist.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorMessageMotorist.Location = new Point(159, 205);
            lblErrorMessageMotorist.Name = "lblErrorMessageMotorist";
            lblErrorMessageMotorist.Size = new Size(73, 25);
            lblErrorMessageMotorist.TabIndex = 20;
            lblErrorMessageMotorist.Text = "label18";
            lblErrorMessageMotorist.Visible = false;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Bottom;
            label12.AutoSize = true;
            label12.Location = new Point(279, 231);
            label12.Name = "label12";
            label12.Size = new Size(39, 15);
            label12.TabIndex = 16;
            label12.Text = "Name";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Bottom;
            label13.AutoSize = true;
            label13.Location = new Point(353, 231);
            label13.Name = "label13";
            label13.Size = new Size(86, 15);
            label13.TabIndex = 17;
            label13.Text = "Phone number";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Bottom;
            label14.AutoSize = true;
            label14.Location = new Point(484, 231);
            label14.Name = "label14";
            label14.Size = new Size(49, 15);
            label14.TabIndex = 18;
            label14.Text = "Address";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Bottom;
            label15.AutoSize = true;
            label15.Location = new Point(549, 231);
            label15.Name = "label15";
            label15.Size = new Size(129, 15);
            label15.TabIndex = 19;
            label15.Text = "Driving license number";
            // 
            // txtMotoristDrivingLicenseNumber
            // 
            txtMotoristDrivingLicenseNumber.Anchor = AnchorStyles.Bottom;
            txtMotoristDrivingLicenseNumber.Location = new Point(565, 249);
            txtMotoristDrivingLicenseNumber.Name = "txtMotoristDrivingLicenseNumber";
            txtMotoristDrivingLicenseNumber.Size = new Size(100, 23);
            txtMotoristDrivingLicenseNumber.TabIndex = 7;
            // 
            // txtMotoristAddress
            // 
            txtMotoristAddress.Anchor = AnchorStyles.Bottom;
            txtMotoristAddress.Location = new Point(459, 249);
            txtMotoristAddress.Name = "txtMotoristAddress";
            txtMotoristAddress.Size = new Size(100, 23);
            txtMotoristAddress.TabIndex = 6;
            // 
            // txtMotoristPhoneNumber
            // 
            txtMotoristPhoneNumber.Anchor = AnchorStyles.Bottom;
            txtMotoristPhoneNumber.Location = new Point(353, 249);
            txtMotoristPhoneNumber.Name = "txtMotoristPhoneNumber";
            txtMotoristPhoneNumber.Size = new Size(100, 23);
            txtMotoristPhoneNumber.TabIndex = 5;
            // 
            // txtMotoristName
            // 
            txtMotoristName.Anchor = AnchorStyles.Bottom;
            txtMotoristName.Location = new Point(247, 249);
            txtMotoristName.Name = "txtMotoristName";
            txtMotoristName.Size = new Size(100, 23);
            txtMotoristName.TabIndex = 4;
            // 
            // btnMotoristAdd
            // 
            btnMotoristAdd.Anchor = AnchorStyles.Bottom;
            btnMotoristAdd.Location = new Point(671, 248);
            btnMotoristAdd.Name = "btnMotoristAdd";
            btnMotoristAdd.Size = new Size(75, 23);
            btnMotoristAdd.TabIndex = 3;
            btnMotoristAdd.Text = "Add";
            btnMotoristAdd.UseVisualStyleBackColor = true;
            btnMotoristAdd.Click += btnMotoristAdd_Click;
            // 
            // btnMotoristDelete
            // 
            btnMotoristDelete.Anchor = AnchorStyles.Bottom;
            btnMotoristDelete.Location = new Point(84, 248);
            btnMotoristDelete.Name = "btnMotoristDelete";
            btnMotoristDelete.Size = new Size(75, 23);
            btnMotoristDelete.TabIndex = 2;
            btnMotoristDelete.Text = "Delete";
            btnMotoristDelete.UseVisualStyleBackColor = true;
            btnMotoristDelete.Click += btnMotoristDelete_Click;
            // 
            // btnMotoristUpdate
            // 
            btnMotoristUpdate.Anchor = AnchorStyles.Bottom;
            btnMotoristUpdate.Location = new Point(3, 248);
            btnMotoristUpdate.Name = "btnMotoristUpdate";
            btnMotoristUpdate.Size = new Size(75, 23);
            btnMotoristUpdate.TabIndex = 1;
            btnMotoristUpdate.Text = "Update";
            btnMotoristUpdate.UseVisualStyleBackColor = true;
            btnMotoristUpdate.Click += btnMotoristUpdate_Click;
            // 
            // dataGridView4
            // 
            dataGridView4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dataGridView4.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView4.BorderStyle = BorderStyle.None;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(36, 3);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowTemplate.Height = 25;
            dataGridView4.Size = new Size(679, 199);
            dataGridView4.TabIndex = 0;
            // 
            // Service
            // 
            Service.BackColor = SystemColors.ActiveCaption;
            Service.Controls.Add(lblErrorMessageService);
            Service.Controls.Add(label17);
            Service.Controls.Add(label16);
            Service.Controls.Add(txtServicePrice);
            Service.Controls.Add(txtServiceName);
            Service.Controls.Add(btnServiceAdd);
            Service.Controls.Add(btnServiceDelete);
            Service.Controls.Add(btnServiceUpdate);
            Service.Controls.Add(dataGridView5);
            Service.Location = new Point(4, 24);
            Service.Name = "Service";
            Service.Size = new Size(754, 279);
            Service.TabIndex = 4;
            Service.Text = "Service";
            // 
            // lblErrorMessageService
            // 
            lblErrorMessageService.Anchor = AnchorStyles.Bottom;
            lblErrorMessageService.AutoSize = true;
            lblErrorMessageService.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorMessageService.Location = new Point(165, 204);
            lblErrorMessageService.Name = "lblErrorMessageService";
            lblErrorMessageService.Size = new Size(73, 25);
            lblErrorMessageService.TabIndex = 8;
            lblErrorMessageService.Text = "label18";
            lblErrorMessageService.Visible = false;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Bottom;
            label17.AutoSize = true;
            label17.Location = new Point(598, 230);
            label17.Name = "label17";
            label17.Size = new Size(33, 15);
            label17.TabIndex = 7;
            label17.Text = "Price";
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Bottom;
            label16.AutoSize = true;
            label16.Location = new Point(491, 230);
            label16.Name = "label16";
            label16.Size = new Size(39, 15);
            label16.TabIndex = 6;
            label16.Text = "Name";
            // 
            // txtServicePrice
            // 
            txtServicePrice.Anchor = AnchorStyles.Bottom;
            txtServicePrice.Location = new Point(565, 248);
            txtServicePrice.Name = "txtServicePrice";
            txtServicePrice.Size = new Size(100, 23);
            txtServicePrice.TabIndex = 5;
            // 
            // txtServiceName
            // 
            txtServiceName.Anchor = AnchorStyles.Bottom;
            txtServiceName.Location = new Point(459, 248);
            txtServiceName.Name = "txtServiceName";
            txtServiceName.Size = new Size(100, 23);
            txtServiceName.TabIndex = 4;
            // 
            // btnServiceAdd
            // 
            btnServiceAdd.Anchor = AnchorStyles.Bottom;
            btnServiceAdd.Location = new Point(671, 248);
            btnServiceAdd.Name = "btnServiceAdd";
            btnServiceAdd.Size = new Size(75, 23);
            btnServiceAdd.TabIndex = 3;
            btnServiceAdd.Text = "Add";
            btnServiceAdd.UseVisualStyleBackColor = true;
            btnServiceAdd.Click += btnServiceAdd_Click;
            // 
            // btnServiceDelete
            // 
            btnServiceDelete.Anchor = AnchorStyles.Bottom;
            btnServiceDelete.Location = new Point(95, 248);
            btnServiceDelete.Name = "btnServiceDelete";
            btnServiceDelete.Size = new Size(75, 23);
            btnServiceDelete.TabIndex = 2;
            btnServiceDelete.Text = "Delete";
            btnServiceDelete.UseVisualStyleBackColor = true;
            btnServiceDelete.Click += btnServiceDelete_Click;
            // 
            // btnServiceUpdate
            // 
            btnServiceUpdate.Anchor = AnchorStyles.Bottom;
            btnServiceUpdate.Location = new Point(14, 248);
            btnServiceUpdate.Name = "btnServiceUpdate";
            btnServiceUpdate.Size = new Size(75, 23);
            btnServiceUpdate.TabIndex = 1;
            btnServiceUpdate.Text = "Update";
            btnServiceUpdate.UseVisualStyleBackColor = true;
            btnServiceUpdate.Click += btnServiceUpdate_Click;
            // 
            // dataGridView5
            // 
            dataGridView5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dataGridView5.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView5.BorderStyle = BorderStyle.None;
            dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView5.Location = new Point(148, 0);
            dataGridView5.Name = "dataGridView5";
            dataGridView5.RowTemplate.Height = 25;
            dataGridView5.Size = new Size(460, 201);
            dataGridView5.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(762, 331);
            Controls.Add(tabControl1);
            Controls.Add(lblTableName);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(778, 370);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WorkWithDB";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            Service_station.ResumeLayout(false);
            Employee.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            Invoice.ResumeLayout(false);
            Invoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            Motorist.ResumeLayout(false);
            Motorist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            Service.ResumeLayout(false);
            Service.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private DataGridView dataGridView1;
        private Button btnAddServiceStation;
        private TextBox txtName;
        private TextBox txtAddress;
        private TextBox txtPhoneNumber;
        private TextBox txtWorkHours;
        private Panel panel1;
        private Button btnDelete;
        private Button btnUpdate;
        private Label lblTableName;
        private TabControl tabControl1;
        private TabPage Service_station;
        private TabPage Employee;
        private TabPage Invoice;
        private TabPage Motorist;
        private TabPage Service;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private DataGridView dataGridView2;
        private Button btnEmployeeUpdate;
        private Button btnEmployeeDelete;
        private Button btnEmployeeAdd;
        private TextBox txtEmployeeServiceStation_id;
        private TextBox txtEmployeeWorkHours;
        private TextBox txtEmployeeSalary;
        private TextBox txtEmployeePosition;
        private TextBox txtEmployeeName;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox txtInvoiceAmount;
        private TextBox txtInvoiceDate;
        private Button btnInvoiceAdd;
        private Button btnInvoiceDelete;
        private Button btnInvoiceUpdate;
        private DataGridView dataGridView3;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private TextBox txtMotoristDrivingLicenseNumber;
        private TextBox txtMotoristAddress;
        private TextBox txtMotoristPhoneNumber;
        private TextBox txtMotoristName;
        private Button btnMotoristAdd;
        private Button btnMotoristDelete;
        private Button btnMotoristUpdate;
        private DataGridView dataGridView4;
        private Label label17;
        private Label label16;
        private TextBox txtServicePrice;
        private TextBox txtServiceName;
        private Button btnServiceAdd;
        private Button btnServiceDelete;
        private Button btnServiceUpdate;
        private DataGridView dataGridView5;
        private Label lblErrorMessageServiceStation;
        private Label lblErrorMessageEmployee;
        private Label lblErrorMessageInvoice;
        private Label lblErrorMessageMotorist;
        private Label lblErrorMessageService;
    }
}