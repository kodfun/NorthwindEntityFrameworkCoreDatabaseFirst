using NorthwindEntityFrameworkCoreDatabaseFirst.Models;

namespace NorthwindEntityFrameworkCoreDatabaseFirst
{
    public partial class Form1 : Form
    {
        NorthwindContext db = new NorthwindContext();
        public Form1()
        {
            InitializeComponent();
            dgvEmployees.DataSource = db.Employees.ToList();
        }
    }
}