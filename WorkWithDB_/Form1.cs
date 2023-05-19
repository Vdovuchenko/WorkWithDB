using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;
using System.Xml.Linq;
using WorkWithDB_.Context;
using WorkWithDB_.Models;

namespace WorkWithDB_
{
    public partial class Form1 : Form
    {
        private MyDbContext dbContext;

        public Form1()
        {
            InitializeComponent();
            dbContext = new MyDbContext();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridView2.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridView3.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridView4.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridView5.EditMode = DataGridViewEditMode.EditOnEnter;

            using (var context = new MyDbContext())
            {

                var table1Data = context.ServiceStations.ToList();
                var table2Data = context.Employees.ToList();
                var table3Data = context.Invoices.ToList();
                var table4Data = context.Motorists.ToList();
                var table5Data = context.Services.ToList();


                dataGridView1.DataSource = table1Data;
                dataGridView2.DataSource = table2Data;
                dataGridView3.DataSource = table3Data;
                dataGridView4.DataSource = table4Data;
                dataGridView5.DataSource = table5Data;
            }
        }


        ////////////////////////SERVICE STATION////////////////////
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            dbContext.SaveChanges();
            RefreshServiceStations();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteSelectedRow(dataGridView1, dbContext.ServiceStations);
            RefreshServiceStations();
        }

        private async void btnAddServiceStation_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceStation serviceStation = new ServiceStation
                {
                    Name = txtName.Text,
                    Address = txtAddress.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    WorkHours = txtWorkHours.Text
                };

                dbContext.ServiceStations.Add(serviceStation);
                dbContext.SaveChanges();

                txtName.Text = "";
                txtAddress.Text = "";
                txtPhoneNumber.Text = "";
                txtWorkHours.Text = "";

                RefreshServiceStations();

                lblErrorMessageServiceStation.ForeColor = Color.Green;
                lblErrorMessageServiceStation.Text = "Data added successfully!";
                lblErrorMessageServiceStation.Visible = true;

                await Task.Delay(5000);

                for (double opacity = 1; opacity >= 0; opacity -= 0.1)
                {
                    lblErrorMessageServiceStation.ForeColor = Color.FromArgb((int)(255 * opacity), lblErrorMessageServiceStation.ForeColor);
                    await Task.Delay(100);
                }

