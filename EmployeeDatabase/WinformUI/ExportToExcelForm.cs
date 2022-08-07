using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
namespace WinformUI
{
    public partial class ExportToExcelForm : Form
    {
        public ExportToExcelForm()
        {
            InitializeComponent();
        }

        private void ExportToExcelForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeDBDataSet.EmployeeTable' table. You can move, or remove it, as needed.
            this.employeeTableTableAdapter.Fill(this.employeeDBDataSet.EmployeeTable);

        }

        private void export_button_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            workbook.Worksheets.Add(this.employeeDBDataSet.EmployeeTable.CopyToDataTable(), "Employees");
                            workbook.SaveAs(sfd.FileName);
                        }
                        MessageBox.Show("Complete");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                        
                    }
                }
            }
        }
    }
}
