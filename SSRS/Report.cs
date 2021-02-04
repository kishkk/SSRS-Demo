
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSRS
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "SSRS.Report1.rdlc";
            reportViewer1.LocalReport.Refresh();
            reportViewer1.LocalReport.DataSources.Clear();
            var rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = GetData();
            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }

        
        private IEnumerable<Employee> GetData()            
        {
            List<Employee> employee = new List<Employee>();
                employee.Add(new Employee { Id = 1, EmployeeName = "Antony Joseph", Salary = 2500, Age = 28, Address = "Kallyan, Mumbai" });
                employee.Add(new Employee { Id = 2, EmployeeName = "Kishor K", Salary = 2500, Age = 31, Address = "Thrissur, Kerala" });
                employee.Add(new Employee { Id = 3, EmployeeName = "Antony Joseph", Salary = 2500, Age = 28, Address = "Kallyan, Mumbai" });
                employee.Add(new Employee { Id = 4, EmployeeName = "Antony Joseph", Salary = 2500, Age = 28, Address = "Kallyan, Mumbai" });
            return employee.ToList();
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public decimal Salary { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

    }
}