                lblErrorMessageServiceStation.Visible = false;
            }
            catch (Exception ex)
            {
                lblErrorMessageServiceStation.ForeColor = Color.Red;
                lblErrorMessageServiceStation.Text = "Data entry error: " + ex.Message;
                lblErrorMessageServiceStation.Visible = true;

                await Task.Delay(5000);

                for (double opacity = 1; opacity >= 0; opacity -= 0.1)
                {
                    lblErrorMessageServiceStation.ForeColor = Color.FromArgb((int)(255 * opacity), lblErrorMessageServiceStation.ForeColor);
                    await Task.Delay(100);
                }

                lblErrorMessageServiceStation.Visible = false;
            }
        }

        private void RefreshServiceStations()
        {
            var serviceStations = dbContext.ServiceStations.ToList();
            dataGridView1.DataSource = serviceStations;
        }


        ////////////////////////EMPLOYEE////////////////////
        private void btnEmployeeUpdate_Click(object sender, EventArgs e)
        {
            dataGridView2.EndEdit();
            dbContext.SaveChanges();
            RefreshEmployees();
        }

        private void btnEmployeeDelete_Click(object sender, EventArgs e)
        {
            DeleteSelectedRow(dataGridView2, dbContext.Employees);
            RefreshEmployees();
        }

        private async void btnEmployeeAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee
                {
                    Name = txtEmployeeName.Text,
                    Position = txtEmployeePosition.Text,
                    Salary = decimal.Parse(txtEmployeeSalary.Text),
                    WorkHours = txtEmployeeWorkHours.Text,
                    ServiceStation_id = int.Parse(txtEmployeeServiceStation_id.Text)
                };

                dbContext.Employees.Add(employee);
                dbContext.SaveChanges();

                txtEmployeeName.Text = "";
                txtEmployeePosition.Text = "";
                txtEmployeeSalary.Text = "";
                txtEmployeeWorkHours.Text = "";
                txtEmployeeServiceStation_id.Text = "";

                RefreshEmployees();

                lblErrorMessageEmployee.ForeColor = Color.Green;
                lblErrorMessageEmployee.Text = "Data added successfully!";
                lblErrorMessageEmployee.Visible = true;

                await Task.Delay(5000);

                for (double opacity = 1; opacity >= 0; opacity -= 0.1)
                {
                    lblErrorMessageEmployee.ForeColor = Color.FromArgb((int)(255 * opacity), lblErrorMessageEmployee.ForeColor);
                    await Task.Delay(100);
                }

                lblErrorMessageEmployee.Visible = false;
            }
            catch (Exception ex)
            {
                lblErrorMessageEmployee.ForeColor = Color.Red;
                lblErrorMessageEmployee.Text = "Data entry error: " + ex.Message;
                lblErrorMessageEmployee.Visible = true;

                await Task.Delay(5000);

                for (double opacity = 1; opacity >= 0; opacity -= 0.1)
                {
                    lblErrorMessageEmployee.ForeColor = Color.FromArgb((int)(255 * opacity), lblErrorMessageEmployee.ForeColor);
                    await Task.Delay(100);
                }

                lblErrorMessageEmployee.Visible = false;
            }
        }

        private void RefreshEmployees()
        {
            var employees = dbContext.Employees.ToList();
            dataGridView2.DataSource = employees;
        }



        ////////////////////////INVOICE////////////////////
        private void btnInvoiceUpdate_Click(object sender, EventArgs e)
        {
            dataGridView3.EndEdit();
            dbContext.SaveChanges();
            RefreshInvoices();
        }

        private void btnInvoiceDelete_Click(object sender, EventArgs e)
        {
            DeleteSelectedRow(dataGridView3, dbContext.Invoices);
            RefreshInvoices();
        }

        private async void btnInvoiceAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Invoice invoice = new Invoice
                {
                    Date = DateTime.Parse(txtInvoiceDate.Text),
                    Amount = decimal.Parse(txtInvoiceAmount.Text)
                };

                dbContext.Invoices.Add(invoice);
                dbContext.SaveChanges();

                txtInvoiceDate.Text = "";
                txtInvoiceAmount.Text = "";

                RefreshInvoices();

                lblErrorMessageInvoice.ForeColor = Color.Green;
                lblErrorMessageInvoice.Text = "Data added successfully!";
                lblErrorMessageInvoice.Visible = true;

                await Task.Delay(5000);

                for (double opacity = 1; opacity >= 0; opacity -= 0.1)
                {
                    lblErrorMessageInvoice.ForeColor = Color.FromArgb((int)(255 * opacity), lblErrorMessageInvoice.ForeColor);
                    await Task.Delay(100);
                }

                lblErrorMessageInvoice.Visible = false;
            }
            catch (Exception ex)
            {
                lblErrorMessageInvoice.ForeColor = Color.Red;
                lblErrorMessageInvoice.Text = "Data entry error: " + ex.Message;
                lblErrorMessageInvoice.Visible = true;

                await Task.Delay(5000);

                for (double opacity = 1; opacity >= 0; opacity -= 0.1)
                {
                    lblErrorMessageInvoice.ForeColor = Color.FromArgb((int)(255 * opacity), lblErrorMessageInvoice.ForeColor);
                    await Task.Delay(100);
                }

                lblErrorMessageInvoice.Visible = false;
            }
        }

        private void RefreshInvoices()
        {
            var invoices = dbContext.Invoices.ToList();
            dataGridView3.DataSource = invoices;
        }



        ////////////////////////MOTORIST////////////////////
        private void btnMotoristUpdate_Click(object sender, EventArgs e)
        {
            dataGridView4.EndEdit();
            dbContext.SaveChanges();
            RefreshMotorists();
        }

        private void btnMotoristDelete_Click(object sender, EventArgs e)
        {
            DeleteSelectedRow(dataGridView4, dbContext.Motorists);
            RefreshMotorists();
        }

        private async void btnMotoristAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Motorist motorist = new Motorist
                {
                    Name = txtMotoristName.Text,
                    PhoneNumber = txtMotoristPhoneNumber.Text,
                    Address = txtMotoristAddress.Text,
                    DrivingLicenseNumber = txtMotoristDrivingLicenseNumber.Text
                };

                dbContext.Motorists.Add(motorist);
                dbContext.SaveChanges();

                txtMotoristName.Text = "";
                txtMotoristPhoneNumber.Text = "";
                txtMotoristAddress.Text = "";
                txtMotoristDrivingLicenseNumber.Text = "";

                RefreshMotorists();

                lblErrorMessageMotorist.ForeColor = Color.Green;
                lblErrorMessageMotorist.Text = "Data added successfully!";
                lblErrorMessageMotorist.Visible = true;

                await Task.Delay(5000);

                for (double opacity = 1; opacity >= 0; opacity -= 0.1)
                {
                    lblErrorMessageMotorist.ForeColor = Color.FromArgb((int)(255 * opacity), lblErrorMessageMotorist.ForeColor);
                    await Task.Delay(100);
                }

                lblErrorMessageMotorist.Visible = false;
            }
            catch (Exception ex)
            {
                lblErrorMessageMotorist.ForeColor = Color.Red;
                lblErrorMessageMotorist.Text = "Data entry error: " + ex.Message;
                lblErrorMessageMotorist.Visible = true;

                await Task.Delay(5000);

                for (double opacity = 1; opacity >= 0; opacity -= 0.1)
                {
                    lblErrorMessageMotorist.ForeColor = Color.FromArgb((int)(255 * opacity), lblErrorMessageMotorist.ForeColor);
                    await Task.Delay(100);
                }

                lblErrorMessageMotorist.Visible = false;
            }
        }

        private void RefreshMotorists()
        {
            var motorists = dbContext.Motorists.ToList();
            dataGridView4.DataSource = motorists;
        }



        ////////////////////////SERVICE////////////////////
        private void btnServiceUpdate_Click(object sender, EventArgs e)
        {
            dataGridView5.EndEdit();
            dbContext.SaveChanges();
            RefreshServices();
        }

        private void btnServiceDelete_Click(object sender, EventArgs e)
        {
            DeleteSelectedRow(dataGridView5, dbContext.Services);
            RefreshServices();
        }

        private async void btnServiceAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Service service = new Service
                {
                    Name = txtServiceName.Text,
                    Price = decimal.Parse(txtServicePrice.Text)
                };

                dbContext.Services.Add(service);
                dbContext.SaveChanges();

                txtServiceName.Text = "";
                txtServicePrice.Text = "";

                RefreshServices();

                lblErrorMessageService.ForeColor = Color.Green;
                lblErrorMessageService.Text = "Data added successfully!";
                lblErrorMessageService.Visible = true;

                await Task.Delay(5000);

                for (double opacity = 1; opacity >= 0; opacity -= 0.1)
                {
                    lblErrorMessageService.ForeColor = Color.FromArgb((int)(255 * opacity), lblErrorMessageService.ForeColor);
                    await Task.Delay(100);
                }

                lblErrorMessageService.Visible = false;
            }
            catch (Exception ex)
            {
                lblErrorMessageService.ForeColor = Color.Red;
                lblErrorMessageService.Text = "Data entry error: " + ex.Message;
                lblErrorMessageService.Visible = true;

                await Task.Delay(5000);

                for (double opacity = 1; opacity >= 0; opacity -= 0.1)
                {
                    lblErrorMessageService.ForeColor = Color.FromArgb((int)(255 * opacity), lblErrorMessageService.ForeColor);
                    await Task.Delay(100);
                }

                lblErrorMessageService.Visible = false;
            }
        }

        private void RefreshServices()
        {
            var services = dbContext.Services.ToList();
            dataGridView5.DataSource = services;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////

        private void DeleteSelectedRow<T>(DataGridView dataGridView, DbSet<T> dbSet) where T : class
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                var selectedRows = dataGridView.SelectedRows.Cast<DataGridViewRow>().ToList();

                foreach (DataGridViewRow selectedRow in selectedRows)
                {
                    int selectedRowId = (int)selectedRow.Cells["ID"].Value;

                    var entityToDelete = dbSet.Find(selectedRowId);

                    if (entityToDelete != null)
                    {
                        dbSet.Remove(entityToDelete);
                    }
                }
                dbContext.SaveChanges();
            }
        }
    }
}